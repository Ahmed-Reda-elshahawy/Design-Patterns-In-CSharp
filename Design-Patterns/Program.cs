using Design_Patterns.FactoryMethod;
using Design_Patterns.FactoryMethod.Helpers;
using Design_Patterns.Singleton;

namespace Design_Patterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            /// singleton
            //var logger = Logger.Instance;

            //// Set the minimum log level
            //logger.CurrentLogLevel = LogLevel.Warning;

            //logger.Log("This is an info message", LogLevel.Info);     // Not shown
            //logger.Log("This is a warning", LogLevel.Warning);       // Shown
            //logger.Log("This is an error!", LogLevel.Error);         // Shown

            /// Factory Method
            PaymentProcessor paymentProcessor = new(new PaymentMethodFactory());
            PaymentDTO paymentDTO = new PaymentDTO("1224-2122-3232-3223", "Ahmed", "12/25", DateTime.Now);
            paymentProcessor.ProcessPayment(PayType.VISA, paymentDTO);
        }
    }
}
