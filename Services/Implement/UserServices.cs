using Azure;
using Microsoft.EntityFrameworkCore;
using Project_XemPhim.entity;
using Project_XemPhim.PayLoad.DataRequest;
using Project_XemPhim.PayLoad.DataResponse;
using Project_XemPhim.PayLoad.Responses;
using Project_XemPhim.Services.Interface;
using System.ComponentModel.DataAnnotations;
using System;
using Project_XemPhim.DataContext;
using Project_XemPhim.Helper.Validation;
using BCryptNet = BCrypt.Net.BCrypt;
using Project_XemPhim.Helper.Enumerates;
using System.Security.Cryptography;
using Project_XemPhim.PayLoad.Converters;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using BcryptNet = BCrypt.Net.BCrypt;
using System.Text;

namespace Project_XemPhim.Services.Implement
{
    public class UserServices : IUserServices
    {
        private readonly AppDbContext dbcontext = new AppDbContext();
        private readonly ResponseObject<Response_UserInfomation> response_user = new ResponseObject<Response_UserInfomation>();
        private readonly ResponseObject<Response_Login> response_login = new ResponseObject<Response_Login>();
        private readonly ResponseObject<string> response_string = new ResponseObject<string>();
        private readonly IEmailServices emailservices = new EmailServices();
        private readonly UserConverters converters = new UserConverters();
        private readonly IConfiguration _configuration;
        public UserServices(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        //public UserServices(IConfiguration configuration, UserConverters _userconverters, IEmailServices _emailservices,
        //    ResponseObject<string> _response_string, ResponseObject<Response_Login> _response_login,
        //    ResponseObject<Response_UserInfomation> _response_user)
        //{

        //    response_user = _response_user;
        //    response_login = _response_login;
        //    emailservices = _emailservices;
        //    converters = _userconverters;
        //    _configuration = configuration;
        //    response_string = _response_string;
        //}




        //tao doan code ngau nhien 
        public string GenerateCode()
        {
            var randomNumber = new Byte[32];
            var range = RandomNumberGenerator.Create();
            range.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);

        }

        // dang ki tai khoan 
        public ResponseObject<string> Register(Request_Register request)
        {
            // xac thuc thong tin dang ki tai khoan 
            if (string.IsNullOrWhiteSpace(request.Username) || string.IsNullOrWhiteSpace(request.Email)
                || string.IsNullOrWhiteSpace(request.Name) || string.IsNullOrWhiteSpace(request.Password))
            {
                return response_string.ResponseFail(StatusCodes.Status400BadRequest, "Vui lòng điền đầy đủ thông tin", null);
            }
            //kiem tra xem email da nhap dung dinh dang hay chua
            if (!ValidateInput.IsValidEmail(request.Email))
            {
                return response_string.ResponseFail(StatusCodes.Status400BadRequest, "email không đúng định dạng", null);
            }
            //kiem tra xem tai khoan email nay da ton tai hay chua
            if (dbcontext.User.Any(x => x.Email.Equals(request.Email)))
            {
                return response_string.ResponseFail(StatusCodes.Status400BadRequest, "email này đã được kích hoạt", null);
            }

            // kiem tra xem ten dang nhap da ton tai hay chua
            if (dbcontext.User.Any(x => x.Username.Equals(request.Username)))
            {
                return response_string.ResponseFail(StatusCodes.Status400BadRequest, "username này đã được tồn tại", null);
            }




            User user = new User()
            {
                Point = 0,
                Username = request.Username,
                Email = request.Email,
                Name = request.Name,
                Password = BCryptNet.HashPassword(request.Password),
                RankCustomerId = 1,
                UserStatusId = 1,
                IsActive = false,
                RoleId = 3
            };
            dbcontext.User.Add(user);
            dbcontext.SaveChanges();
            // add vaof bang confirmeamil
            string generratecode = GenerateCode();
            ConfirmEmail cf = new ConfirmEmail()
            {
                UserId = user.Id_User,
                ExpiredTime = DateTime.Now.AddMinutes(2),
                ConfirmCode = generratecode,
                IsConfirm = false
            };
            dbcontext.ConfirmEmail.Add(cf);
            dbcontext.SaveChanges();

            emailservices.SendEmail(request.Email, "Xac nhan dang ki tai khoan", generratecode);

            return response_string.ResponseSuccess("Vui lòng nhập mã code gửi trong email bạn đăng kí để xác thực", null);

        }
        //xac thuc gmail de hoan thanh dang ki
        public ResponseObject<Response_UserInfomation> ConfirmEmail_Register(string code)
        {
            var confirmEmail = dbcontext.ConfirmEmail.SingleOrDefault(x => x.ConfirmCode.Equals(code) && x.ExpiredTime >= DateTime.Now);
            if (confirmEmail == null)
            {

                return response_user.ResponseFail(StatusCodes.Status400BadRequest, "Thời gian xác nhận hết hạn hoặc code không tồn tại, vui lòng đăng nhập để xác thực lại", null);
            }
            var user = dbcontext.User.SingleOrDefault(x => x.Id_User == confirmEmail.UserId);

            // update thoong tin trong user
            user.IsActive = true;
            user.UserStatusId = 3;
            confirmEmail.IsConfirm = true;
            dbcontext.User.Update(user);
            dbcontext.ConfirmEmail.Update(confirmEmail);
            dbcontext.SaveChanges();
            Response_UserInfomation x = converters.EntityToDTO(user);
            return response_user.ResponseSuccess("Đăng kí tài khoản thành công", x);


        }
        // tao 1 ma token tu user
        public string GenerateAccessToken(User user)
        {
            var JWTHandler = new JwtSecurityTokenHandler();
            //var secretKeyBytes = Encoding.UTF8.GetBytes("mtigoxlhzxznjblcuidjplififjlykif");
            //var tokenExpires = 2;
            var secretKeyBytes = System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:SecretKey").Value);
            var tokenExpires = _configuration.GetValue<int>("AppSetting:TokenExpirationMinutes");
            var role = dbcontext.Role.SingleOrDefault(x => x.Id_Role == user.RoleId);
            var tokenDesctiption = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new[]
                {
                        new Claim("Id", user.Id_User.ToString()),
                        new Claim("Email", user.Email),
                        new Claim("RoleName", role.RoleName)
                    }),
                Expires = DateTime.Now.AddHours(tokenExpires),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = JWTHandler.CreateToken(tokenDesctiption); // tạo 1 token từ JWTHandler 
            var accessToken = JWTHandler.WriteToken(token);
            var refreshToken = GenerateCode();
            RefreshToken rf = new RefreshToken()
            {

                Refresh_Token = refreshToken,
                ExpiredTime = DateTime.Now.AddDays(1),
                UserId = user.Id_User


            };
            dbcontext.RefreshToken.Add(rf);
            dbcontext.SaveChanges();
            return accessToken;




        }

        // dang nhap tai khoan 
        public ResponseObject<Response_Login> Login(Request_Login request)
        {
            // kiem tra thong tin tai khoan
            if (string.IsNullOrWhiteSpace(request.UserName) || string.IsNullOrWhiteSpace(request.Password))
            {
                return response_login.ResponseFail(StatusCodes.Status400BadRequest, "Không được để trống", null);
            }
            // kiểm tra xem tài khoản này đã đc kích hoạt hay chưa
            var user = dbcontext.User.SingleOrDefault(x => x.Username.Equals(request.UserName));
            if (user == null)
            {
                return response_login.ResponseFail(StatusCodes.Status400BadRequest, "Tài khoản này không tồn tại", null);
            }
            var checkPassword = BcryptNet.Verify(request.Password, user.Password);
            if (!checkPassword)
            {
                return response_login.ResponseFail(StatusCodes.Status400BadRequest, "Tài khoản này không tồn tại", null);
            }
            else if (user.IsActive)
            {
                string accessToken = GenerateAccessToken(user);
                string refreshToken = dbcontext.RefreshToken.SingleOrDefault(x => x.UserId == user.Id_User && x.ExpiredTime >= DateTime.Now).Refresh_Token;
                Response_UserInfomation user_info = converters.EntityToDTO(user);
                Response_Login x = new Response_Login()
                {
                    AccessToken = accessToken,
                    RefreshToekn = refreshToken,
                    ResonseUser = user_info
                };

                return response_login.ResponseSuccess("Đăng nhập thành công", x);
            }
            else
            {
                string generratecode = GenerateCode();
                ConfirmEmail cf = new ConfirmEmail()
                {
                    UserId = user.Id_User,
                    ExpiredTime = DateTime.Now.AddMinutes(2),
                    ConfirmCode = generratecode,
                    IsConfirm = false
                };
                dbcontext.ConfirmEmail.Add(cf);
                dbcontext.SaveChanges();


                emailservices.SendEmail(user.Email, "Xac nhan dang ki tai khoan", generratecode);

                return response_login.ResponseSuccess("Tài khoản chưa đươc kích hoạt, hãy vào gmail đăng kí để kích hoạt", null);
            }
        }

        public ResponseObject<string> ChangePassWord()
        {
            throw new NotImplementedException();
        }
        // doi mat khau 

    }

    // tao mot thang token khi dang nhap
    //public ResponseObject<Response_Login> LoginSuccess(User user)
    //{
    //    var JWTHandler = new JwtSecurityTokenHandler();
    //    var secretKeyBytes = System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:SecretKey").Value);
    //    var tokenExpires = _configuration.GetValue<int>("AppSetting:TokenExpirationMinutes");
    //    var role = dbcontext.Role.SingleOrDefault(x => x.Id_Role == user.RoleId);
    //    var tokenDesctiption = new SecurityTokenDescriptor
    //    {
    //        Subject = new System.Security.Claims.ClaimsIdentity(new[]
    //        {
    //            new Claim("Id", user.Id_User.ToString()),
    //            new Claim("Email", user.Email),
    //            new Claim("RoleName", role.RoleName)
    //        }),
    //        Expires = DateTime.Now.AddHours(tokenExpires),
    //        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(secretKeyBytes), SecurityAlgorithms.HmacSha256Signature)
    //    };
    //    var token = JWTHandler.CreateToken(tokenDesctiption); // tạo 1 token từ JWTHandler 
    //    var accessToken = JWTHandler.WriteToken(token);
    //    var refreshToken = GenerateCode();
    //    RefreshToken rf = new RefreshToken()
    //    {

    //        Token =
    //        ExpiredTime = DateTime.Now.AddDays(1),
    //        UserId = user.Id_User


    //    };
    //    dbcontext.RefreshToken.Add(rf);
    //    dbcontext.SaveChanges();
    //    Response_Token response = new Response_Token()
    //    {
    //        AccessToken = accessToken,
    //        RefreshToken = refreshToken,
    //    };

    //    return response;

    //}


}

