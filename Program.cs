using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Employee
    {
        public Dictionary<string, string> employee = new Dictionary<string, string>();

        public Employee()
        {
            employee.Add("Bob228", "xaker228");
            employee.Add("karchevska_a", "32552");
            employee.Add("evthturnedgrey", "bts3987");
            employee.Add("mekiochi", "gospoza");
            employee.Add("martynchukk_v", "sonechko666");
            employee.Add("boreychuk_o", "zabavnaya");
        }

        public void AddLoginPasword(string login, string pasword)
        {
            employee[login] = pasword;
        }

        public void Delete(string login)
        {
            employee.Remove(login);
        }

        public void Change(string oldLogin, string newLogin, string newPasword)
        {
            //врооді помінять key не можна того роблю новий
            Console.WriteLine("Old login:: "+ oldLogin + "\tOld pasword:: " + employee[oldLogin]);
            employee.Remove(oldLogin);
            employee.Add(newLogin, newPasword);
            Console.WriteLine("New login:: " + newLogin + "\tNew pasword:: " + employee[newLogin]);
        }

        public void PrintPasword(string login)
        {
            Console.WriteLine("Pasworld:: " + employee[login]);
       
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.PrintPasword("mekiochi");
            employee.Change("Bob228", "jolybar", "xbox fan");
       
        }
    }
}
