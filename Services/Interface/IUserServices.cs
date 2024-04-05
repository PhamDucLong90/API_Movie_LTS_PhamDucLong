using Project_XemPhim.entity;
using Project_XemPhim.PayLoad.DataRequest;
using Project_XemPhim.PayLoad.DataResponse;
using Project_XemPhim.PayLoad.Responses;

namespace Project_XemPhim.Services.Interface
{
    public interface IUserServices
    {
        // dang ki tai khoan 
        public ResponseObject<string> Register(Request_Register request);
        //tao doan code ngau nhien 
        public string GenerateCode();
        // xac thuc gmail de hoan thanh dang ki
        public ResponseObject<Response_UserInfomation> ConfirmEmail_Register(string code);
        // tao 1 ma token tu user
        public string GenerateAccessToken(User user);
        // dang nhap tai khoan 
        public ResponseObject<Response_Login> Login(Request_Login request);
        // doi mat khau 
        public ResponseObject<string> ChangePassWord(); 


    }
}
