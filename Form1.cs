using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Desligar
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.Desligar, "Desliga o Computador \n * Não gasta energia \n * Boot mais demorado \n * Não salva os programas em aberto \n * Libera a mermoria");
            toolTip1.SetToolTip(this.Reiniciar, "Reinicia o Computador");
            toolTip1.SetToolTip(this.LogOff, "Fecha totalmente a sessão");
            toolTip1.SetToolTip(this.Suspender, "Estado de economia de energia que salva os programas abertos na memoria, assim reinicia mais rapido. \n * Gasta mais energia \n  * Boot mais rapido");
            toolTip1.SetToolTip(this.Hibernar, "Estado de economia de energia que salva no disco rígido os documentos e programas abertos e desliga o computador. \n * Gasta menos energia \n * Boot mais lento");
            toolTip1.SetToolTip(this.Bloquear, "Fecha a sessão, mas deixa os aplicativos abertos \n * Gasta mais energia e memória ");
            toolTip1.SetToolTip(this.ForcarBx, "Forca a operação e fecha o que esta aberto sem perguntar \n * Não desativa as atualizações do sistema, para isso deve-se deastivar nas atualizações automaticas");
        }


        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        #region Desligar
        private void Desligar_Click(object sender, EventArgs e)
        {
            if (ForcarBx.Checked)
            {
                System.Diagnostics.Process.Start("shutdown.exe", "-s -f");
            }
            else
            {
                System.Diagnostics.Process.Start("shutdown.exe", "-s");
            }

        }
        #endregion

        #region Reiniciar
        private void Reiniciar_Click(object sender, EventArgs e)
        {
            if (ForcarBx.Checked)
            {
                System.Diagnostics.Process.Start("shutdown.exe", "-r -f");
            }
            else
            {
                System.Diagnostics.Process.Start("shutdown.exe", "-r");
            }   
        }
        #endregion

        #region Log Off
        private void LogOff_Click(object sender, EventArgs e)
        {
            if (ForcarBx.Checked)
            {
                System.Diagnostics.Process.Start("shutdown.exe", "-l -f");
            }
            else
            {
                System.Diagnostics.Process.Start("shutdown.exe", "-l");
            }   
        }
        #endregion

        #region Hibernar
        private void Hibernar_Click(object sender, EventArgs e)
        {
            if (ForcarBx.Checked)
            {
                System.Diagnostics.Process.Start("rundll32.exe", "PowrProf.dll,SetSuspendState -f ");
            }
            else
            {
                System.Diagnostics.Process.Start("rundll32.exe", "PowrProf.dll,SetSuspendState ");
            }       
        }
        #endregion

        #region Suspender
        private void Suspender_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("rundll32.exe", "powrprof.dll,SetSuspendState 0,1,0");
        }
        #endregion

        #region Bloquear
        private void Bloquear_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Rundll32.exe", "User32.dll,LockWorkStation");
        }
        #endregion


        public void ForcarBx_CheckedChanged(object sender, EventArgs e)
        {
                       
        }

        private void Exemplo_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        
        }

        private void label5_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Sobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão: 1.0 \nDesenvolvido por: Guilherme Zucco \nContato: g62ucc0@hotmail.com");
        }


    }
}
