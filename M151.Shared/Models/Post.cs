﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
//Is the Model of the posting part of our application
namespace M151.Data.Models
{
    public class Post
    {
        [Required]
        public string Title { get; set; }


        public int Id { get; set; }


        public string ApplicationUserId { get; set; }

        [Required]
        public string Content { get; set; }


        public int Likes { get; set; }

        public int Comments { get; set; }

        public string ApplicationUserName { get; set; }


        public virtual ApplicationUser ApplicationUser { get; set; }


        [Timestamp] public Byte[] RowVersion { get; set; }


        public DateTime date { get; set; }
    }
}