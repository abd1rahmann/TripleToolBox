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
        public int Resultat { get; set; }
        
    }
}
