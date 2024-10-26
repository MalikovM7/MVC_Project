using Microsoft.EntityFrameworkCore;
using Repositories;
using Services.BlogPosts;
using System;
using System.Collections.Generic;

namespace Application.Services.Implementations
{
    public class BlogPostService : IBlogPostService
    {

        private readonly IBlogPostRepository blogPostRepository;

        public BlogPostService(IBlogPostRepository blogPostRepository)
        {
            this.blogPostRepository = blogPostRepository;
        }

        public async Task<IEnumerable<BlogPostGetAll>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            return await blogPostRepository.GetAll()
                .Select(blogPost => new BlogPostGetAll
                {
                    Id = blogPost.Id,
                    Title = blogPost.Title,
                    CategoryId = blogPost.CategoryId,
                    Body = blogPost.Body,
                    ImagePath = blogPost.ImagePath,
                    PublishDate = blogPost.PublishDate,
                    PublisherId = blogPost.PublisherId
                })
                .ToListAsync();
        }


    }
    }

