using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes
{
    public class TestCategoryAttribute:System.Attribute
    {
        private string _category;

        public TestCategoryAttribute(string testCategory)
        {
            _category = testCategory;        
        }

        public string Category
        {
            get { return _category; }
        }
    }
}
