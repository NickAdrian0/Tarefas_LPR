﻿int qnum, num, total = 0;
Console.WriteLine("Bem vindo a calculadora de media aritimetica de numeros pares.\nPor favor, insira a quantidade de numeros que deseja.");
qnum = int.Parse(Console.ReadLine());
if (qnum != 0) {
Console.WriteLine("Agora, digite os numeros que deseja fazer a media");
for (int i = 0; i < qnum; i++)
{
    num = int.Parse(Console.ReadLine());
    if (num % 2 == 0) total += num;
} 
Console.WriteLine($"A soma total dos numeros pares inseridos é de {total}");    
} else Console.WriteLine("O numero inserido eh invalido, reinicie o programa e tente novamente.");
