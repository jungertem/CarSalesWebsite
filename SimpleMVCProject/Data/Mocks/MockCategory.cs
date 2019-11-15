using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleMVCProject.Data.Interfaces;
using SimpleMVCProject.Data.Models;

namespace SimpleMVCProject.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ CategoryName = "Electro cars", Description = "Modern mode of transport"},
                    new Category{ CategoryName = "Classic cars", Description = "Obsolete mode of transport"},
                };
            }

        }
    }
}
