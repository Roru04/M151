using M151.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using System.Security.Principal;

//Makes the posting posts on our website possible
namespace M151.Shared
{
    public class PostActions
    {
        public ApplicationDbContext db = new ApplicationDbContext();
        public void SavePost(Post post, string username, string userid)
        {
            Post postForDb = new Post();
            postForDb.Title = post.Title;
            postForDb.Content = post.Content;
            postForDb.date = DateTime.Now;
            postForDb.ApplicationUserId = userid;
            postForDb.ApplicationUserName = username;


            db.Posts.Add(postForDb);
            db.SaveChanges();

            return;


        }

        public IEnumerable<Post> ShowPosts()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                IEnumerable<Post> allPosts = context.Posts.OrderByDescending(p => p.date).ToList();
                return allPosts;
            }
        }
    }
}
