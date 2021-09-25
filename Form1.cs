using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unique_Converter
{
    public partial class UniqueConverter : Form
    {
        public UniqueConverter()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
            LengthResultTextBox.BackColor = Color.White;
            LengthResultTextBox.ForeColor = Color.Black;

            LengthPanel.Visible = true;
            TemperaturePanel.Visible = false;
            AreaPanel.Visible = false;
            TimePanel.Visible = false;
            PlaneAnglePanel.Visible = false;
        }

        // Close Application Button Function
        private void AppCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Tool Strip Menu Color
        private class MyRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                if (!e.Item.Selected) base.OnRenderMenuItemBackground(e);
                else
                {
                    Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                    e.Graphics.FillRectangle(Brushes.LightGray, rc);
                    e.Graphics.DrawRectangle(Pens.Black, 1, 0, rc.Width - 2, rc.Height - 1);
                }
            }
        }
        
        // Tool Strip Menu Click Handling
        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LengthPanel.Visible = false;
            TemperaturePanel.Visible = true;
            AreaPanel.Visible = false;
            TimePanel.Visible = false;
            PlaneAnglePanel.Visible = false;
        }
        private void lengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LengthPanel.Visible = true;
            TemperaturePanel.Visible = false;
            AreaPanel.Visible = false;
            TimePanel.Visible = false;
            PlaneAnglePanel.Visible = false;
        }

        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LengthPanel.Visible = false;
            TemperaturePanel.Visible = false;
            AreaPanel.Visible = true;
            TimePanel.Visible = false;
            PlaneAnglePanel.Visible = false;
        }
        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LengthPanel.Visible = false;
            TemperaturePanel.Visible = false;
            AreaPanel.Visible = false;
            TimePanel.Visible = true;
            PlaneAnglePanel.Visible = false;
        }
        private void planeAngleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LengthPanel.Visible = false;
            TemperaturePanel.Visible = false;
            AreaPanel.Visible = false;
            TimePanel.Visible = false;
            PlaneAnglePanel.Visible = true;
        }

        // Convert Function
        private void LengthConvertBtn_Click(object sender, EventArgs e)
        {
            double length = 0.0;

            if(FromLengthComboBox.SelectedItem == null || ToLengthComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select The Units To Convert....");
            }
            else if(LengthTextBox.TextLength == 0)
            {
                MessageBox.Show("Please Enter The Length....");
            }
            else if (!double.TryParse(LengthTextBox.Text, out length))
            {
                MessageBox.Show("This is a number only field");
                return;
            }

            // Same Units

            else if (Convert.ToString(FromLengthComboBox.SelectedItem) == "Kilometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromLengthComboBox.SelectedItem) == "Meter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Meter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromLengthComboBox.SelectedItem) == "Centimeter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Centimeter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromLengthComboBox.SelectedItem) == "Millimetre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Millimetre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromLengthComboBox.SelectedItem) == "Micrometres" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Micrometres")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromLengthComboBox.SelectedItem) == "Nanometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nanometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromLengthComboBox.SelectedItem) == "Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromLengthComboBox.SelectedItem) == "Yard" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Yard")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromLengthComboBox.SelectedItem) == "Foot" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Foot")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromLengthComboBox.SelectedItem) == "Inch" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Inch")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 2.54E-5) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromLengthComboBox.SelectedItem) == "Nautical Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nautical Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1.852) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }

            // Kilometer

            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Kilometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Meter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Kilometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Centimeter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 100000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Kilometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Millimetre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1000000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Kilometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Micrometres")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 10E+8) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Kilometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nanometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 10E+11) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Kilometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 0.621371) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Kilometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Yard")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1093.613298) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Kilometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Foot")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 3280.839895) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Kilometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Inch")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 3970.07874) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Kilometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nautical Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 1.852) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }

            // Meter
            
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Meter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 1000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Meter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Centimeter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 100) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Meter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Millimetre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Meter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Micrometres")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1000000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Meter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nanometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 10E+8) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Meter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 0.000621371) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Meter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Yard")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1.093613) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Meter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Foot")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 3.28084) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Meter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Inch")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 39.370079) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Meter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nautical Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 1852) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }

            // Centimeter
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Centimeter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Meter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 100) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Centimeter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 10E+4) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Centimeter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Millimetre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 10) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Centimeter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Micrometres")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 10000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Centimeter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nanometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 10E+6) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Centimeter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 6.2137E-6) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Centimeter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Yard")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 0.010936) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Centimeter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Foot")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 0.032808) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Centimeter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Inch")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 2.54) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Centimeter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nautical Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 185200) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }

            // Millimetre

            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Millimetre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 10E+5) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Millimetre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Meter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Millimetre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Centimeter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 10) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Millimetre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Micrometres")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Millimetre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nanometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 10E+5) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Millimetre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 1609344) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Millimetre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Yard")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 0.001094) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Millimetre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Foot")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 0.003281) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Millimetre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Inch")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 2.54) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Millimetre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nautical Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 1852000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            
            // Micrometres

            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Micrometres" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 10E+8) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Micrometres" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Meter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 10E+5) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Micrometres" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Centimeter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 10000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Micrometres" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Millimetre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 1000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Micrometres" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nanometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Micrometres" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 1609344000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Micrometres" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Yard")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 914400) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Micrometres" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Foot")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 304800) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Micrometres" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Inch")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 25400) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Micrometres" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nautical Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 1852000000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            
            // Nanometre

            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nanometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 10E+11) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nanometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Meter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 10E+8) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nanometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Centimeter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 10E+6) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nanometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Micrometres")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 1000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nanometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Millimetre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 10E+5) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nanometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 1609344000000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nanometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Yard")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 914400000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nanometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Foot")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 304800000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nanometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Inch")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 25400000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nanometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nautical Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 1852000000000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }

            // Mile

            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1.609344) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Meter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1609.344) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Centimeter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 160934.4) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Micrometres")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1609344000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Millimetre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1609344) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nanometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 1609344000000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Yard")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1760) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Foot")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 5280) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Inch")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 63360) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nautical Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 1.15078) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            
            // Yard

            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Yard" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 0.000914) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Yard" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Meter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 0.9144) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Yard" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Centimeter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 91.44) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Yard" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Micrometres")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 914400) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Yard" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Millimetre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 914.4) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Yard" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nanometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 914400000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Yard" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 1760) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Yard" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Foot")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 3) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Yard" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Inch")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 36) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Yard" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nautical Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 2025.37183) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            
            // Foot

            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Foot" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 0.000305) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Foot" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Meter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 0.3048) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Foot" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Centimeter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 30.48) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Foot" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Micrometres")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 304800) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Foot" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Millimetre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 304.8) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Foot" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nanometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 304800000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Foot" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Yard")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 3) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Foot" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 5280) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Foot" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Inch")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 12) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Foot" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nautical Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 6076.11549) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            
            // Inch
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Inch" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 2.54E-5) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Inch" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Meter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 0.0254) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Inch" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Centimeter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 2.54) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Inch" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Micrometres")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 25400) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Inch" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Millimetre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 25.4) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Inch" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nanometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 25400000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Inch" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Yard")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 36) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Inch" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 63360) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Inch" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Foot")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 12) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Inch" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nautical Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length / 72913.3858) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            
            // Nautical Miles

            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nautical Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1.852) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nautical Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Meter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1852) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nautical Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Centimeter")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 185200) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nautical Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Micrometres")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1852000000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nautical Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Millimetre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1852000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nautical Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Nanometre")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1852000000000) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nautical Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Yard")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 2025.37183) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nautical Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Mile")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 1.15078) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nautical Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Foot")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 6076.11549) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nautical Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Inch")
            {
                LengthResultTextBox.Text = Convert.ToString(length) + "  " + Convert.ToString(FromLengthComboBox.SelectedItem) + "  =  " + Convert.ToString(length * 72913.3858) + "  " + Convert.ToString(ToLengthComboBox.SelectedItem);
            }
        }
        private void TemperatureConvertBtn_Click(object sender, EventArgs e)
        {
            double temperature = 0.0;

            if (FromTemperatureComboBox.SelectedItem == null || ToTemperatureComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select The Units To Convert....");
            }
            else if (TemperatureTextBox.TextLength == 0)
            {
                MessageBox.Show("Please Enter The Temperature....");
            }
            else if (!double.TryParse(TemperatureTextBox.Text, out temperature))
            {
                MessageBox.Show("This is a number only field");
                return;
            }

            // Same Unit

            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Celsius" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Celsius")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString(temperature) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Kelvin" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Kelvin")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString(temperature) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Fahrenheit" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Fahrenheit")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString(temperature) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Rankine" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Rankine")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString(temperature) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Reaumur" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Reaumur")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString(temperature) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }


            // Celsius

            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Celsius" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Kelvin")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString(temperature + 273.15) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Celsius" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Fahrenheit")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString((temperature * 9 / 5) + 32) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Celsius" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Rankine")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString((temperature + 273.15) * 9 / 5) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Celsius" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Reaumur")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString(temperature * 0.8) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            
            // Kelvin

            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Kelvin" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Celsius")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString(temperature - 273.15) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Kelvin" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Fahrenheit")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString((temperature - 273.15) * 9 / 5 + 32) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Kelvin" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Rankine")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString(temperature * 9 / 5) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Kelvin" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Reaumur")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString((temperature - 273.15) * 0.8) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            
            // Fahrenheit

            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Fahrenheit" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Celsius")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString((temperature - 32) * 5 / 9) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Fahrenheit" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Kelvin")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString((temperature - 32) * 5 / 9 + 273.15) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Fahrenheit" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Rankine")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString(temperature + 459.67) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Fahrenheit" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Reaumur")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString((temperature - 32) * 0.44444) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            
            // Rankine

            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Rankine" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Celsius")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString((temperature - 491.67) * 5 / 9) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Rankine" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Kelvin")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString(temperature * 5 / 9) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Rankine" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Fahrenheit")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString(temperature - 459.67) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Rankine" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Reaumur")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString((temperature - 491.67) * 0.44444) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }

            // Reaumur

            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Reaumur" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Celsius")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString(temperature / 0.8) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Reaumur" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Kelvin")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString((temperature / 0.8) + 273.15) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Reaumur" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Fahrenheit")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString((temperature * 2.25) + 32) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTemperatureComboBox.SelectedItem) == "Reaumur" && Convert.ToString(ToTemperatureComboBox.SelectedItem) == "Rankine")
            {
                TemperatureResultTextBox.Text = Convert.ToString(temperature) + "  " + Convert.ToString(FromTemperatureComboBox.SelectedItem) + "  =  " + Convert.ToString((temperature * 2.25) + 491.67) + "  " + Convert.ToString(ToTemperatureComboBox.SelectedItem);
            }
        }
        private void AreaConvertBtn_Click(object sender, EventArgs e)
        {
            double area = 0.0;

            if (FromAreaComboBox.SelectedItem == null || ToAreaComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select The Units To Convert....");
            }
            else if (AreaTextBox.TextLength == 0)
            {
                MessageBox.Show("Please Enter The Area....");
            }
            else if (!double.TryParse(AreaTextBox.Text, out area))
            {
                MessageBox.Show("This is a number only field");
                return;
            }

            // Same Unit

            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Kilometer" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Kilometer")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 1E+6) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Meter" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Meter")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 1E+6) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Mile" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Mile")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 1E+6) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Yard" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Yard")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 1E+6) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Foot" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Foot")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 1E+6) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Inch" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Inch")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 1E+6) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Hectare" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Hectare")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 1E+6) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Acre" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Acre")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 1E+6) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }

            // Square Kilometer

            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Kilometer" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Meter")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 1E+6) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Kilometer" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Mile")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 0.386102) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Kilometer" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Yard")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 1195990.046301) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Kilometer" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Foot")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 10763910.41671) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Kilometer" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Inch")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 1550003100.0062) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Kilometer" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Hectare")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 100) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Kilometer" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Acre")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 247.105381) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            
            // Square Meter
            
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Meter" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Kilometer")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area / 1E+6) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Meter" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Mile")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 3.861E-7) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Meter" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Yard")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 1.19599) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Meter" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Foot")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 10.76391) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Meter" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Inch")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 1550.0031) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Meter" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Hectare")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area / 10000) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Meter" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Acre")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 0.000247) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }

            // Square Mile
            
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Mile" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Kilometer")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 2.589988) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Mile" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Meter")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 2589988.11) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Mile" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Yard")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 3097599.999598) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Mile" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Foot")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 27878399.996383) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Mile" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Inch")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 4014489599.4792) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Mile" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Hectare")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 258.998811) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Mile" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Acre")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 640) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            
            // Square Yard
            
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Yard" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Kilometer")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 8.3613E-7) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Yard" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Meter")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 0.836127) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Yard" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Mile")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 3.2283E-7) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Yard" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Foot")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 9) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Yard" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Inch")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 1296) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Yard" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Hectare")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 8.3613E-5) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Yard" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Acre")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area / 4840) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }

            // Square Foot
            
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Foot" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Kilometer")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 9.2903E-8) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Foot" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Meter")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 0.092903) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Foot" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Mile")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 3.587E-8) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Foot" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Yard")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area / 9) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Foot" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Inch")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 144) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Foot" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Hectare")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 9.2903E-6) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Foot" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Acre")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area / 43560) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }


            // Square Inch
            
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Inch" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Kilometer")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 6.4516E-10) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Inch" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Meter")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 0.000645) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Inch" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Mile")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 2.491E-10) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Inch" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Yard")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area / 1296) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Inch" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Foot")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area / 144) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Inch" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Hectare")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 6.4516E-8) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Square Inch" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Acre")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area / 6272640) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }

            // Hectare
            
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Hectare" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Kilometer")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area / 100) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Hectare" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Meter")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 10000) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Hectare" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Mile")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 0.003861) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Hectare" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Yard")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 11959.900463) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Hectare" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Foot")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 107639.104167) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Hectare" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Inch")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 15500031.000062) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Hectare" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Acre")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 2.471054) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }

            // Acre
            
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Acre" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Kilometer")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 0.004047) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Acre" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Meter")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 4046.856422) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Acre" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Mile")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area / 640) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Acre" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Yard")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 4840) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Acre" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Foot")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 43560) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Acre" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Square Inch")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 6272640) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromAreaComboBox.SelectedItem) == "Acre" && Convert.ToString(ToAreaComboBox.SelectedItem) == "Hectare")
            {
                AreaResultTextBox.Text = Convert.ToString(area) + "  " + Convert.ToString(FromAreaComboBox.SelectedItem) + "  =  " + Convert.ToString(area * 0.404686) + "  " + Convert.ToString(ToAreaComboBox.SelectedItem);
            }
        }
        private void TimeConvertBtn_Click(object sender, EventArgs e)
        {
            double time = 0.0;

            if (FromTimeComboBox.SelectedItem == null || ToTimeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select The Units To Convert....");
            }
            else if (TimeTextBox.TextLength == 0)
            {
                MessageBox.Show("Please Enter The Time....");
            }
            else if (!double.TryParse(TimeTextBox.Text, out time))
            {
                MessageBox.Show("This is a number only field");
                return;
            }

            // Same Unit

            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Nanosecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Nanosecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Microsecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Microsecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Millisecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Millisecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Second" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Second")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Minute" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Minute")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Hour" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Hour")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Day" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Day")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Week")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Month" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Month")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Calendar Year" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Calendar Year")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Decade" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Decade")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Century" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Century")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }

            // Nanosecond

            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Nanosecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Microsecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 1000) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Nanosecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Millisecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 1E+6) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Nanosecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Second")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 1E+9) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Nanosecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Minute")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 6E+10) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Nanosecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Hour")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 3.6E+12) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Nanosecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Day")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 8.64e+13) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Nanosecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Week")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 6.048E+14) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Nanosecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Month")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 2.628E+15) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Nanosecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Calendar Year")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 3.154E+16) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Nanosecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Decade")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 3.154E+17) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Nanosecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Century")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 3.154E+18) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }

            // Microsecond

            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Microsecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Nanosecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 1000) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Microsecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Millisecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 1000) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Microsecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Second")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 1E+6) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Microsecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Minute")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 6E+7) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Microsecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Hour")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 3.6E+9) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Microsecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Day")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 8.64E+10) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Microsecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Week")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 6.048E+11) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Microsecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Month")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 2.628E+12) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Microsecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Calendar Year")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 3.154E+13) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Microsecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Decade")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 3.154E+14) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Microsecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Century")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 3.154E+15) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }

            // Millisecond

            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Millisecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Nanosecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 1E+6) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Millisecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Microsecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 1000) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Millisecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Second")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 1000) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Millisecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Minute")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 60000) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Millisecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Hour")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 3.6E+6) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Millisecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Day")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 8.64E+7) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Millisecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Week")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 6.048E+8) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Millisecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Month")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 2.628E+9) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Millisecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Calendar Year")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 3.154E+10) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Millisecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Decade")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 3.154E+11) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Millisecond" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Century")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 3.154E+12) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }

            // Second

            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Second" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Nanosecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 1E+9) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Second" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Microsecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 1E+6) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Second" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Millisecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 1000) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Second" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Minute")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 60) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Second" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Hour")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 3600) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Second" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Day")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 86400) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Second" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Week")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 604800) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Second" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Month")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 2.628E+6) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Second" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Calendar Year")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 3.154E+7) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Second" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Decade")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 3.154E+8) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Second" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Century")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 3.154E+9) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }

            // Minute

            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Minute" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Nanosecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 6E+10) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Minute" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Microsecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 6E+7) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Minute" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Millisecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 60000) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Minute" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Second")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 60) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Minute" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Hour")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 60) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Minute" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Day")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 1440) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Minute" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Week")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 10080) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Minute" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Month")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 43800) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Minute" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Calendar Year")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 525600) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Minute" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Decade")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 5.256E+6) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Minute" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Century")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 5.256E+7) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }

            // Hour

            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Hour" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Nanosecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 3.6E+12) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Hour" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Microsecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 3.6E+9) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Hour" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Millisecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 3.6E+6) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Hour" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Second")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 3600) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Hour" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Minute")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 60) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Hour" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Day")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 24) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Hour" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Week")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 168) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Hour" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Month")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 730) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Hour" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Calendar Year")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 8760) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Hour" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Decade")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 87600) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Hour" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Century")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 876000) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }

            // Day

            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Day" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Nanosecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 8.64E+13) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Day" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Microsecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 8.64E+10) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Day" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Millisecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 8.64E+7) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Day" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Second")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 86400) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Day" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Minute")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 1440) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Day" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Hour")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 24) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Day" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Week")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 7) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Day" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Month")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 30.417) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Day" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Calendar Year")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 365) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Day" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Decade")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 36500) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Day" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Century")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 36500) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }

            // Week

            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Nanosecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 6.048E+14) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Microsecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 6.048E+11) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Millisecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 6.048E+8) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Second")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 604800) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Minute")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 10080) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Hour")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 168) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Day")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 7) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Month")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 4.345) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Calendar Year")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 52.143) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Decade")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 521) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Century")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 5214) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }

            // Month

            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Nanosecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 2.628E+15) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Microsecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 2.628E+12) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Millisecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 2.628E+9) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Second")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 2.628E+6) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Minute")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 43800) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Hour")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 730) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Day")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 30.417) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Week")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 4.345) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Calendar Year")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 12) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Decade")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 120) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Week" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Century")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 1200) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }

            // Calendar Year


            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Calendar Year" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Nanosecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 3.154E+16) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Calendar Year" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Microsecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 3.154E+13) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Calendar Year" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Millisecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 3.154E+10) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Calendar Year" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Second")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 3.154E+7) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Calendar Year" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Minute")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 525600) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Calendar Year" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Hour")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 8760) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Calendar Year" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Day")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 365) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Calendar Year" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Week")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 52.143) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Calendar Year" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Month")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 12) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Calendar Year" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Decade")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 10) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Calendar Year" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Century")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 100) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }

            // Decade

            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Decade" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Nanosecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 3.154E+17) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Decade" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Microsecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 3.154E+14) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Decade" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Millisecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 3.154E+11) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Decade" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Second")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 3.154E+8) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Decade" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Minute")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 5.256E+6) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Decade" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Hour")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 87600) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Decade" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Day")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 3650) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Decade" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Week")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 521) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Decade" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Month")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 120) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Decade" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Calendar Year")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 10) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Decade" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Century")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time / 10) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }

            // Century

            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Century" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Nanosecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 3.154E+18) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Century" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Microsecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 3.154E+15) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Century" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Millisecond")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 3.154E+12) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Century" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Second")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 3.154E+9) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Century" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Minute")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 5.256E+7) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Century" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Hour")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 876000) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Century" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Day")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 36500) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Century" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Week")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 5214) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Century" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Month")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 1200) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Century" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Calendar Year")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 100) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromTimeComboBox.SelectedItem) == "Century" && Convert.ToString(ToTimeComboBox.SelectedItem) == "Decade")
            {
                TimeResultTextBox.Text = Convert.ToString(time) + "  " + Convert.ToString(FromTimeComboBox.SelectedItem) + "  =  " + Convert.ToString(time * 10) + "  " + Convert.ToString(ToTimeComboBox.SelectedItem);
            }
        }
        private void PlaneAngleConvertBtn_Click(object sender, EventArgs e)
        {
            double angle = 0.0;
            double pi = System.Math.PI;

            if (FromPlaneAngleComboBox.SelectedItem == null || ToPlaneAngleComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select The Units To Convert....");
            }
            else if (PlaneAngleTextBox.TextLength == 0)
            {
                MessageBox.Show("Please Enter The Angle....");
            }
            else if (!double.TryParse(PlaneAngleTextBox.Text, out angle))
            {
                MessageBox.Show("This is a number only field");
                return;
            }

            // Same Unit

            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Degree" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Degree")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Gradian" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Gradian")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Milliradian" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Milliradian")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Minute Of Arc" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Minute Of Arc")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Radian" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Radian")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Second Of Arc" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Second Of Arc")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            
            // Degree
            
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Degree" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Gradian")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * 200 / 180) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Degree" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Milliradian")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * (1000 * pi) / 180) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Degree" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Minute Of Arc")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * 60) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Degree" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Radian")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * pi / 180) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Degree" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Second Of Arc")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * 3600) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            
            // Gradian

            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Gradian" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Degree")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * 180 / 200) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Gradian" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Milliradian")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * (1000 * pi) / 200) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Gradian" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Minute Of Arc")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * 54) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Gradian" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Radian")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * pi / 200) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Gradian" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Second Of Arc")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * 3240) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            
            // Milliradian
            
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Milliradian" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Degree")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * 180 / (1000 * pi)) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Milliradian" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Gradian")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * 200 / (1000 * pi)) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Milliradian" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Minute Of Arc")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * (60 * 180) / (1000 * pi)) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Milliradian" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Radian")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle / 1000) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Milliradian" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Second Of Arc")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * (3600 * 180) / (1000 * pi)) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            
            // Minute Of Arc
            
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Minute Of Arc" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Degree")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle / 60) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Minute Of Arc" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Gradian")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle / 54) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Minute Of Arc" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Milliradian")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * (1000 * pi) / (60 * 180)) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Minute Of Arc" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Radian")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * pi / (60 * 180)) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Minute Of Arc" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Second Of Arc")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * 60) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            
            // Radian

            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Radian" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Degree")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * 180 / pi) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Radian" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Gradian")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * 200 / pi) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Radian" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Milliradian")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * 1000) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Radian" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Minute Of Arc")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * (60 * 180) / pi) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Radian" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Second Of Arc")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * (3600 * 180) / pi) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            
            // Second Of Arc

            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Second Of Arc" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Degree")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle / 3600) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Second Of Arc" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Gradian")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle / 3240) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Second Of Arc" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Milliradian")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * (1000 * pi) / (180 * 3600)) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Second Of Arc" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Minute Of Arc")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle / 60) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
            else if (Convert.ToString(FromPlaneAngleComboBox.SelectedItem) == "Second Of Arc" && Convert.ToString(ToPlaneAngleComboBox.SelectedItem) == "Radian")
            {
                PlaneAngleResultTextBox.Text = Convert.ToString(angle) + "  " + Convert.ToString(FromPlaneAngleComboBox.SelectedItem) + "  =  " + Convert.ToString(angle * pi / (180 * 3600)) + "  " + Convert.ToString(ToPlaneAngleComboBox.SelectedItem);
            }
        }
    }
    
}
      