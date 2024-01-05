using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Wallet : BaseEntity
    {
        public int UserId { get; set; }

        public double Balance { get; set; }

        public int TransactionHistoryId { get; set; }

        public TransactionHistory TransactionHistory { get; set; }

      //  public User User { get; set; }

    }
}
