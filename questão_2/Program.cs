Console.WriteLine("'Escreva um algorítmo que para receber as dimensões de um retângulo (largura e altura), calcular e escrever a área do retângulo'");
            
            Console.ReadLine();
            
            Console.WriteLine("Maluco como assim tu n sabe calcular a área de um retângulo? Muito burro vsf. Manda a altura e a base aí MAS EM CENTÍMETROS");
            string altura = Console.ReadLine() ?? "";
            int intAltura;
            int.TryParse(altura, out intAltura);

            Console.WriteLine(" ");
            string largura = Console.ReadLine() ?? "";
            int intLargura;
            int.TryParse(largura, out intLargura);

            Console.WriteLine("Só fazer " + altura + " vezes " + largura + ". Dá " + (intAltura*intLargura) + " centímetros" );