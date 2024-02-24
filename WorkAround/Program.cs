
using Business.Concrete;
using Entities.Concrete;
using System;

namespace MyApp 
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Person person1 = new Person();
            person1.FirstName = "Abdulkadir";
            person1.NationalIdentity = 254;
            person1.LastName = "Gur";
            person1.DateOfBirthYear = 2000;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1 );
            
            

            Console.ReadLine();
            
        }
    }
}