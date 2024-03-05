﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Commands.CategoryCommands
{
    public class RemoveCategoryCommand
    {
        public int ID { get; set; }

        public RemoveCategoryCommand(int id)
        {
            ID = id;
        }
    }
}
