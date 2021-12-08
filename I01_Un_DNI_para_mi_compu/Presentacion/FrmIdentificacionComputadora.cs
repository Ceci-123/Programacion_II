using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }

        private void FrmIdentificacionComputadora_Load(object sender, System.EventArgs e)
        {
            this.Text = $"compu de {System.Environment.UserName}";
            ConfigurarLogoSistemaOperativo();
            lblSistemaOperativo.Text = $"sistema operativo {System.Environment.OSVersion}";
            lblNombreMaquina.Text = $"nombre de la maquina {System.Environment.MachineName}";
            ConfigurarArquitectura();
            lblCantProcesadores.Text = $"Cant. procesadores {System.Environment.ProcessorCount} procesadores lógicos";
            ConfigurarEspacioTotalYDisponible();
        }

        private void ConfigurarLogoSistemaOperativo()
        {
            if (System.OperatingSystem.IsWindows())
            {
                picboxSistemaOperativo.Image = Properties.Resources.windows;
            }
            else if (System.OperatingSystem.IsLinux())
            {
                picboxSistemaOperativo.Image = Properties.Resources.linux;
            }
            else
            {
                picboxSistemaOperativo.Image = Properties.Resources.mac;
            }
        }
        private void ConfigurarArquitectura()
        {
            if (System.Environment.Is64BitOperatingSystem is true)
            {
                lblArquitectura.Text = "Arquitectura: 64 bits";
            }
            else
            {
                lblArquitectura.Text = "Arquitectura: 32 bits";
            }
        }

        private void ConfigurarEspacioTotalYDisponible()
        {
            long total = 0;
            long libre = 0;
            foreach (DriveInfo unidad in DriveInfo.GetDrives())
            {
                libre += unidad.TotalFreeSpace;
                total += unidad.TotalSize;
            }

            lblEspacioTotal.Text = $"Espacio total: {total.ToString() } ";
            lblEspacioDisponible.Text = $"Espacio disponible: {libre.ToString() } ";
        }
    }
}
