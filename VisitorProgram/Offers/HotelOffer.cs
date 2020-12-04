using System;

namespace VisitorProgram
{
    class HotelOfferVisitor : IOfferVisitor
    {
        public void VisitBronzeCreditCard(BronzeCreditCard bronze)
        {
            Console.WriteLine("We are computing the cashback for purchasing a hotel room with a bronze credit card");
        }

        public void VisitSilverCreditCard(SilverCreditCard silver)
        {
            Console.WriteLine("We are computing the cashback for purchasing a hotel room with a silver credit card");
        }

        public void VisitGoldCreditCard(GoldCreditCard gold)
        {
            Console.WriteLine("We are computing the cashback for purchasing a hotel room with a gold credit card");
        }
    }
}
