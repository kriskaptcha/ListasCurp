using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ejercicio_1_parcial_2_tinoco
{
    public partial class Form1 : Form
    {
        public Nodo temporal;
        public static int numeronodos=0;

        public Form1()
        {
            InitializeComponent();
        }
        public   void agregarnodo (char dato) {
            Nodo primero = new Nodo(dato);
            primero.siguiente = temporal;
            temporal = primero;
            numeronodos++;
        }
        public void vaciarlista()
        {
            temporal = null;
            numeronodos = 0;
        }
       
        
            
        
        
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
            foreach (char _datos in txtcurp.Text)
            {
                agregarnodo(_datos);
                if(numeronodos == 1 && numeronodos <5)
                {
                    if (char.IsLetter(_datos))
                    {
                        lbevaluacion.Text = "valido";
                    }
                    else
                    {
                        lbevaluacion.Text = "error hay texto ingresa una letra";
                    }
                }

                if (numeronodos == 5 && numeronodos <11)
                {
                    if (char.IsNumber(_datos))
                    {
                        lbevaluacion.Text = "valido";
                    }
                    else
                    {
                        lbevaluacion.Text = "error hay texto ingresa un numero";

                    }
                }
                if (numeronodos ==11 && numeronodos < 17)
                {
                    if (char.IsLetter(_datos))
                    {
                        lbevaluacion.Text = "valido";
                    }
                    else
                    {
                        lbevaluacion.Text = "error hay texto ingresa una letra";
                    }
                }
                if (numeronodos == 17 && numeronodos < 19)
                {
                    if (char.IsNumber(_datos))
                    {
                        lbevaluacion.Text = "valido";
                    }
                    else
                    {
                        lbevaluacion.Text = "error hay texto ingresa un número";

                    }
                }
                
            }
            
            lbcurp.Text = numeronodos.ToString();
            vaciarlista();
            
        }
    }
}
