using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Commands.BannerCommands
{
    public class RemoveBannerCommand
    {
        public int ID { get; set; }

        public RemoveBannerCommand(int id)
        {
            ID = id;
        }
    }
}
