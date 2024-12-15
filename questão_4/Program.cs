
Console.WriteLine("'Em uma loja em Sapiranga, os produtos foram colocads em liquidação. Os descontos variam conforme os códigos dos produtos:");
Console.WriteLine("Códigos \tDescontos ");
Console.WriteLine("1-1000  \t15% ");
Console.WriteLine("1001-2000 \t25% ");
Console.WriteLine("2001-3000 \t35% ");
Console.WriteLine("3001... \t40% ");
Console.WriteLine(@"Faça um algorítmo que receba o preço do produto e seu código.
Calcule e escreva o deconto, o preço com desconto, preço de tabela.
(PrecoDesconto = (preço * (100-desconto))/100)'");

Console.ReadLine();

Console.WriteLine("Bom dia!");

Console.WriteLine("Para seu atendimento, primeiro precisamos saber qual é o preço do produto no qual você quer comprar meu senhor.");
string preco = Console.ReadLine() ?? "";
int intPreco; int.TryParse(preco, out intPreco);

Console.WriteLine("");

Console.WriteLine(@"Agora, precisamos saber qual é o código de desconto desse produto, meu senhor.
Os códigos vão de 1 a até mais que 3000. Como já visto anteriormente, consulte a tabela de descontos.");
string codigo = Console.ReadLine() ?? "";
int intCodigo; int.TryParse(codigo, out intCodigo);

int desconto;
if (intCodigo >= 1 && intCodigo <= 1000)            {desconto = 15;}
else if (intCodigo >= 1001 && intCodigo <= 2000)    {desconto = 25;}
else if (intCodigo >= 2001 && intCodigo <= 3000)    {desconto = 35;}
else if (intCodigo >= 3001)                          {desconto = 40;}
else                                                {desconto = 100;}
                
Console.WriteLine(@"Ok senhor, ok. Fica............................................................................................................................................................................................................................................
hm, o sistema ta dando problema. Deseja tentar novamente?");
Console.ReadLine();
Console.WriteLine("Hm, imagino que sim então. O senhor poderia por os dados novamente?");
Console.ReadLine();
Console.WriteLine("Hm..................................................... Calma que o sistema ta voltando");
Console.ReadLine();
Console.ReadLine();
Console.WriteLine("Calma que ta andando.");
Console.ReadLine();
Console.WriteLine("FOI");
Console.WriteLine("O preço digitado anteriormente foi de " + preco + ", né? Ok ok... e o desconto, com o código de " + codigo + " fica de " + desconto + "%, o que significa queno fim o preço fica de " + ((intPreco * (100-desconto))/100) + ". Espero que tenha um ótimo dia!");        