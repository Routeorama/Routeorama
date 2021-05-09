using System.Collections.Generic;

namespace Routeorama.Models.Post
{
    public class PostContainer
    {
        public bool hasMorePosts { get; set; }
        public List<Post> posts { get; set; }
        
    }
}