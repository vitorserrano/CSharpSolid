using System;

namespace CSharpSolid
{
  internal class EmailService 
  {
    public static void SendEmail(Person person)
    => Console.WriteLine($"Para: {person.Email}, Mensagem: Olá {person.Name}");
  }
}