﻿using System.ComponentModel.DataAnnotations;

namespace Tudo_List.Application.Models.Users
{
    public class AuthenticateRequest
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
