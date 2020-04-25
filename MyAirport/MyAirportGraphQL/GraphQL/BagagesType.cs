using System;
using GraphQL.Types;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IA.MyAirport.EF;

namespace IA.MyAirportGraphQL
{
    public class BagageType: ObjectGraphType<Bagage>
    {

        public BagageType()
        {
            Field(x => x.BagageId);
            Field(x => x.classe);
            Field(x => x.code_iata);
            Field(x => x.date_creation);
            Field(x => x.destination);
            Field(x => x.escale);
          //  Field(x => x.prioritaire);
          //  Field(x => x.sta);
            Field(x => x.ssur);
          //  Field(x => x.VolId);

        }
    }
}
