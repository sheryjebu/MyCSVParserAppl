using System;
namespace CSVParserApp.Models
{
	public class scrap
	{
		public scrap()
		{
		}
	}
}
/*
list = new List<PersonDetails>();

// Get the data from path.
string sampleCSV = filePath; //"/Users/sheryjebu/TechReturnsGIT/CSVParserApp/CSVParserApp/input.csv";
ReadFile readFile = new ReadFile(filePath);

string[,] values = readFile.ReadFileFromPath(sampleCSV);
int num_rows = values.GetUpperBound(0) + 1;

//Read the data and add to List 
for (int r = 1; r < num_rows; r++)
{
    //name age mail company
    person = new PersonDetails(values[r, 0], (values[r, 1]), values[r, 2], values[r, 3]
                              , values[r, 4], (values[r, 5]), values[r, 6], values[r, 7]
                              , values[r, 8], (values[r, 9]), values[r, 10]);
    list.Add(person);
}

//read data from list
foreach (var item in list)
{
    Console.WriteLine(item.FirstName + "\t" + item.LastName + "\t" + item.Company + "\t"
        + item.Address + "\t" + item.City + "\t" + item.County + "\t" + item.Postal + "\t"
         + item.Phone1 + "\t" + item.Phone2 + "\t" + item.Email + "\t" + item.Web + "\t"
        );
}
Console.ReadLine();*/

