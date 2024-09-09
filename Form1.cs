namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //Mostra a caixa de di�logo Abrir arquivo. Se o usu�rio clicar em OK, carregue o
            //imagem que o usu�rio escolheu.
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the picture.
           
            pictureBox1.Image = null;
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Mostre a caixa de di�logo de cores. Se o usu�rio clicar em OK, altere o
            // Fundo do controle PictureBox na cor escolhida pelo usu�rio.
            
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Se o usu�rio marcar a caixa de sele��o Stretch, 
            // altera o PictureBox
            // Propriedade SizeMode para "Stretch". Se o usu�rio limpar 
            // a caixa de sele��o, altere-a para "Normal".
            
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
