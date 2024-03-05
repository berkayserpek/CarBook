﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Commands.CategoryCommands
{
    public class UpdateCategoryCommand
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
