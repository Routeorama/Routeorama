using System.Collections.Generic;

namespace Routeorama.Models.Post
{
    public class CommentContainer
    {
        public List<Comment> comments { get; set; }
        public bool hasMoreComments { get; set; }
    }
}