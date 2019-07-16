using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebitOrdersApi.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int BankId { get; set; }
        public Bank Bank { get; set; }
    }
}
