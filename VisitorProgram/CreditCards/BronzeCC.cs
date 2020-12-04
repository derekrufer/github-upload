using System;

namespace VisitorProgram
{
    public class BronzeCreditCard : ICreditCard
    {
        public void Accept(IOfferVisitor visitor)
        {
            visitor.VisitBronzeCreditCard(this);
        }

        public String GetName()
        {
            return "Bronze";
        }
    }
}