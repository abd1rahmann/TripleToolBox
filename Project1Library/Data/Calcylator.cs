using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Library.Data
{
    public class Calcylate
    {
        [Key] 
        public int CalcylateId { get; set; }
        public decimal Tal1 { get; set; }
        public string Operator { get; set; }
        public decimal Tal2 { get; set;}
        public decimal Resultat { get; set; }
        public DateTime Datum { get; set; }
    }
}
