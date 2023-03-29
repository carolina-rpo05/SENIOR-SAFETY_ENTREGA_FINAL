using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRABAJO_PROGRAMACIÓN
{
    class Datospersonales
    {

        private string PrimerNombre;
        private string SegundoNombre;
        private string PrimerApellido;
        private string SegundoApellido;
        private string Tipo_Identificacion;
        private int Numero_de_Identificacion;
        private string Genero;
        private DateTime Fecha_de_Nacimiento;
        private string Dirección_de_Residencia;
        private int Telefono_Contacto;
        private string Nivel_Escolaridad;
        private string EPS;
        private string Regimen;
        private string Correo_Electronico;
        private string Contacto_en_de_emergencia;

        SqlConnection conexion = new SqlConnection("server=PCSARITA\\SQLEXPRESS;integrated security = true; database=Trabajo_programación");

        public string PrimerNombre1 { get => PrimerNombre; set => PrimerNombre = value; }
        public string SegundoNombre1 { get => SegundoNombre; set => SegundoNombre = value; }
        public string PrimerApellido1 { get => PrimerApellido; set => PrimerApellido = value; }
        public string SegundoApellido1 { get => SegundoApellido; set => SegundoApellido = value; }
        public string Tipo_Identificacion1 { get => Tipo_Identificacion; set => Tipo_Identificacion = value; }
        public int Numero_de_Identificacion1 { get => Numero_de_Identificacion; set => Numero_de_Identificacion = value; }
        public string Genero1 { get => Genero; set => Genero = value; }
        public DateTime Fecha_de_Nacimiento1 { get => Fecha_de_Nacimiento; set => Fecha_de_Nacimiento = value; }
        public string Dirección_de_Residencia1 { get => Dirección_de_Residencia; set => Dirección_de_Residencia = value; }
        public int Telefono_Contacto1 { get => Telefono_Contacto; set => Telefono_Contacto = value; }
        public string Nivel_Escolaridad1 { get => Nivel_Escolaridad; set => Nivel_Escolaridad = value; }
        public string EPS1 { get => EPS; set => EPS = value; }
        public string Regimen1 { get => Regimen; set => Regimen = value; }
        public string Correo_Electronico1 { get => Correo_Electronico; set => Correo_Electronico = value; }
        public string Contacto_en_de_emergencia1 { get => Contacto_en_de_emergencia; set => Contacto_en_de_emergencia = value; }

        public string AgregarDatospersonales()
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("insert into Datospersonales values (@PrimerNombre, @SegundoNombre ,@ PrimerApellido, @SegundoApellido, @ Tipo_Identificacion, @Numero_de_Identificacion, @Genero, @Fecha_de_Nacimiento , @Dirección_de_Residencia, @Telefono_Contacto, @Nivel_Escolaridad, @EPS, @Regimen, @Correo_Electronico,@Contacto_en_de_emergencia)", conexion);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@PrimerNombre", PrimerNombre1);
            comando.Parameters.AddWithValue("@SegundoNombre", SegundoNombre1);
            comando.Parameters.AddWithValue("@PrimerApellido", PrimerApellido1);
            comando.Parameters.AddWithValue("@SegundoApellido", SegundoApellido1);
            comando.Parameters.AddWithValue("@Tipo_Identificacion", Tipo_Identificacion1);
            comando.Parameters.AddWithValue("@Numero_de_Identificacion", Numero_de_Identificacion1);
            comando.Parameters.AddWithValue("@Genero", Genero1);
            comando.Parameters.AddWithValue("@Fecha_de_Nacimiento", Fecha_de_Nacimiento1);
            comando.Parameters.AddWithValue("@Dirección_de_Residencia", Dirección_de_Residencia1);
            comando.Parameters.AddWithValue("@Telefono_Contacto", Telefono_Contacto1);
            comando.Parameters.AddWithValue("@Nivel_Escolaridad", Nivel_Escolaridad1);
            comando.Parameters.AddWithValue("@EPS", EPS1);
            comando.Parameters.AddWithValue("@Regimen", Regimen1);
            comando.Parameters.AddWithValue("@Correo_Electronico", Correo_Electronico1);
            comando.Parameters.AddWithValue("@Contacto_en_de_emergencia", Contacto_en_de_emergencia1);

            comando.ExecuteNonQuery();
            conexion.Close();
            return "Agregado con Exito";





        }

    }
}


