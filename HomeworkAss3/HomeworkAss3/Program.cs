using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

public class MainHomeworkAss3
{
    static void Main(string[] args)
    {
        using (var context = new HomeworkAss3.Db.ContactsContext())
        {

            //create contacts for records

            Console.WriteLine("Creating Contacts...");

            var contact1 = new HomeworkAss3.Db.Contact()
            {
                ContactName = "Phil",
                ContactEmail = "pcolson@shield.com",
                ContactPhoneType = "Work Phone",
                ContactPhoneNumber = "555-111-2222",
                ContactAge = 49,
                ContactNotes = "SHIELD AGENT",
                ContactCreatedDate = DateTime.Now
            };

            context.Contacts.Add(contact1);

            var contact2 = new HomeworkAss3.Db.Contact()
            {
                ContactName = "Natasha",
                ContactEmail = "nromanov@avengers.com",
                ContactPhoneType = "Burner Phone",
                ContactPhoneNumber = "555-222-3333",
                ContactAge = 19,
                ContactNotes = "MAY BE A SPY",
                ContactCreatedDate = DateTime.Now
            };

            context.Contacts.Add(contact2);

            var contact3 = new HomeworkAss3.Db.Contact()
            {
                ContactName = "Steve",
                ContactEmail = "steverogers@avengers.com",
                ContactPhoneType = "Home/Landline",
                ContactPhoneNumber = "555-333-4444",
                ContactAge = 108,
                ContactNotes = "OLD FASHIONED",
                ContactCreatedDate = DateTime.Now
            };

            context.Contacts.Add(contact3);

            var contact4 = new HomeworkAss3.Db.Contact()
            {
                ContactName = "Tony",
                ContactEmail = "tstark@avengers.com",
                ContactPhoneType = "Jarvis Implant",
                ContactPhoneNumber = "555-666-7777",
                ContactAge = 50,
                ContactNotes = "Definitely is Ironman",
                ContactCreatedDate = DateTime.Now
            };

            context.Contacts.Add(contact4);

            context.SaveChanges();
            Console.WriteLine("Contacts Assembled!");

            //list contact info/records
            Console.WriteLine("");
            Console.WriteLine("Here's the list of Avengers available:");

            foreach (var contact in context.Contacts)
            {
                Console.WriteLine(contact.ContactName);
                Console.WriteLine(contact.ContactEmail);
                Console.WriteLine(contact.ContactPhoneType);
                Console.WriteLine(contact.ContactPhoneNumber);
                Console.WriteLine(contact.ContactAge);
                Console.WriteLine(contact.ContactNotes);
                Console.WriteLine(contact.ContactCreatedDate);
                Console.WriteLine("");
            }

            //delete list of contacts
            Console.WriteLine("This list will now self-destruct.");
            Console.WriteLine("");
            foreach (var contact in context.Contacts)
            {
                Console.WriteLine("Deleting {0}", contact.ContactName);
                context.Contacts.Remove(contact);
                Console.WriteLine("Success!");
                Console.WriteLine("");
            }
            context.SaveChanges();
            
            Console.WriteLine("It's like The Avengers were never here.");

        }
    }
}
