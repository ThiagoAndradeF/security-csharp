using System.ComponentModel.DataAnnotations;

namespace webSecurityCsharp.Entitys
{
    public class User
    {
        public required string Name { get; set; }

        public required string Email { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public bool ShouldUpdatePassword { get; set; }

        public bool IsActive { get; set; }

    }
}
