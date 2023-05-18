// See https://aka.ms/new-console-template for more information
using System.IO.Enumeration;

Console.WriteLine("Hello, World!");


// 2. Show All meeting
// 1. Add Meeting - without validation
// 0. Exit calendar 


const string FileName = "meetings.csv";


void AddMeeting() {

    Console.WriteLine("Start time: ");
    var startTime = Console.ReadLine();

    Console.WriteLine("Duration: ");
    var duration  = int.Parse(Console.ReadLine());

    Console.WriteLine("Room: ");
    var room = Console.ReadLine();

    Console.WriteLine("Name: ");
    var name = Console.ReadLine();





    File.AppendAllText(FileName, contents:$"{startTime},{duration},{room},{name}" + Environment.NewLine);

}

void Exit ()
{ 
   Environment.Exit(0);
}
    

void ShowAll() {

    Console.WriteLine($"{"Start time",20}" 
        + $"{"Duration",20}"
        + $"{"Room",20}"
        + $"{"Name",20}");

   var fileContent = File.ReadAllLines(FileName);

    foreach (var line in fileContent)
    {
        var meetingContent = line.Split(",");
        Console.WriteLine($"{meetingContent[0],20}" + $"{meetingContent[1],20}" + $"{meetingContent[2],+20}" + $"{meetingContent[3],+20}");
    }

    Console.ReadLine();

};


void Menu () {

    Console.Clear();
    Console.WriteLine("2. Show All meeting");
    Console.WriteLine("1. Add Meeting - without validation");
    Console.WriteLine("0. Exit calendar");


};


while (true)
{
    Menu();
    var KeyInfo = Console.ReadKey();
    switch (KeyInfo.Key)
    {
        case ConsoleKey.D0:
            Exit();
            break;
       case ConsoleKey.D1:
            AddMeeting();
            break;
       case ConsoleKey.D2:
            ShowAll();
            break;
        default:break;
                 
    }

};