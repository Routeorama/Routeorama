namespace Routeorama.Models.Post
{
    public class Comment
    {
        public int userId { get; set; }
        public string displayName { get; set; }
        public int postId { get; set; }
        public string content { get; set;}
        public string timestamp { get; set;}
    }
}