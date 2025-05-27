using System.Collections.Generic;

/**
    Você está fazendo um programa que simula um céu estrelado
    para realizar análises astronomicas.

    Para isso você deve implementar uma função que recebe uma
    coordenada x e y, além de uma lista de estrelas que estão
    no céu e precisa retornar a intensidade de brilho vista
    naquela coordenada.

    Para fazer isso basta seguir a seguinte equação:

    ** BrilhoNaCoordeada = Soma da contribuição de Brilho de todas 
                        as estrelas para aquela coordenada
    
    Ou seja, cada estrela contribui para um pouco de brilho
    na coordenada que você está calculado.

    Para descobrir quanto de brilho uma estrela contribui para
    a coordenada específica basta realizar o seguinte calculo:

    ** ContribuiçãoDeUmaEstrela = Brilho da Estrela dividido pela
        distância da estrela até a coordenada que você deseja
    
    Para descobrir a distância distância de duas coordenadas, ou
    seja da estrela até a coordenada que você deseja descobrir
    é muito simples:

    ** distancia = raiz(distância em X^2 + distância em Y^2)
 **/


App.Run();

public class StarFinder
{   
    public float GetBrightness(int x, int y, List<Star> stars)
    {
        return 0;
    }
}

public class Star
{
    public float Brightness { get; set; }
    public float X { get; set;}
    public float Y { get; set;}
}