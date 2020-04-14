using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IA.MyAirport.EF;
using GraphQL.Types;
using GraphQL;

namespace MyAirportGraphQL
{
    public class AirportSchema : Schema
    {
        public AirportSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<AirportQuery>();
        }
    }
}
