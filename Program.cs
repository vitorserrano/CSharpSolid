using System;

namespace CSharpSolid
{
  class Program
  {
    // Injeção de Dependencias
    private static readonly IServiceBank _serviceBank = new ServiceBank();
    static void Main(string[] args)
    {
      var person = new Person(
              "00000000000",
              "Vitor",
              "vitorcirinoserrano@gmail.com"
          );

      EmailService.SendEmail(person);

      Console.WriteLine("\n");

      var accountPoupanca = new AccountPoupanca(person);

      _serviceBank.Credit(accountPoupanca, 10.00m);
      _serviceBank.Debit(accountPoupanca, 10.00m);
      _serviceBank.GetSaldo(accountPoupanca);

      Console.ReadLine();
    }
  }
}
