using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SC212549_Desafío1
{
    public partial class Form1 : Form
    {
        //Declaración del arreglo y sua dimensiones
        private string[,] asientosCine = new string [5,10];
        //Declaración de variable golbal
        private string opc;
        public Form1()
        {
            InitializeComponent();
            cmbFilaA.Select();
            btnReservar.Enabled = false;
            txtNombre.Enabled = false;
            //Asignacion de los valores a cada uno de los indices del arreglo bidimensional
            asientosCine[0, 0] = "A1";
            asientosCine[1, 0] = "B1";
            asientosCine[2, 0] = "C1";
            asientosCine[3, 0] = "D1";
            asientosCine[4, 0] = "E1";

            asientosCine[0, 1] = "A2";
            asientosCine[1, 1] = "B2";
            asientosCine[2, 1] = "C2";
            asientosCine[3, 1] = "D2";
            asientosCine[4, 1] = "E2";

            asientosCine[0, 2] = "A3";
            asientosCine[1, 2] = "B3";
            asientosCine[2, 2] = "C3";
            asientosCine[3, 2] = "D3";
            asientosCine[4, 2] = "E3";

            asientosCine[0, 3] = "A4";
            asientosCine[1, 3] = "B4";
            asientosCine[2, 3] = "C4";
            asientosCine[3, 3] = "D4";
            asientosCine[4, 3] = "E4";

            asientosCine[0, 4] = "A5";
            asientosCine[1, 4] = "B5";
            asientosCine[2, 4] = "C5";
            asientosCine[3, 4] = "D5";
            asientosCine[4, 4] = "E5";

            asientosCine[0, 5] = "A6";
            asientosCine[1, 5] = "B6";
            asientosCine[2, 5] = "C6";
            asientosCine[3, 5] = "D6";
            asientosCine[4, 5] = "E6";

            asientosCine[0, 6] = "A7";
            asientosCine[1, 6] = "B7";
            asientosCine[2, 6] = "C7";
            asientosCine[3, 6] = "D7";
            asientosCine[4, 6] = "E7";

            asientosCine[0, 7] = "A8";
            asientosCine[1, 7] = "B8";
            asientosCine[2, 7] = "C8";
            asientosCine[3, 7] = "D8";
            asientosCine[4, 7] = "E8";

            asientosCine[0, 8] = "A9";
            asientosCine[1, 8] = "B9";
            asientosCine[2, 8] = "C9";
            asientosCine[3, 8] = "D9";
            asientosCine[4, 8] = "E9";

            asientosCine[0, 9] = "A10";
            asientosCine[1, 9] = "B10";
            asientosCine[2, 9] = "C10";
            asientosCine[3, 9] = "D10";
            asientosCine[4, 9] = "E10";

            //Se inicalizan con los valores del array ya asignados para cada comoboBox
            for (int i = 0; i<10; i++)//Insertado de datos al ComboBox para la fila A
            {
                cmbFilaA.Items.Add(asientosCine[0, i]);
            }
            for(int i = 0; i < 10; i++)//Insertado de datos al ComboBox para la fila B
            {
                cmbFilaB.Items.Add(asientosCine[1, i]);
            }
            for (int i = 0; i < 10; i++)//Insertado de datos al ComboBox para la fila C
            {
                cmbFilaC.Items.Add(asientosCine[2, i]);
            }
            for(int i = 0; i < 10; i++)//Insertado de datos al ComboBox para la fila D
            {
                cmbFilaD.Items.Add(asientosCine[3, i]);
            }
            for(int i = 0; i < 10; i++)//Insertado de datos al ComboBox para la fila E
            {
                cmbFilaE.Items.Add(asientosCine[4, i]);
            }


        }

        private void CmbFilaA_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Al momnento de seleccionar el comboBox - Fila A se desabilitan las siguientes entredas:
            btnReservar.Enabled = true;
            txtNombre.Enabled = true;
            txtNombre.Focus();
            cmbFilaB.Enabled = false;
            cmbFilaC.Enabled = false;
            cmbFilaD.Enabled = false;
            cmbFilaE.Enabled = false;
            //La variable toma el dato de A que luego se ocuprara en un switch
            opc = "A";
        }

        private void CmbFilaB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Al momnento de seleccionar el comboBox - Fila B se desabilitan las siguientes entredas:
            btnReservar.Enabled = true;
            txtNombre.Enabled = true;
            txtNombre.Focus();
            cmbFilaA.Enabled = false;
            cmbFilaC.Enabled = false;
            cmbFilaD.Enabled = false;
            cmbFilaE.Enabled = false;
            //La variable toma el dato de B que luego se ocuprara en un switch
            opc = "B";
        }

        private void CmbFilaC_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Al momnento de seleccionar el comboBox - Fila C se desabilitan las siguientes entredas:
            btnReservar.Enabled = true;
            txtNombre.Enabled = true;
            txtNombre.Focus();
            cmbFilaA.Enabled = false;
            cmbFilaB.Enabled = false;
            cmbFilaD.Enabled = false;
            cmbFilaE.Enabled = false;
            //La variable toma el dato de C que luego se ocuprara en un switch
            opc = "C";
        }

        private void CmbFilaD_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Al momnento de seleccionar el comboBox - Fila D se desabilitan las siguientes entredas:
            btnReservar.Enabled = true;
            txtNombre.Enabled = true;
            txtNombre.Focus();
            cmbFilaA.Enabled = false;
            cmbFilaB.Enabled = false;
            cmbFilaC.Enabled = false;
            cmbFilaE.Enabled = false;
            //La variable toma el dato de D que luego se ocuprara en un switch
            opc = "D";
        }

        private void CmbFilaE_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Al momnento de seleccionar el comboBox - Fila E se desabilitan las siguientes entredas:
            btnReservar.Enabled = true;
            txtNombre.Enabled = true;
            txtNombre.Focus();
            cmbFilaA.Enabled = false;
            cmbFilaB.Enabled = false;
            cmbFilaC.Enabled = false;
            cmbFilaD.Enabled = false;
            //La variable toma el dato de E que luego se ocuprara en un switch
            opc = "E";
        }

        private void BtnReservar_Click(object sender, EventArgs e)
        {
            //Declaración de variables locales
            string nom, asieS;
            int fil, col;
            //Se captura el nombre de quien reserva
            nom = txtNombre.Text;
            //Se establecen los parametros para recorrer el array bidimensional
            fil = 5;
            col = 10;
            //Switch con del dato de la variable globlal: opc, que ha sido definido según el comoboBox seleccionado
            switch (opc)
            {
                case "A":
                    asieS = cmbFilaA.Text; //Se toma el dato del asiento seleccionado
                    for (int j = 0; j < fil; j++)//For para recorrer las filas
                    {
                        for (int k = 0; k < col; k++)//For para recorrer las columnas
                        {
                            if (asieS.Equals(asientosCine[j,k]))//If para comprobar que el asiento ingresado coincida con un valor del array
                            {
                                //Mensaje de confirmacion de reserva
                                MessageBox.Show("El asiento " + asientosCine[j, k] + " ha sido reservado", "¡Felicidades, " + nom + "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmbFilaA.Items.Remove(asieS);//Se elimina del comboBox el asiento seleccionado para ya no ser reservado por otra persona
                                lstAR.Items.Add(asientosCine[j, k] + ": " + nom);//Se lista el asiento con el nombre de quien lo reservo 
                            }
                        }
                    }
                    break;
                    //-------------EL MISMO PROCESO ES SEGUIDO EN LOS DEMÁS CASES--------------
                case "B":
                    asieS = cmbFilaB.Text;
                    for (int j = 0; j < fil; j++)
                    {
                        for (int k = 0; k < col; k++)
                        {
                            if (asieS.Equals(asientosCine[j, k]))
                            {
                                MessageBox.Show("El asiento " + asientosCine[j, k] + " ha sido reservado", "¡Felicidades, " + nom + "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmbFilaB.Items.Remove(asieS);
                                lstAR.Items.Add(asientosCine[j, k] + ": " + nom);
                            }
                        }
                    }
                    break;
                case "C":
                    asieS = cmbFilaC.Text;
                    for (int j = 0; j < fil; j++)
                    {
                        for (int k = 0; k < col; k++)
                        {
                            if (asieS.Equals(asientosCine[j, k]))
                            {
                                MessageBox.Show("El asiento " + asientosCine[j, k] + " ha sido reservado", "¡Felicidades, " + nom + "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmbFilaC.Items.Remove(asieS);
                                lstAR.Items.Add(asientosCine[j, k] + ": " + nom);
                            }
                        }
                    }
                    break;
                case "D":
                    asieS = cmbFilaD.Text;
                    for (int j = 0; j < fil; j++)
                    {
                        for (int k = 0; k < col; k++)
                        {
                            if (asieS.Equals(asientosCine[j, k]))
                            {
                                MessageBox.Show("El asiento " + asientosCine[j, k] + " ha sido reservado", "¡Felicidades, " + nom + "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmbFilaD.Items.Remove(asieS);
                                lstAR.Items.Add(asientosCine[j, k] + ": " + nom);
                            }
                        }
                    }
                    break;
                case "E":
                    asieS = cmbFilaE.Text;
                    for (int j = 0; j < fil; j++)
                    {
                        for (int k = 0; k < col; k++)
                        {
                            if (asieS.Equals(asientosCine[j, k]))
                            {
                                MessageBox.Show("El asiento " + asientosCine[j, k] + " ha sido reservado", "¡Felicidades, " + nom + "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cmbFilaE.Items.Remove(asieS);
                                lstAR.Items.Add(asientosCine[j, k] + ": " + nom);
                                
                            }
                        }
                    }
                    break;
            }
            //Se habilitan de nuevo las siguientes entradas para poder repetir el proceso
            cmbFilaA.Enabled = true;
            cmbFilaB.Enabled = true;
            cmbFilaC.Enabled = true;
            cmbFilaD.Enabled = true;
            cmbFilaE.Enabled = true;
            txtNombre.Clear();//Se limpia
            //Se deshabilita de nuevo lo siguiente:
            txtNombre.Enabled = false;
            btnReservar.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Cerrar Programa
            Close();
        }

    }
}
