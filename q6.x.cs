using System;
using System.Collections.Generic;

/**
    Você está trabalhando na fusão de duas empresas e tem
    acesso a duas funções que acessam dados dos usuários
    das duas empresas, a getUsers1() e a getUsers2().

    Faça consultas que respondam as seguintes perguntas:

    1. Qual o saldo médio dos usuários premium da empresa
       1? Qual é o mesmo valor quando juntamos as duas 
       empresas?

    2. Quais são os nomes dos 100 usuários mais ricos
       considerando ambas as empresas? Quantos desses
       usuários são usuários premium?
 **/

IEnumerable<User> getUsers1()
{
    string[] names = [
        "Donathan", "Nycollas", "Queila",
        "Leonardo", "Fábio", "Alisson"
    ];
    string[] surnames = [
        "Ramalho", "Sobolevski", "Lima",
        "Trevisan", "Silveira", "Ferro"
    ];

    int N = Random.Shared.Next(800, 1_200);
    for (int i = 0; i < N; i++)
    {
        var name = names[Random.Shared.Next(names.Length)];
        var surname = surnames[Random.Shared.Next(surnames.Length)];
        yield return new User {
            Name = $"{name} {surname}",
            Age = Random.Shared.Next(12, 80),
            Money = 10_000 * Random.Shared.NextDouble(),
            IsPremium = Random.Shared.Next() % 3 == 0,
            Company = 1
        };
    }
}

IEnumerable<User> getUsers2()
{
    string[] names = [
        "Fernanda", "Patrick", "Lucas",
        "Gabriel", "Christian", "Eduardo"
    ];
    string[] surnames = [
        "Silveira", "Pereira", "Buchner",
        "Bernardelli", "Cardoso", "Ribeiro"
    ];

    int N = Random.Shared.Next(1_000, 1_400);
    for (int i = 0; i < N; i++)
    {
        var name = names[Random.Shared.Next(names.Length)];
        var surname = surnames[Random.Shared.Next(surnames.Length)];
        yield return new User {
            Name = $"{name} {surname}",
            Age = Random.Shared.Next(10, 40),
            Money = 8_000 * Random.Shared.NextDouble(),
            IsPremium = Random.Shared.Next() % 2 == 0,
            Company = 2
        };
    }
}

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Money { get; set; }
    public bool IsPremium { get; set; }
    public int Company { get; set; }
}