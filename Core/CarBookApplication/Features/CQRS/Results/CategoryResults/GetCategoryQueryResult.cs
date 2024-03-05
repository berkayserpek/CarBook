using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Results.CategoryResult
{
    public class GetCategoryQueryResult
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
