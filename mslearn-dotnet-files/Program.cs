
using Newtonsoft.Json;



var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");

var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");
Directory.CreateDirectory(salesTotalDir);   // Add this line of code

var salesFiles = FindFiles(storesDirectory);
double total = CalculateSalesTotal(salesFiles);






File.AppendAllText($"salesTotalDir{Path.DirectorySeparatorChar}totals.txt", $"{total}{Environment.NewLine}");


static double CalculateSalesTotal(IEnumerable<string> salesFiles)
{
    double salesTotal = 0;
    string? salesJson;
    SalesData? salesData;
    foreach (var item in salesFiles)
    {
        salesJson = File.ReadAllText(item);
        salesData = JsonConvert.DeserializeObject<SalesData>(salesJson);
        salesTotal += salesData?.Total ?? 0;
    }

    return salesTotal;
}




static IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        // The file name will contain the full path, so only check the end of it
        var extension = Path.GetExtension(file);
        if (extension == ".json")
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}

record SalesData(double Total);


/*
    var salesFiles = FindFiles("stores");

    foreach (var file in salesFiles)
    {
        Console.WriteLine(file);
    }
    Console.WriteLine("");
    Console.WriteLine(Directory.GetCurrentDirectory());
    Console.WriteLine("");
    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
    Console.WriteLine(docPath);
    Console.WriteLine("");
    Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");
    Console.WriteLine();

    string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";
    FileInfo info = new FileInfo(fileName);
    Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}"); // And many more
    Console.WriteLine();
*/

/*
    var currentDirectory = Directory.GetCurrentDirectory();
    var storesDirectory = Path.Combine(currentDirectory, "stores");
    var salesFiles = FindFiles(storesDirectory);


    foreach (var file in salesFiles)
    {
        Console.WriteLine(file);
    }
*/
/*
Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores","201","newDir"));
var filePath =  $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}newDir";
bool doesDirectoryExist = Directory.Exists(filePath);
Console.WriteLine("{0}" , doesDirectoryExist);
File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "greeting.txt"), $"Hello World! {Environment.NewLine}");
File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), "greeting.txt"), "This is a new world\n");
File.AppendAllText(Path.Combine(Directory.GetCurrentDirectory(), "greeting.txt"), "This is a new world");
*/











