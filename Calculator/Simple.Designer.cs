
using System.Windows.Forms;

namespace Calculator
{
    partial class Simple
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Simple";
        }
        Button MC = new Button();
        Button MR = new Button();
        Button MS = new Button();
        Button Mplus = new Button();
        Button Mminus = new Button();

        Button delete = new Button();
        Button CE = new Button();
        Button C = new Button();
        Button plus_minus = new Button();
        Button root = new Button();

        Button button7 = new Button();
        Button button8 = new Button();
        Button button9 = new Button();
        Button divide = new Button();
        Button percentage = new Button();

        Button button4 = new Button();
        Button button5 = new Button();
        Button button6 = new Button();
        Button multiply = new Button();
        Button one_of_the = new Button();

        Button button1 = new Button();
        Button button2 = new Button();
        Button button3 = new Button();
        Button minus = new Button();
        Button equals = new Button();

        Button button0 = new Button();
        Button comma = new Button();
        Button plus = new Button();
        #endregion
    }
}