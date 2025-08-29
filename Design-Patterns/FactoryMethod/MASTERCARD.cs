using Design_Patterns.FactoryMethod.Helpers;

namespace Design_Patterns.FactoryMethod
{
    public class MASTERCARD : PaymentMethod
    {
        private readonly PaymentDTO paymentDTO;
        public MASTERCARD(PaymentDTO paymentDTO)
        {
            this.paymentDTO = paymentDTO;
        }

        public override void AuthorizePayment()
        {
            Console.WriteLine("MasterCard: Authorize payment");
            Console.WriteLine($"CardData: \nCardNumber: {paymentDTO.CardNumber}, CardHolder: {paymentDTO.CardHolder}, CVV: {paymentDTO.CVV}, ExpiryDate:{paymentDTO.ExpireDate}");
        }

        public override void CalculatePaymentFee(double amount)
        {
            Console.WriteLine($"MasterCard: payment fee {amount}");
        }

        public override void StartMoneyTransfer()
        {
            Console.WriteLine("MasterCard: Start Transfer");
        }
    }
}
