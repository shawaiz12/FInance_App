using System;
using System.Collections.Generic;

namespace Finance_app.DTOs.Account
{
    public class NewUserDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }

        public string Token { get; set; }
    }
}
