using System;
using System.Drawing;
using System.Windows.Forms;

namespace JujutsuKaisen
{
    public partial class JujutsuKaisenForm : Form
    {
        #region Variables

        private float fontSize = 0f;
        private string fontFamily = JujutsuKaisenForm.DefaultFont.Name;
        private FontStyle fontStyle = FontStyle.Regular;

        #endregion

        #region Constrructeur et initialisation
        public JujutsuKaisenForm()
        {
            InitializeComponent();
        }
        private void JujutsuKaisenForm_Load(object sender, EventArgs e)
        {
            InitializeFontComboBox();

            quatorzeRadioButton.Checked = true;
            sukunaPictureBox.Location = new Point(-sukunaPictureBox.Width, this.ClientSize.Height - sukunaPictureBox.Height);
        }
        #endregion

        #region Initialiser les polices 
        private void InitializeFontComboBox()
        {
            foreach (FontFamily oFontFamilies in FontFamily.Families)
                fontComboBox.Items.Add(oFontFamilies.Name);

            fontComboBox.SelectedItem = this.Font.Name;
            fontComboBox.DropDownWidth = this.Width / 2;
        }
        #endregion

        #region Changement de la police
        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (fontComboBox.SelectedItem != null)
                {
                    fontFamily = fontComboBox.SelectedItem.ToString();
                    infoJujutsuKaisenLabel.Font = new Font(fontFamily, fontSize, fontStyle);
                }
            }
            catch
            {
                infoJujutsuKaisenLabel.Font = new Font(this.Font.FontFamily, this.Font.Size, this.Font.Style);
            }
        }
        #endregion

        #region Changement du style
        private void StyleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (boldCheckBox.Checked && italicCheckBox.Checked)
                    fontStyle = FontStyle.Bold | FontStyle.Italic;
                else if (boldCheckBox.Checked)
                    fontStyle = FontStyle.Bold;
                else if (italicCheckBox.Checked)
                    fontStyle = FontStyle.Italic;
                else
                    fontStyle = FontStyle.Regular;

                infoJujutsuKaisenLabel.Font = new Font(fontFamily, fontSize, fontStyle);
            }
            catch
            {
                infoJujutsuKaisenLabel.Font = new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Regular);
            }
        }
        #endregion

        #region Changement de la taille
        private void SizeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (huitRadioButton.Checked)
                fontSize = 8f;
            if (dixRadioButton.Checked)
                fontSize = 10f;
            if (douzeRadioButton.Checked)
                fontSize = 12f;
            if (quatorzeRadioButton.Checked)
                fontSize = 14f;

            infoJujutsuKaisenLabel.Font = new Font(fontFamily, fontSize, fontStyle);
        }
        #endregion

        #region Dessins
        private void dessinPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Dessin des lignes Methode 4
            Point pointOrigine = new Point(0, 0);
            for (int i = 0; i < dessinPictureBox.Width; i += 10)
                g.DrawLine(Pens.Violet, pointOrigine, new Point(i, dessinPictureBox.Height));

            // Dessiner le titre
            string title = "Jujutsu Kaisen";
            Font titleFont = new Font("Tahoma", 40);
            Point titlePosition = new Point(10, 10);
            g.DrawString(title, titleFont, Brushes.Crimson, titlePosition);

            // Dessiner l'image dans le coin supérieur droit
            int x = dessinPictureBox.Width - sukunaPictureBox.Width - 50; 
            int y = 10; 
            Rectangle destRect = new Rectangle(x, y, 145, 151);
            e.Graphics.DrawImage(sukunaPictureBox.Image, destRect);
        }
        #endregion

        #region Animation
        private void sukunaTimer_Tick(object sender, EventArgs e)
        {
            int positionx = sukunaPictureBox.Location.X + 2;

            if (positionx > this.ClientSize.Width)
                positionx = -sukunaPictureBox.Width;

            sukunaPictureBox.Location = new Point(positionx, sukunaPictureBox.Location.Y);
        }
        #endregion
    }

}
