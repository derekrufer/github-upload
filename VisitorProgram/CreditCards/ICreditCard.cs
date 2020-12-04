using System;
    
namespace VisitorProgram
{
    interface ICreditCard
    {
        void Accept(IOfferVisitor visitor);
        String GetName();
    }
}