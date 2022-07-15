#pragma once
#include <string>

class Calculator {
    Calculator();
    ~Calculator();

    int Plus(int a, int b);
    int Minus(int a, int b);
    int Multiply(int a, int b);

private:
    std::string name;

protected:

};
