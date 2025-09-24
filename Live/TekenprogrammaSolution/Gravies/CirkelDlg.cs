using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TekenProgramma;

namespace Gravies
{
    public class CirkelDlg : Form
    {
        public Figuur Generate()
        {
            Cirkel c = new Cirkel();
            c.Positie = new Positie { X = (int)hX.Value, Y = (int)hY.Value };
            c.Straal = (int)hRadius.Value;
            c.Kleur = colorDialog1.Color;
            return c;
        }
        public CirkelDlg()
        {
            InitializeComponent();
        }

        private System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            hX = new NumericUpDown();
            hY = new NumericUpDown();
            hRadius = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            colorDialog1 = new ColorDialog();
            button3 = new Button();
            button4 = new Button();
            ((ISupportInitialize)hX).BeginInit();
            ((ISupportInitialize)hY).BeginInit();
            ((ISupportInitialize)hRadius).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(12, 114);
            label1.Name = "label1";
            label1.Size = new Size(64, 30);
            label1.TabIndex = 0;
            label1.Text = "Straal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(25, 30);
            label2.TabIndex = 1;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(12, 55);
            label3.Name = "label3";
            label3.Size = new Size(25, 30);
            label3.TabIndex = 2;
            label3.Text = "Y";
            // 
            // hX
            // 
            hX.Location = new Point(102, 19);
            hX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            hX.Name = "hX";
            hX.Size = new Size(120, 23);
            hX.TabIndex = 3;
            // 
            // hY
            // 
            hY.Location = new Point(102, 65);
            hY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            hY.Name = "hY";
            hY.Size = new Size(120, 23);
            hY.TabIndex = 4;
            // 
            // hRadius
            // 
            hRadius.Location = new Point(102, 124);
            hRadius.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            hRadius.Name = "hRadius";
            hRadius.Size = new Size(120, 23);
            hRadius.TabIndex = 5;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(352, 223);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(271, 223);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Create";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(284, 87);
            button3.Name = "button3";
            button3.Size = new Size(8, 8);
            button3.TabIndex = 8;
            button3.Text = "Kleur";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(270, 90);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 9;
            button4.Text = "Kleur";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // CirkelDlg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 258);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(hRadius);
            Controls.Add(hY);
            Controls.Add(hX);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CirkelDlg";
            Text = "CirkelDlg";
            Load += CirkelDlg_Load;
            ((ISupportInitialize)hX).EndInit();
            ((ISupportInitialize)hY).EndInit();
            ((ISupportInitialize)hRadius).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown hX;
        private System.Windows.Forms.NumericUpDown hY;
        private System.Windows.Forms.NumericUpDown hRadius;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private void CirkelDlg_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                //_kleur = colorDialog1.Color;
            }
        }

        private ColorDialog colorDialog1;
        private Button button3;
        private Button button4;
    }
}
