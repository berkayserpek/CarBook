using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.Mediator.Results.SocialMediaResults
{
    public class GetSocialMediaByIdQueryResult
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public string Icon { get; set; }
    }
}
