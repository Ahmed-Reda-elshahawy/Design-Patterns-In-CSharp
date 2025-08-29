using Design_Patterns.FactoryMethod.Helpers;

namespace Design_Patterns.FactoryMethod
{
    public class PaymentMethodFactory
    {
        public PaymentMethod CreatePaymentMethod(PayType payType, PaymentDTO paymentDTO)
        {
            if(payType == PayType.VISA)
            {
                return new VISA(paymentDTO);
            }

            if(payType == PayType.MASTERCARD)
            {
                return new MASTERCARD(paymentDTO);
            }

            throw new NotImplementedException();
        }
    }
}
