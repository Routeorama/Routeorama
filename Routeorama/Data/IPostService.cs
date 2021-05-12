﻿using System;
using System.Threading.Tasks;
using Routeorama.Models.Post;

namespace Routeorama.Data {
    public interface IPostService {

        Task<Post> CreateNewPost(Post post);

        Task<PostContainer> FetchPosts(int placeId, int postId);
        Task<Boolean> DeletePost(int postID);
    }
}