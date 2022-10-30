using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppPractica3.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsAppPractica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Empleado empleado;
        public Publicador publicador1;
        private void btnCrearObjetos_Click(object sender, EventArgs e)
        {
            //creando objetos de la clase autor 
            Autor autor1 = new Autor();
            Autor autor2 = new Autor();

            //seteando sus propiedades 
            autor1.Nombre = "Perez";
            autor1.Apellido = "Lopez";
            autor1.Fecha = new DateTime(1997, 10, 1);
            autor1.Domicilio = "Alem 1800";
            autor1.Ciudad = "Mar del plata";
            autor1.Pais = "Argentina";

            autor2.Nombre = "Tomas";
            autor2.Apellido = "Agusto";
            autor2.Fecha = new DateTime(1996, 1, 2);
            autor2.Domicilio = "Pacheco 1212";
            autor2.Ciudad = "Rio Negro";
            autor2.Pais = "Suiza";


            //crear el objeto empleado con su declaracion a nivel formulario y seteando sus propiedades
            empleado = new Empleado();
            empleado.Nombre = "Raymundo";
            empleado.Apellido = "Gonzales";
            empleado.Titulo = "Administrativo";
            empleado.FechaIngreso = new DateTime(2022, 12, 10);


            //Creando objetos de la clase venta 
            Venta venta1 = new Venta();
            Venta venta2 = new Venta();

            //seteando sus propiedades 
            venta1.Tienda = "Guolis";
            venta1.NumeroOrden = 3243242;
            venta1.Fecha = new DateTime(2002, 03, 01);
            venta1.Cantidad = 30;
            venta1.Titulo = "Contador";

            venta2.Tienda = "las Vituallas";
            venta2.NumeroOrden = 223243242;
            venta2.Fecha = new DateTime(2022, 03, 01);
            venta2.Cantidad = 55;
            venta2.Titulo = "Administrativo";

            //crear el objeto publicador con su declaracion a nivel formulario y seteando sus propiedades
            publicador1 = new Publicador();
            publicador1.Nombre = "Angie";
            publicador1.Ciudad = "New York";
            publicador1.Domicilio = "Acevedo 2014";
            publicador1.Contacto = "publicador@gmail.com";
            publicador1.Pais = "Arabia saudita";


            //Creando objetos de la clase titulo
            Titulo titulo = new Titulo();
            titulo.NombreAutor = "Jamito";
            titulo.titulo = "Abogado";
            titulo.Categoria = "Administrativo";
            titulo.Precio = 303;
            titulo.Notas = 30;

            //mostrando GET

            MessageBox.Show(autor1.Nombre + " " + autor1.Apellido);
            MessageBox.Show(autor2.Nombre + " " + autor2.Apellido);

            MessageBox.Show(publicador1.Nombre + " " + publicador1.Pais);

            MessageBox.Show(titulo.NombreAutor + " " + titulo.Categoria + " " + titulo.titulo);

            MessageBox.Show($"Nombre: {titulo.NombreAutor} y su categoria es {titulo.titulo}");
            


        }
    }
}
