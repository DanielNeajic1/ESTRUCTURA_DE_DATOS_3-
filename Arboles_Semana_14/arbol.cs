class ArbolBinario
{
    private Nodo raiz;

    public void Insertar(int valor)
    {
        raiz = InsertarRec(raiz, valor);
    }

    private Nodo InsertarRec(Nodo nodo, int valor)
    {
        if (nodo == null) return new Nodo(valor);
        if (valor < nodo.Valor) nodo.Izquierdo = InsertarRec(nodo.Izquierdo, valor);
        else if (valor > nodo.Valor) nodo.Derecho = InsertarRec(nodo.Derecho, valor);
        return nodo;
    }

    public bool Buscar(int valor)
    {
        return BuscarRec(raiz, valor);
    }

    private bool BuscarRec(Nodo nodo, int valor)
    {
        if (nodo == null) return false;
        if (nodo.Valor == valor) return true;
        return valor < nodo.Valor ? BuscarRec(nodo.Izquierdo, valor) : BuscarRec(nodo.Derecho, valor);
    }

    public void InOrden() => InOrdenRec(raiz);
    private void InOrdenRec(Nodo nodo)
    {
        if (nodo != null)
        {
            InOrdenRec(nodo.Izquierdo);
            Console.Write(nodo.Valor + " ");
            InOrdenRec(nodo.Derecho);
        }
    }
}
