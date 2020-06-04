using System;
using System.Collections.Generic;
using System.Text;

namespace CreditCompanyLibrary
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Payment> Payment { get; set; }

        public Client(int clientId, string firstName, string lastName, List<Payment> payment)
        {
            ClientId = clientId;
            FirstName = firstName;
            LastName = lastName;
            Payment = payment;

        }

     

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Client: {ClientId} {FirstName} {LastName}";
        }
    }
}
