using CreditCompanyLibrary;
using System;
using System.Collections.Generic;

namespace CreditCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            var _paymentCalculator = new PaymentCalculator();
            bool end = false;
            var _payments = new List<Payment>();
            while (end)
            {
                Console.WriteLine("Credit Company");
                Console.WriteLine("Write your clientid:");
                string clientid = Console.ReadLine();

                //Klientas turi prisijungti irases savo ID, turetu buti ir slaptazodis
                // yra du klientai 123 ir 124
                switch (clientid)
                {
                    case "123":
                        _payments = _paymentCalculator.paymentsOfJonas;
                    break;
                    case "124":
                        _payments = _paymentCalculator.paymentsOfPetras;
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Choose what you want to do");
                Console.WriteLine("1 - Get current month payments");
                Console.WriteLine("2 - Get last month payments");
                Console.WriteLine("3 - Compare current month payments with last month");
                Console.WriteLine("4 - Show categories where I spend more than the last month");
                Console.WriteLine("5 - Show my payment by categories");
                Console.WriteLine("6 - EXIT");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        _paymentCalculator.CountPaymentsOfCurrentMonth(_payments);
                        break;
                    case "2":
                        _paymentCalculator.CountPaymentsOfLastMonth(_payments);
                        break;
                    case "3":
                        // palygina dvieju menesiu islaidas
                        break;
                    case "4":
                        // rodo kur daugiau isleista pinigu
                        break;
                    case "5":
                        // rodo islaidas pagal kategorijas
                        break;
                    case "6":
                        end = true;
                        break;
                    default:
                        break;

                }


            }
        }
    }
}
