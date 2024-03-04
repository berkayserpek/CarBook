﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Queries.BannerQueries
{
    public class GetBannerByIdQuery
    {
        public int ID { get; set; }

        public GetBannerByIdQuery(int id)
        {
            ID = id;
        }
    }
}
