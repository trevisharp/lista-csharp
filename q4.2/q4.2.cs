using System;
using System.Collections.Generic;

/**
   Faça a abstração que será usada por um restaurante para
   controlar pedidos. Você precisa ter uma classe Item que
   representa um item do cardápio com nome e a propriedade
   de tipo (salgado, café, doce, etc.) que usará um enum.
   Você deverá ter uma classe pedido que possui uma mesa e
   uma lista de itens do cardápio.
   Por fim você precisará de uma classe de gerenciador dos
   pedidos. Essa classe possui uma fila que recebe pedidos
   em um método de AdicionarPedido.
   O Gerenciador precisa de uma função EscolherProximo que
   retorna o proximo pedido que deve ser preparado. Abaixo
   você pode ver o comportamento básico do gerenciador:
   1.O Gerenciador tem outra lista de proximos pedidos.
   2.Se algo estiver nessa lista ele pega o menor pedido e
     então remove esse pedido da lista.
   3.Se a lista de proximos pedidos estiver vazia ele pega
     até 3 pedidos da fila principal e coloca na lista de
     próximos pedidos.
 **/