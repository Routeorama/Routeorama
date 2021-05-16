using System;
using System.Threading.Tasks;
using Routeorama.Models.Post;

namespace Routeorama.Data {
    public interface IPostService {

        Task<Post> CreateNewPost(Post post);

        Task<PostContainer> FetchPosts(int placeId, int postId);
        Task<bool> DeletePost(int postId);
        Task<bool> GetLikeState(int postId, int userId);
        Task LikePost(int postId, int userId, bool action);
    }
}