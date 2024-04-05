namespace Project_XemPhim.Services.Interface
{
    public interface IEmailServices
    {
        // gui email den doi duong : To 
        bool SendEmail(string to, string subject, string message);
        


    }
}
