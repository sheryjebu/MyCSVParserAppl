using System;
using System.Linq;
using System.Data;


namespace CSVParserApp.Models
{
	public class PersonDetails
    {

        public string? FirstName { get ; set ; }
        public string? LastName { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Postal { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Email { get; set; }
        public string Web { get; set; }
        public string[] data { get; set; }

        public PersonDetails (string rowData)
        {
            string[] data = rowData.Split(",");

         
           //passing data into properties
            FirstName = data[0];
            LastName = data[1];
            Company = data[2];
            Address = data[3];
            City = data[4];
            County = data[5];
            Postal = data[6];
            Phone1 = data[7];
            Phone2 = data[8];
            Email = data[9];
            Web = data[10];
           

           Console.WriteLine(LastName);
          
        }
    }
}

