namespace WindowsFormsApplication1 {
	partial class FormNewUserCard {
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
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this._btnOpenImage = new System.Windows.Forms.Button();
			this.tbFatherName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbPosts = new System.Windows.Forms.ComboBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.database1DataSet = new WindowsFormsApplication1.Database1DataSet();
			this.typeSecure = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbTabelNum = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.listObjects = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnAddRecord = new System.Windows.Forms.Button();
			this.btnAddRecordAndPrint = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.insertRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.printCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.insertAndCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewPostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.objectsTableAdapter = new WindowsFormsApplication1.Database1DataSetTableAdapters.objectsTableAdapter();
			this.objectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.oidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.objectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.objectsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.tbFatherName);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tbFirstName);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbLastName);
			this.groupBox1.Location = new System.Drawing.Point(12, 37);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(557, 218);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Персональные данные";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.pictureBox1);
			this.groupBox3.Controls.Add(this._btnOpenImage);
			this.groupBox3.Location = new System.Drawing.Point(256, 22);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(285, 182);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = " Фотография ";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(134, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(120, 150);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// _btnOpenImage
			// 
			this._btnOpenImage.Location = new System.Drawing.Point(23, 146);
			this._btnOpenImage.Name = "_btnOpenImage";
			this._btnOpenImage.Size = new System.Drawing.Size(86, 23);
			this._btnOpenImage.TabIndex = 4;
			this._btnOpenImage.Text = "Открыть";
			this._btnOpenImage.UseVisualStyleBackColor = true;
			this._btnOpenImage.Click += new System.EventHandler(this._btnOpenImage_Click);
			// 
			// tbFatherName
			// 
			this.tbFatherName.Location = new System.Drawing.Point(24, 131);
			this.tbFatherName.Name = "tbFatherName";
			this.tbFatherName.Size = new System.Drawing.Size(193, 20);
			this.tbFatherName.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Отчество";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Имя";
			// 
			// tbFirstName
			// 
			this.tbFirstName.Location = new System.Drawing.Point(24, 86);
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(193, 20);
			this.tbFirstName.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Фамилия";
			// 
			// tbLastName
			// 
			this.tbLastName.Location = new System.Drawing.Point(24, 41);
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(193, 20);
			this.tbLastName.TabIndex = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbPosts);
			this.groupBox2.Controls.Add(this.groupBox4);
			this.groupBox2.Controls.Add(this.typeSecure);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.tbTabelNum);
			this.groupBox2.Location = new System.Drawing.Point(12, 261);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(557, 303);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Профессиональные данные";
			// 
			// cbPosts
			// 
			this.cbPosts.FormattingEnabled = true;
			this.cbPosts.Location = new System.Drawing.Point(126, 59);
			this.cbPosts.Name = "cbPosts";
			this.cbPosts.Size = new System.Drawing.Size(193, 21);
			this.cbPosts.TabIndex = 6;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.checkBox2);
			this.groupBox4.Controls.Add(this.dataGridView1);
			this.groupBox4.Location = new System.Drawing.Point(6, 119);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(545, 178);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = " Объекты ";
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(21, 24);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(15, 14);
			this.checkBox2.TabIndex = 7;
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.objectDataGridViewTextBoxColumn,
            this.oidDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.objectsBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(6, 19);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.Size = new System.Drawing.Size(533, 153);
			this.dataGridView1.TabIndex = 8;
			// 
			// database1DataSet
			// 
			this.database1DataSet.DataSetName = "Database1DataSet";
			this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// typeSecure
			// 
			this.typeSecure.FormattingEnabled = true;
			this.typeSecure.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green"});
			this.typeSecure.Location = new System.Drawing.Point(126, 92);
			this.typeSecure.Name = "typeSecure";
			this.typeSecure.Size = new System.Drawing.Size(193, 21);
			this.typeSecure.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 92);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "Тип допуска";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(21, 59);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "Должность";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(21, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Табельный номер";
			// 
			// tbTabelNum
			// 
			this.tbTabelNum.Location = new System.Drawing.Point(126, 26);
			this.tbTabelNum.Name = "tbTabelNum";
			this.tbTabelNum.Size = new System.Drawing.Size(193, 20);
			this.tbTabelNum.TabIndex = 5;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Enabled = false;
			this.checkBox1.Location = new System.Drawing.Point(575, 440);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(15, 14);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.Visible = false;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// listObjects
			// 
			this.listObjects.CheckBoxes = true;
			this.listObjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.listObjects.Enabled = false;
			this.listObjects.GridLines = true;
			this.listObjects.Location = new System.Drawing.Point(575, 380);
			this.listObjects.Name = "listObjects";
			this.listObjects.Size = new System.Drawing.Size(39, 54);
			this.listObjects.TabIndex = 0;
			this.listObjects.UseCompatibleStateImageBehavior = false;
			this.listObjects.View = System.Windows.Forms.View.Details;
			this.listObjects.Visible = false;
			this.listObjects.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkObject);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "";
			this.columnHeader1.Width = 26;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "объект";
			this.columnHeader2.Width = 499;
			// 
			// btnAddRecord
			// 
			this.btnAddRecord.Location = new System.Drawing.Point(12, 570);
			this.btnAddRecord.Name = "btnAddRecord";
			this.btnAddRecord.Size = new System.Drawing.Size(89, 23);
			this.btnAddRecord.TabIndex = 9;
			this.btnAddRecord.Text = "Внести в базу";
			this.btnAddRecord.UseVisualStyleBackColor = true;
			this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
			// 
			// btnAddRecordAndPrint
			// 
			this.btnAddRecordAndPrint.Location = new System.Drawing.Point(400, 570);
			this.btnAddRecordAndPrint.Name = "btnAddRecordAndPrint";
			this.btnAddRecordAndPrint.Size = new System.Drawing.Size(169, 23);
			this.btnAddRecordAndPrint.TabIndex = 10;
			this.btnAddRecordAndPrint.Text = "Внести в базу и распечатать";
			this.btnAddRecordAndPrint.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.operationsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(581, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertRecordToolStripMenuItem,
            this.printCardToolStripMenuItem,
            this.insertAndCloseToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.fileToolStripMenuItem.Text = "Файл";
			// 
			// insertRecordToolStripMenuItem
			// 
			this.insertRecordToolStripMenuItem.Name = "insertRecordToolStripMenuItem";
			this.insertRecordToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.insertRecordToolStripMenuItem.Text = "Внести карту";
			// 
			// printCardToolStripMenuItem
			// 
			this.printCardToolStripMenuItem.Name = "printCardToolStripMenuItem";
			this.printCardToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.printCardToolStripMenuItem.Text = "Печать карты";
			// 
			// insertAndCloseToolStripMenuItem
			// 
			this.insertAndCloseToolStripMenuItem.Name = "insertAndCloseToolStripMenuItem";
			this.insertAndCloseToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.insertAndCloseToolStripMenuItem.Text = "Внести карту и закрыть";
			// 
			// operationsToolStripMenuItem
			// 
			this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewPostToolStripMenuItem,
            this.addNewObjectToolStripMenuItem});
			this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
			this.operationsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
			this.operationsToolStripMenuItem.Text = "Служебное";
			// 
			// addNewPostToolStripMenuItem
			// 
			this.addNewPostToolStripMenuItem.Name = "addNewPostToolStripMenuItem";
			this.addNewPostToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.addNewPostToolStripMenuItem.Text = "Добавить должность";
			this.addNewPostToolStripMenuItem.Click += new System.EventHandler(this.addNewPostToolStripMenuItem_Click);
			// 
			// addNewObjectToolStripMenuItem
			// 
			this.addNewObjectToolStripMenuItem.Name = "addNewObjectToolStripMenuItem";
			this.addNewObjectToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
			this.addNewObjectToolStripMenuItem.Text = "Добавить объект";
			this.addNewObjectToolStripMenuItem.Click += new System.EventHandler(this.addNewObjectToolStripMenuItem_Click);
			// 
			// colCheck
			// 
			this.colCheck.HeaderText = "";
			this.colCheck.Name = "colCheck";
			this.colCheck.Width = 40;
			// 
			// objectsTableAdapter
			// 
			this.objectsTableAdapter.ClearBeforeFill = true;
			// 
			// objectsBindingSource
			// 
			this.objectsBindingSource.DataMember = "objects";
			this.objectsBindingSource.DataSource = this.database1DataSet;
			// 
			// oidDataGridViewTextBoxColumn
			// 
			this.oidDataGridViewTextBoxColumn.DataPropertyName = "oid";
			this.oidDataGridViewTextBoxColumn.HeaderText = "oid";
			this.oidDataGridViewTextBoxColumn.Name = "oidDataGridViewTextBoxColumn";
			this.oidDataGridViewTextBoxColumn.ReadOnly = true;
			this.oidDataGridViewTextBoxColumn.Visible = false;
			// 
			// objectDataGridViewTextBoxColumn
			// 
			this.objectDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.objectDataGridViewTextBoxColumn.DataPropertyName = "object";
			this.objectDataGridViewTextBoxColumn.HeaderText = "object";
			this.objectDataGridViewTextBoxColumn.Name = "objectDataGridViewTextBoxColumn";
			// 
			// FormNewUserCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(581, 597);
			this.Controls.Add(this.listObjects);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.btnAddRecordAndPrint);
			this.Controls.Add(this.btnAddRecord);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormNewUserCard";
			this.Text = "Add new user card";
			this.Load += new System.EventHandler(this.FormNewUserCard_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.objectsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox tbFatherName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbLastName;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbTabelNum;
		private System.Windows.Forms.ComboBox typeSecure;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button _btnOpenImage;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ListView listObjects;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.Button btnAddRecord;
		private System.Windows.Forms.Button btnAddRecordAndPrint;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem insertRecordToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem printCardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem insertAndCloseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewPostToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewObjectToolStripMenuItem;
		private System.Windows.Forms.ComboBox cbPosts;
		private System.Windows.Forms.DataGridView dataGridView1;
		private Database1DataSet database1DataSet;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
		private System.Windows.Forms.DataGridViewTextBoxColumn objectDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn oidDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource objectsBindingSource;
		private Database1DataSetTableAdapters.objectsTableAdapter objectsTableAdapter;
	}
}