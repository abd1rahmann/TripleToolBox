using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Library.Data
{
    public class Shape
    {
        [Key]
        public int ShapeId { get; set; }
        public string ShapeForm {  get; set; } = String.Empty;
        public decimal Circumference { get; set; }
        public decimal Area { get; set; }
        public decimal Lenght { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Base { get; set; }
        public decimal Katet1 { get; set; }
        public decimal Katet2 { get; set; }
        public decimal Hypotenusan { get; set; }
        public DateTime Date { get; set; }
    }
}
