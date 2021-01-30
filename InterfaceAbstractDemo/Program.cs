using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    partial class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new customer {DateOfBirth = new DateTime(1995,9,16), FirstName="Muhammed Akif", LastName="HAŞLAK",NationalityId="14933979746" });

          
           Console.ReadLine();
        }
    }
}
