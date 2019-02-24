namespace Desligar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ForcarBx = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Exemplo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Sair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bloquear = new System.Windows.Forms.Button();
            this.Suspender = new System.Windows.Forms.Button();
            this.Hibernar = new System.Windows.Forms.Button();
            this.LogOff = new System.Windows.Forms.Button();
            this.Reiniciar = new System.Windows.Forms.Button();
            this.Desligar = new System.Windows.Forms.Button();
            this.Sobre = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ForcarBx
            // 
            this.ForcarBx.AutoSize = true;
            this.ForcarBx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ForcarBx.Location = new System.Drawing.Point(99, 210);
            this.ForcarBx.Name = "ForcarBx";
            this.ForcarBx.Size = new System.Drawing.Size(56, 17);
            this.ForcarBx.TabIndex = 6;
            this.ForcarBx.Text = "Forçar";
            this.ForcarBx.UseVisualStyleBackColor = true;
            this.ForcarBx.CheckedChanged += new System.EventHandler(this.ForcarBx_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.White;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Exemplo
            // 
            this.Exemplo.AutoSize = true;
            this.Exemplo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exemplo.Location = new System.Drawing.Point(27, 92);
            this.Exemplo.Name = "Exemplo";
            this.Exemplo.Size = new System.Drawing.Size(45, 13);
            this.Exemplo.TabIndex = 7;
            this.Exemplo.Text = "Desligar";
            this.Exemplo.Click += new System.EventHandler(this.Exemplo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reiniciar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(102, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Log Off";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(102, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hibernar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(179, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Suspender";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(184, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bloquear";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(11, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Opção de Desligamento";
            // 
            // Sair
            // 
            this.Sair.BackColor = System.Drawing.Color.IndianRed;
            this.Sair.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSalmon;
            this.Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.ForeColor = System.Drawing.Color.White;
            this.Sair.Location = new System.Drawing.Point(210, -3);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(45, 23);
            this.Sair.TabIndex = 14;
            this.Sair.Text = "X";
            this.Sair.UseVisualStyleBackColor = false;
            this.Sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-4, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 36);
            this.panel1.TabIndex = 15;
            // 
            // Bloquear
            // 
            this.Bloquear.BackgroundImage = global::Desligar.Properties.Resources.Block;
            this.Bloquear.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.Bloquear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Bloquear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Bloquear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bloquear.Location = new System.Drawing.Point(182, 123);
            this.Bloquear.Name = "Bloquear";
            this.Bloquear.Size = new System.Drawing.Size(50, 50);
            this.Bloquear.TabIndex = 5;
            this.Bloquear.UseVisualStyleBackColor = true;
            this.Bloquear.Click += new System.EventHandler(this.Bloquear_Click);
            // 
            // Suspender
            // 
            this.Suspender.BackgroundImage = global::Desligar.Properties.Resources.Suspender;
            this.Suspender.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.Suspender.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Suspender.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Suspender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Suspender.Location = new System.Drawing.Point(182, 39);
            this.Suspender.Name = "Suspender";
            this.Suspender.Size = new System.Drawing.Size(50, 50);
            this.Suspender.TabIndex = 4;
            this.Suspender.UseVisualStyleBackColor = true;
            this.Suspender.Click += new System.EventHandler(this.Suspender_Click);
            // 
            // Hibernar
            // 
            this.Hibernar.BackgroundImage = global::Desligar.Properties.Resources.Hibernar;
            this.Hibernar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.Hibernar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Hibernar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Hibernar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hibernar.Location = new System.Drawing.Point(99, 39);
            this.Hibernar.Name = "Hibernar";
            this.Hibernar.Size = new System.Drawing.Size(50, 50);
            this.Hibernar.TabIndex = 3;
            this.Hibernar.UseVisualStyleBackColor = true;
            this.Hibernar.Click += new System.EventHandler(this.Hibernar_Click);
            // 
            // LogOff
            // 
            this.LogOff.BackgroundImage = global::Desligar.Properties.Resources.LogOff;
            this.LogOff.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.LogOff.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.LogOff.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.LogOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOff.Location = new System.Drawing.Point(99, 123);
            this.LogOff.Name = "LogOff";
            this.LogOff.Size = new System.Drawing.Size(50, 50);
            this.LogOff.TabIndex = 2;
            this.LogOff.UseVisualStyleBackColor = true;
            this.LogOff.Click += new System.EventHandler(this.LogOff_Click);
            // 
            // Reiniciar
            // 
            this.Reiniciar.BackgroundImage = global::Desligar.Properties.Resources.Reiniciar;
            this.Reiniciar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.Reiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Reiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Reiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reiniciar.Location = new System.Drawing.Point(22, 123);
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.Size = new System.Drawing.Size(50, 50);
            this.Reiniciar.TabIndex = 1;
            this.Reiniciar.UseVisualStyleBackColor = true;
            this.Reiniciar.Click += new System.EventHandler(this.Reiniciar_Click);
            // 
            // Desligar
            // 
            this.Desligar.BackgroundImage = global::Desligar.Properties.Resources.Desligar;
            this.Desligar.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.Desligar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.Desligar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Desligar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Desligar.Location = new System.Drawing.Point(22, 39);
            this.Desligar.Name = "Desligar";
            this.Desligar.Size = new System.Drawing.Size(50, 50);
            this.Desligar.TabIndex = 0;
            this.Desligar.UseVisualStyleBackColor = true;
            this.Desligar.Click += new System.EventHandler(this.Desligar_Click);
            // 
            // Sobre
            // 
            this.Sobre.BackColor = System.Drawing.Color.SteelBlue;
            this.Sobre.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.Sobre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateGray;
            this.Sobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.Sobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sobre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sobre.Location = new System.Drawing.Point(210, 206);
            this.Sobre.Name = "Sobre";
            this.Sobre.Size = new System.Drawing.Size(45, 23);
            this.Sobre.TabIndex = 16;
            this.Sobre.Text = "Sobre";
            this.Sobre.UseVisualStyleBackColor = false;
            this.Sobre.Click += new System.EventHandler(this.Sobre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(260, 237);
            this.Controls.Add(this.Sobre);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exemplo);
            this.Controls.Add(this.ForcarBx);
            this.Controls.Add(this.Bloquear);
            this.Controls.Add(this.Suspender);
            this.Controls.Add(this.Hibernar);
            this.Controls.Add(this.LogOff);
            this.Controls.Add(this.Reiniciar);
            this.Controls.Add(this.Desligar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opção de Desligamento";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Desligar;
        private System.Windows.Forms.Button Reiniciar;
        private System.Windows.Forms.Button LogOff;
        private System.Windows.Forms.Button Hibernar;
        private System.Windows.Forms.Button Suspender;
        private System.Windows.Forms.Button Bloquear;
        private System.Windows.Forms.CheckBox ForcarBx;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label Exemplo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Sobre;

    }
}

