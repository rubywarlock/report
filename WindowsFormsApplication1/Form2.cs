using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using System.Collections;

namespace WindowsFormsApplication1 {
	public partial class FormNewUserCard : Form {
		public FormNewUserCard() {
			InitializeComponent();
		}

		private void textBox5_TextChanged(object sender, EventArgs e) {}

		private void _btnOpenImage_Click(object sender, EventArgs e) {
			//mylib ml = new mylib();

			OpenFileDialog imageOpen = new OpenFileDialog();
			imageOpen.Filter = "image files (*.jpg)|*.jpg|all files (*.*)|*.*";
			imageOpen.Title = "Выбор фотографии для пропуска";
			//imageOpen.InitialDirectory = "";
			if(imageOpen.ShowDialog() == DialogResult.OK){
				pictureBox1.ImageLocation = imageOpen.FileName;

				//byte[] imgData;
				//imgData = File.ReadAllBytes(pictureBox1.ImageLocation);

				/*ml.commandHandler.CommandText = "INSERT INTO Photos (photo) VALUES (@IMAGE)";
				ml.commandHandler.Parameters.Add("@IMAGE", imgData);
				ml.connectHandler.Open();
				ml.commandHandler.ExecuteNonQuery();
				ml.connectHandler.Close();*/
			}
		}

		private void btnAddRecord_Click(object sender, EventArgs e) {
			ArrayList alObjects = new ArrayList();
			mylib ml = new mylib();

			int post, UserID, PhtoID;
			byte[] imageData;

			foreach (DataGridViewRow row in dataGridView1.Rows) {
				if (Convert.ToBoolean(row.Cells[0].Value) == true) {
					DataGridViewCell cell = row.Cells[2];
					alObjects.Add(cell.Value.ToString());
					string val = alObjects[(alObjects.Count - 1)].ToString();
				}
			}

			string cbVal = cbPosts.SelectedValue.ToString();
			string typeSecureVal = typeSecure.SelectedValue.ToString();
			int typeSecureInt = Convert.ToInt32(typeSecureVal);
			//if (cbVal != null) MessageBox.Show(cbVal);
			//else MessageBox.Show("Должность не выбрана.", "Ошибка заполнения формы");
			//if (alObjects.Count == 0)	MessageBox.Show("Ни один объект допуска не выбран", "Ошибка заполнения формы");
			
 			imageData = File.ReadAllBytes(pictureBox1.ImageLocation);
			post = Convert.ToInt32(cbVal);

			string prns = "'" + tbFirstName.Text + "','" + tbLastName.Text + "','" + tbFatherName.Text + "','" + tbTabelNum.Text + "','" + post + "'";

			UserID = ml.insert("INSERT INTO users (fname,lname,ftname,tabnum,post) VALUES (" + prns + ")", "Yes");
			PhtoID = ml.insert_image(imageData, UserID, "Yes");

			//string card_column_prns = null;
			string card_values_prns = "'" + UserID + "','" + typeSecureInt + "','" + PhtoID  + "'";
			int i = 1;
			foreach (var obj in alObjects) {
				int objID = Convert.ToInt32(obj);
				//card_column_prns += ",obj0" + i.ToString();
				//card_values_prns += ",'" + objID.ToString() + "'";
				i++;
			}

			int CID = ml.insert("INSERT INTO cards (uid,type,photo) VALUES (" + card_values_prns + ")","Yes");
			ml.insert("INSERT INTO UsersObjects (uid,oid,cid) VALUES (" + card_values_prns + ",'" + CID + "')");
		}

		private void addNewObjectToolStripMenuItem_Click(object sender, EventArgs e) {
			FormAddObject fao = new FormAddObject();
			fao.Show();
		}

		private void addNewPostToolStripMenuItem_Click(object sender, EventArgs e) {
			FormAddPost fap = new FormAddPost();
			fap.Show();
		}

		private void FormNewUserCard_Load(object sender, EventArgs e) {
			// TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.objects". При необходимости она может быть перемещена или удалена.
			this.objectsTableAdapter.Fill(this.database1DataSet.objects);
			mylib ml = new mylib();
			ml.fill_posts_combobox(cbPosts);
			ml.fill_types_combobox(typeSecure);
			//ml.fill_objects_listbox(listObjects);
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e) {
			/*if (checkBox1.Checked) {
				foreach (ListViewItem item in listObjects.Items) {
					item.Checked = true;
				}
			}
			else {
				foreach (ListViewItem item in listObjects.Items) {
					item.Checked = false;
				}
			}*/
		}

		private void checkObject(object sender, ItemCheckEventArgs e) {
			//MessageBox.Show(this.listObjects.Items[e.Index].Tag.ToString());
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e) {
			if (checkBox2.Checked) {
				foreach (DataGridViewRow item in dataGridView1.Rows) {
					//item.Selected = true;
					item.Cells[0].Value = true;
				}
			} else {
				foreach (DataGridViewRow item in dataGridView1.Rows) {
					//item.Selected = false;
					item.Cells[0].Value = false;
				}
			}

		}
	}
}
