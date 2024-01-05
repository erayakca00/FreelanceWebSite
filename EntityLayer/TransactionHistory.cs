using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class TransactionHistory : BaseEntity
    {
        public double Price { get; set; }

        public ICollection<Wallet> UserWallets { get; set; }

    }  
}
