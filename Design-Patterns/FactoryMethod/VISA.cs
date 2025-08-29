using Design_Patterns.FactoryMethod.Helpers;

namespace Design_Patterns.FactoryMethod
{
    public class VISA : PaymentMethod
    {
        private readonly PaymentDTO paymentDTO;
        public VISA(PaymentDTO paymentDTO)
        {
            this.paymentDTO = paymentDTO;
        }

        public override void AuthorizePayment()
        {
            Console.WriteLine("Visa: authorize payment");
            Console.WriteLine($"CardData: \nCardNumber: {paymentDTO.CardNumber}, CardHolder: {paymentDTO.CardHolder}, CVV: {paymentDTO.CVV}, ExpiryDate:{paymentDTO.ExpireDate}");
        }

        public override void CalculatePaymentFee(double amount)
        {
            Console.WriteLine($"Visa: payment fee {amount}");
        }

        public override void StartMoneyTransfer()
        {
            Console.WriteLine("Visa: Start transfer");
        }
    }
}
