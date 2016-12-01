using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3D_printer_calibrator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            string errors = "";
            TextBox[] values = {oldX, oldY, X1, X2, Y1, Y2};
            float[] numbers = new float[6];

            int i = 0;

            foreach (var box in values)
            {
                errors += parseTextbox(box, out numbers[i]);
                i++;
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float deltaX = numbers[2] - numbers[3];
            float deltaY = numbers[4] - numbers[5];

            float newXValue = numbers[0] + deltaX/2.0f;
            float newYValue = numbers[1] + deltaY/2.0f;

            newX.Text = "" + newXValue;
            NewY.Text = "" + newYValue;
        }

        private string parseTextbox(TextBox box, out float value)
        {
            bool success = float.TryParse(box.Text.Replace(".", ","), out value);
            if (success)
            {
                return "";
            }
            return box.Name + " parse error\n";
        }
    }
}
