using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ola
{
    public partial class FrmDatos : Form
    {
        public FrmDatos()
        {
            InitializeComponent();
        }

        private void FrmDatos_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            MessageBox.Show(dateTime.ToString());
        }

        private void TxtStudent_TextChanged(object sender, EventArgs e)
        {

        }

        private void BttAdd_Click(object sender, EventArgs e)
        {
            this.LstStudents.Items.Add(this.TxtStudent.Text);
        }

        private void BttDelete_Click(object sender, EventArgs e)
        {
            this.LstStudents.Items.Remove(this.LstStudents.SelectedItem);
        }

        private void TxtAge_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstStudents.SelectedItem == null)
            {
                TxtStudent.Text = string.Empty;
            }

            else
            {
                this.TxtStudent.Text = this.LstStudents.SelectedItem.ToString();
            }
        }

        private void LblAge_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.MntDate.SetDate(this.dateTimePicker1.Value);
        }

        private void BttShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Año : " + this.dateTimePicker1.Value.Year.ToString() + "\nMes: " + this.dateTimePicker1.Value.Month.ToString() + "\nDía: " + this.dateTimePicker1.Value.Day.ToString() + "\nDía de la semana: " + this.dateTimePicker1.Value.DayOfWeek.ToString() + "\nDía del año: " + this.dateTimePicker1.Value.DayOfYear.ToString());
        }

        private void BttAge_Click(object sender, EventArgs e)
        {
            DateTime fechanacimiento = dateTimePicker1.Value;
            int edad = CalcularEdad(fechanacimiento, DateTime.Today);
            TxtAge.Text = edad.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private int CalcularEdad(DateTime fechaNacimiento, DateTime fechaActual)
        {
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Restar un año si aún no ha pasado el día del cumpleaños
            if (fechaNacimiento.Date > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }

        private void BttAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
