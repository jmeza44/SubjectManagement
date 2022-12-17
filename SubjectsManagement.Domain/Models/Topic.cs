using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectsManagement.Domain.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string References { get; set; }
    }
}
