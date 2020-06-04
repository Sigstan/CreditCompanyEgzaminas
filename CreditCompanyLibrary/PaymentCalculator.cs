using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CreditCompanyLibrary
{
    public class PaymentCalculator

    {
        public List<Client> clients = new List<Client>();
        public List<Payment> paymentsOfJonas = new List<Payment>();
        public List<Payment> paymentsOfPetras = new List<Payment>();




        public PaymentCalculator()
        {
            paymentsOfJonas.Add(new Payment(001, 20, Category.Food, 0));
            paymentsOfJonas.Add(new Payment(002, 60, Category.Entertainment, 0));
            paymentsOfJonas.Add(new Payment(003, 200, Category.Taxes, 0));
            paymentsOfJonas.Add(new Payment(004, 40, Category.Food, 0));
            paymentsOfJonas.Add(new Payment(005, 30, Category.Food, 1));
            paymentsOfJonas.Add(new Payment(006, 70, Category.Entertainment, 1));
            paymentsOfJonas.Add(new Payment(007, 201, Category.Taxes, 1));  paymentsOfJonas.Add(new Payment(001, 20, Category.Food, 0));
            paymentsOfPetras.Add(new Payment(002, 60, Category.Entertainment, 0));
            paymentsOfPetras.Add(new Payment(003, 200, Category.Taxes, 0));
            paymentsOfPetras.Add(new Payment(004, 40, Category.Food, 0));
            paymentsOfPetras.Add(new Payment(005, 30, Category.Food, 1));
            paymentsOfPetras.Add(new Payment(006, 70, Category.Entertainment, 1));
            paymentsOfPetras.Add(new Payment(007, 201, Category.Taxes, 1));
            clients.Add(new Client(123, "Jonas", "Jonaitis", paymentsOfJonas));
            clients.Add(new Client(124, "Petras", "Petraitis", paymentsOfPetras));
        }

        public double CountPaymentsOfLastMonth(List<Payment> payments)
        {
            double lastMonthExpenses = 0;
           
            foreach (var payment in payments)
            {
                if (PaymentIsFromLastMonth(payment))
                {
                    lastMonthExpenses += payment.Price;
                } 
            }
            return lastMonthExpenses;
            
        }

        public double CountPaymentsOfCurrentMonth(List<Payment> payments)
        {
            double currentMonthExpenses = 0;

            foreach (var payment in payments)
            {
                if (!PaymentIsFromLastMonth(payment))
                {
                    currentMonthExpenses += payment.Price;
                }
            }
            return currentMonthExpenses;

        }


        public bool PaymentIsFromLastMonth(Payment payment)
        {
            if (payment.MonthId == 0)
                return true;
            return false;
        }
      
    }
}
