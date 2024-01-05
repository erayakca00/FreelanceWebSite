using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class User : BaseEntity
    {
        public string UserName { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public UserType UserType { get; set; }

        public int WalletId { get; set; }

        public Wallet Wallet { get; set; }

        public ICollection<Payment> Payments { get; set; }

        public ICollection<Project> Projects { get; set; }
    }

    public enum UserType
    {
         Admin,
         Employer,
         Developer,
    }
}
