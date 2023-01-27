using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

namespace Work_8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            ContacktBook1 cb = new ContacktBook1();
            Console.Write("Введите ФИО:");
            cb.FIO = Console.ReadLine();
            Console.Write("Введите улицу: ");
            cb.street = Console.ReadLine();
            Console.Write("Введите дом: ");
            cb.numberHome = int.Parse(Console.ReadLine());
            Console.Write("Введите номер квартиры: ");
            cb.numberHome = int.Parse(Console.ReadLine());
            Console.Write("Введите номер мобильного телефона: ");
            cb.nPhone = long.Parse(Console.ReadLine());
            Console.Write("Введите номер домашнего телефона: ");
            cb.hPhone = int.Parse(Console.ReadLine());
            CreateXML();

            void CreateXML()
            {
                XDocument xdoc = new XDocument();
                XElement Person = new XElement("Person");
                XElement Adress = new XElement("Adress");
                XElement Phones = new XElement("Phones");
                XElement Street = new XElement("Street", cb.street);
                XElement HouseNUmber = new XElement("HouseNumber", cb.numberHome);
                XElement FlatNumber = new XElement("FlatNumber", cb.numberApart);
                XElement MobilePhone = new XElement("MobilePhone", cb.nPhone);
                XElement FlatPhone = new XElement("FlatPhone", cb.hPhone);
                XAttribute Name = new XAttribute("name", cb.FIO);

                Person.Add(Name);
                Person.Add(Adress, Phones);
                Adress.Add(Street, HouseNUmber, FlatNumber);
                Phones.Add(MobilePhone, FlatPhone);
                xdoc.Add(Person);
                xdoc.Save("Worker.xml");
            }
        }
    }
}

