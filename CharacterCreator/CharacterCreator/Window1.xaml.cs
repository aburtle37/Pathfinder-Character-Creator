using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Drawing;
using Microsoft.Win32;

namespace CharacterCreator
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        int finalSTRMod = 0;
        int finalDEXMod = 0;
        int finalCONMod = 0;
        int finalINTMod = 0;
        int finalWISMod = 0;
        int finalCHAMod = 0;
        bool onChange = false;
        bool radioNecessary = false;

        public static int[] abilityScores;

        public Window1()
        {
            InitializeComponent();
            onChange = true;                                      //Keeps onChange events from firing when window is loaded

            label4.Content = MainWindow.charName;                 //This block fills character info with values from main window
            label5.Content = MainWindow.charGender;
            label6.Content = MainWindow.charAlignmentFull;
            label8.Content = MainWindow.charRace;
            label11.Content = MainWindow.charClass;
            label12.Content = MainWindow.charArchetype;
            label15.Content = MainWindow.charHeightFeet.ToString() + "' " + MainWindow.charHeightInches.ToString() + "''";
            label16.Content = MainWindow.charWeight.ToString() + " lbs.";
            label32.Content = MainWindow.charHealthPoints.ToString();
            label33.Content = MainWindow.charWealth.ToString();

            abilityScores = new int[20];                          //Values for stat calculation
            abilityScores[7] = -4;
            abilityScores[8] = -2;
            abilityScores[9] = -1;
            abilityScores[10] = 0;
            abilityScores[11] = 1;
            abilityScores[12] = 2;
            abilityScores[13] = 3;
            abilityScores[14] = 5;
            abilityScores[15] = 7;
            abilityScores[16] = 10;
            abilityScores[17] = 13;
            abilityScores[18] = 17;
            abilityScores[19] = 1000;           //Keeps players from being able to raise a stat above 18. Do not change, intentionally high

            if (MainWindow.charRace == "Human" || MainWindow.charRace == "Half-Elf" || MainWindow.charRace == "Half-Orc")       //Makes Stat Bonus selectable for human/human-hybrid classes
            {
                label18.Content = "Select";
                label35.Content = "+2 Bonus";
                radioNecessary = true;

                strRadio.Visibility = Visibility.Visible;
                dexRadio.Visibility = Visibility.Visible;
                conRadio.Visibility = Visibility.Visible;
                intRadio.Visibility = Visibility.Visible;
                wisRadio.Visibility = Visibility.Visible;
                chaRadio.Visibility = Visibility.Visible;

            }
            else                                                    //If race is not human or half human, this sets the labels displaying the proper racial modifiers
            {
                if (MainWindow.charSTR > 0)
                {
                    label38.Content = "+" + MainWindow.charSTR;
                }
                else
                {
                    label38.Content = MainWindow.charSTR;
                }

                if (MainWindow.charDEX > 0)
                {
                    label39.Content = "+" + MainWindow.charDEX;
                }
                else
                {
                    label39.Content = MainWindow.charDEX;
                }

                if (MainWindow.charCON > 0)
                {
                    label40.Content = "+" + MainWindow.charCON;
                }
                else
                {
                    label40.Content = MainWindow.charCON;
                }

                if (MainWindow.charINT > 0)
                {
                    label41.Content = "+" + MainWindow.charINT;
                }
                else
                {
                    label41.Content = MainWindow.charINT;
                }

                if (MainWindow.charWIS > 0)
                {
                    label42.Content = "+" + MainWindow.charWIS;
                }
                else
                {
                    label42.Content = MainWindow.charWIS;
                }

                if (MainWindow.charCHA > 0)
                {
                    label43.Content = "+" + MainWindow.charCHA;
                }
                else
                {
                    label43.Content = MainWindow.charCHA;
                }

            }


        }



        private void reset_Click(object sender, RoutedEventArgs e)              //Resets values and states to default
        {
            finalize.IsEnabled = false;
            export.IsEnabled = false;

            strUp.IsEnabled = true;
            strDown.IsEnabled = true;
            dexUp.IsEnabled = true;
            dexDown.IsEnabled = true;
            conUp.IsEnabled = true;
            conDown.IsEnabled = true;
            intUp.IsEnabled = true;
            intDown.IsEnabled = true;
            wisUp.IsEnabled = true;
            wisDown.IsEnabled = true;
            chaUp.IsEnabled = true;
            chaDown.IsEnabled = true;

            strRadio.IsEnabled = true;
            dexRadio.IsEnabled = true;
            conRadio.IsEnabled = true;
            intRadio.IsEnabled = true;
            wisRadio.IsEnabled = true;
            chaRadio.IsEnabled = true;

            strRadio.IsChecked = false;
            dexRadio.IsChecked = false;
            conRadio.IsChecked = false;
            intRadio.IsChecked = false;
            wisRadio.IsChecked = false;
            chaRadio.IsChecked = false;

            strStatBox.Text = "10";
            dexStatBox.Text = "10";
            conStatBox.Text = "10";
            intStatBox.Text = "10";
            wisStatBox.Text = "10";
            chaStatBox.Text = "10";

            textBox.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            setPoolValue();


        }

        private void finalize_Click(object sender, RoutedEventArgs e)           //Calculates final point values and disables all buttons except reset and export
        {
            
            textBox.Text = (Convert.ToInt32(strStatBox.Text) + MainWindow.charSTR + finalSTRMod).ToString();
            textBox1.Text = (Convert.ToInt32(dexStatBox.Text) + MainWindow.charDEX + finalDEXMod).ToString();
            textBox2.Text = (Convert.ToInt32(conStatBox.Text) + MainWindow.charCON + finalCONMod).ToString();
            textBox3.Text = (Convert.ToInt32(intStatBox.Text) + MainWindow.charINT + finalINTMod).ToString();
            textBox4.Text = (Convert.ToInt32(wisStatBox.Text) + MainWindow.charWIS + finalWISMod).ToString();
            textBox5.Text = (Convert.ToInt32(chaStatBox.Text) + MainWindow.charCHA + finalCHAMod).ToString();

            strUp.IsEnabled = false;
            strDown.IsEnabled = false;
            dexUp.IsEnabled = false;
            dexDown.IsEnabled = false;
            conUp.IsEnabled = false;
            conDown.IsEnabled = false;
            intUp.IsEnabled = false;
            intDown.IsEnabled = false;
            wisUp.IsEnabled = false;
            wisDown.IsEnabled = false;
            chaUp.IsEnabled = false;
            chaDown.IsEnabled = false;
            strRadio.IsEnabled = false;
            dexRadio.IsEnabled = false;
            conRadio.IsEnabled = false;
            intRadio.IsEnabled = false;
            wisRadio.IsEnabled = false;
            chaRadio.IsEnabled = false;

            export.IsEnabled = true;

            finalize.IsEnabled = false;
        }

        private void export_Click(object sender, RoutedEventArgs e)                    //Saves a copy of the character window as an image file (Jpeg, Bitmap, or gif)
        {

            int windowTop = (int)this.Top;
            int windowLeft = (int)this.Left;

            double sysScale = System.Windows.PresentationSource.FromVisual(this).CompositionTarget.TransformToDevice.M11;

            Bitmap bitmap = new Bitmap(Convert.ToInt32(502 * sysScale), Convert.ToInt32(480 * sysScale));
            Graphics charSheet = Graphics.FromImage(bitmap as System.Drawing.Image);
            charSheet.CopyFromScreen(Convert.ToInt32((windowLeft + 10) * sysScale), Convert.ToInt32((windowTop + 50) * sysScale), 0, 0, bitmap.Size);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        bitmap.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        bitmap.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        bitmap.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }
                fs.Close();
            }
        }
        

        private void strUp_Click(object sender, RoutedEventArgs e)                      //Up and Down Click functions on arrow buttons for selecting stat values
        {
            int strVal = Convert.ToInt32(strStatBox.Text);
            strVal++;
            strStatBox.Text = strVal.ToString();

            setPoolValue();

        }

        private void strDown_Click(object sender, RoutedEventArgs e)
        {
            int strVal = Convert.ToInt32(strStatBox.Text);
            strVal--;
            strStatBox.Text = strVal.ToString();

            setPoolValue();

        }

        private void dexUp_Click(object sender, RoutedEventArgs e)
        {
            int dexVal = Convert.ToInt32(dexStatBox.Text);
            dexVal++;
            dexStatBox.Text = dexVal.ToString();

            setPoolValue();

        }

        private void dexDown_Click(object sender, RoutedEventArgs e)
        {
            int dexVal = Convert.ToInt32(dexStatBox.Text);
            dexVal--;
            dexStatBox.Text = dexVal.ToString();

            setPoolValue();

        }

        private void conUp_Click(object sender, RoutedEventArgs e)
        {
            int conVal = Convert.ToInt32(conStatBox.Text);
            conVal++;
            conStatBox.Text = conVal.ToString();

            setPoolValue();

        }

        private void conDown_Click(object sender, RoutedEventArgs e)
        {
            int conVal = Convert.ToInt32(conStatBox.Text);
            conVal--;
            conStatBox.Text = conVal.ToString();

            setPoolValue();

        }

        private void intUp_Click(object sender, RoutedEventArgs e)
        {
            int intVal = Convert.ToInt32(intStatBox.Text);
            intVal++;
            intStatBox.Text = intVal.ToString();

            setPoolValue();

        }

        private void intDown_Click(object sender, RoutedEventArgs e)
        {
            int intVal = Convert.ToInt32(intStatBox.Text);
            intVal--;
            intStatBox.Text = intVal.ToString();

            setPoolValue();

        }

        private void wisUp_Click(object sender, RoutedEventArgs e)
        {
            int wisVal = Convert.ToInt32(wisStatBox.Text);
            wisVal++;
            wisStatBox.Text = wisVal.ToString();

            setPoolValue();

        }

        private void wisDown_Click(object sender, RoutedEventArgs e)
        {
            int wisVal = Convert.ToInt32(wisStatBox.Text);
            wisVal--;
            wisStatBox.Text = wisVal.ToString();

            setPoolValue();

        }

        private void chaUp_Click(object sender, RoutedEventArgs e)
        {
            int chaVal = Convert.ToInt32(chaStatBox.Text);
            chaVal++;
            chaStatBox.Text = chaVal.ToString();

            setPoolValue();

        }

        private void chaDown_Click(object sender, RoutedEventArgs e)
        {
            int chaVal = Convert.ToInt32(chaStatBox.Text);
            chaVal--;
            chaStatBox.Text = chaVal.ToString();

            setPoolValue();

        }








        private void strStatBox_TextChanged(object sender, TextChangedEventArgs e)              //StatBox_TextChanged for disabling arrow buttons when score too high or low
        {
            if (strStatBox.Text == "7")
            {
                strDown.IsEnabled = false;
            }
            else
            {
                strDown.IsEnabled = true;
            }

            if (strStatBox.Text == "18")
            {
                strUp.IsEnabled = false;
            }
            else
            {
                strUp.IsEnabled = true;
            }
        }

        private void dexStatBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (dexStatBox.Text == "7")
            {
                dexDown.IsEnabled = false;
            }
            else
            {
                dexDown.IsEnabled = true;
            }

            if (dexStatBox.Text == "18")
            {
                dexUp.IsEnabled = false;
            }
            else
            {
                dexUp.IsEnabled = true;
            }
        }

        private void conStatBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (conStatBox.Text == "7")
            {
                conDown.IsEnabled = false;
            }
            else
            {
                conDown.IsEnabled = true;
            }

            if (conStatBox.Text == "18")
            {
                conUp.IsEnabled = false;
            }
            else
            {
                conUp.IsEnabled = true;
            }
        }

        private void intStatBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (intStatBox.Text == "7")
            {
                intDown.IsEnabled = false;
            }
            else
            {
                intDown.IsEnabled = true;
            }

            if (intStatBox.Text == "18")
            {
                intUp.IsEnabled = false;
            }
            else
            {
                intUp.IsEnabled = true;
            }
        }

        private void wisStatBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (wisStatBox.Text == "7")
            {
                wisDown.IsEnabled = false;
            }
            else
            {
                wisDown.IsEnabled = true;
            }

            if (wisStatBox.Text == "18")
            {
                wisUp.IsEnabled = false;
            }
            else
            {
                wisUp.IsEnabled = true;
            }
        }

        private void chaStatBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (chaStatBox.Text == "7")
            {
                chaDown.IsEnabled = false;
            }
            else
            {
                chaDown.IsEnabled = true;
            }

            if (chaStatBox.Text == "18")
            {
                chaUp.IsEnabled = false;
            }
            else
            {
                chaUp.IsEnabled = true;
            }
        }

        private void pointPool_TextChanged(object sender, TextChangedEventArgs e)
        {
            int strValue = Convert.ToInt32(strStatBox.Text);                                //Used for calcualtion of Point Pool
            int dexValue = Convert.ToInt32(dexStatBox.Text);
            int conValue = Convert.ToInt32(conStatBox.Text);
            int intValue = Convert.ToInt32(intStatBox.Text);
            int wisValue = Convert.ToInt32(wisStatBox.Text);
            int chaValue = Convert.ToInt32(chaStatBox.Text);
            if (onChange == true)                                                                                  //This block will not fire when window is loaded
            {
                if (abilityScores[strValue + 1] - abilityScores[strValue] > Convert.ToInt32(pointPool.Text))      //Enables and disables stat up buttons
                {
                    strUp.IsEnabled = false;
                }
                else
                {
                    strUp.IsEnabled = true;
                }

                if (abilityScores[dexValue + 1] - abilityScores[dexValue] > Convert.ToInt32(pointPool.Text))
                {
                    dexUp.IsEnabled = false;
                }
                else
                {
                    dexUp.IsEnabled = true;
                }

                if (abilityScores[conValue + 1] - abilityScores[conValue] > Convert.ToInt32(pointPool.Text))
                {
                    conUp.IsEnabled = false;
                }
                else
                {
                    conUp.IsEnabled = true;
                }

                if (abilityScores[intValue + 1] - abilityScores[intValue] > Convert.ToInt32(pointPool.Text))
                {
                    intUp.IsEnabled = false;
                }
                else
                {
                    intUp.IsEnabled = true;
                }

                if (abilityScores[wisValue + 1] - abilityScores[wisValue] > Convert.ToInt32(pointPool.Text))
                {
                    wisUp.IsEnabled = false;
                }
                else
                {
                    wisUp.IsEnabled = true;
                }

                if (abilityScores[chaValue + 1] - abilityScores[chaValue] > Convert.ToInt32(pointPool.Text))
                {
                    chaUp.IsEnabled = false;
                }
                else
                {
                    chaUp.IsEnabled = true;
                }

                if (pointPool.Text == "0")                                                                   //Rules for enabling finalize button
                {
                    if (radioNecessary == true)
                    {
                        if (strRadio.IsChecked == true || dexRadio.IsChecked == true || conRadio.IsChecked == true || intRadio.IsChecked == true || wisRadio.IsChecked == true || chaRadio.IsChecked == true)
                        {
                            finalize.IsEnabled = true;
                        }
                    }
                    else
                    {
                        finalize.IsEnabled = true;
                    }
                }
                else
                {
                    finalize.IsEnabled = false;
                }

            }


        }



        private void setPoolValue()         //Sets value of Point pool based on selected ability scores
        {
            pointPool.Text = (20 - (abilityScores[Convert.ToInt32(strStatBox.Text)] + abilityScores[Convert.ToInt32(dexStatBox.Text)] + abilityScores[Convert.ToInt32(conStatBox.Text)] + abilityScores[Convert.ToInt32(intStatBox.Text)] + abilityScores[Convert.ToInt32(wisStatBox.Text)] + abilityScores[Convert.ToInt32(chaStatBox.Text)])).ToString();
        }

        private void strRadio_Checked(object sender, RoutedEventArgs e)         //Radio checked functions for enabling finalize button and final stat value calculations
        {
            if (pointPool.Text == "0")
            {
                finalize.IsEnabled = true;
            }

            finalSTRMod = 2;
            finalDEXMod = 0;
            finalCONMod = 0;
            finalINTMod = 0;
            finalWISMod = 0;
            finalCHAMod = 0;
        }

        private void dexRadio_Checked(object sender, RoutedEventArgs e)
        {
            if (pointPool.Text == "0")
            {
                finalize.IsEnabled = true;
            }

            finalSTRMod = 0;
            finalDEXMod = 2;
            finalCONMod = 0;
            finalINTMod = 0;
            finalWISMod = 0;
            finalCHAMod = 0;
        }

        private void conRadio_Checked(object sender, RoutedEventArgs e)
        {
            if (pointPool.Text == "0")
            {
                finalize.IsEnabled = true;
            }

            finalSTRMod = 0;
            finalDEXMod = 0;
            finalCONMod = 2;
            finalINTMod = 0;
            finalWISMod = 0;
            finalCHAMod = 0;
        }

        private void intRadio_Checked(object sender, RoutedEventArgs e)
        {
            if (pointPool.Text == "0")
            {
                finalize.IsEnabled = true;
            }

            finalSTRMod = 0;
            finalDEXMod = 0;
            finalCONMod = 0;
            finalINTMod = 2;
            finalWISMod = 0;
            finalCHAMod = 0;
        }

        private void wisRadio_Checked(object sender, RoutedEventArgs e)
        {
            if (pointPool.Text == "0")
            {
                finalize.IsEnabled = true;
            }

            finalSTRMod = 0;
            finalDEXMod = 0;
            finalCONMod = 0;
            finalINTMod = 0;
            finalWISMod = 2;
            finalCHAMod = 0;
        }

        private void chaRadio_Checked(object sender, RoutedEventArgs e)
        {
            if (pointPool.Text == "0")
            {
                finalize.IsEnabled = true;
            }

            finalSTRMod = 0;
            finalDEXMod = 0;
            finalCONMod = 0;
            finalINTMod = 0;
            finalWISMod = 0;
            finalCHAMod = 2;
        }
    }
}
