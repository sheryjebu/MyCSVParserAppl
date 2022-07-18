using System;
using System.Collections.Generic ;
using System.Linq;
namespace CSVParserApp.Models
{
	public class ReadFile
	{
        public string FilePath { get; set; }
       
        public ReadFile(string filePath)
        {
             FilePath = filePath;
        }

        public void ReadFileFromPath(string filePath)
        {
            //Read the lines from csv files
            string[] csvdata = System.IO.File.ReadAllLines(@filePath);

            List<PersonDetails> PersonList = new List<PersonDetails>();

            //split each row into column data
            for (int i =1; i<csvdata.Length; i++)
            {
                PersonDetails pd = new PersonDetails(csvdata[i]);
                PersonList.Add(pd);

            }

            Console.WriteLine(PersonList);

            var result = from s in PersonList
                         where s.FirstName.Contains("Aleshia") 
                         select new
                         {
                            s.FirstName,s.LastName,s.Company
                         };

          
             Console.WriteLine(result);
        }

    }
}

