
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
            person1.FirstName = "A";
            person1.NationalIdentity = 254;
            person1.LastName = "G";
            person1.DateOfBirthYear = 2010;

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1 );
            
            

            Console.ReadLine();
            
        }
    }
}