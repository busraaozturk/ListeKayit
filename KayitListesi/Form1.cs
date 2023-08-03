using System.Data;
using System.Data.SqlClient;

namespace Araba
{
    public partial class Form1 : Form
    {
        string connection = @"Data Source=(localdb);Initial Catalog=Araba;Integrated Security=SSPI;";
        int secilenMarkaTipi = 0;
        int secilenModelTipi = 0;
        int secilenKasaTipi = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MarkaGetir();
            KasaGetir();

            List<Model> modellist = new List<Model>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                Model md = new Model
                {
                    ModelId = -1,
                    ModelAdi = "Model Seçiniz"
                };
                modellist.Add(md);
            }
            cmbModel.DataSource = modellist;
            cmbModel.DisplayMember = "ModelAdi";
            cmbModel.ValueMember = "ModelId";
        }

        public void MarkaGetir()
        {
            List<Marka> markalist = new List<Marka>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("Select * from Marka", conn);
                    SqlDataReader reader = command.ExecuteReader();
                    Marka m = new Marka
                    {
                        MarkaId = -1,
                        MarkaAdi = "Marka Seçiniz"
                    };
                    markalist.Add(m);
                    while (reader.Read())
                    {
                        markalist.Add(new Marka
                        {
                            MarkaId = Convert.ToInt32(reader["id"].ToString()),
                            MarkaAdi = reader["markaAdi"].ToString()
                        });
                    }
                    cmbMarka.DataSource = markalist;
                    cmbMarka.DisplayMember = "MarkaAdi";
                    cmbMarka.ValueMember = "MarkaId";
                    conn.Close();
                    reader.Close();
                }
                catch (Exception ex)
                {

                }
            }

        }
        public void Model()
        {
            List<Model> modellist = new List<Model>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                Model md = new Model
                {
                    ModelId = -1,
                    ModelAdi = "Model Seçiniz"
                };
                modellist.Add(md);
            }
            cmbModel.DataSource = modellist;
            cmbModel.DisplayMember = "ModelAdi";
            cmbModel.ValueMember = "ModelId";
        }

        public void ModelGetir(int MarkaId)
        {
            List<Model> modellist = new List<Model>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("Select * from Model where MarkaId=" + MarkaId, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    Model md = new Model
                    {
                        ModelId = -1,
                        ModelAdi = "Model Seçiniz"
                    };
                    modellist.Add(md);
                    while (reader.Read())
                    {
                        modellist.Add(new Model
                        {
                            ModelId = Convert.ToInt32(reader["id"].ToString()),
                            ModelAdi = reader["ModelAdi"].ToString()
                        });
                    }
                    cmbModel.DataSource = modellist;
                    cmbModel.DisplayMember = "ModelAdi";
                    cmbModel.ValueMember = "ModelId";
                    conn.Close();
                    reader.Close();
                }
                catch (Exception ex)
                {

                }
            }
        }

        public void KasaGetir()
        {
            List<Kasa> kasalist = new List<Kasa>();
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("Select * from Kasa", conn);
                    SqlDataReader reader = command.ExecuteReader();
                    Kasa k = new Kasa
                    {
                        KasaId = -1,
                        KasaAdi = "Kasa Tipi Seçiniz"
                    };
                    kasalist.Add(k);
                    while (reader.Read())
                    {
                        kasalist.Add(new Kasa
                        {
                            KasaId = Convert.ToInt32(reader["id"].ToString()),
                            KasaAdi = reader["KasaTipi"].ToString()
                        });
                    }
                    cmbKasa.DataSource = kasalist;
                    cmbKasa.DisplayMember = "KasaAdi";
                    cmbKasa.ValueMember = "KasaId";
                    conn.Close();
                    reader.Close();
                }
                catch (Exception ex)
                {

                }
            }

        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            Marka mark = (Marka)cmbMarka.SelectedItem;
            secilenMarkaTipi = mark.MarkaId;
            if (secilenMarkaTipi > 0)
            {
                ModelGetir(secilenMarkaTipi);
            }

        }

        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Model model = (Model)cmbModel.SelectedItem;
            secilenModelTipi = model.ModelId;
        }

        private void cmbKasa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kasa kasa = (Kasa)cmbKasa.SelectedItem;
            secilenKasaTipi = kasa.KasaId;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    //SqlCommand command = new SqlCommand("insert into Araba(MarkaId,ModelId,KasaId,kapisayisi,penceresayisi) " +
                    //    "values('" + secilenMarkaTipi + "','" + secilenModelTipi + "','" + secilenKasaTipi + "'," +
                    //    "'" + txtKapiSayisi.Text + "','" + txtPencereSayisi.Text + "')", conn);
                    //int etkilenenKayitSayis = command.ExecuteNonQuery();
                    SqlCommand command = new SqlCommand("INSERT INTO Araba(MarkId, ModelId, KasaId, kapisayisi, penceresayisi) " +
                    "VALUES(@MarkaId, @ModelId, @KasaId, @KapiSayisi, @PencereSayisi)", conn);

                    // Parametreleri ekleyin ve uygun türleri belirtin (SQL enjeksiyonunu önlemek için).
                    command.Parameters.AddWithValue("@MarkaId", secilenMarkaTipi.ToString());
                    command.Parameters.AddWithValue("@ModelId", secilenModelTipi);
                    command.Parameters.AddWithValue("@KasaId", secilenKasaTipi);
                    command.Parameters.AddWithValue("@KapiSayisi", txtKapiSayisi.Text);
                    command.Parameters.AddWithValue("@PencereSayisi", txtPencereSayisi.Text);


                    int etkilenenKayitSayisi = command.ExecuteNonQuery();
                    if (etkilenenKayitSayisi > 0)
                    {

                        // Verileri çeken kýsým (ArabaGetir metodu çaðýrýlabilir)
                        ArabaGetir();

                    }
                    conn.Close();

                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
        }

        public void ArabaGetir()
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                string sorgu = "Select Marka.MarkaAdi as Marka,Model.ModelAdi as Model, " +
                    "K.KasaTipi as Kasa,A.KapiSayisi as 'Kapý Sayýsý' ,A.PencereSayisi as 'Pencere Sayýsý' " +
                    "from Araba as A inner join Marka on Marka.id = A.MarkId inner join Model on Model.id = A.ModelId " +
                    "inner join Kasa K on K.id = A.KasaID";

                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Araba");
                dgwSiparisVerilen.DataSource = ds.Tables[0];
                conn.Close();
            }
        }
    }
}
