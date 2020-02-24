using IA.MyAirport.EF;
using System;
using System.Linq;


namespace IA
{
    class Program
    {
        static void Main(string[] args)
        {
            /*using (var db = new MyAirportContext())
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
                Console.WriteLine("Afficher les bagages: {0}",bgs);

            }*/


            System.Console.WriteLine("MyAirport project bonjour!!");
            using (var db = new MyAirportContext())
            {
                // Create
                  Console.WriteLine("Création du vol LH1232");
                  Vol v1 = new Vol
                  {
                      cie = "LH",
                      des = "BKK",
                      dhc = Convert.ToDateTime("14/01/2020 16:45"),
                      imm = "RZ62",
                      lig = "1232",
                      pkg = "R52",
                      pax = 238
                  };
                  db.Add(v1);

                  Console.WriteLine("Creation vol SQ333");
                  Vol v2 = new Vol
                  {
                      cie = "SK",
                      des = "CDG",
                      dhc = Convert.ToDateTime("14/01/2020 18:20"),
                      imm = "TG43",
                      lig = "333",
                      pkg = "R51",
                      pax = 423
                  };
                  db.Add(v2);

                  Console.WriteLine("creation du bagage 012387364501");
                  Bagage b1 = new Bagage
                  {
                     // VolId = v1.Vol,
                      classe = "Y",
                      code_iata = "012387364501",
                      date_creation = Convert.ToDateTime("14/01/2020 12:52"),
                      destination = "BEG"
                  };
                  db.Add(b1);
                  
                  db.SaveChanges();
                  Console.ReadLine();

                  // Read
                  Console.WriteLine("Voici la liste des vols disponibles");
                  var vol = db.Vols.OrderBy(v => v.cie);
                  foreach (var v in vol)
                  {
                      Console.WriteLine($"Le vol {v.cie}{v.lig} N° {v.VolId} a destination de {v.des} part à {v.dhc} heure");
                  }
                  Console.ReadLine();
                 

         
                // Update
                Console.WriteLine($"Le bagage {b1.BagageId} est modifié pour être rattaché au vol {v1.VolId} => {v1.cie}{v1.lig}");
                b1.VolId = v1.VolId;
                db.SaveChanges();
                Console.ReadLine();

                // Delete vol et bagages du vol
                Console.WriteLine($"Suppression du vol {v1.VolId} => {v1.cie}{v1.lig}");
                db.Remove(v1);
                db.SaveChanges();
                Console.ReadLine();
            }
          
        }

    }
}

