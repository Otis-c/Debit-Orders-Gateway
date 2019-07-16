using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitOrdersApi.Models
{
    public class Bank
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
    }
}
