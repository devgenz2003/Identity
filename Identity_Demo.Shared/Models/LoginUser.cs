﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity_Demo.Shared.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Username cannot be blank")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password cannot be blank")]
        public string? Password { get; set; }
    }
}
