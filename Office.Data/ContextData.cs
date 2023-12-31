using CsvHelper;
using Microsoft.EntityFrameworkCore;
using Office.Core.Entites;
using System.Globalization;

namespace Office.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Costumer> Costumers { get; set; }
        public DbSet<CourtCase> CourtCases { get; set; }
        public DbSet<Income> Incomes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=lawyerDb");
        }


        //public DataContext()
        //{
        //    using (var writer = new StreamWriter("output.csv"))
        //    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
        //    {
        //        csv.WriteRecords<Costumer>(new List<Costumer>());
        //    }

        //    using (var reader = new StreamReader("costumers.csv"))
        //    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        //    {
        //        Costumers = csv.GetRecords<Costumer>().ToList();
        //    }

        //    using (var reader = new StreamReader("courtcases.csv"))
        //    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        //    {
        //        CourtCases = csv.GetRecords<CourtCase>().ToList();
        //    }

        //    using (var reader = new StreamReader("incomes.csv"))
        //    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        //    {
        //        Incomes = csv.GetRecords<Income>().ToList();
        //    }
        //}
    }
}
