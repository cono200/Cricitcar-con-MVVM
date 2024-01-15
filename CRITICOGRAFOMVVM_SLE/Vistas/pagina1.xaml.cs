using CRITICOGRAFOMVVM_SLE.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CRITICOGRAFOMVVM_SLE.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pagina1 : ContentPage
    {
        public pagina1()
        {
            InitializeComponent();
            BindingContext = new VmPersona(Navigation);
        }
    }
}