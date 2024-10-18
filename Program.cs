using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework401433113
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"Title : {Title}");
            Console.WriteLine($"Author : {Author}");
            Console.WriteLine($"Year : {Year}");
            Console.WriteLine($"ISBN : {ISBN}");
        }
    }
    class Member
    { 
        public int ID { get; set; }
     public string Name { get; set; }
     public string PhoneNumber { get; set; }
     public void PrintMemberInfo()
        {
            Console.WriteLine($"Member ID : {ID}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Phone Number : {PhoneNumber}");
        }
    }
    class Program
    { 
        static void Main(string[] args)
    {
            Book book = new Book
            {
                Title = "Divan-e Shams-e Tabrizi",
                Author = "Jalal ad-din Mohammad AKA Rumi",
                Year = 2010,
                ISBN = "10:8877780800"
            };
        book.PrintInfo();
            Member member = new Member
            {
                ID = 401433113,
                Name = "Shahin Arab",
                PhoneNumber = "09178916721"
            };
        member.PrintMemberInfo();
    }}
}
