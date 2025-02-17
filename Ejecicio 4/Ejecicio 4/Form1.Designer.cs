namespace Ejecicio_4
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
            textTexto1 = new TextBox();
            textTexto2 = new TextBox();
            btnConvertir1 = new Button();
            btnConvertir2 = new Button();
            lblResultado1 = new Label();
            lblResultado2 = new Label();
            lblTexto1 = new Label();
            lblTexto2 = new Label();
            lblTexto3 = new Label();
            lblTexto4 = new Label();
            SuspendLayout();
            // 
            // textTexto1
            // 
            textTexto1.Font = new Font("Comic Sans MS", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textTexto1.Location = new Point(12, 90);
            textTexto1.Name = "textTexto1";
            textTexto1.Size = new Size(245, 59);
            textTexto1.TabIndex = 0;
            textTexto1.TextChanged += textBox1_TextChanged;
            // 
            // textTexto2
            // 
            textTexto2.Font = new Font("Comic Sans MS", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textTexto2.Location = new Point(12, 317);
            textTexto2.Name = "textTexto2";
            textTexto2.Size = new Size(245, 59);
            textTexto2.TabIndex = 1;
            // 
            // btnConvertir1
            // 
            btnConvertir1.Font = new Font("Comic Sans MS", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvertir1.Location = new Point(326, 93);
            btnConvertir1.Name = "btnConvertir1";
            btnConvertir1.Size = new Size(204, 50);
            btnConvertir1.TabIndex = 2;
            btnConvertir1.Text = "Convertir";
            btnConvertir1.UseVisualStyleBackColor = true;
            btnConvertir1.Click += btnConvertir1_Click;
            // 
            // btnConvertir2
            // 
            btnConvertir2.Font = new Font("Comic Sans MS", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvertir2.Location = new Point(326, 320);
            btnConvertir2.Name = "btnConvertir2";
            btnConvertir2.Size = new Size(204, 50);
            btnConvertir2.TabIndex = 3;
            btnConvertir2.Text = "Convertir";
            btnConvertir2.UseVisualStyleBackColor = true;
            btnConvertir2.Click += btnConvertir2_Click;
            // 
            // lblResultado1
            // 
            lblResultado1.AutoSize = true;
            lblResultado1.BackColor = SystemColors.ActiveBorder;
            lblResultado1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado1.Location = new Point(613, 93);
            lblResultado1.Name = "lblResultado1";
            lblResultado1.Size = new Size(42, 32);
            lblResultado1.TabIndex = 4;
            lblResultado1.Text = "°F";
            lblResultado1.Click += lblTexto1_Click;
            // 
            // lblResultado2
            // 
            lblResultado2.AutoSize = true;
            lblResultado2.BackColor = SystemColors.ActiveBorder;
            lblResultado2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado2.Location = new Point(615, 320);
            lblResultado2.Name = "lblResultado2";
            lblResultado2.Size = new Size(38, 32);
            lblResultado2.TabIndex = 5;
            lblResultado2.Text = "℃";
            lblResultado2.Click += lblTexto2_Click;
            // 
            // lblTexto1
            // 
            lblTexto1.AutoSize = true;
            lblTexto1.BackColor = SystemColors.ActiveBorder;
            lblTexto1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTexto1.Location = new Point(4, 46);
            lblTexto1.Name = "lblTexto1";
            lblTexto1.Size = new Size(253, 41);
            lblTexto1.TabIndex = 6;
            lblTexto1.Text = "Ingrese  Celsius";
            lblTexto1.Click += label1_Click;
            // 
            // lblTexto2
            // 
            lblTexto2.AutoSize = true;
            lblTexto2.BackColor = SystemColors.ActiveBorder;
            lblTexto2.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTexto2.Location = new Point(12, 273);
            lblTexto2.Name = "lblTexto2";
            lblTexto2.Size = new Size(253, 41);
            lblTexto2.TabIndex = 7;
            lblTexto2.Text = "Ingrese  Celsius";
            // 
            // lblTexto3
            // 
            lblTexto3.AutoSize = true;
            lblTexto3.BackColor = SystemColors.ActiveBorder;
            lblTexto3.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTexto3.Location = new Point(4, -3);
            lblTexto3.Name = "lblTexto3";
            lblTexto3.Size = new Size(295, 39);
            lblTexto3.TabIndex = 8;
            lblTexto3.Text = "Celsius a Fahrenhait";
            // 
            // lblTexto4
            // 
            lblTexto4.AutoSize = true;
            lblTexto4.BackColor = SystemColors.ActiveBorder;
            lblTexto4.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTexto4.Location = new Point(4, 225);
            lblTexto4.Name = "lblTexto4";
            lblTexto4.Size = new Size(307, 39);
            lblTexto4.TabIndex = 9;
            lblTexto4.Text = "Fahrenhait a Celsius ";
            lblTexto4.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTexto4);
            Controls.Add(lblTexto3);
            Controls.Add(lblTexto2);
            Controls.Add(lblTexto1);
            Controls.Add(lblResultado2);
            Controls.Add(lblResultado1);
            Controls.Add(btnConvertir2);
            Controls.Add(btnConvertir1);
            Controls.Add(textTexto2);
            Controls.Add(textTexto1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textTexto1;
        private TextBox textTexto2;
        private Button btnConvertir1;
        private Button btnConvertir2;
        private Label lblResultado1;
        private Label lblResultado2;
        private Label lblTexto1;
        private Label lblTexto2;
        private Label lblTexto3;
        private Label lblTexto4;
    }
}
