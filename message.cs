using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp
{
    public class message
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public string Name { get; set; }
        public string MessageContent { get; set; }
    }
}
