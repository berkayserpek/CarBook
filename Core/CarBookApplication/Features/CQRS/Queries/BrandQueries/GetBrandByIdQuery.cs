﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Queries.BrandQueries
{
    public class GetBrandByIdQuery
    {
        public int ID { get; set; }

        public GetBrandByIdQuery(int id)
        {
            ID = id;
        }
    }
}
