namespace Temperaturanzeige
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.temperatureSensorControl1 = new Temperaturanzeige.TemperatureSensorControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericDisplayControl = new Temperaturanzeige.NumericDisplayControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.graphicDisplayControl = new Temperaturanzeige.GraphicDisplayControl();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.temperatureSensorControl1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(373, 311);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensor (Simulator)";
            // 
            // temperatureSensorControl1
            // 
            this.temperatureSensorControl1.Location = new System.Drawing.Point(8, 36);
            this.temperatureSensorControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.temperatureSensorControl1.Name = "temperatureSensorControl1";
            this.temperatureSensorControl1.Size = new System.Drawing.Size(363, 92);
            this.temperatureSensorControl1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericDisplayControl);
            this.groupBox2.Location = new System.Drawing.Point(408, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(243, 105);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Numeric Display Device";
            // 
            // numericDisplayControl
            // 
            this.numericDisplayControl.Location = new System.Drawing.Point(24, 36);
            this.numericDisplayControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.numericDisplayControl.Name = "numericDisplayControl";
            this.numericDisplayControl.Size = new System.Drawing.Size(188, 49);
            this.numericDisplayControl.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.graphicDisplayControl);
            this.groupBox3.Location = new System.Drawing.Point(408, 127);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(243, 199);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphic Display Device";
            // 
            // graphicDisplayControl
            // 
            this.graphicDisplayControl.Location = new System.Drawing.Point(47, 26);
            this.graphicDisplayControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.graphicDisplayControl.Name = "graphicDisplayControl";
            this.graphicDisplayControl.Size = new System.Drawing.Size(132, 166);
            this.graphicDisplayControl.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 471);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperaturanzeige (mit dem Observer Pattern implementiert)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private TemperatureSensorControl temperatureSensorControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private NumericDisplayControl numericDisplayControl;
        private System.Windows.Forms.GroupBox groupBox3;
        private GraphicDisplayControl graphicDisplayControl;


    }
}