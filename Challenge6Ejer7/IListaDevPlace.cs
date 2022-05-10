using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6Ejer7
{
    interface IListaDevPlace<T>
    {
        void AgregarItem(T item);
        void BorrarItem(T item);
        T ObtenerItem(int index);
        int CantidadItems();
    }
}
