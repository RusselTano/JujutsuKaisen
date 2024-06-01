using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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
                this.Font = new Font(this.Font.FontFamily, this.Font.Size, this.Font.Style);
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

                infoJujutsuKaisenLabel.Font = new Font(fontFamily, fontSize, fontStyle);
            }
            catch
            {
                this.Font = new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Regular);
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
    }
}
