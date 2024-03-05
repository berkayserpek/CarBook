using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApplication.Features.CQRS.Queries.ContactQueries
{
    public class GetContactByIdQuery
    {
        public int ID { get; set; }

        public GetContactByIdQuery(int id)
        {
            ID = id;
        }
    }
}
