/* BREIF:
 * 
 * Create a Dictionary list of employee IDs and the name that goes with the ID. 
 * Fill in a few records.Then ask the user for their ID and return their name.
 * 
 */

bool exitStatus = false;

Dictionary<int, string> database = new Dictionary<int, string>();

database[1] = "Joshua";
database[2] = "James";
database[3] = "Erik";
database[4] = "Bjorn";
database[5] = "Susan";
database[6] = "Stephanie";

do
{
    Console.Write("Please type the ID for the employee name: ");
    string? indexStr = Console.ReadLine();
    int.TryParse(indexStr, out int index);
    //int newIndex = index - 1;

    if (index >= 0 && index <= 6)
    {
        Console.WriteLine($"The employee with index {index} is {database[index]}");
    }
    else
    {
        Console.WriteLine("Index was out of range, or doesn't exist");
    }

} while (exitStatus == false);