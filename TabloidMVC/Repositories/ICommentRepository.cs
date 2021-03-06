﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TabloidMVC.Models;

namespace TabloidMVC.Repositories
{
    public interface ICommentRepository
    {
        List<Comment> GetAllCommentsByPostId(int postId);
        void AddComment(Comment comment);
        void UpdateComment(Comment comment);
        Comment GetCommentById(int id);
        void DeleteComment(int id);
    }
}
