using System;

/**
    Você está fazendo um programa com o objetivo de desenhar
    coisas baseados em expressões. Como seu primeiro teste você
    deseja desenhar um coração.

    Para isso você deve implementar a função SetPixel que 
    recebe a posição i e j da image (de 0 a 400) e retorna
    um pequeno vetor com valores bgr (Blue-Green-Red) que
    devem ser desenhados.

    Os pixeis que devem ser pintados são os que a seguinte equação tem valores negativos:
        val = (((i / 150 - 1.25)^2 + (j / 150 - 1.25)^2 - 1)^3 + (i / 150 - 1.25)^2 (j / 150 - 1.25)^3

    Lembre-se em usar valores de float ou double para efetuar os calculos e não
    usar inteiros. Lembre-se também que ^ é potência na matemática mas não
    na programação.
 **/    


App.Run();

public class HeartDrawer
{   
    public byte[] SetPixels(int i, int j)
    {
        var pixel = new byte[3];

        return pixel;
    }
}