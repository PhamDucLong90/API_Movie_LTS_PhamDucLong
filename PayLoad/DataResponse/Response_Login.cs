using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Project_XemPhim.PayLoad.DataResponse
{
    public class Response_Login
    {
        public string AccessToken {  get; set; }
        public string RefreshToekn {  get; set; }
       
        public Response_UserInfomation ResonseUser {  get; set; }
    }
}
