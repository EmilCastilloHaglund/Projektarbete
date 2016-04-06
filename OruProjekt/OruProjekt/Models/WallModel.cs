
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoApplication.Models
{
    public class WallModel
    {
        //public List<Användare> Wall { get; set; }
        public string Sender { get; set; }
        public string Reciever { get; set; }
    }
}