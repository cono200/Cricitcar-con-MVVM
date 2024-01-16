using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CRITICOGRAFOMVVM_SLE.VistaModelo
{
    public  class VmPersona : BaseViewModel
    {
        #region VARIABLES
        string _nombre;
        bool _mujer; //= false;
        bool _hombre;// = false;
        bool _alto; //= false;
        bool _feo; //= false;
        bool _listo; //= false;
        bool _extravagante;
        bool _grande;
        bool _raro;
        string _aber;
        string _texto;
        string _resultado;
        int _contador;
      //  string[] opciones = new string[6];

        #endregion
        #region CONSTRUCTOR
        public VmPersona(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string Nombre
        {
            get { return _nombre; }
            set { SetValue(ref _nombre, value); }
        }
        public string Texto
        {
            get { return _texto; }
            set { SetValue(ref _texto, value); }
        } 
        public string Resultado
        {
            get { return _resultado; }
            set { SetValue(ref _resultado, value); }
        }

        public bool Mujer
        {
            get { return _mujer; }
            set { SetValue(ref _mujer, value); }
        }

        public bool Hombre
        {
            get { return _hombre; }
            set { SetValue(ref _hombre, value); }
        }

        public bool Alto
        {
            get { return _alto; }
            set { SetValue(ref _alto, value); }
        }

        public bool Feo
        {
            get { return _feo; }
            set { SetValue(ref _feo, value); }
        }

        public bool Listo
        {
            get { return _listo; }
            set { SetValue(ref _listo, value); }
        }
        public bool Extravagante
        {
            get { return _extravagante; }
            set { SetValue(ref _extravagante, value); }
        } 
        public bool Grande
        {
            get { return _grande; }
            set { SetValue(ref _grande, value); }
        }
        public bool Raro
        {
            get { return _raro; }
            set { SetValue(ref _raro, value); }
        }
        public string aber
        {
            get { return _aber; }
            set { SetValue(ref _aber, value); }
        }
        public int Contador
        {
            get { return _contador; }
            set { SetValue(ref _contador, value); }
        }
        
        





        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void resultadoFinal()
        {
            Criticar();
            aber = Nombre + "es" + Resultado;
        }

        public void Criticar()
        {
            if (Mujer == true)
            {
                Texto = "";
                Contador = 0;
                if (Alto == true)
                {
                    Texto += "alta,";
                    Contador++;
                }
                if (Feo == true)
                {
                    Texto += "fea,";
                    Contador++;
                }
                if (Listo == true)
                {
                    Texto += "lista,";
                    Contador++;
                }
                if (Extravagante == true)
                {
                    Texto += "extravagante,";
                    Contador++;
                }
                if (Grande == true)
                {
                    Texto += "grande,";
                    Contador++;
                }
                if (Raro == true)
                {
                    Texto += "rara,";
                    Contador++;
                }

                Resultado = "";
                string[] guardarTexto = Texto.Split(',');
                if (Contador > 1)
                {
                    for (int i = 0; i < Contador - 1; i++)
                    {
                        Resultado += guardarTexto[i] + ", ";
                    }
                    Resultado = Resultado.Substring(0, Resultado.Length - 2); 
                    Resultado += " y " + guardarTexto[Contador - 1];
                }
                else if (Contador == 1)
                {
                    Resultado = guardarTexto[0];
                }
                Resultado = Nombre + " es " + Resultado + ".";
            }
            else
            {
                Texto = "";
                Contador = 0;
                if (Alto == true)
                {
                    Texto += "alto,";
                    Contador++;
                }
                if (Feo == true)
                {
                    Texto += "feo,";
                    Contador++;
                }
                if (Listo == true)
                {
                    Texto += "listo,";
                    Contador++;
                }
                if (Extravagante == true)
                {
                    Texto += "extravagante,";
                    Contador++;
                }
                if (Grande == true)
                {
                    Texto += "grande,";
                    Contador++;
                }
                if (Raro == true)
                {
                    Texto += "raro,";
                    Contador++;
                }

                Resultado = "";
                string[] guardarTexto = Texto.Split(',');
                if (Contador > 1)
                {
                    for (int i = 0; i < Contador - 1; i++)
                    {
                        Resultado += guardarTexto[i] + ", ";
                    }
                    Resultado = Resultado.Substring(0, Resultado.Length - 2);
                    Resultado += " y " + guardarTexto[Contador - 1];
                }
                else if (Contador == 1)
                {
                    Resultado = guardarTexto[0];
                }
                Resultado = Nombre + " es " + Resultado + ".";
            }
        }


        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand CriticarCommand => new Command(Criticar);
        #endregion









    }
}
