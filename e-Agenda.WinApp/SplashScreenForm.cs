using System;
using System.Windows.Forms;

namespace e_Agenda.WinApp
{
    public partial class SplashScreenForm : Form
    {
        private TelaPrincipal telaPrincipal;

        public SplashScreenForm()
        {
            InitializeComponent();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            if(progressBarCarregamento.Value < 100)
            {
                progressBarCarregamento.Value += 2;
            }
            else
            {
                telaPrincipal = new TelaPrincipal();
                
                timerSplash.Enabled = false;
                
                this.Visible = false;
                
                telaPrincipal.ShowDialog();
            }
        }
    }
}
