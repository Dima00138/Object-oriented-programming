using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_17
{
    [Serializable]
    public class Lector
    {
        [Required]
        public int department {get;set;}
        public string name { get; set; }
        public string surname { get; set; }
        public string otche { get; set; }
        public string auditorium { get; set; }
        [CheckCorp]
        public decimal corpus { get; set; }
        public string gender { get; set; }
    }
}
