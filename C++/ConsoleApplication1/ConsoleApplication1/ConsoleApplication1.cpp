#include <iostream>
using namespace std;

int main()
{
    char op;
    float num1,num2;

    cout << "Enter the functions to use: +, -, *, /: ";
    cin >> op;

    cout << "Enter the numbers: ";
    cin >> num1 >> num2;

    switch (op) {
        case '+':
            cout << num1 << " + " << num2 << " = " << num1 + num2;
            break;

        case '-':
            cout << num1 << " - " << num2 << " = " << num1 - num2;
            break;

        case '*':
            cout << num1 << " * " << num2 << " = " << num1 * num2;
            break;

        case '/':
            cout << num1 << " / " << num2 << " = " << num1 / num2;
            break;

        default: 
            // if the operator is other than +, -, * or /, error message will be shown to the one that did this
            cout << "Error! Function isn't found";
            break;
    } 

    return 0;
}

