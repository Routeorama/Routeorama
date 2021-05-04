namespace Routeorama.Models
{
    public class User{
        public int UserId { get; set; }
        public string username { get; set;}
        public string password { get; set;}
        public string dob { get; set;}
        public string email { get; set; }
        public RoleEnum role { get; set;}
        public string displayName { get; set;}
        
    }
}