using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;


namespace SampleApplication.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Url]
        public string   Url { get; set; }  

        public DateTime DateOfBirth { get; set; }

        [Range(0,int.MaxValue)]
        public int JumpCount { get; set; }

        [CreditCard]
        public string CreditCard { get; set; }

        public Color ParachuteColor { get; set; }

        [DefaultValue(700)]
        public double JumpHeight { get; set; }




    }
}