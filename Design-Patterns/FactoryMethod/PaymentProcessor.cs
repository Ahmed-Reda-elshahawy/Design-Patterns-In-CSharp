using Design_Patterns.FactoryMethod.Helpers;

namespace Design_Patterns.FactoryMethod
{
    public class PaymentProcessor(PaymentMethodFactory paymentMethodFactory)
    {
        public void ProcessPayment(PayType payType, PaymentDTO paymentDTO)
        {
            // create payment card
            PaymentMethod paymentMethod = paymentMethodFactory.CreatePaymentMethod(payType, paymentDTO);

            // process payment
            paymentMethod.AuthorizePayment();
            paymentMethod.StartMoneyTransfer();
            paymentMethod.CalculatePaymentFee(0.02);
        }
    }
}
