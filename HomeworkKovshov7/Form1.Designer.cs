using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    partial class Form1
    {/// <summary>
     ///  Required designer variable.
     /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        private System.Windows.Forms.Button b;
        private MessageBox msg;
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b = new System.Windows.Forms.Button();
            //
            // Form1
            //
            this.Controls.Add(this.b);
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Running Button";
            //
            // b
            //
            this.b.Text = "PUSH ME";
            this.b.Size = new System.Drawing.Size(70, 70);
            this.b.BackColor = Color.Red;
            this.b.Location = new System.Drawing.Point(this.ClientSize.Width / 2 - 50, this.ClientSize.Height / 2 - 25);
        }

        #endregion
    }
}

