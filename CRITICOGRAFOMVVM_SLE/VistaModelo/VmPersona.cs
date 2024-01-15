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
        
        





        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void BtnCriticarLlamar(string palabras)
        {
            Resultado = palabras;
        }

        public void Criticar()
        {
            BtnCriticarLlamar(aber);
            if (Mujer== true)
            {
                //string[] opciones = new string[6];
                //int contador = 0;
                if (Alto==true)
                {
                    Texto = "alta";
                    
                }
                if (Feo==true)
                {
                    Texto = "fea";
                    
                }
                if (Listo == true)
                {
                    Texto = "lista";
                }
                if (Extravagante == true)
                {
                    Texto = "extravagante";
                }
                if (Grande == true)
                {
                    Texto = "grande";
                    
                }
                if (Raro == true)
                {
                    Texto = "rara";
                }
                aber += Texto;

                //if (contador > 1)
                //{
                //    for (int i = 0; i < contador - 1; i++)
                //    {
                //        resultado += opciones[i] + ", ";
                //    }
                //    resultado += "y " + opciones[contador - 1] + ".";
                //}
                //else
                //{
                //    resultado = opciones[0] + ".";
                //}

                //Resultado.Text = nombre + " es " + resultado;
            }



            //else
            //{
            //    string[] opciones = new string[6];
            //    int contador = 0;
            //    if (Alto.IsChecked)
            //    {
            //        opciones[contador] = "alto";
            //        contador++;
            //    }
            //    if (Feo.IsChecked)
            //    {
            //        opciones[contador] = "feo";
            //        contador++;
            //    }
            //    if (Listo.IsChecked)
            //    {
            //        opciones[contador] = "listo";
            //        contador++;
            //    }
            //    if (Extravagante.IsChecked)
            //    {
            //        opciones[contador] = "extravagante";
            //        contador++;
            //    }
            //    if (Grande.IsChecked)
            //    {
            //        opciones[contador] = "grande";
            //        contador++;
            //    }
            //    if (Raro.IsChecked)
            //    {
            //        opciones[contador] = "raro";
            //        contador++;
            //    }

            //    string resultado = "";
            //    if (contador > 1)
            //    {
            //        for (int i = 0; i < contador - 1; i++)
            //        {
            //            resultado += opciones[i] + ", ";
            //        }
            //        resultado += "y " + opciones[contador - 1] + ".";
            //    }
            //    else //if (contador == 1)
            //    {
            //        resultado = opciones[0] + ".";
            //    }

            //    //Resultado.Text = nombre + " es " + resultado;
            //}
        }


        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand CriticarCommand => new Command(Criticar);
        #endregion









    }
}
