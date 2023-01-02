using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MomHudCustomizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fontComboBox.SelectedItem = null;
            colorComboBox.SelectedItem = null;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            string textFile = AppDomain.CurrentDomain.BaseDirectory + @"resources\config.scss";

            if (File.Exists(textFile))
            {
                // Read entire text file content in one string    
                string[] baseCSS = File.ReadAllLines(textFile);

                parseFile(baseCSS);
            }
        }
        
        private void parseFile(string[] baseCSS)
        {
            #region CSS FONT

            if (fontComboBox.SelectedItem != null)
            {
                string chosenFont = "error ):";
                string fontFile = "handelgothic.ttf";

                switch (fontComboBox.SelectedItem.ToString())
                {
                    case "avenir": // AVENIR
                        chosenFont = "Avenir";
                        fontFile = "avenir.ttf";
                        break;
                    case "handel gothic": // HANDEL GOTHIC BT
                        chosenFont = "HandelGothic BT";
                        fontFile = "handelgothic.ttf";
                        break;
                    case "surface": // SURFACE
                        chosenFont = "todo"; // TODO: WORKING SURFACE FONT NAME
                        fontFile = "handelgothic.ttf";
                        break;
                    default:
                        chosenFont = "FIXME, UNSELECTED FONT???";
                        fontFile = "handelgothic.ttf";
                        break;
                }

                baseCSS[Array.IndexOf(baseCSS, "$font-primary: Roboto, sans-serif !default;")] = "$font-primary: \'" + chosenFont + "\' !default;";
                baseCSS[Array.IndexOf(baseCSS, "$font-secondary: Bebas Neue, Arial, sans-serif !default;")] = "$font-secondary: \'" + chosenFont + "\' !default;";
                baseCSS[Array.IndexOf(baseCSS, "$font-secondary-light: Bebas Neue Light, Bebas Neue, Arial, sans-serif !default; // Only required for Bebas, for other fonts just use same value as regular")] = "$font-secondary-light: \'" + chosenFont + "\' !default;";
                baseCSS[Array.IndexOf(baseCSS, "$font-monospace: \'Roboto Mono\' !default;")] = "$font-monospace: \'" + chosenFont + "\' !default;";

                // COPY OVER FONT FILE

                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\customhud\panorama\fonts\");

                string sourceFile = AppDomain.CurrentDomain.BaseDirectory + @"resources\" + fontFile;
                string destinationFile = AppDomain.CurrentDomain.BaseDirectory + @"\customhud\panorama\fonts\" + fontFile;

                try
                {
                    File.Copy(sourceFile, destinationFile, true);
                }
                catch
                {
                    statusText.Text = "error copying over files ):";
                    return;
                }

                // we have now replaced all da fonts :D
            }
            else
            {
                // :D
            }

            #endregion

            #region CSS COLORS

            if (colorComboBox.SelectedItem != null)
            {
                string primaryColor = "";
                string secondaryColor = "";
                string tertiaryColor = "";

                string gradientPrimaryColor = "";
                string gradientSecondaryColor = "";

                switch (colorComboBox.SelectedItem.ToString())
                {
                    case "green": // AVENIR
                        primaryColor = "#7aee7a";
                        secondaryColor = "#7aee7a";
                        tertiaryColor = "#159856";

                        gradientPrimaryColor = "#7aee7a";
                        gradientSecondaryColor = "#159856";
                        break;
                    case "pink": // HANDEL GOTHIC BT
                        primaryColor = "#ffb6dc";
                        secondaryColor = "#fa7ca2";
                        tertiaryColor = "#ab4657";

                        gradientPrimaryColor = "#fa7ca2";
                        gradientSecondaryColor = "#ab4657";
                        break;
                    default:
                        break;
                }

                // $blue
                baseCSS[8] = "$blue: " + primaryColor + " !default;";

                // $mid-blue
                baseCSS[9] = "$mid-blue: " + secondaryColor + " !default;";

                // $light-blue
                baseCSS[10] = "$light-blue: " + tertiaryColor + " !default;";


                // 'blue': (
                baseCSS[147] = "		" + gradientPrimaryColor + ",";
                baseCSS[148] = "		" + gradientSecondaryColor;

                // 'light-blue': (
                baseCSS[151] = "		" + gradientPrimaryColor + ",";
                baseCSS[152] = "		" + gradientSecondaryColor;

                // we have now replaced all da colors
            }
            else
            {
                // :D
            }

            #endregion

            #region CSS FINALE

            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\customhud\panorama\styles\");

            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + @"\customhud\panorama\styles\config.scss", baseCSS);

            #endregion

            #region AUTOEXEC

            Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"\customhud\cfg\");

            StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"\customhud\cfg\autoexec.cfg");

            if (momVersionCheckBox.Checked)
            {
                writer.WriteLine("mom_hud_versioninfo_enable 1;");
            }
            else
            {
                writer.WriteLine("mom_hud_versioninfo_enable 0;");
            }

            if (arrowsCrossCheckBox.Checked)
            {
                writer.WriteLine("cl_crosshair_style 1");
            }
            else
            {
                writer.WriteLine("cl_crosshair_style 0");
            }

            if (tCrosshairStyleCheckBox.Checked)
            {
                writer.WriteLine("cl_crosshair_t 1;");
            }
            else
            {
                writer.WriteLine("cl_crosshair_t 0;");
            }

            writer.Close();

            #endregion

            statusText.Text = "copy the \"customhud\" folder to your custom folder (:";
            return;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
