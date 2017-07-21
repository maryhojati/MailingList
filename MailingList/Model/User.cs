using System;

namespace MailingList.Model
{
    public enum Gender
    {
        Female = 1,
        Male = 2
    }

    public class User
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public Gender Gender { get; set; }
        public override string ToString()
        {

            return Firstname+" "+Lastname;
        }
    }

    public class RegisterUser : User
    {
        public string RePassword { get; set; }

        public string GetValidationError()
        {
            if(string.IsNullOrWhiteSpace(Password))
                return "Password is Required";
            if(Password != RePassword)
                return "Password don't match RePassword";

            return null;
        }
    }
}