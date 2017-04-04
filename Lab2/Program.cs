using CreditLibrary;
﻿using BusinessCard;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard creditCard = new CreditCard();
            creditCard.getCredit();
            BusinessCardMain businessCard = new BusinessCardMain();
            businessCard.UseBusinessCard();
        }
    }
}
