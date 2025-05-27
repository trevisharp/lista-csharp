using System;
using System.Collections.Generic;

/**
    Uma variável aleatória é um objeto matemático que pode resultar
    em valores aleatórios. Nesta questão você implementará uma
    classe mãe abstrata chamada RandomVariable e 3 de seus filhos.

    Toda a variável aleatória tem um método Get() -> float que 
    retorna um valor aleatório com base em uma regra que depende
    da implementação do filho. 

    Toda variável aleatória tem um método Expected() -> float que
    retorna o valor esperado (médio). Ele pode depender da
    implementação do filho mas tem uma implementação padrão que faz
    o seguinte processo:
        - Roda a função Get() 1000 vezes e tira a média.

    Variáveis aleatórias ainda podem se somar por uma função
    Add(RandomVariable) -> RandomVariable. Essa função tem um 
    comportamento que independe dos filhos retornando um objeto
    de SumRandomVariable.

    Implemente os seguintes filhos:
    
    - DiceRandomVarialbe
        - O Get() retorna um valor entre 1 e 6.

    - ConstatnRandomVariable(float value)
        - O Get() retorna sempre value.
        - O Expected() retorna sempre value.
    
    - SumRandomVariable(RandomVariable X1, RandomVariable X2)
        - O Get() chama o Get de X1 e X2 e soma.
        - O Expected() chama o Expected de X1 e X2 e soma.
 **/