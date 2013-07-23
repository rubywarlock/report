using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace WindowsFormsApplication1 {
	public partial class FormAddObject : Form {
		public FormAddObject() {
			InitializeComponent();
		}

		private void btnAddObject_Click(object sender, EventArgs e) {
			mylib ml = new mylib();

			string objectname = (tbObjectName.Text).ToString();
			ml.insert("Insert into Objects (object) values ('" + objectname + "');");
			this.Close();
		}

	}
}
