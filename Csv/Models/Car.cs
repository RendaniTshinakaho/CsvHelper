using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CsvHelper.Configuration;

namespace Csv.Models
{
    public class Car
    {
        [CsvField(Name = "5000 Code")]
        public string Code { get; set; }
        [CsvField(Name = "BODY STYLE")]
        public string BodyStyle { get; set; }
        [CsvField(Name = "ENGINE")]
        public string Engine { get; set; }
        [CsvField(Name = "DERIVATIVE")]
        public string Derivative { get; set; }
        [CsvField(Name = "MODEL CODE")]
        public string ModelCode { get; set; }
        [CsvField(Name = "TRIM LEVEL")]
        public string TrimLevel { get; set; }
        [CsvField(Name = "DERIVATIVE PACK CODE")]
        public string DerivativeParkCode { get; set; }
        [CsvField(Name = "PAR / COUNTRY CODE")]
        public string CountryCode { get; set; }
        [CsvField(Name = "MODEL AVAILABILITY")]
        public string ModelAvailabilty { get; set; }
        [CsvField(Name = "Importer FOB Price")]
        public string ImporterPrice { get; set; }
        [CsvField(Name = "Freight (if applicable)")]
        public string Freight { get; set; }
        [CsvField(Name = "Insurance (Calculation - Derivative*1.1*%)")]
        public string Insurance { get; set; }
    }
}