
#include "lista.h"
#include<stdio.h>
#include<stdlib.h>
#include <string.h>
#include<lista.h>

void ingresarLDE(int valor, Lista * lista){
    NodoLDE * actual = (NodoLDE*)malloc(sizeof(NodoLDE));
    NodoLDE * nuevo = (NodoLDE*)malloc(sizeof(NodoLDE));
    nuevo->valor=valor;
    nuevo->siguiente=NULL;
    nuevo->anterior=NULL;

    if(lista->primero==NULL){
        lista->primero=nuevo;
    }else{
        actual=lista->primero;
        while (actual->siguiente!=NULL) {
            actual=actual->siguiente;
        }
        actual->siguiente=nuevo;
        nuevo->anterior=actual;
    }
}

void eliminarLDE(int valor, Lista * lista){
    NodoLDE * actual = (NodoLDE*)malloc(sizeof(NodoLDE));
    actual=lista->primero;
    while (actual!=NULL) {
        if(actual->valor==valor){
            if(actual->anterior!=NULL){
                actual->anterior->siguiente=actual->siguiente;
            }
            if(actual->siguiente!=NULL){
                actual->siguiente->anterior=actual->anterior;
            }
            free(actual);
            return;
        }else{
            actual=actual->siguiente;
        }
    }
}

int Imprimir(Lista*lista){
   if(lista->primero != NULL){
       NodoLDE* aux= lista->primero;

       while(aux!=NULL){
           printf("%i\n",aux->valor);
           aux=aux->siguiente;
       }
   }else{
       printf("la lista esta vacia\n");
   }
   return 0;
}
