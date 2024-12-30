using System.Text;

namespace GCodePanelizer
{
    public partial class fmGCodePanelizer : Form
    {
        public fmGCodePanelizer()
        {
            InitializeComponent();
        }

        private void btCreaPannello_Click(object sender, EventArgs e)
        {
            try
            {
                int numcolonne = int.Parse(txNumColonne.Text);
                int numrighe = int.Parse(txNumRighe.Text);
                double distx = double.Parse(txDistanzaX.Text);
                distx = Math.Truncate(distx * 100) / 100;

                string intestazione = txHeader.Text;
                string footer = txFooter.Text;
                string corpo = txCorpo.Text;

                FileDialog fd = new SaveFileDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    using (var writer = new StreamWriter(File.OpenWrite(fd.FileName), Encoding.UTF8))
                    {
                        writer.Write(intestazione);
                        for (int i = 0; i < numrighe; i++)
                        {
                            for (int j = 0; j < numcolonne; j++)
                            {
                                writer.WriteLine("\r\n;Pannello " + i + " " + j);
                                if (!(j == 0))
                                    writer.WriteLine("G0 X" + distx + " Y0");
                                writer.WriteLine("G92 X0 Y0");
                                writer.Write(corpo);
                            }
                            if ( !( i == numrighe - 1 ))
                                writer.WriteLine("G0 X-" + (distx * (numcolonne - 1)) + " Y" + (distx));
                        }
                        writer.Write("\r\n" + footer);
                    }
                }

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void btLeggiFile_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder st = new StringBuilder(1000000);
                FileDialog fd = new OpenFileDialog();
                fd.CheckFileExists = true;
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(fd.FileName))
                    {
                        using (var reader = new StreamReader(File.OpenRead(fd.FileName), Encoding.UTF8))
                        {
                            while (!reader.EndOfStream)
                            {
                                var line = reader.ReadLine();
                                st.Append(line + "\r\n");
                            }
                        }
                        txCorpo.Text = st.ToString();
                    }
                }
            } catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
