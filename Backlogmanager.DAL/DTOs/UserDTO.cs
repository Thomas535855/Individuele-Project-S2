﻿namespace Backlogmanager.DAL.DTOs
{
    public class UserDTO
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int Points { get; set; }
        public string Password { get; set; }
    }
}
