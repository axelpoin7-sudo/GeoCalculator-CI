using System;
using System.Drawing;
using System.Windows.Forms;
using GeoApp.Models;
namespace GeoApp
{
    public class FormCirculo : Form
    {
        private TextBox txtRadio = new TextBox { Location = new Point(100, 20) };
        private Button btnCalcular = new Button { Text ="Calcular", Location = new Point(100, 80) };
        public FormCirculo()
        {
            this.Controls.Add(new Label { Text = "Radio:", Location= new Point(20, 20) });
            this.Controls.Add(txtRadio);
        
            this.Controls.Add(btnCalcular);
            btnCalcular.Click += (s, e) => {double res =Calculadora.AreaCirculo(double.Parse(txtRadio.Text));
            MessageBox.Show("El área es: " + res);
            };
        }
    }
}