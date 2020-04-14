using System;
using GraphQL.Types;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IA.MyAirport.EF;

namespace MyAirportGraphQL
{
    public class VolType: ObjectGraphType<Vol>
    {

        public VolType()
        {
            Field(x => x.cie);
            Field(x => x.des);
            Field(x => x.dhc);
            Field(x => x.imm);
            Field(x => x.lig);
            Field(x => x.pkg);
            Field(x => x.pax);
            Field(x => x.VolId);
           
     

        }
    }
}
