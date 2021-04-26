namespace Routeorama.Models
{
    public class User{
        public string username { get; set;}
        public string password { get; set;}
        public string dob { get; set;}
        public RoleEnum role { get; set;}
        public string email { get; set; }
        public string displayName { get; set;}
    }
}