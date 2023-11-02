using System.Formats.Asn1;
using ExemploFundamentos.Common.Models;
/*Pessoa P1 = new Pessoa();
P1.Nome = "Samuel";
P1.Idade = 22;

P1.Apresentar();


Pessoa P1 = new Pessoa();

P1.Nome = "Samuel";
P1.Idade = 22;

P1.Apresentar();

int idade = 20;

double valores1 = 18.80;

decimal valores2 = 18.80M;

string texto = "Testando";

Console.WriteLine("int: " + idade);
Console.WriteLine("double: " + valores1);
Console.WriteLine("decimal: " + valores2 + "/...Seu tipo agora é: "+ valores2.GetType());
Console.WriteLine($"decimal com o ToString : {valores2.ToString("0.00")} :" + valores2.ToString("0.00").GetType());
Console.WriteLine("texto: " + texto);


int a = 10;
int b = 20;
int c = a + b;
Console.WriteLine(c);


c = c + 5;
Console.WriteLine(c);
c += 5;
Console.WriteLine(c);

//Casting
int t1 =Convert.ToInt32 ("4");
//ou
int t2 = int.Parse("5");
Console.WriteLine(t1 + " Seu tipo é "+ t1.GetType());
Console.WriteLine(t2 + " Seu tipo é "+ t2.GetType());

//Converter String

int inteiro = 10;
string conversao = inteiro.ToString();
Console.WriteLine(conversao);


int s1 = 10;
double s2 = s1;

Console.WriteLine(s2);


//TryParse


Nesse caso gera um erro:
string a1 = "15-";
int a2 = int.Parse(a1);

Console.WriteLine(a2);

string a1 = "15-";
int b2 = 0;
int.TryParse(a1, out b2);
Console.WriteLine(b2);

Calculadora calc = new Calculadora();

calc.Somar(3, 5);
calc.Subtrair(3,6);
calc.Multiplicar(2,2);
calc.Dividir(50,5);
calc.Potencia(5,2);
calc.RaizQuadrada(9);
calc.Tan(30);
calc.Sen(30);
calc.Cos(30);

Console.WriteLine("Digite um número");
int numeroConvertido = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Tabuada do {numeroConvertido}");

for (int i = 0; i <= 10; i++)
{
        Console.WriteLine($"{numeroConvertido} X {i} = {numeroConvertido * i}");
}



int contador = 0;

while (contador <= 10)
{
    Console.WriteLine($"{numeroConvertido} X {contador} = {numeroConvertido * contador}");
    contador++;
}

int contador = 0;

do
{
    Console.WriteLine($"{numeroConvertido} X {contador} = {numeroConvertido * contador}");
    contador++;
} while (contador <= 10);



int[] arrayDeInterios = new int[3];
arrayDeInterios[0] = 10;
arrayDeInterios[1] = 15;
arrayDeInterios[2] = 100;
for (int i = 0; i < arrayDeInterios.Length; i++)
{
    Console.WriteLine($"posição numero {i} --- valor..: {arrayDeInterios[i]}");
}


int contadorForEach = 0;

foreach(int valor in arrayDeInterios){
    Console.WriteLine($"posição numero {contadorForEach} --- valor..: {valor}");
    contadorForEach++;

Array.Resize(ref arrayDeInterios, arrayDeInterios.Length * 2);
arrayDeInterios[3] = 10;
arrayDeInterios[4] = 15;
arrayDeInterios[5] = 100;
for (int i = 0; i < arrayDeInterios.Length; i++)
{
    Console.WriteLine($"posição numero {i} --- valor..: {arrayDeInterios[i]}");
}


int[] arrayInteirosDobrados = new int[arrayDeInterios.Length * 2];
Array.Copy(arrayDeInterios, arrayInteirosDobrados, arrayDeInterios.Length);
for (int i = 0; i < arrayInteirosDobrados.Length; i++)
{
    Console.WriteLine($"posição numero {i} --- valor..: {arrayInteirosDobrados[i]}");
}*/

List<string> listaDeEstados = new List<string>();
listaDeEstados.Add("MG");
listaDeEstados.Add("SP");
listaDeEstados.Add("GO");
listaDeEstados.Add("RS");
listaDeEstados.Add("RN");
Console.WriteLine($"Itens da minha Lista: {listaDeEstados.Count}");
listaDeEstados.Add("SC");
Console.WriteLine($"Itens da minha Lista: {listaDeEstados.Count}");