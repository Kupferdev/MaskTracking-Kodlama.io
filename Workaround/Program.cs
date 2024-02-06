using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;

Console.WriteLine("Hello World!");

Person person1 = new();
person1.FirstName = "Ahmet";
person1.LastName = "Bakır";
person1.DateOfBirthYear = 2004;
person1.NationalId = 24815739606;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);