using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Onetour2
{
    class Validacion
    {
        string cadena;

        public void ValidatTextbox_1(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        public void ValidatNombreUsuario(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            
            
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        public void ValidatTextbox_2(KeyPressEventArgs e)
        {
           
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
           
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        public void ValidatTextbox_3(KeyPressEventArgs e)
        {

            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
                e.Handled = true;
        }

        //Validacion ingreso de datos

        public void ValidatTextbox(KeyPressEventArgs e)
        {

            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else
                e.Handled = true;

            
        }

        public void Valida(TextBox e)
        {
            if (e.TextLength == 3)
            {
                e.Text.Insert(2,".");
            }
           


        }

        public void SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }



        }

        public void SoloLetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }

            else { e.Handled = true; }



        }

        public void SoloLetrasNombre(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }



        }

        public void ValidarDVRut(KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "k" || e.KeyChar.ToString() == "K")
            {
                e.Handled = false;
            }
            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }



        }

        public int Validar_email(TextBox f)
        {
            int contador = 0;

            if (f.Text.Contains("@"))
            {
                contador = 1;

            }

           

            else {

                contador = 0;
                
            }

            return contador;
        }





    }
}
