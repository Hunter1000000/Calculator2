
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Calculator";

            simple_calc.Size = new Size(50, 50);
            simple_calc.Location = new Point(0, 100);
            Controls.Add(simple_calc);

            fuel_calc.Size = new Size(50, 50);
            fuel_calc.Location = new Point(0, 50);
            Controls.Add(fuel_calc);
        }
        Button simple_calc = new Button();
        Button fuel_calc = new Button();
        #endregion
    }
}

