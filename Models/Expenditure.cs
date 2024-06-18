using System.Runtime.CompilerServices;

namespace Templating_Razor.Models
{
    public class Expenditure
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
    }
}