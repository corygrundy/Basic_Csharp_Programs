using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsletterAppMvc.Models
{
    public class NewsLetterSignUp
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAdress { get; set; }
        public string SocialSecurityNumber { get; set; }
    }
}