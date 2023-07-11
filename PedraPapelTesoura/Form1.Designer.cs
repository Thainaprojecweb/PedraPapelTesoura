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
            label1 = new Label();
            bnt_pedra = new Button();
            bnt_tesoura = new Button();
            bnt_papel = new Button();
            text_maquina = new TextBox();
            label2 = new Label();
            resultado = new Label();
            label3 = new Label();
            label4 = new Label();
            placarMaquina = new TextBox();
            placarUsuario = new TextBox();
            label5 = new Label();
            text_usuario = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 45);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // bnt_pedra
            // 
            bnt_pedra.Location = new Point(12, 137);
            bnt_pedra.Name = "bnt_pedra";
            bnt_pedra.Size = new Size(112, 34);
            bnt_pedra.TabIndex = 1;
            bnt_pedra.Text = "Pedra";
            bnt_pedra.UseVisualStyleBackColor = true;
            bnt_pedra.Click += bnt_pedra_Click;
            // 
            // bnt_tesoura
            // 
            bnt_tesoura.Location = new Point(248, 137);
            bnt_tesoura.Name = "bnt_tesoura";
            bnt_tesoura.Size = new Size(112, 34);
            bnt_tesoura.TabIndex = 2;
            bnt_tesoura.Text = "Tesoura";
            bnt_tesoura.UseVisualStyleBackColor = true;
            bnt_tesoura.Click += bnt_tesoura_Click;
            // 
            // bnt_papel
            // 
            bnt_papel.Location = new Point(130, 137);
            bnt_papel.Name = "bnt_papel";
            bnt_papel.Size = new Size(112, 34);
            bnt_papel.TabIndex = 3;
            bnt_papel.Text = "Papel";
            bnt_papel.UseVisualStyleBackColor = true;
            bnt_papel.Click += bnt_papel_Click;
            // 
            // text_maquina
            // 
            text_maquina.Enabled = false;
            text_maquina.Location = new Point(192, 205);
            text_maquina.Name = "text_maquina";
            text_maquina.Size = new Size(150, 31);
            text_maquina.TabIndex = 4;
            text_maquina.TextChanged += text_maquina_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 208);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 5;
            label2.Text = "Escolha da Máquina:";
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(65, 308);
            resultado.Name = "resultado";
            resultado.Size = new Size(33, 25);
            resultado.TabIndex = 6;
            resultado.Text = "---";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(109, 9);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 7;
            label3.Text = "PLACAR";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(192, 45);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 8;
            label4.Text = "Computador";
            label4.Click += label4_Click;
            // 
            // placarMaquina
            // 
            placarMaquina.Enabled = false;
            placarMaquina.Location = new Point(205, 73);
            placarMaquina.Name = "placarMaquina";
            placarMaquina.Size = new Size(78, 31);
            placarMaquina.TabIndex = 9;
            placarMaquina.Text = "0";
            placarMaquina.TextAlign = HorizontalAlignment.Center;
            // 
            // placarUsuario
            // 
            placarUsuario.Enabled = false;
            placarUsuario.Location = new Point(34, 73);
            placarUsuario.Name = "placarUsuario";
            placarUsuario.Size = new Size(64, 31);
            placarUsuario.TabIndex = 10;
            placarUsuario.Text = "0";
            placarUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 245);
            label5.Name = "label5";
            label5.Size = new Size(167, 25);
            label5.TabIndex = 12;
            label5.Text = "Escolha do Usuário:";
            // 
            // text_usuario
            // 
            text_usuario.Enabled = false;
            text_usuario.Location = new Point(192, 242);
            text_usuario.Name = "text_usuario";
            text_usuario.Size = new Size(150, 31);
            text_usuario.TabIndex = 11;
            text_usuario.TextChanged += text_usuario_TextChanged;
            // 
            // Form1
            // 
            AcceptButton = bnt_papel;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(text_usuario);
            Controls.Add(placarUsuario);
            Controls.Add(placarMaquina);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(resultado);
            Controls.Add(label2);
            Controls.Add(text_maquina);
            Controls.Add(bnt_papel);
            Controls.Add(bnt_tesoura);
            Controls.Add(bnt_pedra);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bnt_pedra;
        private Button bnt_tesoura;
        private Button bnt_papel;
        private TextBox text_maquina;
        private Label label2;
        private Label resultado;
        private Label label3;
        private Label label4;
        private TextBox placarMaquina;
        private TextBox placarUsuario;
        private Label label5;
        private TextBox text_usuario;
    }
}