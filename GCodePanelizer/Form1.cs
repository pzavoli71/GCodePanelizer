using System.Text;

namespace GCodePanelizer
{
    public partial class fmGCodePanelizer : Form
    {
        public fmGCodePanelizer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numcolonne = int.Parse( txNumColonne.Text);
                int numrighe = int.Parse(txNumRighe.Text);
                double distx = double.Parse(txDistanzaX.Text);
                distx = Math.Truncate(distx * 100) / 100;

                StringBuilder st = new StringBuilder(1000000);
                int offset = 0, conta = 0;
                byte []bt = new byte[2000000];
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
                                st.Append(line + "\n");
                            }
                        }
                        using (var writer = new StreamWriter(File.OpenWrite(@"c:\\temp\\pannello_gcode.gcode"), Encoding.UTF8))
                        { 
                            for (int i = 0; i < numrighe; i++)
                            {
                                for (int j = 0; j < numcolonne; j++)
                                {
                                    writer.WriteLine(";Pannello " + i + " " + j);
                                    if (! (j == 0)) 
                                        writer.WriteLine("G0 X" + distx + " Y0");
                                    writer.WriteLine("G92 X0 Y0");
                                    writer.Write(st.ToString());
                                }
                                writer.WriteLine("G0 X-" + (distx * numcolonne) + " Y" + (distx * 2));
                            }
                        }
                    }
                    
                }
            } catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }
    }
}
