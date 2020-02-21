using IA.MyAirport.EF;
using System;

namespace IA
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MyAirportContext())
            {
                // Create
                Console.WriteLine("Inserting a new blog");


                Vol v1 = new Vol
                {
                    cie = 1,
                    dhc = Convert.ToDateTime("14/01/2020 16:45"),
                    lig = "2345",
                    pkg = "538"

                };
                Bagage b1 = new Bagage { Vol = v1, code_iata = "010227273100" };
                db.Add(v1);
                db.Add(b1);
                db.SaveChanges();

                Console.WriteLine("Querying for a blog");
                var bgs = db.Bagages;
                Console.WriteLine("Afficher les bagages: {0}",bgs.);

            }
        
        }
    }
}
