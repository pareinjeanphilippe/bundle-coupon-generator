using System.IO;
using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Reflection.PortableExecutable;

namespace bundle_coupon_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Fichiers texte (*.csv)|*.csv";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                List<string> lines = new List<string>();

                ClearListview1();
                int nr = 0;
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;


                    while ((line = reader.ReadLine()) != null)
                    {
                        if (nr > 0)
                        {
                            string[] values = line.Split(',');
                            ListViewItem item = new ListViewItem();
                            item.Text = values[0].Replace("\"", "");
                            item.SubItems.Add(values[1].Replace("\"", ""));
                            item.Checked = true;
                            listView1.Items.Add(item);
                        }
                        nr++;
                    }
                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearListview1();
            comboBox1.SelectedIndex = 1;

            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Value = new DateTime(2023, 5, 12, 0, 0, 0);

        }

        private void ClearListview1()
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("Id", 100);
            listView1.Columns.Add("Formation", -2);
            listView1.CheckBoxes = true;

        }

        private void SelectNone_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = false;
            }
        }

        private void SelectAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Fichier CSV|*.csv|Tous les fichiers|*.*";
            saveFileDialog1.FileName = txtCodeCoupon.Text + ".csv";


            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;

            using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName, false))
            {

                writer.WriteLine("course_id,coupon_type,coupon_code,start_date,start_time,custom_price");
            }

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked)
                {
                    //Id du coupon
                    var id = int.Parse(item.SubItems[0].Text);

                    //Titre de la formation
                    string titre = item.SubItems[1].Text;

                    //Date
                    DateTime date = dateTimePicker1.Value;
                    string year = date.ToString("yyyy");
                    string month = date.ToString("MM");
                    string day = date.ToString("dd");
                    string formattedDate = year + "-" + month + "-" + day;

                    //heure
                    string time = dateTimePicker2.Value.ToString("HH:mm");

                    //Verification validitée code coupon
                    string message = "Le texte doit comporter entre 6 et 20 caractères et contenir uniquement des caractères alphanumériques (A-Z, 0-9), des points (« . »), des tirets simples (« - ») ou des barres de soulignement (« _ »)";
                    if (!ValidateTextbox(txtCodeCoupon.Text))
                    {
                        MessageBox.Show(message, "Code coupon interdit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    //Verification validitée du custom price
                    if (!Regex.IsMatch(txtCustomPrice.Text, @"^\d+(\.\d{1,2})?$") && comboBox1.Text == "custom_price")
                    {
                        MessageBox.Show("Veuillez saisir un nombre décimal avec un point comme séparateur et limité à deux chiffres après la virgule", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string customPrice = txtCustomPrice.Text;

                    if (!customPrice.Contains("."))
                    {
                        customPrice += ".00";
                    }
                    else if (customPrice.IndexOf(".") == customPrice.Length - 2)
                    {
                        customPrice += "0";
                    }

                    if (comboBox1.Text != "custom_price") customPrice = "";

                    //Enregistremetn du fichier csv
                    string filename = saveFileDialog1.FileName;


                    using (StreamWriter writer = new StreamWriter(filename, true))
                    {
                        writer.WriteLine("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}", ",", id, comboBox1.Text, txtCodeCoupon.Text, formattedDate, time, customPrice);
                    }
                }
            }
        }

        private bool ValidateTextbox(string text)
        {
            // Vérifier que le texte a une longueur entre 6 et 20 caractères
            if (text.Length < 6 || text.Length > 20)
            {
                return false;
            }

            // Vérifier que le texte ne contient que des caractères alphanumériques, des points, des tirets ou des underscores
            string pattern = "^[a-zA-Z0-9._-]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(text);
        }

        private void txtCodeCoupon_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateTextbox(txtCodeCoupon.Text))
            {
                txtCodeCoupon.BackColor = Color.Tomato;
            }
            else
            {
                txtCodeCoupon.BackColor = Color.LightGreen;
            }
        }

        private void txtCustomPrice_TextChanged(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(txtCustomPrice.Text, @"^\d+(\.\d{1,2})?$"))
            {
                txtCustomPrice.BackColor = Color.Tomato;

            }
            else
            {
                txtCustomPrice.BackColor = Color.LightGreen;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() != "custom_price")
            {
                txtCustomPrice.Enabled = false;
            }
            else
            {
                txtCustomPrice.Enabled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}