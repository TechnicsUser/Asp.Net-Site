﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication9.Models {
    public class CoralPhoto {


        [Key ]
        public int CoralPhotoId { get; set; }
        public byte[] Photo { get; set; }

        public int CoralId { get; set; }
        public string UserId { get; set; }

        public string CommentId { get; set; }
        public int Likes { get; set; }
        public int DisLikes { get; set; }
        public int Views { get; set; }

        public string CreatedOn { get; set; }
        public string RemovedOn { get; set; }

        public bool Removed { get; set; }



        }
    }