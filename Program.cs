// See https://aka.ms/new-console-template for more information
/*
Install git on your computer (this assumes you will be using a personal computer for your schoolwork) 
Create a github account
Complete and submit first phase of project
Build data file with initial system tickets and data in a CSV
Write Console application to process and add records to the CSV file
Tickets.csv

TicketID, Summary, Status, Priority, Submitter, Assigned, Watching

1,This is a bug ticket,Open,High,Drew Kjell,Jane Doe,Drew Kjell|John Smith|Bill Jones
*/
using System.Net;
using System.Security.Cryptography;

string resp = "";
string file = "ticket.csv";
do {
    Console.WriteLine("1) Display tickets");
    Console.WriteLine("2) Enter ticket");
    resp = Console.ReadLine();
    if (resp == "1"){
        // display tickets
        if(File.Exists(file)){
            StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream){
                string line = sr.ReadLine();
                string[] arr = line.Split(',');
                // display remaining ticket info
                Console.WriteLine("Ticket id: {0}, Summary: {1}, Status: {2}, Priority: {3}, Submitter: {4}, Assigned: {5}, Watching: {6}",arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]);
            }
            sr.Close();
        }
    } else if (resp == "2"){
        // enter ticket
        Console.WriteLine("Enter ticket id:");
        string id = Console.ReadLine();
        Console.WriteLine("Enter ticket summary:");
        string summary = Console.ReadLine();
        Console.WriteLine("Enter ticket status:");
        string status = Console.ReadLine();
        Console.WriteLine("Enter ticket priority:");
        string priority = Console.ReadLine();
        Console.WriteLine("Enter the submitter:");
        string submitter = Console.ReadLine();
        Console.WriteLine("Enter who is assigned:");
        string assigned = Console.ReadLine();
        Console.WriteLine("Enter who is watching: ");
        string watching = Console.ReadLine();
        //input remaining ticket info

        // save ticket to file
        StreamWriter sw = new StreamWriter(file, append: true);
        sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", id, summary, status, priority, submitter, assigned, watching);
        sw.Close();
    }
} while (resp == "1" || resp == "2" );
