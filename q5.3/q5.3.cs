using System;
using System.Collections.Generic;
using System.Drawing;

/**
    Você está fazendo um jogo baseado em texto e está
    modularizando a forma como mensagens são formatadas
    na tela. Ou seja, nesta questão, você irá esquecer
    personagens e focar apenas na formatação.

    Sua ideia é implementar duas abstraçãoes: A abstração
    de mensagem e a abstração de formatador.

    Um IMessage é uma interface base para todas as 
    mensagens do seu jogo. Ela possui apenas uma única
    função chamada Build(Context) -> string que recebe
    um objeto de contexto e retorna uma string da saída.

    Um IFormater tem uma função Format(IMessage, Context)
    que printa a mensagem de uma forma específica.

    Implemente 2 formater e 2 messages:

    -HelloMessage: Sempre retorna oi.
    -CookieMessage: Se o contexto possui "Cookie" na sua
        Info, não diz nada ("...") caso contrário oferece
        um Cookie ("Deseja um Cookie?").
    -NormalFormater: Apenas printa a mensagem recebida.
    -SpecialFormater: Digita cada caracter com um pequeno
        atraso e um um espaçamento adicional entre cada
        caracter.
 **/

public class Context
{
    public HashSet<string> Info { get; set; } = [];
}