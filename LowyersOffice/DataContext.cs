using LowyersOffice.Entities;
using System.Formats.Asn1;
using System.Globalization;
using System;
using CsvHelper;
using System.Diagnostics.Metrics;

namespace LowyersOffice
{
    public class DataContext
    {
        public List<Costumer> Costumers{ get; set; }
        public List<CourtCase> CourtCases { get; set; }
        public List<Income> Incomes { get; set; }



        public DataContext()
        {
          
            using (var reader = new StreamReader("costumers.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Costumers = csv.GetRecords<Costumer>().ToList();
            }
            
            using (var reader = new StreamReader("courtcases.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                CourtCases = csv.GetRecords<CourtCase>().ToList();
            }
            
            using (var reader = new StreamReader("incomes.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                Incomes = csv.GetRecords<Income>().ToList();
            }
        }
    }
}
