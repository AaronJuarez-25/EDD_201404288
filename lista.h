#ifndef LISTA_H
#define LISTA_H


typedef struct NodoLDE NodoLDE;
typedef struct Lista Lista;

struct NodoLDE{
   int valor;
    NodoLDE * anterior;
    NodoLDE * siguiente;
};

struct Lista{
    NodoLDE * primero;

};

void ingresarLDE(int valor, Lista * lista);
void eliminarLDE(int valor, Lista * lista);

int Imprimir(Lista*lista);

#endif // LISTA_H
