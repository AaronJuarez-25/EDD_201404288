#include <QCoreApplication>
#include <iostream>
#include "stdio.h"
#include "stdlib.h"
#include "string.h"
#include "assert.h"


extern "C"{
#include "lista.h"
}
Lista * lista = (Lista*)malloc(sizeof(Lista));
NodoLDE* nodo = (NodoLDE*)malloc(sizeof(NodoLDE));


using namespace std;



int main(int argc, char *argv[])
{
     bool ciclar = false;
    lista->primero=NULL;
    QCoreApplication a(argc, argv);



    do{
    ciclar=false;
    int opcion = 0;
    int valor = 0;
    cout<<"Seleccione una opcion del menu"<<endl;
    cout<<"1-Ingresar Valor Entero en la Lista"<<endl;
    cout<<"2-Imprimir Lista"<<endl;
    cout<<"3-Borrar elemento de la lista"<<endl;
    cin>>opcion;

    switch(opcion){
case 1:

    cout<<"Ingrese el numero entero que dese agregar a la lista"<<endl;
    cin>>valor;
    ingresarLDE(valor,lista);
    cout<<"El numero: "<<valor<<"  fue agregado correctamente"<<endl;

    ciclar = true;
        break;
case 2:

        nodo = Imprimir(lista);
      // cout<<nodo->valor<<endl;

        ciclar = true;
    break;
case 3:
    cout<<"Ingrese el valor que desea eliminar de la lista"<<endl;
    cin>>valor;
    if(lista->primero==NULL){
    cout<<"La lista esta Vacia"<<endl;
    }else{
    eliminarLDE(valor, lista);
    }
        ciclar = true;
        break;
default:


    {

    }
    }
    }while(ciclar);

    return 0;
    return a.exec();
}
