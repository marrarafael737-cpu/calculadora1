

{
int opcao = 0;
double num1; double num2; double soma;  double subtracao; double multiplicacao; double divisao;

while(opcao != 5)
{
Console.WriteLine("===CALCULADORA DIGITAL===");
Console.WriteLine("Selecione a opção desejada: ");
Console.WriteLine("1- Quero Somar ");
Console.WriteLine("2- Quero Subtrair ");
Console.WriteLine("3- Quero multiplicar");
Console.WriteLine("4- Quero Dividir");
Console.WriteLine("5- Sair");
opcao= int.Parse(Console.ReadLine());

if(opcao== 1)
{
Console.WriteLine("Digite o primeiro número: ");
num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digte o segundo número: ");
num2 = double.Parse(Console.ReadLine());
soma = num1 + num2; 
Console.WriteLine($"O resultado da soma entre {num1} e {num2} é: {soma} ");
}

else if(opcao== 2)
{
Console.WriteLine("Digite o primeiro número: ");
num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digte o segundo número: ");
num2= double.Parse(Console.ReadLine());
subtracao = num1-num2;
Console.WriteLine($"O resultado da subtração entre {num1} e {num2} é: {subtracao} ");
} 

else if(opcao== 3)
{
Console.WriteLine("Digite o primeiro número: ");
num1= double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
num2= double.Parse(Console.ReadLine());
multiplicacao= num1*num2;
Console.WriteLine($"O resultado da multiplicação entre {num1} e {num2} é: {multiplicacao}");
}

else if(opcao== 4)
{ 
Console.WriteLine("Digite o primeiro número: ");
num1= double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo número: ");
num2= double.Parse(Console.ReadLine());
divisao= num1/num2;
Console.WriteLine($"O resultado da divisão entre {num1} e {num2} é: {divisao}");
}

if(opcao== 5)

{
Console.WriteLine("Encerrando Programa");
}

}
}