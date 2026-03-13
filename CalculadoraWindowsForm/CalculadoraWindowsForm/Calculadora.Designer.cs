namespace CalculadoraWindowsForm
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            btn0 = new Button();
            btnDividir = new Button();
            btnIgual = new Button();
            btnReset = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnMultiplicar = new Button();
            btnMenos = new Button();
            btnMais = new Button();
            txtCalculo = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn0
            // 
            btn0.BackColor = Color.MediumAquamarine;
            btn0.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.ForeColor = SystemColors.ActiveCaptionText;
            btn0.Location = new Point(13, 473);
            btn0.Name = "btn0";
            btn0.Size = new Size(98, 90);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += Botao_Click;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = Color.HotPink;
            btnDividir.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDividir.ForeColor = SystemColors.ActiveCaptionText;
            btnDividir.Location = new Point(324, 185);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(86, 90);
            btnDividir.TabIndex = 10;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += Operador_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.CadetBlue;
            btnIgual.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIgual.ForeColor = SystemColors.ActiveCaptionText;
            btnIgual.Location = new Point(116, 473);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(202, 90);
            btnIgual.TabIndex = 13;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.CadetBlue;
            btnReset.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = SystemColors.ActiveCaptionText;
            btnReset.Location = new Point(12, 146);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(202, 33);
            btnReset.TabIndex = 15;
            btnReset.Text = "LIMPAR TUDO";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.MediumAquamarine;
            btn7.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.ForeColor = SystemColors.ActiveCaptionText;
            btn7.Location = new Point(13, 185);
            btn7.Name = "btn7";
            btn7.Size = new Size(98, 90);
            btn7.TabIndex = 16;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Botao_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.MediumAquamarine;
            btn8.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.ForeColor = SystemColors.ActiveCaptionText;
            btn8.Location = new Point(116, 185);
            btn8.Name = "btn8";
            btn8.Size = new Size(98, 90);
            btn8.TabIndex = 17;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += Botao_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.MediumAquamarine;
            btn9.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.ForeColor = SystemColors.ActiveCaptionText;
            btn9.Location = new Point(220, 185);
            btn9.Name = "btn9";
            btn9.Size = new Size(98, 90);
            btn9.TabIndex = 18;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += Botao_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.MediumAquamarine;
            btn6.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.ForeColor = SystemColors.ActiveCaptionText;
            btn6.Location = new Point(220, 281);
            btn6.Name = "btn6";
            btn6.Size = new Size(98, 90);
            btn6.TabIndex = 19;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Botao_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.MediumAquamarine;
            btn3.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ForeColor = SystemColors.ActiveCaptionText;
            btn3.Location = new Point(220, 377);
            btn3.Name = "btn3";
            btn3.Size = new Size(98, 90);
            btn3.TabIndex = 20;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Botao_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.MediumAquamarine;
            btn5.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.ForeColor = SystemColors.ActiveCaptionText;
            btn5.Location = new Point(116, 281);
            btn5.Name = "btn5";
            btn5.Size = new Size(98, 90);
            btn5.TabIndex = 21;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Botao_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.MediumAquamarine;
            btn4.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.ForeColor = SystemColors.ActiveCaptionText;
            btn4.Location = new Point(13, 281);
            btn4.Name = "btn4";
            btn4.Size = new Size(98, 90);
            btn4.TabIndex = 22;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Botao_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.MediumAquamarine;
            btn2.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = SystemColors.ActiveCaptionText;
            btn2.Location = new Point(117, 377);
            btn2.Name = "btn2";
            btn2.Size = new Size(98, 90);
            btn2.TabIndex = 23;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Botao_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.MediumAquamarine;
            btn1.Font = new Font("Tahoma", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.ActiveCaptionText;
            btn1.Location = new Point(13, 376);
            btn1.Name = "btn1";
            btn1.Size = new Size(98, 90);
            btn1.TabIndex = 24;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Botao_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = Color.HotPink;
            btnMultiplicar.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiplicar.ForeColor = SystemColors.ActiveCaptionText;
            btnMultiplicar.Location = new Point(325, 281);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(86, 90);
            btnMultiplicar.TabIndex = 25;
            btnMultiplicar.Text = "*";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += Operador_Click;
            // 
            // btnMenos
            // 
            btnMenos.BackColor = Color.HotPink;
            btnMenos.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenos.ForeColor = SystemColors.ActiveCaptionText;
            btnMenos.Location = new Point(325, 377);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(86, 90);
            btnMenos.TabIndex = 26;
            btnMenos.Text = "-";
            btnMenos.UseVisualStyleBackColor = false;
            btnMenos.Click += Operador_Click;
            // 
            // btnMais
            // 
            btnMais.BackColor = Color.HotPink;
            btnMais.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMais.ForeColor = SystemColors.ActiveCaptionText;
            btnMais.Location = new Point(325, 473);
            btnMais.Name = "btnMais";
            btnMais.Size = new Size(86, 90);
            btnMais.TabIndex = 27;
            btnMais.Text = "+";
            btnMais.UseVisualStyleBackColor = false;
            btnMais.Click += Operador_Click;
            // 
            // txtCalculo
            // 
            txtCalculo.BackColor = SystemColors.Info;
            txtCalculo.Font = new Font("SimSun-ExtB", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCalculo.Location = new Point(13, 12);
            txtCalculo.Multiline = true;
            txtCalculo.Name = "txtCalculo";
            txtCalculo.ReadOnly = true;
            txtCalculo.Size = new Size(397, 128);
            txtCalculo.TabIndex = 28;
            txtCalculo.TabStop = false;
            txtCalculo.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(220, 146);
            button1.Name = "button1";
            button1.Size = new Size(191, 33);
            button1.TabIndex = 29;
            button1.Text = "BACKSPACE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnBackSpace_Click;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(423, 575);
            Controls.Add(button1);
            Controls.Add(txtCalculo);
            Controls.Add(btnMais);
            Controls.Add(btnMenos);
            Controls.Add(btnMultiplicar);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn3);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnReset);
            Controls.Add(btnIgual);
            Controls.Add(btnDividir);
            Controls.Add(btn0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Calculadora";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn0;
        private Button btnDividir;
        private Button btnIgual;
        private Button btnReset;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn6;
        private Button btn3;
        private Button btn5;
        private Button btn4;
        private Button btn2;
        private Button btn1;
        private Button btnMultiplicar;
        private Button btnMenos;
        private Button btnMais;
        private TextBox txtCalculo;
        private Button button1;
    }
}
