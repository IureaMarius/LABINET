using System;

namespace SOLID.OCP
{
    public enum BankTerminalModel
    {
        Brp,
        Dcp
    }

    public interface IBankTerminal
    {
    }

    // Changed the design pattern used for this factory to abstract factory. Classes that used to use the BankTerminalFactory should hold it in a TerminalFactoryBase variable and instantiate the right one.
    public abstract class TerminalFactoryBase
    {
        public abstract IBankTerminal CreateBankTerminal(BankTerminalModel model);
    }
    public class BankTerminalFactory: TerminalFactoryBase
    {
        public override IBankTerminal CreateBankTerminal(BankTerminalModel model)
        {
            switch (model)
            {
                case BankTerminalModel.Brp:
                    return new BrpTerminal();
                case BankTerminalModel.Dcp:
                    return new DcpTerminal();
                default:
                    throw new ArgumentException("Unknown model");
            }
        }
    }

    public class ExtendedBankTerminalFactory: TerminalFactoryBase
    {
        public override IBankTerminal CreateBankTerminal(BankTerminalModel model)
        {
            switch (model)
            {
                case BankTerminalModel.Brp:
                    return new BrpTerminal();
                case BankTerminalModel.Dcp:
                    return new DcpTerminal();
                // ADD WHATEVER NEW CASE HERE
                default:
                    throw new ArgumentException("Unknown model");
            }
        }

    }

    public class BrpTerminal : IBankTerminal
    {
    }

    public class DcpTerminal : IBankTerminal
    {
    }
}