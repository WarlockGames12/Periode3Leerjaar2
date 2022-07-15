#include "Person.h"
#include <string>

Person::Person() {
	Naam = "Dirk";
	Achternaam = "ten Have";
	DateOfBirth = "05-10-2001";
	PlaceOfBirth = "Maastricht";
	Adress = "Jachthoornstraat 57";
	postalCode = "6219BN";
}
Person::~Person() {

}

void Person::SetMother(Person* aPerson) {
	mother = aPerson;
}

void Person::SetFather(Person* aPerson) {
	father = aPerson;
}

void Person::SetSister(Person* aPerson) {
	sister = aPerson;
}

void Person::SetName(std::string aName) {
	name = aName;
}
void Person::SetSurName(std::string aName) {
	surName = aName;
}

Person* Person::GetFather() {
	return father;
}

Person* Person::GetMother() {
	return mother;
}

Person* Person::GetSister() {
	return sister;
}

std::string Person::GetName() {
	return name;
}

std::string Person::GetSurName() {
	return surName;
}
