using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores_Ordenados
{
    class Inventario
    {
        int _Cantidad;
        int _Posicion;

        string Datos = "";
        bool Validar;
        public int posicion { get { return _Posicion; } set { _Posicion = value; } }
        public bool validar { get { return Validar; } }

        Auto[] lisAuto = new Auto[15];
        public int cantidad { get { return _Cantidad; } }
        public Inventario()

        {
            _Cantidad = 0;
            _Posicion = 0;
        }

        public void Agregar(Auto Car)
        {
            if (_Cantidad < 14)
            {

                Ordenar(Car);
                // lisAuto[_Cantidad] = Car;
                _Cantidad++;
            }
            else if (cantidad == 14)
            {
                Ordenar(Car);
            }
        }
        private void Ordenar(Auto temp)//Nota este codigo cortarlo para entregar practica es perteneciente a la practica 2
        {
            {
                int a = 0;
                while (a <= cantidad)
                {
                    if (lisAuto[a] != null)
                    {

                        if (temp.placa.CompareTo(lisAuto[a].placa) < 0)
                        {
                            for (int l = cantidad; l > a; l--)
                            {
                                lisAuto[l] = lisAuto[l - 1];

                            }
                            lisAuto[a] = temp;
                            a = cantidad;
                        }
                    }
                    else
                    {
                        lisAuto[a] = temp;
                    }
                    a++;
                }
            }
        }

        /*public void Insertar(Auto Car)

        {
            Mover();
            lisAuto[_Posicion] = Car;

            if (_Cantidad < 14)

            {
                _Cantidad++;
            }
        }*/

        private void Mover()
        {
            for (int a = _Cantidad; a > _Posicion; a--)
            {
                lisAuto[a] = lisAuto[a - 1];
            }
        }
        public void Eliminar(string placa)

        {
            Buscar(placa);
            if (Validar)
            {
                if (lisAuto[posicion] != null)
                {
                    Auto vacio = new Auto();
                    lisAuto[posicion] = vacio;
                    MoverBorrar();
                    _Cantidad--;

                }
            }
        }
        private void MoverBorrar()
        {
            for (int a = _Posicion; a < _Cantidad; a++)

            {
                lisAuto[a] = lisAuto[a + 1];
            }
        }


        public void Lista()//Enlista los datos
        {
            Datos = "";
            for (int a = 0; a <= (_Cantidad - 1); a++)
            {
                Datos += (a + 1) + "._\t" + lisAuto[a].ToString() + Environment.NewLine;
            }
        }
        public Auto Buscar(string placa)//Metodo Buscar ahora modificado //nota presente algunos problemas con la sintaxis
        {
            Validar = false;
            int a = 0;
            while (Validar == false && a < cantidad)
            {
                if (lisAuto[a] != null)
                {
                    if ((placa.CompareTo(lisAuto[a].placa) == 0))
                    {

                        Validar = true;
                        posicion = a;

                        return lisAuto[a];
                    }
                    else if ((placa.CompareTo(lisAuto[a].placa) < 0))
                    {
                        return null;
                    }

                }

                a++;
            }
            return null;
        }

        public override string ToString()
        {
            return Datos;
        }
    }
}

/*   bool existe = false;
   Datos = "";
   int a = 0;
   while (existe == false && a <= _Cantidad)
   {
       if (lisAuto[a].placa == placa)
       {
           Datos = (a + 1) + "._\t" + lisAuto[a].ToString();
           MessageBox.Show("Carro encontrado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

           a = _Cantidad;
           existe = true;
       }
       a++;
   }*/




