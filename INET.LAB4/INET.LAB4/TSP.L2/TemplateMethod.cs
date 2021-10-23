namespace SOLID.OCP
{
    // I assume we have to add a new step without breaking implementations that inherit from PaymentProcessor
    // We do this by adding a virtual method in the parent class, that he children can choose to override, but are not forced to. These are commonly named "hooks"
    public abstract class PaymentProcessor
    {
        public void ProcessTransaction()
        {
            WithdrawMoney();
            CalculateBonus();
            SendGreetings();
            NotifyClient();
        }

        protected abstract void WithdrawMoney();
        protected abstract void CalculateBonus();
        protected abstract void SendGreetings();
        protected virtual void NotifyClient()
        {

        }
    }

    public class OnlineProcessor : PaymentProcessor
    {
        protected override void WithdrawMoney() { }

        protected override void CalculateBonus() { }

        protected override void SendGreetings() { }
    }

    public class PosTerminalProcessor : PaymentProcessor
    {
        protected override void WithdrawMoney() { }

        protected override void CalculateBonus() { }

        protected override void SendGreetings() { }
    }

    public class CryptoPaymentProcessor : PaymentProcessor
    {
        protected override void WithdrawMoney() { }

        protected override void CalculateBonus() { }

        protected override void SendGreetings() { }
        protected override void NotifyClient()
        {
            // extra step in this class, not affecting any other children in the hierarchy
        }
    }
}
