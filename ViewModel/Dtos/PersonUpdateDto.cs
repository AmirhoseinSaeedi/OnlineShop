using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.Dtos
{
    public class PersonUpdateDto
    {
        public int Id { get; set; }
        public string? NewFirstName { get; set; }
        public string? NewLastName { get; set; }
    }
}
