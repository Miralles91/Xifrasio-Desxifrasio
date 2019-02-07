using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace DesgenerarFitxers
{
    public partial class FrmDesxifasio : Form
    {
        public FrmDesxifasio()
        {
            InitializeComponent();
        }
        private void crearFitxers()
        {
            string rutaMirallesTonto = "C:\\Users\\admin\\source\\repos\\GenerarFitxers\\Fitxers\\Dessifra\\Huilaliem.txt";
            String[] Codinumero = new String[1000000];
            for (int i = 1; i < 5; i++)
            {
                DesxifrarNumLletra(i, Codinumero);
            }
            concatArxius(rutaMirallesTonto);

            for (int z = 1; z < 5; z++)
            {

                File.Delete("C:\\Users\\admin\\source\\repos\\GenerarFitxers\\Fitxers\\Dessifra\\HUILALIEM" + z + ".txt");
            }
        }
        public string[] CodiLletra()
        {
            SqlConnection connexxion = new SqlConnection();
            connexxion.ConnectionString = ConfigurationManager.ConnectionStrings["RepublicSystemConnectionString"].ConnectionString;
            connexxion.Open();

            DataSet dtsCli = new DataSet();

            string query = "SELECT Numbers from InnerEncryptionData where IdInnerEncryption = 24"; // and b.Day = '" + Convert.ToDateTime(DateTime.Today).ToString("yyyy-MM-dd") + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connexxion);
            adapter.Fill(dtsCli);

            string[] LletraCodi = new string[26];

            for (int i = 0; i < LletraCodi.Length; i++)
            {
                LletraCodi[i] = dtsCli.Tables[0].Rows[i][0].ToString();

            }
              
            return LletraCodi;
        }

        private void DesxifrarNumLletra(int z, string[] Codinumero)
        {
            string[] numeroCodi = new string[26];
            numeroCodi = CodiLletra();
            String[] lletres = new String[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

            string rutaFitxerDesgen = "C:\\Users\\admin\\source\\repos\\GenerarFitxers\\Fitxers\\Arxiu" + z + ".txt";
            string rutaFitxer = "C:\\Users\\admin\\source\\repos\\GenerarFitxers\\Fitxers\\Dessifra\\HUILALIEM"+z+".txt";
           
            StreamWriter XifratNums = new StreamWriter(rutaFitxer);

            int j = 0, t = 4;
            string cadena, cad;
            bool verifica = false;
            cadena = File.ReadAllText(rutaFitxerDesgen);
            for (int i = 0; i < Codinumero.Length; i++)
            {
                cad = cadena.Substring(j, t);

                for (int x = 0; x < numeroCodi.Length; x++)
                {
                        if (numeroCodi[x].Equals(cad))
                        {
                            XifratNums.Write(lletres[x]);
                        x = 26;
                        }
                }
                j += 4;
            }
            
            XifratNums.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            crearFitxers();
            MessageBox.Show("Has generat una moguda que flipas");
        }

        public void concatArxius(string ruta)
        {
            string A1 = File.ReadAllText("C:\\Users\\admin\\source\\repos\\GenerarFitxers\\Fitxers\\Dessifra\\HUILALIEM1.txt");
            string A2 = File.ReadAllText("C:\\Users\\admin\\source\\repos\\GenerarFitxers\\Fitxers\\Dessifra\\HUILALIEM2.txt");
            string A3 = File.ReadAllText("C:\\Users\\admin\\source\\repos\\GenerarFitxers\\Fitxers\\Dessifra\\HUILALIEM3.txt");
            string A4 = File.ReadAllText("C:\\Users\\admin\\source\\repos\\GenerarFitxers\\Fitxers\\Dessifra\\HUILALIEM4.txt");

            File.WriteAllText(ruta, A1 + A2 + A3 + A4);
        }
        
    }
}
