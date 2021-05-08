namespace Routeorama.Models.Post {
    public class Post {
        public int postId { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string photo { get; set; }
        public int likeCount { get; set; }
        public string dateOfCreation { get; set; }
        public int placeId { get; set; }
        public int userId { get; set; }
    }
}