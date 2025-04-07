#include <iostream>

using namespace std;
int num;
 
int numReverse (int& number) {
    int reversenum;
    number = number % 10;
    num = reversenum * 10 + number;
    return reversenum;
}

int main () {
    cout << "Ola, seja bem vindo ao algoritmo reversor de numeros.\nDigite um numero e indicarei seu reverso:\n";
    cin >> num;
    num = numReverse(num);
    cout << "Seu numero invertido equivale a " <<  num << ".\n";
    system("pause");
}