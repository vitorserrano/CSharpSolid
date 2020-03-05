using System;

namespace CSharpSolid
{
  class Person 
  {
      public string Document { get; set; }
      public String Name { get; set; }
      public String Email { get; set; }

      public Person(string document, string name, string email) 
      {
          Document = document ?? throw new Exception("Informe o Documento!");
          Name = name ?? throw new Exception("Informe o Nome!");
          Email = email ?? throw new Exception("Informe o E-mail!");
      }
  }
}