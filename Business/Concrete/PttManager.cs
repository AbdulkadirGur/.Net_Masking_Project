using Entities.Concrete;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager
    {
        public void GiveMask(Person person)
        {
            PersonManager personmanger = new PersonManager();
            if (personmanger.CheckPerson(person)) 
            {
                Console.WriteLine(person.FirstName + "icin maske verildi");
            
            }
        }
    }
}
