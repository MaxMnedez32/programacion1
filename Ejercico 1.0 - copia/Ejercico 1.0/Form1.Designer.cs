namespace Ejercico_1._0
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
            btncambiar = new Button();
            txtTexto = new TextBox();
            lblTexto = new Label();
            SuspendLayout();
            // 
            // btncambiar
            // 
            btncambiar.BackColor = Color.DimGray;
            btncambiar.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncambiar.Location = new Point(239, 272);
            btncambiar.Margin = new Padding(3, 4, 3, 4);
            btncambiar.Name = "btncambiar";
            btncambiar.Size = new Size(307, 86);
            btncambiar.TabIndex = 0;
            btncambiar.Text = "Cambiar";
            btncambiar.UseVisualStyleBackColor = false;
            btncambiar.Click += button1_Click;
            // 
            // txtTexto
            // 
            txtTexto.BackColor = Color.DimGray;
            txtTexto.Font = new Font("Comic Sans MS", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTexto.Location = new Point(239, 121);
            txtTexto.Margin = new Padding(3, 4, 3, 4);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(307, 59);
            txtTexto.TabIndex = 1;
            txtTexto.TextChanged += textBox1_TextChanged;
            // 
            // lblTexto
            // 
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTexto.Location = new Point(254, 30);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(292, 65);
            lblTexto.TabIndex = 2;
            lblTexto.Text = "Hola Mundo";
            lblTexto.Click += lbltexto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(816, 400);
            Controls.Add(lblTexto);
            Controls.Add(txtTexto);
            Controls.Add(btncambiar);
            Font = new Font("Comic Sans MS", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncambiar;
        private TextBox txtTexto;
        private Label lblTexto;
    }
}
