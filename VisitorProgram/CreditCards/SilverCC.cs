using System;

namespace VisitorProgram
{
    public class SilverCreditCard : ICreditCard
    {
        public void Accept(IOfferVisitor visitor)
        {
            visitor.VisitSilverCreditCard(this);
        }

        public String GetName()
        {
            return "Silver";
        }
    }
}
