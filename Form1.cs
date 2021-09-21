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
        }

        // Close Application Button Function And Design
        private void AppCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AppCloseBtn_MouseHover(object sender, EventArgs e)
        {
            this.AppCloseBtn.BackColor = Color.Red;
        }

        private void AppCloseBtn_MouseLeave(object sender, EventArgs e)
        {
            this.AppCloseBtn.BackColor = Color.Transparent;
        }

        // Maximize Button Function And Design
        private void MaximizeBtn_MouseHover(object sender, EventArgs e)
        {
            this.MaximizeBtn.BackColor = Color.DarkGray;
        }
        
        private void MaximizeBtn_MouseLeave(object sender, EventArgs e)
        {
            this.MaximizeBtn.BackColor = Color.Transparent;
        }

        private void MaximizeBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
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
        }

        private void lengthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LengthPanel.Visible = true;
            TemperaturePanel.Visible = false;
        }
        
        private void areaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LengthPanel.Visible = false;
            TemperaturePanel.Visible = false;
            AreaPanel.Visible = true;
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

            //Meter
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Meter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometer")
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
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Centimeter" && Convert.ToString(ToLengthComboBox.SelectedItem) == "kilometer")
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

            //Millimetre
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Millimetre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometer")
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
            
            //Micrometres
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Micrometres" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometer")
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
            
            //Nanometre
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nanometre" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometer")
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

            //Mile
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometer")
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
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Yard" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometer")
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
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Foot" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometer")
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
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Inch" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometer")
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
            
            // Nutical Miles
            else if(Convert.ToString(FromLengthComboBox.SelectedItem) == "Nautical Mile" && Convert.ToString(ToLengthComboBox.SelectedItem) == "Kilometer")
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
                MessageBox.Show("Please Enter The Length....");
            }
            else if (!double.TryParse(TemperatureTextBox.Text, out temperature))
            {
                MessageBox.Show("This is a number only field");
                return;
            }
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

        }
    }
    
}
