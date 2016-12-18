#include <iostream>
using namespace std;

class Base
{
 public:
       virtual void fn() = 0;
       virtual void fn(int i){printf("\n Base: fn(int)\n");};
       virtual void fn2() {printf("\n Base: void fn2()\n");}
       void fn3() {printf("\n Base: fn3()\n");}
       void fn4(){printf("\n Base: fn4()\n");}
};

class ClassA : public Base
{
  public:
	  ClassA (int n, int d){};
      // using Base::fn2;
      virtual void fn(){printf("\n ClassA: fn()\n");};
      virtual void fn(int i){printf("\n ClassA: fn(INT)\n");};

      virtual void fn2(int i) {printf("\n ClassA: fn2(INT)\n"); }
      void fn3() {printf("\n ClassA: fn3()\n");}
      void fn4(int i){printf("\n ClassA: fn4()\n");}
 };

int main()
{ 
 Base* pBase1 = new ClassA(10, 20);
 pBase1->fn();             //OK，ClassA: fn()
 pBase1->fn(11);           //OK，ClassA: fn(INT)
 pBase1->fn2();            //OK，Base: void fn2(int)
//pBase1->fn2(2);          //NO, Does not compile
 pBase1->fn3();            //OK，Base: fn3()
 pBase1->fn4();            //OK，Base: fn4()
//pBase1->fn4(2);          //NO, Does not compile
 printf("\n============================================\n");

 ClassA* pDerived = new ClassA(10, 20);
 pDerived->fn();            //OK，ClassA: fn()
 pDerived->fn(1);           //OK，ClassA: fn(INT)
//pDerived->fn2();          //NO, Does not compile，
 pDerived->fn2(2);          //OK，ClassA: fn2(INT)
 pDerived->fn3();           //OK，ClassA: fn3()
//pDerived->fn4();          //NO, Does not compile
 pDerived->fn4(2);          //OK，ClassA: fn4()
 printf("\n============================================\n");

 system("pause");
 return 0;      
}
