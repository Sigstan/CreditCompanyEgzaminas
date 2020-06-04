using System;

namespace CreditCompanyLibrary
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public int MonthId { get; set; } // is uzduoties aprasymo, supratau, kad reikia naudoti tik du menesius

        public Payment(int paymentId, int price, Category category, int monthId)
        {
            PaymentId = paymentId;
            Price = price;
            Category = category;
            MonthId = monthId;

        }
        

        
    }
}
