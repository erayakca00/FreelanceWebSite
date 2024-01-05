using EntityLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Payment : BaseEntity
    {
        public int ProjectId { get; set; }

        public int UserId { get; set; }

        public double Price { get; set; }

        public Status Status { get; set; }

        public User User { get; set; }

        public Project Project { get; set; }
    }

    public enum Status
    {
        Await,
        Success,
    }
}

