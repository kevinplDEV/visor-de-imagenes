using System;
using System.Windows.Forms;

namespace Visor_de_imagen
{
    public partial class Visordeimagenes : Form
    {
        public Visordeimagenes()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Cierra el formulario.
            this.Close();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            /* Muestra el cuadro de diálogo Abrir archivo. Si el usuario hace clic en Aceptar,
             * carga la imagen que eligió el usuario.*/
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Borra la imagen.
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            /*Muestra el cuadro de diálogo de color. Si el usuario hace clic en Aceptar,
             * cambie el fondo del control PictureBox al color que el usuario eligió*/
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*Si el usuario selecciona la casilla de verificación Estirar,
             * cambie la propiedad PictureBox sizeMode a "Estirar".
             * Si el usuario desactiva la casilla de verificación, cámbiela a "Normal".*/
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
