using System.Threading.Tasks;
using Routeorama.Models.Post;

namespace Routeorama.Data {
    public interface IPostService {

        Task CreateNewPost(Post post);
    }
}