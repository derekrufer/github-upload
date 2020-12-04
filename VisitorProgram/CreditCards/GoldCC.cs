using System;

namespace VisitorProgram
{
    public class GoldCreditCard : ICreditCard
    {
        public void Accept(IOfferVisitor visitor)
        {
            visitor.VisitGoldCreditCard(this);
        }

        public String GetName()
        {
            return "Gold";
        }
    }
}