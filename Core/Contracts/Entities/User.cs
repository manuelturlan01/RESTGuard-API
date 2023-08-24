using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.Entities
{
    public class User
    {
        public User()
        {
            DateCreated = DateTime.UtcNow;
        }
        /* ==========================
            * USER BASICS DATA
        * ========================== */
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        /* ==========================
            * ROLE AND PERMISSIONS
        * ========================== */
        public UserRole Role { get; set; }
        public enum UserRole
        {
            Admin,
            User,
            Guest
        }
        /* ==========================
            * AUTH AND SECURITY
        * ========================== */
        public DateTime LastLogin { get; set; }
        public int FailedLoginAttemps { get; set; }
        public bool IsLockedOut { get; set; }
        public DateTime? LockoutEnd { get; set; }
        /* ==========================
            * OTHER
        * ========================== */
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
