﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OneTrueError.Web.Areas.Installation.Models
{
    public class EmailViewModel
    {
        [Display(Name = "Account Name")]
        public string AccountName { get; set; }

        [Display(Name = "SMTP Host"), Required]
        public string SmtpHost { get; set; }

        [Display(Name = "SMTP Port"), Required]
        public int? PortNumber { get; set; }

        [Display(Name = "Use SSL")]
        public bool UseSSL { get; set; }

        [Display(Name = "Account password")]
        public string AccountPassword { get; set; }

    }
}