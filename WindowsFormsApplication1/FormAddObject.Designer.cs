namespace WindowsFormsApplication1 {
	partial class FormAddObject {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.btnAddObject = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbObjectName = new System.Windows.Forms.TextBox();
			this.objectsTableAdapter1 = new WindowsFormsApplication1.Database1DataSetTableAdapters.objectsTableAdapter();
			this.database1DataSet1 = new WindowsFormsApplication1.Database1DataSet();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAddObject
			// 
			this.btnAddObject.Location = new System.Drawing.Point(28, 58);
			this.btnAddObject.Name = "btnAddObject";
			this.btnAddObject.Size = new System.Drawing.Size(75, 23);
			this.btnAddObject.TabIndex = 5;
			this.btnAddObject.Text = "Добавить";
			this.btnAddObject.UseVisualStyleBackColor = true;
			this.btnAddObject.Click += new System.EventHandler(this.btnAddObject_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(135, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Наименование объекта";
			// 
			// tbObjectName
			// 
			this.tbObjectName.Location = new System.Drawing.Point(12, 32);
			this.tbObjectName.Name = "tbObjectName";
			this.tbObjectName.Size = new System.Drawing.Size(299, 22);
			this.tbObjectName.TabIndex = 3;
			// 
			// objectsTableAdapter1
			// 
			this.objectsTableAdapter1.ClearBeforeFill = true;
			// 
			// database1DataSet1
			// 
			this.database1DataSet1.DataSetName = "Database1DataSet";
			this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// FormAddObject
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(326, 96);
			this.Controls.Add(this.btnAddObject);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbObjectName);
			this.Name = "FormAddObject";
			this.Text = "Добавление нового объекта";
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnAddObject;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbObjectName;
		public Database1DataSetTableAdapters.objectsTableAdapter objectsTableAdapter1;
		private Database1DataSet database1DataSet1;
	}
}