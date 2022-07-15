#include <iostream>
#include <string>
#include "Person.h";
using namespace std;

class Calculator {
    Calculator ();
    ~Calculator(); 

    int Plus (int a, int b);
    int Minus(int a, int b);
    int Multiply(int a, int b);
    
private:
    std::string name;

protected:

};

int Plus(int a, int b){
    return a + b;
}


int main()
{
    //Opdracht 2
    Person* p = new Person();

    //Opdracht 3
    Person* Dirk = new Person();
    Person* Coen = new Person();
    Person* Marianne = new Person();
    Person* Emma = new Person();

    Dirk->SetName("Dirk");
    Dirk->SetSurName("ten Have"); 

    Dirk->SetFather(Coen);
    Coen->SetName("Coen");
    Coen->SetSurName("ten Have");

    Dirk->SetMother(Marianne);
    Marianne->SetName("Marianne");
    Marianne->SetSurName("ten Have-Vestering");

    Dirk->SetSister(Emma);
    Emma->SetName("Emma");
    Emma->SetSurName("ten Have");
    
    std::cout << Dirk->GetName() << std::endl;
    std::cout << Dirk->GetSurName() << std::endl;
    std::cout << Dirk->GetFather()->GetName() << std::endl;
    std::cout << Dirk->GetFather()->GetSurName() << std::endl;
    std::cout << Dirk->GetMother()->GetName() << std::endl;
    std::cout << Dirk->GetMother()->GetSurName() << std::endl;
    std::cout << Dirk->GetSister()->GetName() << std::endl;
    std::cout << Dirk->GetSister()->GetSurName() << std::endl;

    
    //let's count
    std::cout << ", Let's Count: 10 + 10 = " << Plus(10, 10);
}



