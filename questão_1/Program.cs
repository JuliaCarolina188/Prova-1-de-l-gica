Console.WriteLine("'Receba três números inteiros e informe o valor do menor, do maior e a média entre eles'");

Console.ReadLine();

//confesso que as linhas a seguir serão um gore pra quem sabe programar em c#, mas minha capacidade me limita :) (tive q usar ia pra converter inclusive)
//aqui eu recebo um número em string(dado de texto) e converto pra int(dado de número).
//o número é reebido em cada console.readline econvertido nas 5 linhas seguintes
//deveter uma forma tão mais fácil de fazer isso pelo amor

Console.WriteLine("Digite um número qualquer, por favor: ");
    string entradaUm = Console.ReadLine() ?? "";
    int numeroUm;
    int.TryParse(entradaUm, out numeroUm);
    int maior = numeroUm; int menor = numeroUm;
    
Console.WriteLine("Mais um, por obséquio: ");
    string entradaDois = Console.ReadLine() ?? "";
    int numeroDois;
    int.TryParse(entradaDois, out numeroDois);
    if (numeroDois > maior) {maior = numeroDois;}
    if (numeroDois < menor) {menor = numeroDois;}

Console.WriteLine("E um último: ");
    string entradaTres = Console.ReadLine() ?? "";
    int numeroTres;
    int.TryParse(entradaTres, out numeroTres);
    if (numeroTres > maior) {maior = numeroTres;}
    if (numeroTres < menor) {menor = numeroTres;}

Console.WriteLine("Com todas essas informações, consigo concluir que o maior número dito foi " + maior + ", enquanto o menor foi " + menor);
Console.WriteLine("Agora, a média entre os números é de " + (numeroUm+numeroDois+numeroTres)/3 + "!");