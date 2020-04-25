using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IA.MyAirport.EF;
using GraphQL.Types;

namespace IA.MyAirportGraphQL
{
    public class AirportQuery : ObjectGraphType
    {
     
            public AirportQuery(MyAirportContext db)
            {
                Field<ListGraphType<BagageType>>("bagages",resolve: context => db.Bagages.ToList());

        /*    Field<ListGraphType<BagageType>>(
                "bagages",
                arguments: new QueryArguments(new QueryArgument<IInterfaceGraphType> { Name = "BagageId" })
               // resolve: context => db.Bagages.First(b =>
                );
      */
            }
       
    }
}
