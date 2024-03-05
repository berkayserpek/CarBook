﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Commands.CarCommands
{
    public class RemoveCarCommand
    {
        public int ID { get; set; }

        public RemoveCarCommand(int id)
        {
            ID = id;
        }
    }
}
