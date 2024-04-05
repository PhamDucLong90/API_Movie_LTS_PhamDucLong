using System.ComponentModel.DataAnnotations;

namespace Project_XemPhim.Helper.Validation
{
    public class ValidateInput
    {
        //kiem tra xem eamail co hop le hay khong
        public static bool  IsValidEmail(string email)
        {
            var check = new EmailAddressAttribute();
            return check.IsValid(email);
        }
    }
}
