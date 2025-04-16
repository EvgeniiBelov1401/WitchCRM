using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WitchCRM.Modules
{
    public class Client
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public string? SourceName { get; set; }
        public string? SourceData { get; set; }
        public decimal? Prise { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
    }
}
