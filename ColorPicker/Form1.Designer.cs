using System.Drawing;
using System.Windows.Forms;

namespace ColorPicker
{
    partial class Form1
    {
        /// <summary>
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
        private System.Windows.Forms.Label canvas;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.Label labelRed0;
        private System.Windows.Forms.Label labelRed255;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelBlue0;
        private System.Windows.Forms.Label labelBlue255;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.Label labelGreen0;
        private System.Windows.Forms.Label labelGreen255;
        private System.Windows.Forms.TrackBar r;
        private System.Windows.Forms.TrackBar g;
        private System.Windows.Forms.TrackBar b;
        private System.Windows.Forms.TableLayoutPanel palette;
        private System.Windows.Forms.TableLayoutPanel rgb;
        private System.Windows.Forms.TableLayoutPanel red;
        private System.Windows.Forms.TableLayoutPanel red0255;
        private System.Windows.Forms.TableLayoutPanel green;
        private System.Windows.Forms.TableLayoutPanel green0255;
        private System.Windows.Forms.TableLayoutPanel blue;
        private System.Windows.Forms.TableLayoutPanel blue0255;
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas = new Label();
            this.labelBlue = new Label();
            this.labelBlue0 = new Label();
            this.labelBlue255 = new Label();
            this.labelGreen = new Label();
            this.labelGreen0 = new Label();
            this.labelGreen255 = new Label();
            this.labelRed = new Label();
            this.labelRed0 = new Label();
            this.labelRed255 = new Label();
            this.r = new TrackBar();
            this.g = new TrackBar();
            this.b = new TrackBar();
            this.rgb = new TableLayoutPanel();
            this.red = new TableLayoutPanel();
            this.red0255 = new TableLayoutPanel();
            this.green = new TableLayoutPanel();
            this.green0255 = new TableLayoutPanel();
            this.blue = new TableLayoutPanel();
            this.blue0255 = new TableLayoutPanel();
            this.palette = new TableLayoutPanel();
            // 
            // rgb
            // 
            this.rgb.Name = "rgb";
            this.rgb.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.rgb.ColumnCount = 1;
            this.rgb.RowCount = 3;
            this.rgb.Controls.Add(this.red, 0, 0);
            this.rgb.Controls.Add(this.green, 0, 1);
            this.rgb.Controls.Add(this.blue, 0, 2);
            this.rgb.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rgb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.rgb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.rgb.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.rgb.Size = new System.Drawing.Size(400, 400);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            //
            // palette
            // 
            this.palette.Margin = new System.Windows.Forms.Padding(10);
            this.palette.Name = "palette";
            this.palette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palette.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.palette.ColumnCount = 2;
            this.palette.RowCount = 1;
            this.palette.Controls.Add(this.canvas, 0, 0);
            this.palette.Controls.Add(this.rgb, 1, 0);
            this.palette.Location = new System.Drawing.Point(10, 10);
            this.palette.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.palette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.palette.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.palette.Size = new System.Drawing.Size(800, 400);
            //
            // canvas
            //
            this.canvas.Name = "canvas";
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.BorderStyle = BorderStyle.FixedSingle;
            this.canvas.BackColor = Color.FromArgb(255, 128, 128, 128);
            this.canvas.Margin = new Padding(20, 10, 20, 40);
            this.canvas.ClientSize = new Size(400, 400);
            //
            // red
            //
            this.red.Name = "red";
            this.red.Dock = System.Windows.Forms.DockStyle.Fill;
            this.red.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.red.ColumnCount = 2;
            this.red.RowCount = 2;
            this.red.Controls.Add(this.labelRed, 0, 0);
            this.red.Controls.Add(this.r, 1, 0);
            this.red.Controls.Add(this.red0255, 1, 1);
            this.red.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50));
            this.red.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
            this.red.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.red.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.red.Size = new System.Drawing.Size(400, 80);
            //
            // green
            //
            this.green.Name = "green";
            this.green.Dock = System.Windows.Forms.DockStyle.Fill;
            this.green.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.green.ColumnCount = 2;
            this.green.RowCount = 2;
            this.green.Controls.Add(this.labelGreen, 0, 0);
            this.green.Controls.Add(this.g, 1, 0);
            this.green.Controls.Add(this.green0255, 1, 1);
            this.green.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50));
            this.green.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
            this.green.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.green.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.green.Size = new System.Drawing.Size(400, 80);
            //
            // blue
            //
            this.blue.Name = "blue";
            this.blue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blue.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.blue.ColumnCount = 2;
            this.blue.RowCount = 2;
            this.blue.Controls.Add(this.labelBlue, 0, 0);
            this.blue.Controls.Add(this.b, 1, 0);
            this.blue.Controls.Add(this.blue0255, 1, 1);
            this.blue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50));
            this.blue.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30));
            this.blue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.blue.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.blue.Size = new System.Drawing.Size(400, 80);
            //
            // red0255
            // 
            this.red0255.Name = "red0255";
            this.red0255.Dock = System.Windows.Forms.DockStyle.Fill;
            this.red0255.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.red0255.ColumnCount = 2;
            this.red0255.RowCount = 1;
            this.red0255.Controls.Add(this.labelRed0, 0, 0);
            this.red0255.Controls.Add(this.labelRed255, 1, 0);
            this.red0255.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80));
            this.red0255.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.red0255.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.red0255.Size = new System.Drawing.Size(300, 80);
            //
            // green0255
            // 
            this.green0255.Name = "green0255";
            this.green0255.Dock = System.Windows.Forms.DockStyle.Fill;
            this.green0255.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.green0255.ColumnCount = 2;
            this.green0255.RowCount = 1;
            this.green0255.Controls.Add(this.labelGreen0, 0, 0);
            this.green0255.Controls.Add(this.labelGreen255, 1, 0);
            this.green0255.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80));
            this.green0255.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.green0255.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.green0255.Size = new System.Drawing.Size(300, 80);
            //
            // blue0255
            // 
            this.blue0255.Name = "blue0255";
            this.blue0255.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blue0255.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.blue0255.ColumnCount = 2;
            this.blue0255.RowCount = 1;
            this.blue0255.Controls.Add(this.labelBlue0, 0, 0);
            this.blue0255.Controls.Add(this.labelBlue255, 1, 0);
            this.blue0255.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80));
            this.blue0255.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.blue0255.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.blue0255.Size = new System.Drawing.Size(300, 80);
            //
            // r
            //
            this.r.Dock = Dock = System.Windows.Forms.DockStyle.Top;
            this.r.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.r.Maximum = 255;
            this.r.Minimum = 0;
            this.r.TickFrequency = 16;
            this.r.SmallChange = 1;
            this.r.Size = new Size(400, 50);
            this.r.Value = 128;
            this.r.TickStyle = TickStyle.BottomRight;
            //
            // g
            //
            this.g.Dock = Dock = System.Windows.Forms.DockStyle.Top;
            this.g.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.g.Maximum = 255;
            this.g.Minimum = 0;
            this.g.TickFrequency = 16;
            this.g.SmallChange = 1;
            this.g.Size = new Size(400, 50);
            this.g.Value = 128;
            this.g.TickStyle = TickStyle.BottomRight;
            //
            // b
            //
            this.b.Dock = Dock = System.Windows.Forms.DockStyle.Top;
            this.b.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right);
            this.b.Maximum = 255;
            this.b.Minimum = 0;
            this.b.TickFrequency = 16;
            this.b.SmallChange = 1;
            this.b.Size = new Size(400, 50);
            this.b.Value = 128;
            this.b.TickStyle = TickStyle.BottomRight;
            //
            // labelRed
            //
            this.labelRed.Text = "Red: ";
            this.labelRed.Size = new Size(100, 20);
            this.labelRed.Dock = DockStyle.Left;
            //
            // labelBlue
            //
            this.labelBlue.Text = "Blue: ";
            this.labelBlue.Size = new Size(100, 20);
            this.labelBlue.Dock = DockStyle.Left;
            //
            // labelGreen
            //
            this.labelGreen.Text = "Green: ";
            this.labelGreen.Size = new Size(100, 20);
            this.labelGreen.Dock = DockStyle.Left;
            //
            // labelRed0
            //
            this.labelRed0.Text = "0";
            this.labelRed0.Size = new Size(20, 20);
            this.labelRed0.Dock = DockStyle.Left;
            this.labelRed0.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left);
            //
            // labelGreen0
            //
            this.labelGreen0.Text = "0";
            this.labelGreen0.Size = new Size(20, 20);
            this.labelGreen0.Dock = DockStyle.Left;
            this.labelGreen0.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left);
            //
            // labelBlue0
            //
            this.labelBlue0.Text = "0";
            this.labelBlue0.Size = new Size(20, 20);
            this.labelBlue0.Dock = DockStyle.Left;
            this.labelBlue0.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left);
            //
            // labelRed255
            //
            this.labelRed255.Text = "255";
            this.labelRed255.Size = new Size(40, 20);
            this.labelRed255.Dock = DockStyle.Right;
            this.labelRed255.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            //
            // labelBlue255
            //
            this.labelBlue255.Text = "255";
            this.labelBlue255.Size = new Size(40, 20);
            this.labelBlue255.Dock = DockStyle.Right;
            this.labelBlue255.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
            //
            // labelGreen255
            //
            this.labelGreen255.Text = "255";
            this.labelGreen255.Size = new Size(40, 20);
            this.labelGreen255.Dock = DockStyle.Right;
            this.labelGreen255.Anchor = (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);

            // 
            // Form1
            //       
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 420);
            this.Text = "Color Picker";
            this.Name = "Form1";
            this.MaximizeBox = true;
            this.KeyPreview = true;
            this.BackColor = Color.White;
            this.Controls.Add(this.palette);
            this.MinimumSize = new System.Drawing.Size(750, 300);
            this.rgb.ResumeLayout(false);
            this.rgb.PerformLayout();
            this.palette.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

    }
}

