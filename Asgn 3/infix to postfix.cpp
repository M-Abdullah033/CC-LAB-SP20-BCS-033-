#include <iostream>
#include <stdlib.h>
using namespace std;

/*
E->TE'
E'->+TE'|-TE'|null    print + / print -
T-> FT'
T'->*FT'|/FT'|null
F-> id|num|(E)        print id/print num
*/

int count = 0;
void E();
void Ed();
void T();
void Td();
void F();

string expr;

int main() {
  cin >> expr;
  int l = expr.length();
  expr += "$";
  E();
  if (l == count)
    cout << "Accepted" << endl;
  else
    cout << "Rejected" << endl;
}

void E() {
  T();
  Ed();
}

void Ed() {
  if (expr[count] == '+') {
    count++;
    T();
    Ed();
    cout << "+";
  } else if (expr[count] == '-') {
    count++;
    T();
    Ed();
    cout << "-";
  } else {
    // E'->null
  }
}

void T() {
  F();
  Td();
}

void Td() {
  if (expr[count] == '*') {
    count++;
    F();
    Td();
    cout << "*";
  } else if (expr[count] == '/') {
    count++;
    F();
    Td();
    cout << "/";
  } else {
    // T'->null
  }
}

void F() {
  if (isalpha(expr[count]) || isdigit(expr[count])) {
    cout << expr[count];
    count++;
  } else if (expr[count] == '(') {
    count++;
    E();
    if (expr[count] != ')') {
      cout << "Rejected" << endl;
      exit(0);
    }
    count++;
  } else {
    cout << "Rejected" << endl;
    exit(0);
  }
}