using M151.Data.Models;
using M151.Shared;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M151.Controllers
{
    public class PostController : Controller
    {
        public PostActions actions = new PostActions();
       
        [Authorize]
        // GET: Post
        public ActionResult Index(bool? hasPosted = null)
        {
            ViewBag.WasPostingSuccess = hasPosted;
            Post post = new Post();
            return View(post);

        }
        [HttpPost]
        //Save a new post in the db
        public ActionResult Index(Post post)
        {
            
            actions.SavePost(post, User.Identity.GetUserName(), User.Identity.GetUserId());
            ViewBag.WasPostingSuccess = true;
            return View();
        }
    }
}