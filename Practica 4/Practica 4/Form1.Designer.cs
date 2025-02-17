namespace Practica_4
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTexto1 = new TextBox();
            lblinge1 = new Label();
            btnCalcular1 = new Button();
            btnCalcular2 = new Button();
            lblResultado1 = new Label();
            lblResultado2 = new Label();
            SuspendLayout();
            // 
            // txtTexto1
            // 
            txtTexto1.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTexto1.Location = new Point(32, 188);
            txtTexto1.Name = "txtTexto1";
            txtTexto1.Size = new Size(252, 73);
            txtTexto1.TabIndex = 0;
            txtTexto1.TextChanged += txtTexto1_TextChanged;
            // 
            // lblinge1
            // 
            lblinge1.AutoSize = true;
            lblinge1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblinge1.Location = new Point(12, 156);
            lblinge1.Name = "lblinge1";
            lblinge1.Size = new Size(289, 29);
            lblinge1.TabIndex = 1;
            lblinge1.Text = "Ingresar el radio del circulo";
            // 
            // btnCalcular1
            // 
            btnCalcular1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular1.Location = new Point(328, 131);
            btnCalcular1.Name = "btnCalcular1";
            btnCalcular1.Size = new Size(207, 66);
            btnCalcular1.TabIndex = 2;
            btnCalcular1.Text = "Calcular area";
            btnCalcular1.UseVisualStyleBackColor = true;
            btnCalcular1.Click += btnCalcular1_Click;
            // 
            // btnCalcular2
            // 
            btnCalcular2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular2.Location = new Point(326, 267);
            btnCalcular2.Name = "btnCalcular2";
            btnCalcular2.Size = new Size(209, 62);
            btnCalcular2.TabIndex = 3;
            btnCalcular2.Text = "Calcular perimetro";
            btnCalcular2.UseVisualStyleBackColor = true;
            btnCalcular2.Click += btnCalcular2_Click;
            // 
            // lblResultado1
            // 
            lblResultado1.AutoSize = true;
            lblResultado1.BackColor = Color.Snow;
            lblResultado1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado1.Location = new Point(593, 148);
            lblResultado1.Name = "lblResultado1";
            lblResultado1.Size = new Size(121, 32);
            lblResultado1.TabIndex = 4;
            lblResultado1.Text = "Resultado";
            lblResultado1.Click += lblResultado1_Click;
            // 
            // lblResultado2
            // 
            lblResultado2.AutoSize = true;
            lblResultado2.BackColor = SystemColors.ButtonHighlight;
            lblResultado2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado2.Location = new Point(593, 282);
            lblResultado2.Name = "lblResultado2";
            lblResultado2.Size = new Size(121, 32);
            lblResultado2.TabIndex = 5;
            lblResultado2.Text = "Resultado";
            lblResultado2.Click += lblResultado2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado2);
            Controls.Add(lblResultado1);
            Controls.Add(btnCalcular2);
            Controls.Add(btnCalcular1);
            Controls.Add(lblinge1);
            Controls.Add(txtTexto1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTexto1;
        private Label lblinge1;
        private Button btnCalcular1;
        private Button btnCalcular2;
        private Label lblResultado1;
        private Label lblResultado2;
    }
}
