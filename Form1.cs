using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
using System.IO;
//using System.Data.Common;

namespace Assistant_VI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Inicjalizacja
        string polazno_mesto = null;
        string dolazno_mesto = null;

        bool polazno_marker = false;
        bool dolazno_marker = false;

        bool marker_iz_za = false;

        string datum_i_vreme = null;


        private void button_Send1_Click(object sender, EventArgs e)
        {
            string[] niz_reci = textBox_You.Text.Split(' ');

            Pretrazivanje(niz_reci);

            // Pogrešan unos
            if (polazno_mesto == null && dolazno_mesto == null)
            {
                listBox_History.Items.Add("YOU:  " + textBox_You.Text);
                listBox_History.Items.Add("ASSISTANT:  Nisam Vas razumeo.");
                listBox_History.Items.Add("\n");

                label_Assistant.Text = "Nisam Vas razumeo. Da li možete da ponovite?";
            }

            // Uneto je polazno i dolazno mesto
            if (polazno_mesto != null && dolazno_mesto != null)
            {
                listBox_History.Items.Add("YOU:  " + textBox_You.Text);
                listBox_History.Items.Add("ASSISTANT:  Kada želite da krenete?");
                listBox_History.Items.Add("\n");

                label_Assistant.Text = "Kada želite da krenete?";

                comboBox_Assistant.Visible = true;
                comboBox_Assistant.SelectedIndex = 0;

                button_Send2.Visible = true;

                Baza_Select();
            }

            // Uneto je samo polazno mesto
            else if (polazno_mesto != null && dolazno_mesto == null)
            {
                listBox_History.Items.Add("YOU: " + textBox_You.Text);
                listBox_History.Items.Add("ASSISTANT: Za koje mesto želite da letite?");
                listBox_History.Items.Add("\n");

                label_Assistant.Text = "Za koje mesto želite da letite?";

                polazno_marker = true;
            }

            // Uneto je samo dolazno mesto
            else if (polazno_mesto == null && dolazno_mesto != null)
            {
                listBox_History.Items.Add("YOU: " + textBox_You.Text);
                listBox_History.Items.Add("ASSISTANT: Iz kojeg mesta polazite?");
                listBox_History.Items.Add("\n");

                label_Assistant.Text = "Iz kojeg mesta polazite?";

                dolazno_marker = true;

                marker_iz_za = true;
            }

            // Auto scroll
            listBox_History.SelectedIndex = listBox_History.Items.Count - 1;
            listBox_History.SelectedIndex = -1;

            textBox_You.Clear();
        }


        private void button_Send2_Click(object sender, EventArgs e)
        {
            // Uzimanje vrednosti za Termin
            datum_i_vreme = comboBox_Assistant.SelectedItem.ToString();

            listBox_History.Items.Add("YOU: " + datum_i_vreme);

            Baza_Insert();

            // Osveži tabelu u bazi
            this.rezervacijeTableAdapter.Fill(this.assistant_VI_dbDataSet.Rezervacije);

            // comboBox_Assistant - Reset
            comboBox_Assistant.Items.Clear();
            comboBox_Assistant.Items.Add("-Izaberite termin-");
            comboBox_Assistant.SelectedIndex = 0;
            comboBox_Assistant.Visible = false;

            button_Send2.Visible = false;

            polazno_mesto = null;
            dolazno_mesto = null;

            polazno_marker = false;
            dolazno_marker = false;

            marker_iz_za = false;
        }



        // Funkcija - Uzimanje vrednosti za polazno mesto
        public string Nadji_polazno_mesto(string[] niz_reci, int i3, string polazno_mesto, string dolazno_mesto)
        {
            for (int i2 = i3; i2 < niz_reci.Length; i2++)
            {
                if (string.Equals(niz_reci[i2], "iz", StringComparison.OrdinalIgnoreCase))
                {
                    // Nivo i1
                    int i1 = i2 + 1;

                    if (dolazno_mesto != null && marker_iz_za == false)
                    {
                        while (niz_reci[i1] != "za")
                        {
                            polazno_mesto += niz_reci[i1] + " ";

                            i1++;
                        }
                    }

                    else
                    {
                        while (i1 != niz_reci.Length)
                        {
                            polazno_mesto += niz_reci[i1] + " ";

                            i1++;
                        }
                    }
                }
            }

            return polazno_mesto;
        }


        // Funkcija - Uzimanje vrednosti za dolazno mesto
        public string Nadji_dolazno_mesto(string[] niz_reci, int i3, string dolazno_mesto)
        {
            for (int i2 = i3; i2 < niz_reci.Length; i2++)
            {
                if (string.Equals(niz_reci[i2], "za", StringComparison.OrdinalIgnoreCase))
                {
                    // Nivo i1
                    int i1 = i2 + 1;

                    while (i1 != niz_reci.Length)
                    {
                        dolazno_mesto += niz_reci[i1].Trim('?', '.') + " ";

                        i1++;
                    }
                }
            }

            return dolazno_mesto;
        }


        // Funkcija - Pretraživanje unetog string-a
        public void Pretrazivanje(string[] niz_reci)
        {
            // Uzimanje vrednosti za polazno i dolazno mesto
            if (polazno_marker == false && dolazno_marker == false)
            {
                // Nivo i3
                for (int i3 = 0; i3 < niz_reci.Length; i3++)
                {
                    if (string.Equals(niz_reci[i3], "letove", StringComparison.OrdinalIgnoreCase))
                    {
                        dolazno_mesto = Nadji_dolazno_mesto(niz_reci, i3, dolazno_mesto);

                        polazno_mesto = Nadji_polazno_mesto(niz_reci, i3, polazno_mesto, dolazno_mesto);
                    }
                }
            }

            // Uzimanje vrednost za dolazno mesto
            if (polazno_marker == true && dolazno_marker == false)
            {
                for (int i3 = 0; i3 < niz_reci.Length; i3++)
                {
                    if (string.Equals(niz_reci[i3], "za", StringComparison.OrdinalIgnoreCase))
                    {
                        dolazno_mesto = Nadji_dolazno_mesto(niz_reci, i3, dolazno_mesto);
                    }
                }
            }

            // Uzimanje vrednosti za polazno mesto
            if (polazno_marker == false && dolazno_marker == true)
            {
                for (int i3 = 0; i3 < niz_reci.Length; i3++)
                {
                    if (string.Equals(niz_reci[i3], "iz", StringComparison.OrdinalIgnoreCase))
                    {
                        polazno_mesto = Nadji_polazno_mesto(niz_reci, i3, polazno_mesto, dolazno_mesto);
                    }
                }
            }
        }



        // Funkcija - Uzimanje vrednosti iz baze
        public void Baza_Select()
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Assistant_VI_db.accdb");
            
            connection.Open();

            OleDbCommand command = new OleDbCommand("SELECT * FROM [" + polazno_mesto.TrimEnd(' ', 'a') + "] WHERE Dolazno_mesto= '" + dolazno_mesto + "'", connection);
           
            OleDbDataReader reader = null;
            
            reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                comboBox_Assistant.Items.Add(reader[1].ToString() + ". u " + reader[2].ToString() + " h");
            }

            connection.Close();
        }


        // Funkcija - Unošenje vrednosti u bazu
        public void Baza_Insert()
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Assistant_VI_db.accdb");

            connection.Open();

            OleDbCommand cmd = new OleDbCommand("INSERT INTO Rezervacije (Polazno_mesto, Dolazno_mesto, Termin) VALUES (@p_mesto_rez, @d_mesto_rez, @termin)", connection);


            if (connection.State == ConnectionState.Open)
            {
                cmd.Parameters.Add("@p_mesto_rez", OleDbType.VarChar).Value = polazno_mesto.TrimEnd(' ', 'a'); ;
                cmd.Parameters.Add("@d_mesto_rez", OleDbType.VarChar).Value = dolazno_mesto;
                cmd.Parameters.Add("@termin", OleDbType.VarChar).Value = datum_i_vreme;

                try
                {
                    cmd.ExecuteNonQuery();

                    listBox_History.Items.Add("ASSISTANT:  Let iz " + polazno_mesto + "za " + dolazno_mesto + "( " + datum_i_vreme + " ) je rezervisan.");
                    listBox_History.Items.Add("\n");

                    listBox_History.SelectedIndex = listBox_History.Items.Count - 1;
                    listBox_History.SelectedIndex = -1;

                    label_Assistant.Text = "Let iz " + polazno_mesto + "za " + dolazno_mesto + "( " + datum_i_vreme + " ) je rezervisan.";

                    timer1.Start();
                    timer1.Interval = 5000;

                    connection.Close();
                }

                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Source);
                    connection.Close();
                }
            }
            
            else
            {
                MessageBox.Show("Connection Failed");
            }
        }


        // Uzimanje tabele Rezervacije iz baze
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assistant_VI_dbDataSet.Rezervacije' table. You can move, or remove it, as needed.
            this.rezervacijeTableAdapter.Fill(this.assistant_VI_dbDataSet.Rezervacije);

        }


        // Deaktivacija button-a ako je prazan textBox
        private void textBox_You_TextChanged(object sender, EventArgs e)
        {
            button_Send1.Enabled = !string.IsNullOrWhiteSpace(textBox_You.Text); 
        }


        // Deaktivacija button-a ako je indeks comboBox-a postavljen na 0
        private void comboBox_Assistant_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_Send2.Enabled = !comboBox_Assistant.SelectedIndex.Equals(0);
        }


        // Brisanje sadržaja nakon 5 sekundi
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_Assistant.Text = null;
        }
    }
}
