using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corona_Models
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
// later when using this dto in the server project, the categorydto must be converted to a category object