string fileDirectoryPath = @"C:\Users\leonm\OneDrive - me.thm.de\Acer Laptop\OneDrive - me.thm.de\Dokumente\Studium\Ausland\Kurse\RKE132IndroductiontoProgramming\data";
string fileName = "chuck.txt";

string fullFilePath = Path.Combine(fileDirectoryPath, fileName); //Path.Combine => C:\.....\data\chuck => create the Path


ReadFromFile(fullFilePath);



//functions
static void DisplayDataFromArray(string[] someArray)
{
    foreach(string Line in someArray)
    {
        Console.WriteLine(Line);
    }
}

static void ReadFromFile(string filePath)
{
    if (File.Exists(filePath)) //when it exist in the folder the code will continue 
    {
        string[] tempArray = File.ReadAllLines(filePath);
        Console.WriteLine($"There are {tempArray.Length} lines about Chuck Norris in the file");
        Console.WriteLine("Do you want to see all lines or pick a random on? all/random");
        string userChoice = Console.ReadLine();

        if (userChoice == "all")
        {
            DisplayDataFromArray(tempArray);
        }
        else if (userChoice == "random")
        {
            DisplayRandomElement(tempArray);
        }
        else
        {
            Console.WriteLine("Try again!");
        }
    }

    else
    {
        Console.WriteLine($"File was not found.");
    }
}

static void DisplayRandomElement(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    Console.WriteLine(someArray[randomIndex]);
}