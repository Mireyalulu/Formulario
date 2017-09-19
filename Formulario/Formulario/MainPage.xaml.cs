using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Formulario
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void datos(object sender,EventArgs e)
        {
            var nombre = txtnombre.Text;
            var apellido = txtapellido.Text;
            var direccion = txtdireccion.Text;
            var telefono = txttelefono.Text;
            var carrera = txtcarrera.Text;
            var semestre = txtsemestre.Text;
            var matricula = txtmatricula.Text;
            var correo = txtcorreo.Text;
            var github = txtgithub.Text;


            DisplayAlert("Datos","Datos Personales\n Nombre: "+nombre+"\n Apellidos: "+ apellido +"\n Direccion:"+ direccion
            + "\n Telefono:" + telefono + "\n Datos Escolares\n Carrera:" + carrera + "\n Semestre:" + semestre + "\n Matricula:" + matricula +
            "\n Datos Sociales\n Correo:" + correo + "\n Github:" + github, "OK");
        }

        
        
    }
}
