namespace Routeorama.Models
{
    public class User{
        public int userId { get; set; }
        public string username { get; set;}
        public string password { get; set;}
        public string dob { get; set;}
        
        public string dateCreated { get; set;}
        public string email { get; set; }
        public RoleEnum role { get; set;}
        public string displayName { get; set;}
        public byte[] photo { get; set; }
        public string photoType { get; set; }
    }
}