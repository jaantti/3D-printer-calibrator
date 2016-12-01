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
    public partial class Form1 : Form
    {
        private List<PrinterClass> printers;

        public Form1() {
            printers = new List<PrinterClass>();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            printers.Add(new Cartesio());
            printers.Add(new TAZ6Cura());
            printers.Add(new TAZ6S3D());

            foreach (var printer in printers)
            {
                printerBox.Items.Add(printer.name);
            }
            printerBox.SelectedIndex = 0;
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

            var printer = printers[printerBox.SelectedIndex];
            var newValues = printer.calculateOffsets(numbers);

            newX.Text = $"{newValues.Item1:F3}";
            newY.Text = $"{newValues.Item2:F3}";
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
