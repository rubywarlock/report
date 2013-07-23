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

namespace WindowsFormsApplication1{
	public partial class Form1 : Form{
		public Form1(){
			InitializeComponent();
		}

		private void listchecked() {
			//string str;
			//1//ListView.CheckedListViewItemCollection checkedItems = listView1.CheckedItems;
			//1
			/*foreach (ListViewItem item in checkedItems) {
				str = item.SubItems[1].Text + ' ' + item.SubItems[2].Text;
				listBox1.Items.Add(str);
			}*/
			//foreach (ListViewItem item in listView1.CheckedItems) {
			//	str = item.SubItems[1].Text + ' ' + item.SubItems[2].Text;
			//	listBox1.Items.Add(str);
			//}
		}

		private void button1_Click(object sender, EventArgs e){
			//FastReport.Report rp = new FastReport.Report();
			
			//report1.Show();
			
			//ListViewItem lvi = new ListViewItem("");
			//lvi.SubItems.Add(textBox1.Text);
			//lvi.SubItems.Add(textBox2.Text);
			//listView1.Items.Add(lvi);
			try {
				ArrayList alMembers = new ArrayList();
				mylib ml = new mylib();

				foreach (DataGridViewRow row in dgMembers.Rows) {
					if (Convert.ToBoolean(row.Cells[0].Value) == true) {
						DataGridViewCell cell = row.Cells[1];
						alMembers.Add(cell.Value.ToString());
						string val = alMembers[(alMembers.Count - 1)].ToString();
						MessageBox.Show(val);
					}
				}
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}

		}

		private void Form1_Load(object sender, EventArgs e) {
			mylib ml = new mylib();
			SqlCeDataAdapter da;
			DataTable dt = new DataTable();

			ArrayList al = new ArrayList();

			string SQLQuery =
				"SELECT us.uid, us.fname, us.lname, us.ftname, us.tabnum, cs.type " +
				"FROM users AS us " +
				"LEFT OUTER JOIN cards AS cs ON us.uid = cs.uid ";// +
				//"WHERE (us.uid = 3)";

			//da = new SqlCeDataAdapter(cmd, ml.connectHandler);
			//da.Fill(dt);
			//dgMembers.DataSource = dt;
			
			//ml.connectHandler.Close();

			al = (ArrayList)ml.select(SQLQuery);

			foreach (object[] row in al) {

				string name = row[2].ToString() + " " + row[1].ToString() + " " + row[3].ToString();
				string uid = row[0].ToString();
				string tab = row[4].ToString();
				string chk = "";

				object[] rows = new object[] { false, uid, name, tab };
				//object[] rows = new object[] { row6 };

				dgMembers.Rows.Add(rows);
			}


			/*for (int i = 1; i < 6; i++ ) {
				ListViewItem lvi = new ListViewItem("");
				lvi.SubItems.Add("name0" + i.ToString());
				lvi.SubItems.Add("tabel0" + i.ToString());
				listView1.Items.Add(lvi);
			}*/
		}

		private void mainMenuPrintChk_Click(object sender, EventArgs e) {
			//listBox1.Items.Clear();
			/*if (listView1.CheckedItems.Count != 0) {
				listchecked();
				if (listView1.CheckedItems.Count != 0) labelResult.Text = ": " + listView1.CheckedItems.Count.ToString();
				else labelResult.Text = ": ";
			} else {labelResult.Text = ": ";}*/

			ArrayList alMembers = new ArrayList();
			ArrayList alPrintSelect = new ArrayList();
			mylib ml = new mylib();

			ml.delete("DELETE FROM PrintTable");
			bool print = false;
			foreach (DataGridViewRow row in dgMembers.Rows) {
				if (Convert.ToBoolean(row.Cells[0].Value) == true) {
					print = true;
					DataGridViewCell cell = row.Cells[1];
					alMembers.Add(cell.Value.ToString());
					string val = alMembers[(alMembers.Count - 1)].ToString();
					//MessageBox.Show(val);

					string cmd1 = "SELECT * FROM cards WHERE uid = '" + val + "'";
					alPrintSelect = (ArrayList)ml.select(cmd1);
					if (alPrintSelect.Count != 0) {
						foreach (object[] myTargetArray in alPrintSelect) {
							string cid = myTargetArray[0].ToString();
							string uid = myTargetArray[1].ToString();
							string tip = myTargetArray[2].ToString();
							string phid = myTargetArray[3].ToString();
							ml.insert("INSERT INTO PrintTable (cid,phid,uid,tip) VALUES ('" + cid + "')");
						}
					}
				}
			}

			if (print) {
				report1.Show();
			}

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e) {
			/*if (checkBox1.Checked) {
				foreach (ListViewItem item in listView1.Items) {
					item.Checked = true;
				}
			} else {
				foreach (ListViewItem item in listView1.Items) {
					item.Checked = false;
				}
			}*/
		}

		private void deleteCheckedToolStripMenuItem_Click(object sender, EventArgs e) {
			const string message = "Вы уверены что хотите удалить запись?";
			const string caption = "Подтверждение удаления";
			var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			
			if (result == DialogResult.No) {
				labelResult.Text = ": " + "No";
			}
			if (result == DialogResult.Yes) {
				listchecked();
				labelResult.Text = ": " + "Yes";
			}
		}

		private void addUserCardToolStripMenuItem_Click_1(object sender, EventArgs e) {
			FormNewUserCard fnuc = new FormNewUserCard();
			fnuc.Show();
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e) {
			if (checkBox2.Checked) {
				foreach (DataGridViewRow item in dgMembers.Rows) {
					//item.Selected = true;
					item.Cells[0].Value = true;
				}
			} else {
				foreach (DataGridViewRow item in dgMembers.Rows) {
					//item.Selected = false;
					item.Cells[0].Value = false;
				}
			}
		}
	}
}
