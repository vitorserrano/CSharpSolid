using System;

namespace CSharpSolid
{
  internal class ServiceBank : IServiceBank
  {
    public void Credit(AbstractAccountBank accountBank, decimal value)
    {
      accountBank.Credit(value);
    }

    public void Debit(AbstractAccountBank accountBank, decimal value)
    {
      accountBank.Debit(value);
    }

    public void GetSaldo(AbstractAccountBank accountBank)
    {
      accountBank.GetSaldo();
    }
  }
}