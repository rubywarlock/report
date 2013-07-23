using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlServerCe;
using System.Data;
using System.Collections;

namespace WindowsFormsApplication1 {
	class mylib : sqlclass{

		delegate void MyDelegate_for_objects_listbox(ListView listObjects);
		delegate void MyDelegate_for_posts_combobox(ComboBox cbPosts);

		public mylib() {
			MyDelegate_for_objects_listbox md_objects_listbox = new MyDelegate_for_objects_listbox(fill_objects_listbox);
			MyDelegate_for_posts_combobox md_posts_combobox = new MyDelegate_for_posts_combobox(fill_posts_combobox);

			this.data_base_Init();
		}

		public void fill_posts_combobox(ComboBox cbPosts) {
			this.connectHandler.Open();
			this.commandHandler.CommandText = "SELECT pid, post FROM Posts";
			SqlCeDataReader reader = this.commandHandler.ExecuteReader();

			DataTable dt = new DataTable();
			dt.Columns.Add("pid", typeof(string));
			dt.Columns.Add("post", typeof(string));
			dt.Load(reader);

			cbPosts.ValueMember = "pid";
			cbPosts.DisplayMember = "post";
			cbPosts.DataSource = dt;

			this.connectHandler.Close();
		}

		public void fill_types_combobox(ComboBox typeSecure) {
			this.connectHandler.Open();
			this.commandHandler.CommandText = "SELECT tid, type FROM Types";
			SqlCeDataReader reader = this.commandHandler.ExecuteReader();

			DataTable dt = new DataTable();
			dt.Columns.Add("tid", typeof(string));
			dt.Columns.Add("type", typeof(string));
			dt.Load(reader);

			typeSecure.ValueMember = "tid";
			typeSecure.DisplayMember = "type";
			typeSecure.DataSource = dt;

			this.connectHandler.Close();
		}

		public void fill_objects_listbox(ListView listObjects) {
			try {
				ArrayList al = (ArrayList)this.select("SELECT oid, object FROM Objects");

				foreach (object[] row in al) {
					listObjects.Items.Add("").Name = row[0].ToString();
					listObjects.Items.Add(row[0].ToString()).SubItems.Add(row[1].ToString());
				}

			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "fill_objects_listbox");
			}
		}
	}
}