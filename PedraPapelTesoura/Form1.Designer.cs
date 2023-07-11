namespace PedraPapelTesoura
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
            btn_Pedra = new Button();
            Btn_Papel = new Button();
            btn_Tesoura = new Button();
            textBox1 = new TextBox();
            label_EscolhadaMaquina = new Label();
            label2 = new Label();
            label_Usuario = new Label();
            label_Computador = new Label();
            label_Resultado = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label_EscolhadoUsuario = new Label();
            Text_Resultado = new TextBox();
            SuspendLayout();
            // 
            // btn_Pedra
            // 
            btn_Pedra.Location = new Point(192, 142);
            btn_Pedra.Name = "btn_Pedra";
            btn_Pedra.Size = new Size(112, 34);
            btn_Pedra.TabIndex = 0;
            btn_Pedra.Text = "Pedra";
            btn_Pedra.UseVisualStyleBackColor = true;
            btn_Pedra.Click += button1_Click;
            // 
            // Btn_Papel
            // 
            Btn_Papel.Location = new Point(333, 142);
            Btn_Papel.Name = "Btn_Papel";
            Btn_Papel.Size = new Size(112, 34);
            Btn_Papel.TabIndex = 1;
            Btn_Papel.Text = "Papel";
            Btn_Papel.UseVisualStyleBackColor = true;
            Btn_Papel.Click += Btn_Papel_Click;
            // 
            // btn_Tesoura
            // 
            btn_Tesoura.Location = new Point(471, 142);
            btn_Tesoura.Name = "btn_Tesoura";
            btn_Tesoura.Size = new Size(112, 34);
            btn_Tesoura.TabIndex = 2;
            btn_Tesoura.Text = "Tesoura";
            btn_Tesoura.UseVisualStyleBackColor = true;
            btn_Tesoura.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(310, 208);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 31);
            textBox1.TabIndex = 3;
            // 
            // label_EscolhadaMaquina
            // 
            label_EscolhadaMaquina.AutoSize = true;
            label_EscolhadaMaquina.Location = new Point(124, 208);
            label_EscolhadaMaquina.Name = "label_EscolhadaMaquina";
            label_EscolhadaMaquina.Size = new Size(170, 25);
            label_EscolhadaMaquina.TabIndex = 4;
            label_EscolhadaMaquina.Text = "Escolha da máquina";
            label_EscolhadaMaquina.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(357, 9);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 5;
            label2.Text = "Placar";
            label2.Click += label2_Click;
            // 
            // label_Usuario
            // 
            label_Usuario.AutoSize = true;
            label_Usuario.Location = new Point(210, 63);
            label_Usuario.Name = "label_Usuario";
            label_Usuario.Size = new Size(77, 25);
            label_Usuario.TabIndex = 6;
            label_Usuario.Text = "Usuário ";
            label_Usuario.Click += label_Usuario_Click;
            // 
            // label_Computador
            // 
            label_Computador.AutoSize = true;
            label_Computador.Location = new Point(469, 63);
            label_Computador.Name = "label_Computador";
            label_Computador.Size = new Size(114, 25);
            label_Computador.TabIndex = 7;
            label_Computador.Text = "Computador";
            // 
            // label_Resultado
            // 
            label_Resultado.AutoSize = true;
            label_Resultado.Location = new Point(160, 362);
            label_Resultado.Name = "label_Resultado";
            label_Resultado.Size = new Size(90, 25);
            label_Resultado.TabIndex = 9;
            label_Resultado.Text = "Resultado";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(192, 91);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(122, 31);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(461, 91);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(122, 31);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(310, 282);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(273, 31);
            textBox4.TabIndex = 12;
            // 
            // label_EscolhadoUsuario
            // 
            label_EscolhadoUsuario.AutoSize = true;
            label_EscolhadoUsuario.Location = new Point(124, 288);
            label_EscolhadoUsuario.Name = "label_EscolhadoUsuario";
            label_EscolhadoUsuario.Size = new Size(163, 25);
            label_EscolhadoUsuario.TabIndex = 13;
            label_EscolhadoUsuario.Text = "Escolha do Usuário";
            // 
            // Text_Resultado
            // 
            Text_Resultado.Enabled = false;
            Text_Resultado.Location = new Point(310, 356);
            Text_Resultado.Name = "Text_Resultado";
            Text_Resultado.Size = new Size(273, 31);
            Text_Resultado.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Text_Resultado);
            Controls.Add(label_EscolhadoUsuario);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label_Resultado);
            Controls.Add(label_Computador);
            Controls.Add(label_Usuario);
            Controls.Add(label2);
            Controls.Add(label_EscolhadaMaquina);
            Controls.Add(textBox1);
            Controls.Add(btn_Tesoura);
            Controls.Add(Btn_Papel);
            Controls.Add(btn_Pedra);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Pedra;
        private Button Btn_Papel;
        private Button btn_Tesoura;
        private TextBox textBox1;
        private Label label_EscolhadaMaquina;
        private Label label2;
        private Label label_Usuario;
        private Label label_Computador;
        private Label label_Resultado;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label_EscolhadoUsuario;
        private TextBox Text_Resultado;
    }
}