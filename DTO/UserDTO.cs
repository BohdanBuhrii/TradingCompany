﻿namespace DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public RoleDTO Role { get; set; }
    }
}
