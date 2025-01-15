using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPocket.Components
{
    public class Debt
    {
        public int Id { get; set; }
        [Required] public string Source { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")] public decimal Amount { get; set; }
        [Required] public DateTime DueDate { get; set; }
        public bool IsCleared { get; set; }
    }
}
