using _0104.Models;

Console.WriteLine("Hello, World!");

Customer c1 = new Customer();
c1.CustomerId = 1;
c1.Name = "Jaguara";
c1.EmailAddress = "jaguara@pixote.net";

Customer c2 = new Customer(2);
c2.Name = "Boca-mole";
c2.EmailAddress = "nerso@pixote.com";

Customer c3 = new Customer{
CustomerId = 1,
Name = "Boca-mole",
EmailAddress = "nerso@pixote.com"
};