using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace WindowsFormsApplication1 {
	class sqlclass {

		public string connectString;
		public SqlCeConnection connectHandler;
		public SqlCeCommand commandHandler;

		public void data_base_Init() {
			string str = Path.GetDirectoryName(Application.ExecutablePath);
			str = str.Replace("\\bin\\Debug", "");
			str = str.Replace(@"\", "\\");
			string path = "Data Source=" + str + @"\Database1.sdf";
			this.connectString = path;//"Data Source=D:\\programming\\Visual Studio 2010\\C#\\WindowsFormsApplication1\\WindowsFormsApplication1\\Database1.sdf";

			string cnt_string = this.connectString;
			SqlCeConnection ccnt = new SqlCeConnection(cnt_string);
			SqlCeCommand ccmd = new SqlCeCommand();

			this.connectHandler = ccnt;
			this.commandHandler = ccmd;
			this.commandHandler.Connection = ccnt;

		}

		public int insert(string SQLQuery = "", string reIdentity = "No") {
			int insertResult = 0;
						
			if (SQLQuery != "") {
				this.commandHandler.CommandText = SQLQuery;
				this.connectHandler.Open();
				this.commandHandler.ExecuteNonQuery();

				if (reIdentity == "Yes") {
					this.commandHandler.CommandText = "Select @@Identity";
					SqlCeDataReader reader = this.commandHandler.ExecuteReader();
					while (reader.Read()) {
						string[] row1 = { reader.GetSqlDecimal(0).ToString() };
						insertResult = Convert.ToInt32(row1[0]);
					}
				}

				this.connectHandler.Close();				
			}

			return insertResult;
		}

		public int insert_image(byte[] imgData, int UserID, string reIdentity = "No") {
			int insertResult = 0;

			if (imgData != null) {
				this.commandHandler.CommandText = "INSERT INTO Photos (uid,photo) VALUES (@UID,@IMAGE)";
				this.commandHandler.Parameters.Add("@UID", UserID);
				this.commandHandler.Parameters.Add("@IMAGE", imgData);
				this.connectHandler.Open();
				this.commandHandler.ExecuteNonQuery();

				if (reIdentity == "Yes") {
					this.commandHandler.CommandText = "Select @@Identity";
					SqlCeDataReader reader = this.commandHandler.ExecuteReader();
					while (reader.Read()) {
						string[] row1 = { reader.GetSqlDecimal(0).ToString() };
						insertResult = Convert.ToInt32(row1[0]);
					}
				}

				this.connectHandler.Close();
			}

			return insertResult;
		}

		public object select(string SQLQuery = "", string Reader = "No") {
			this.connectHandler.Open();
			this.commandHandler.CommandText = SQLQuery;
			
			ArrayList al = new ArrayList();
			SqlCeDataReader reader = this.commandHandler.ExecuteReader();
			
			while(reader.Read()) {
				object[] values = new object[reader.FieldCount];
				reader.GetValues(values);
				al.Add(values);
			}

			reader.Close();
			this.connectHandler.Close();
			return al;
		}

		public void update() { }

		public void delete(string SQLQuery = "") {
			this.commandHandler.CommandText = SQLQuery;
			this.connectHandler.Open();
			this.commandHandler.ExecuteNonQuery();
			this.connectHandler.Close();
		}
	}
}

/*
			 SqlCeTransaction myTrans;
			ml.connectHandler.Open();
			myTrans = ml.connectHandler.BeginTransaction();

			ml.commandHandler.Connection = ml.connectHandler;
			ml.commandHandler.Transaction = myTrans;

			try
			{
				ml.commandHandler.CommandText = "Insert into Objects (object) values ('" + objectname + "');";
				ml.commandHandler.ExecuteNonQuery();
				myTrans.Commit();
			}
			catch (SqlCeException ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				ml.commandHandler.Dispose();
				ml.connectHandler.Close();
			}
			  
			 */
