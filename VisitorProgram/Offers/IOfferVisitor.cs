namespace VisitorProgram
{
    public interface IOfferVisitor
    {
        void VisitBronzeCreditCard(BronzeCreditCard bronze);
        void VisitGoldCreditCard(GoldCreditCard gold);
        void VisitSilverCreditCard(SilverCreditCard silver);
    }
}