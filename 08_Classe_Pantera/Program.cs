﻿using Models;

class Program {
   public static void Main() {
    var pantera1 = new Pantera();
    pantera1.tamanho = 2,5m;
    pantera1.peso = 150;
    pantera1.cor = "preto";
    pantera1.especie = "negra";
    pantera1.alimentaçao = "carnes";
    pantera1.Correr();
   }
}