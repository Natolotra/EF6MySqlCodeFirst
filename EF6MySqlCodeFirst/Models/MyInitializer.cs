using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF6MySqlCodeFirst.Models
{
    public class MyInitializer : CreateDatabaseIfNotExists<MyContext>
    {
        protected override void Seed(MyContext context)
        {
            context.Livres.Add(
                new Livre()
                {
                    DateSortie = DateTime.Now.AddMonths(-6),
                    NombrePage = 150,
                    Titre = "Livre Test 1" }
            );
            context.Livres.Add(
                new Livre()
                {
                    DateSortie = DateTime.Now.AddMonths(-12),
                    NombrePage = 200,
                    Titre = "Livre Test 2"
                }
            );
            context.Livres.Add(
                new Livre()
                {
                    DateSortie = DateTime.Now.AddMonths(-2),
                    NombrePage = 300,
                    Titre = "Livre Test 3"
                }
            );
            context.Livres.Add(
                new Livre()
                {
                    DateSortie = DateTime.Now.AddMonths(-23),
                    NombrePage = 50,
                    Titre = "Livre Test 4"
                }
            );
            context.Livres.Add(
                new Livre()
                {
                    DateSortie = DateTime.Now.AddMonths(-15),
                    NombrePage = 250,
                    Titre = "Livre Test 5"
                }
            );

            context.SaveChanges();
        }
    }
}