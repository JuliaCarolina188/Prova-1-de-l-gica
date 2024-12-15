Console.WriteLine("'Faça um algorítmo que receba um número inteiro. Se o número for maior que 10 calcule e escreva a soma do antecessor com o sucessor. Caso contrário, calcule e escreva o produto do número com seu triplo.'");
            
Console.ReadLine();
            
Console.WriteLine("É o seguinte chefe");
Console.ReadLine();
Console.WriteLine("Não te quero questionando nada nessa porra");
Console.ReadLine();
Console.WriteLine("Fala um número aí. Se tu quer tomar um soco tu escreve um número quebrado entendeu maluco: ");
    string strNumero = Console.ReadLine() ?? "";
    int intNumero;
    int.TryParse(strNumero, out intNumero);

if (intNumero > 10)
    {
        int antecessor = intNumero - 1;
        int sucessor = intNumero +1;
        Console.WriteLine("Seguinte parceiro... O número que vem depois de " + intNumero + " é " + sucessor + " e o que vem antes é o " + antecessor + ". Se tu pegar um e outro dá " + (sucessor+antecessor) + ". Po muito tri né. Aprendi na aula do Xavier");
    }

else if (intNumero == 10)
    {
        Console.WriteLine("Parabéns locão! Agora essa porra vai tudo explodir em 13h horas e meia");
    }

else if (intNumero < 10)
    {
        Console.WriteLine("Se tu pega esse número e faz x3 dá " + intNumero*3 + ". Daí, se tu pega esse número e o normal que é " + intNumero + " e faz um vezes o outro dá " + (intNumero*(intNumero*3)) + ". Muito tri né. Aprendi na aula do Xavier");
    }

else
    {
        Console.WriteLine("E tu conseguiu falar um número errado");
    }