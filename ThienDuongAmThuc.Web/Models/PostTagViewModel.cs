using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThienDuongAmThuc.Web.Models
{
    public class PostTagViewModel
    {

        public string TagID { set; get; }

        public virtual PostViewModel Post { set; get; }

        public virtual TagViewModel Tag { set; get; }
    }
}