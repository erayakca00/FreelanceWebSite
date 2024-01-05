using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Project : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public double Budget { get; set; }

        public int PaymentId { get; set; }

        public ICollection<User> Users { get; set; }

       // public Payment Payment { get; set; }



    }
}
