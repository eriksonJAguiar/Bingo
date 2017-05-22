namespace Bingo
{
    partial class Bingo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bingo));
            this.panel_Principal = new System.Windows.Forms.Panel();
            this.confBingo = new System.Windows.Forms.GroupBox();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.btn_entraJogo = new System.Windows.Forms.Button();
            this.label_jogador = new System.Windows.Forms.Label();
            this.label_porta = new System.Windows.Forms.Label();
            this.label_ip = new System.Windows.Forms.Label();
            this.textBox_porta = new System.Windows.Forms.TextBox();
            this.textBox_jogador = new System.Windows.Forms.TextBox();
            this.panel_Principal.SuspendLayout();
            this.confBingo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Principal
            // 
            this.panel_Principal.Controls.Add(this.confBingo);
            this.panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Principal.Location = new System.Drawing.Point(0, 0);
            this.panel_Principal.Name = "panel_Principal";
            this.panel_Principal.Size = new System.Drawing.Size(480, 457);
            this.panel_Principal.TabIndex = 0;
            // 
            // confBingo
            // 
            this.confBingo.Controls.Add(this.textBox_jogador);
            this.confBingo.Controls.Add(this.textBox_porta);
            this.confBingo.Controls.Add(this.textBox_ip);
            this.confBingo.Controls.Add(this.btn_entraJogo);
            this.confBingo.Controls.Add(this.label_jogador);
            this.confBingo.Controls.Add(this.label_porta);
            this.confBingo.Controls.Add(this.label_ip);
            this.confBingo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confBingo.Location = new System.Drawing.Point(12, 12);
            this.confBingo.Name = "confBingo";
            this.confBingo.Size = new System.Drawing.Size(456, 433);
            this.confBingo.TabIndex = 1;
            this.confBingo.TabStop = false;
            this.confBingo.Text = "Configuração do Bingo";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(146, 96);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(151, 26);
            this.textBox_ip.TabIndex = 4;
            // 
            // btn_entraJogo
            // 
            this.btn_entraJogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_entraJogo.Location = new System.Drawing.Point(146, 288);
            this.btn_entraJogo.Name = "btn_entraJogo";
            this.btn_entraJogo.Size = new System.Drawing.Size(151, 60);
            this.btn_entraJogo.TabIndex = 3;
            this.btn_entraJogo.Text = "Entra no Jogo";
            this.btn_entraJogo.UseVisualStyleBackColor = true;
            // 
            // label_jogador
            // 
            this.label_jogador.AutoSize = true;
            this.label_jogador.Location = new System.Drawing.Point(142, 217);
            this.label_jogador.Name = "label_jogador";
            this.label_jogador.Size = new System.Drawing.Size(155, 20);
            this.label_jogador.TabIndex = 2;
            this.label_jogador.Text = "Nome do Jogador:";
            // 
            // label_porta
            // 
            this.label_porta.AutoSize = true;
            this.label_porta.Location = new System.Drawing.Point(142, 142);
            this.label_porta.Name = "label_porta";
            this.label_porta.Size = new System.Drawing.Size(57, 20);
            this.label_porta.TabIndex = 1;
            this.label_porta.Text = "Porta:";
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.Location = new System.Drawing.Point(142, 73);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(31, 20);
            this.label_ip.TabIndex = 0;
            this.label_ip.Text = "IP:";
            // 
            // textBox_porta
            // 
            this.textBox_porta.Location = new System.Drawing.Point(146, 165);
            this.textBox_porta.Name = "textBox_porta";
            this.textBox_porta.Size = new System.Drawing.Size(151, 26);
            this.textBox_porta.TabIndex = 5;
            // 
            // textBox_jogador
            // 
            this.textBox_jogador.Location = new System.Drawing.Point(146, 240);
            this.textBox_jogador.Name = "textBox_jogador";
            this.textBox_jogador.Size = new System.Drawing.Size(151, 26);
            this.textBox_jogador.TabIndex = 6;
            // 
            // Bingo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 457);
            this.Controls.Add(this.panel_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bingo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bingo";
            this.panel_Principal.ResumeLayout(false);
            this.confBingo.ResumeLayout(false);
            this.confBingo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Principal;
        private System.Windows.Forms.GroupBox confBingo;
        private System.Windows.Forms.Label label_jogador;
        private System.Windows.Forms.Label label_porta;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Button btn_entraJogo;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_jogador;
        private System.Windows.Forms.TextBox textBox_porta;
    }
}

