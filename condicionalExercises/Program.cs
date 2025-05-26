// Exercicio 1

/* Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
*/

// Exemplos:

/* Entrada:                         Saída:
   -10                              NEGATIVO
*/

// Solução:


int numInt = int.Parse(Console.ReadLine());

if (numInt >= 0) {
    Console.WriteLine("NÃO NEGATIVO");
}
else {
    Console.WriteLine("NEGATIVO");
}


// Exercício 2

/* Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
*/

// Exemplos:

/* Entrada:                         Saída:
   12                               PAR
*/

// Solução:


int numInt = int.Parse(Console.ReadLine());

if (numInt % 2 == 0) {
    Console.WriteLine("PAR");
}
else {
    Console.WriteLine("IMPAR");
}


// Exercício 3

/* Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
ordem crescente ou decrescente
*/

// Exemplos:

/* Entrada:                         Saída:
 * 6 24                             São multiplos
 */

// Solução:


string[] vet = Console.ReadLine().Split(' ');

int A = int.Parse(vet[0]);
int B = int.Parse(vet[1]);

if (A % B == 0 || B % A == 0) {
    Console.WriteLine("São múltiplos de sí");
}
else {
    Console.WriteLine("Não são múltiplos de sí");
}


// Exercicio 4

/* Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
*/

// Exemplos:

/* Entrada:                         Saída:
 * 16 2                             O JOGO DUROU 10 HORA(S)
 */

// Solução:


string[] vet1 = Console.ReadLine().Split(' ');

int horaInicial = int.Parse(vet1[0]);
int horaFinal = int.Parse(vet1[1]);

int duracao;
if (horaInicial > horaFinal) {
    duracao = 24 - horaInicial + horaFinal;
    Console.WriteLine($"O jogo durou {duracao} hora(s)");
}


// utilizando else if apenas para melhor explicação do problema
else if (horaInicial < horaFinal) {
    duracao = horaFinal - horaInicial;
    Console.WriteLine($"O jogo durou {duracao} hora(s)");
}


// Exercicio 5

/* Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
seguir, calcule e mostre o valor da conta a paga
*/

// Exemplos: 

/* Entrada:                         Saída:
 * 3 2                              Total: R$ 10.00
 */

// Solução:


using System.Numerics;

string[] vet2 = Console.ReadLine().Split(' ');

int cod = int.Parse(vet2[0]);
int quant = int.Parse(vet2[1]);

string item;
double preco;
double total;

if (cod == 1) {
    item = "Cachorro Quente";
    preco = 4.00;
    total = preco * quant;
    Console.WriteLine($"Total = {total}");
    
}
else if (cod == 2) {
    item = "X-Salada";
    preco = 4.50;
    total = preco * quant;
    Console.WriteLine($"Total = {total}");
}
else if (cod == 3) {
    item = "X-Bacon";
    preco = 5.00;
    total = preco * quant;
    Console.WriteLine($"Total = {total}");
}
else if (cod == 4) {
    item = "Torrada Simples";
    preco = 2.00;
    total = preco * quant;
    Console.WriteLine($"Total = {total}");
}

else if (cod == 5) {
    item = "Refrigerante";
    preco = 1.50;
    total = preco * quant;
    Console.WriteLine($"Total = {total}");
}
else {
    Console.WriteLine("Produto não está no cardápio");
}


// Exercício 6

/* Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
*/

// Exemplos:

/* Entrada:                         Saída:
 * 25.01                            Intervalo(25,50]
 */

// Solução:


double valor = double.Parse(Console.ReadLine());

if (valor >= 0 && valor <= 25.0) {
    Console.WriteLine("Intervalo (0,25]");
}
else if (valor >= 25 && valor <= 50) {
    Console.WriteLine("Intervalo (25,50]");
}
else if (valor >= 50 && valor <= 75) {
    Console.WriteLine("Intervalo (50,75]");
}
else if (valor >= 75 && valor <= 100) {
    Console.WriteLine("Intervalo (75,100]");
}
else {
    Console.WriteLine("Fora de intervalo");
}



// Exercício 7

/* Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
* de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
* ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
* Se o ponto estiver na origem, escreva a mensagem “Origem”.
* Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for 
*/

// Exemplos:

/* Entrada:                         Saída:
* 4.5 -2.2                          Q4
*/

// Solução:


string[] vet3 = Console.ReadLine().Split(' ');

double x = double.Parse(vet3[0]);
double y = double.Parse(vet3[1]);

if (x == 0.0 && y == 0.0) {
    Console.WriteLine("Origem");
}
else if (x == 0) {
    Console.WriteLine("Eixo Y");

}
else if (y == 0) {
    Console.WriteLine("Eixo X");
}
else if (x > 0.0 && y > 0.0 ) {
    Console.WriteLine("Q1");
}
else if (x < 0.0 && y > 0.0) {
    Console.WriteLine("Q2");
}
else if (x < 0.0 && y < 0.0) {
    Console.WriteLine("Q3");
}
else if (x > 0.0 && y < 0.0) {
    Console.WriteLine("Q4");
}
else {
    Console.WriteLine("inválido");
}


// Exercício 8

/* Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
duas casas decimais.
*/

// Exemplos:

/* Entrada:                         Saída:
 * 3002.00                          R$ 80,36
 */

// Solução:


using System.Globalization;

double salario = double.Parse(Console.ReadLine());
double imposto;

if (salario >= 0.00 && salario <= 2000.00) {
    Console.WriteLine("Isento");
}
else if (salario >= 2000.01 && salario <= 3000.00) {
    imposto = (salario - 2000.00) * 0.08;
    Console.WriteLine($"R$ {imposto:F2}");
}
else if (salario >= 3000.01 && salario <= 4500.00) {
    imposto = (salario - 3000.00) * 0.18 + 1000.00 * 0.08;
    Console.WriteLine($"R$ {imposto:F2}");
}

else if (salario > 4500.00) {
    imposto = (salario - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
    Console.WriteLine($"R$ {imposto:F2}");
}

