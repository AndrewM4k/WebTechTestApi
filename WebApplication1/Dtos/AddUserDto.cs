﻿using WebApplication1.Enums;

namespace WebApplication1.Dtos
{
    public class AddUserDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
    }
}
