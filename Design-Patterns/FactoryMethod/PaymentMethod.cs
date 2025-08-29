namespace Design_Patterns.FactoryMethod
{
    public abstract class PaymentMethod
    {
        public string CardNumber { get; set; } = null!;
        public string CardHolder { get; set; } = null!;
        public string CVV { get; set; } = null!;
        public DateTime ExpiryDate { get; set; }

        public abstract void AuthorizePayment();
        public abstract void StartMoneyTransfer();
        public abstract void CalculatePaymentFee(double amount);
    }
}
