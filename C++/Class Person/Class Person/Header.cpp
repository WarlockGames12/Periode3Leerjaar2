#include "Header.h"

Calculator::Calculator() {
	name = "Dirk";
}
Calculator::~Calculator() {

}

int Calculator::Plus(int a, int b) {
	return a + b;
}

int Calculator::Minus(int a, int b) {
	return a - b;
}

int Calculator::Multiply(int a, int b) {
	return a * b;
}

