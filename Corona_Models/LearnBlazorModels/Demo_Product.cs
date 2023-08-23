using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// creating first model as demo_product

namespace Corona_Models.LearnBlazorModels
{
    // 1. first change this class to public
    public class Demo_Product
    {
        // 2. create three basic properties of the product you will work with
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        //adding a new property. rmbr properties must start with Caps
        public double Price { get; set; }

        public IEnumerable<Demo_ProductProp> ProductProperties { get; set; }
    }
}

// 3. time to use this model in the bindprop component under the blazor server project

