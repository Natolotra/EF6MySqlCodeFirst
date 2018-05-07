using System;

namespace EF6MySqlCodeFirst.Models
{
    public class Livre
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public Nullable<int> NombrePage { get; set; }
        public DateTime DateSortie { get; set; }
        public string Description { get; set; }
    }
}