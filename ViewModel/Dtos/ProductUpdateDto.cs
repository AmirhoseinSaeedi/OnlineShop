using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.Dtos
{
    public class ProductUpdateDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int UnitPrice { get; set; }
    }
}
