using System;

namespace CSharpSolid
{
  internal interface IServiceBank 
  {
    void GetSaldo(AbstractAccountBank accountBank);

    void Credit(AbstractAccountBank accountBank, decimal value);

    void Debit(AbstractAccountBank accountBank, decimal value);
  }
}