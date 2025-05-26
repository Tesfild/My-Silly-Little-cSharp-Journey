using System;
using System.Globalization;

// Exercício 1

/* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
mensagem explicativa, conforme exemplos
*/

// Exemplos: 

/* Entrada:                 Saída:
 * 10                       SOMA = 40
 * 30
 */

// Resolução:

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

int soma = num1 + num2;

Console.WriteLine($"SOMA = {soma}");

// Exercício 2

/* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
casas decimais conforme exemplos.

Fórmula da área: area = π . raio2
Considere o valor de π = 3.14159
*/

// Exemplos: 

/* Entrada:                 Saída:
 * 2.00                     A=12.5664
 */

// Resolução:

// A = PI * r^2

double raio = double.Parse(Console.ReadLine());
double area = Math.PI * (Math.Pow(raio, 2));

Console.WriteLine($"A={area:F4}");

// Exercício 3

/* Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
 */

// Exemplos: 

/* Entrada:                 Saída:
 * 5                        DIFERENCA = -26
 * 6
 * 7
 * 8
 */

// Resolução:

int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int C = int.Parse(Console.ReadLine());
int D = int.Parse(Console.ReadLine());

int diferenca = ((A * B) - (C * D));

Console.WriteLine($"DIFERENÇA = {diferenca}");

// Exercício 4

/* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
decimais
*/

// Exemplos: 

/* Entrada:                 Saída:
* 25                        NUMBER = 25                          
* 100                       SALARY = U$ 550.00
* 5.50
*/

// Resolução

int numeroFuncionario = int.Parse(Console.ReadLine());
int horasDeTrabalho = int.Parse(Console.ReadLine());
double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double calcSalario = horasDeTrabalho * valorPorHora;

Console.WriteLine($"NUMBER = {numeroFuncionario}");
Console.WriteLine($"SALARY = US {calcSalario:F2}");

// Exercício 5

/* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago
*/

// Exemplos:

/* Entrada:                 Saída:
* 12 1 5.30                 VALOR A PAGAR: R$ 15.5
* 16 2 5.10
*/

// Resolução:

Console.WriteLine("Entre as informações da primeira peça:");
string[] vet1 = Console.ReadLine().Split(' ');

int cod1 = int.Parse(vet1[0]);
int quant1 = int.Parse(vet1[1]);
double valor1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

Console.WriteLine("Entre as informações da segunda peça:");
string[] vet2 = Console.ReadLine().Split(' ');

int cod2 = int.Parse(vet2[0]);
int quant2 = int.Parse(vet2[1]);
double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

double calc = (valor1 * quant1) + (valor2 * quant2);

Console.WriteLine($"VALOR A PAGAR: R$ {calc}");


// Exercício 6

/* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: G, E e F. Em seguida, calcule e
mostre:

a) a área do triângulo retângulo que tem G por base e F por altura.
b) a área do círculo de raio F. (pi = 3.14159)
c) a área do trapézio que tem G e E por bases e F por altura.
d) a área do quadrado que tem lado E.
e) a área do retângulo que tem lados G e E.
*/

// Exemplos:

/* Entrada:                 Saída:
 * 3.0 4.0 5.2              TRIANGULO: 7.800
                            CIRCULO: 84.949
                            TRAPEZIO: 18.200
                            QUADRADO: 16.000
                            RETANGULO: 12.000
 */

// Resolução:

string[] vet = Console.ReadLine().Split(' ');

double G = double.Parse(vet[0], CultureInfo.InvariantCulture);
double E = double.Parse(vet[1], CultureInfo.InvariantCulture);
double F = double.Parse(vet[2], CultureInfo.InvariantCulture);

// Calculo da área do triângulo retângulo

double areaTR = (G * F) / 2;

// Calculo da área do círculo

double areaC = Math.PI * Math.Pow(G, 2);

// Calculo da área do trapézio

double areaT = ((G + E) * F) / 2;

// Calculo da área do quadrado

double areaQ = Math.Pow(E, 2);

// Calculo da área do retângulo

double areaR = G * E;

// Saídas:

Console.WriteLine($"TRIANGULO: {areaTR:F3}");
Console.WriteLine($"CIRCULO: {areaC:F3}");
Console.WriteLine($"TRAPEZIO: {areaT:F3}");
Console.WriteLine($"QUADRADO: {areaQ:F3}");
Console.WriteLine($"RETANGULO: {areaR:F3}");

