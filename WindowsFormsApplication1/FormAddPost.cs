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

namespace WindowsFormsApplication1 {
	public partial class FormAddPost : Form {
		public FormAddPost() {
			InitializeComponent();
		}

		private void btnAddPost_Click(object sender, EventArgs e) {
			mylib ml = new mylib();
			string postname = tbPostName.Text;
			int insertResult = ml.insert("INSERT INTO Posts (post) VALUES ('" + postname + "')");
			this.Close();
		}

		private void FormAddPost_Load(object sender, EventArgs e) {
			
		}
	}
}
