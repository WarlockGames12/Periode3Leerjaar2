#pragma once
#include <string>
class Person
{
public:
	Person();
	~Person();
public:
    //Opdracht 3
	void SetMother(Person* aPerson);
	void SetFather(Person* aPerson);
	void SetSister(Person* aPerson);
	void SetName(std::string aName);
	void SetSurName(std::string aSurName);

	std::string GetName();
	std::string GetSurName();

	Person* GetFather();
	Person* GetMother();
	Person* GetSister();

private:
	//Opdracht 2
	std::string Naam;
	std::string Achternaam;
	std::string DateOfBirth;
	std::string PlaceOfBirth;
	std::string Adress;
    std::string postalCode;

	//Opdracht 3
	std::string name;
	std::string surName;

	Person* father;
	Person* mother;
	Person* sister;
};

