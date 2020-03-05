using System;

namespace CSharpSolid
{
  internal abstract class AbstractAccountBank
  {
    public Person Person { get; private set; }

    public decimal Saldo { get; set; }

    public AbstractAccountBank(Person person)
    {
      Person = person;
      Saldo = 0.0m;
    }

    public abstract void Debit(decimal value);
    public abstract void Credit(decimal value);

    public void GetSaldo()
      => Console.WriteLine($"{Person.Name} seu saldo é de {Saldo}");
  }
}