using System;

namespace CSharpSolid
{
  internal class AccountPoupanca : AbstractAccountBank
  {
    public AccountPoupanca(Person person) : base(person) { }

    public override void Credit(decimal value)
    {
      if (Saldo < value)
      {
        Console.WriteLine($"{Person.Name} saldo indisponível para saque!");
        return;
      }

      Saldo += value;
      Console.WriteLine("Deposito efetuado com sucesso!");
    }

    public override void Debit(decimal value)
    {
      Saldo -= value;
      Console.WriteLine("Saque efetuado com sucesso!");
    }
  } 
}