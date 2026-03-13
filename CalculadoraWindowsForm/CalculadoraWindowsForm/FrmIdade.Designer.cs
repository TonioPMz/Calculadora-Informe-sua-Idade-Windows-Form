namespace CalculadoraWindowsForm
{
    partial class FrmIdade
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
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtGrab = new TextBox();
            btnEnviar = new Button();
            lbInformacao = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.OldLace;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(137, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 49);
            textBox1.TabIndex = 0;
            textBox1.TabStop = false;
            textBox1.Text = "Informe sua Idade:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 140);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.old_slack_logo_icon_214620;
            pictureBox1.Location = new Point(15, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // txtGrab
            // 
            txtGrab.Location = new Point(137, 67);
            txtGrab.Name = "txtGrab";
            txtGrab.PlaceholderText = "Informe aqui.";
            txtGrab.Size = new Size(120, 23);
            txtGrab.TabIndex = 4;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(263, 67);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(86, 24);
            btnEnviar.TabIndex = 5;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lbInformacao
            // 
            lbInformacao.AutoSize = true;
            lbInformacao.Location = new Point(146, 108);
            lbInformacao.Name = "lbInformacao";
            lbInformacao.Size = new Size(0, 15);
            lbInformacao.TabIndex = 7;
            // 
            // FrmIdade
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(475, 132);
            Controls.Add(lbInformacao);
            Controls.Add(btnEnviar);
            Controls.Add(txtGrab);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FrmIdade";
            Text = "FrmIdade";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtGrab;
        private Button btnEnviar;
        private Label lbInformacao;
    }
}