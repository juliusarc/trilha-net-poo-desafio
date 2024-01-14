using DesafioPOO.Models; 
using System;


        Console.WriteLine("Nokia: ");
        // Criando uma instância de Nokia
        Nokia meuNokia = new Nokia("ModeloNokia", "987654321", "IMEINokia", 32);

        // Chamando métodos de Smartphone
        meuNokia.Ligar();
        meuNokia.ReceberLigacao();
        meuNokia.InstalarAplicativo("WhatsApp");


        
        Console.WriteLine("Iphone: ");
        // Criando uma instância de Iphone
        Iphone meuIphone = new Iphone("ModeloIphone", "123456789", "IMEIIphone", 64);

        // Chamando métodos de Smartphone
        meuIphone.Ligar();
        meuIphone.ReceberLigacao();
        meuIphone.InstalarAplicativo("Instagram");

        // Aguarda a entrada do usuário antes de encerrar o programa:
  