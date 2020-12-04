using System;

namespace VisitorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelOfferVisitor hotelVisitor = new HotelOfferVisitor();
            GasOfferVisitor gasVisitor = new GasOfferVisitor();

            BronzeCreditCard bronze = new BronzeCreditCard();
            SilverCreditCard silver = new SilverCreditCard();
            GoldCreditCard gold = new GoldCreditCard();

            bronze.Accept(hotelVisitor);
            silver.Accept(hotelVisitor);
            gold.Accept(hotelVisitor);

            bronze.Accept(gasVisitor);
            silver.Accept(gasVisitor);
            gold.Accept(gasVisitor);

            Console.ReadLine();
        }
    }
}
