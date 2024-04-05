using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Project_XemPhim.DataContext;
using Project_XemPhim.entity;
using Project_XemPhim.PayLoad.DataResponse;
using Project_XemPhim.Services.Implement;
using Project_XemPhim.Services.Interface;

namespace Project_XemPhim.PayLoad.Converters
{
    public class UserConverters
    {
        private readonly AppDbContext dbcontext;
        
        

        public UserConverters()
        {
            dbcontext = new AppDbContext();
         
        }
        // private readonly IConfiguration _configuration;
        //public UserConverters(IUserServices _userservices)
        //{
        //    dbcontext = new AppDbContext();
        //    userservices = _userservices;
        // //   _configuration = configuration;

        //}
        //chuyen tu user sang response)userinfomation
        public Response_UserInfomation EntityToDTO(User user)
        {
            /*  public string Username { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Point { get; set; }
        public string RoleName {  get; set; }
        public string NameStatus {  get; set; }
      */
            Response_UserInfomation ui = new Response_UserInfomation();
            ui.Username = user.Username;
            ui.Email = user.Email;
            ui.Name = user.Name;
            ui.Password = user.Password;
            ui.Point = user.Point;
            ui.RoleName = dbcontext.Role.SingleOrDefault(x => x.Id_Role == user.RoleId).RoleName;
            ui.NameStatus = dbcontext.UserStatus.SingleOrDefault(x => x.Id_UserStatus == user.UserStatusId).Name;
            return ui;
        }
        //chuyen tu user sang response_login;
        //public Response_Login EntityToResponse_Login(User user)
        //{
        //    string accessToken = userservices.GenerateAccessToken(user);
        //    string refreshToken = dbcontext.RefreshToken.SingleOrDefault(x => x.UserId == user.Id_User && x.ExpiredTime >= DateTime.Now).Refresh_Token;
        //    Response_UserInfomation user_info = EntityToDTO(user);
        //    return new Response_Login()
        //    {
        //        AccessToken = accessToken,
        //        RefreshToekn = refreshToken,
        //        ResonseUser = user_info
        //    };

        //}
    }
}
