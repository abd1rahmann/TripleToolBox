using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Library.Data
{
    public class RockPaperScissor
    {
        [Key] 
        public int RPSId { get; set; }
        public int Vinst { get; set; }
        public int Oavgjort { get; set; }
        public int Förlust { get; set; }
        public decimal Genomsnitt { get; set; }
        public DateTime Datum { get; set; }
        public string SpelarensDrag { get; set; }
        public string DatornsDrag { get; set; }
        public string Resultat { get; set; }
    }
}
