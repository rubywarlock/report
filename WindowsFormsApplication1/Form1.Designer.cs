namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
					this.components = new System.ComponentModel.Container();
					this.database1DataSet1 = new WindowsFormsApplication1.Database1DataSet();
					this.buttonTest = new System.Windows.Forms.Button();
					this.contextMenu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
					this.printCheckedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
					this.textBox1 = new System.Windows.Forms.TextBox();
					this.textBox2 = new System.Windows.Forms.TextBox();
					this.label1 = new System.Windows.Forms.Label();
					this.label2 = new System.Windows.Forms.Label();
					this.menuMain = new System.Windows.Forms.MenuStrip();
					this.mainMenu = new System.Windows.Forms.ToolStripMenuItem();
					this.mainMenuPrintChk = new System.Windows.Forms.ToolStripMenuItem();
					this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
					this.deleteCheckedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
					this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
					this.addUserCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
					this.groupBox1 = new System.Windows.Forms.GroupBox();
					this.listBox1 = new System.Windows.Forms.ListBox();
					this.labelResult = new System.Windows.Forms.Label();
					this.dgMembers = new System.Windows.Forms.DataGridView();
					this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
					this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
					this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
					this.tabNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
					this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
					this.usersTableAdapter = new WindowsFormsApplication1.Database1DataSetTableAdapters.usersTableAdapter();
					this.checkBox2 = new System.Windows.Forms.CheckBox();
					((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
					this.contextMenu1.SuspendLayout();
					this.menuMain.SuspendLayout();
					this.groupBox1.SuspendLayout();
					((System.ComponentModel.ISupportInitialize)(this.dgMembers)).BeginInit();
					((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
					this.SuspendLayout();
					// 
					// database1DataSet1
					// 
					this.database1DataSet1.DataSetName = "Database1DataSet";
					this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
					// 
					// buttonTest
					// 
					this.buttonTest.Location = new System.Drawing.Point(644, 339);
					this.buttonTest.Name = "buttonTest";
					this.buttonTest.Size = new System.Drawing.Size(75, 23);
					this.buttonTest.TabIndex = 0;
					this.buttonTest.Text = "Test";
					this.buttonTest.UseVisualStyleBackColor = true;
					this.buttonTest.Click += new System.EventHandler(this.button1_Click);
					// 
					// contextMenu1
					// 
					this.contextMenu1.ImeMode = System.Windows.Forms.ImeMode.On;
					this.contextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printCheckedToolStripMenuItem});
					this.contextMenu1.Name = "contextMenu1";
					this.contextMenu1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
					this.contextMenu1.Size = new System.Drawing.Size(185, 26);
					this.contextMenu1.Text = "Main";
					// 
					// printCheckedToolStripMenuItem
					// 
					this.printCheckedToolStripMenuItem.Name = "printCheckedToolStripMenuItem";
					this.printCheckedToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
					this.printCheckedToolStripMenuItem.Text = "Печать отмеченных";
					this.printCheckedToolStripMenuItem.Click += new System.EventHandler(this.mainMenuPrintChk_Click);
					// 
					// textBox1
					// 
					this.textBox1.Location = new System.Drawing.Point(528, 69);
					this.textBox1.Name = "textBox1";
					this.textBox1.Size = new System.Drawing.Size(191, 20);
					this.textBox1.TabIndex = 2;
					// 
					// textBox2
					// 
					this.textBox2.Location = new System.Drawing.Point(528, 95);
					this.textBox2.Name = "textBox2";
					this.textBox2.Size = new System.Drawing.Size(191, 20);
					this.textBox2.TabIndex = 3;
					// 
					// label1
					// 
					this.label1.AutoSize = true;
					this.label1.Location = new System.Drawing.Point(445, 72);
					this.label1.Name = "label1";
					this.label1.Size = new System.Drawing.Size(35, 13);
					this.label1.TabIndex = 5;
					this.label1.Text = "Name";
					// 
					// label2
					// 
					this.label2.AutoSize = true;
					this.label2.Location = new System.Drawing.Point(445, 98);
					this.label2.Name = "label2";
					this.label2.Size = new System.Drawing.Size(34, 13);
					this.label2.TabIndex = 6;
					this.label2.Text = "Tabel";
					// 
					// menuMain
					// 
					this.menuMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
					this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenu,
            this.personalToolStripMenuItem});
					this.menuMain.Location = new System.Drawing.Point(0, 0);
					this.menuMain.Name = "menuMain";
					this.menuMain.Size = new System.Drawing.Size(731, 24);
					this.menuMain.TabIndex = 8;
					this.menuMain.Text = "menuStrip1";
					// 
					// mainMenu
					// 
					this.mainMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuPrintChk,
            this.toolStripSeparator1,
            this.deleteCheckedToolStripMenuItem});
					this.mainMenu.Name = "mainMenu";
					this.mainMenu.Size = new System.Drawing.Size(48, 20);
					this.mainMenu.Text = "Файл";
					// 
					// mainMenuPrintChk
					// 
					this.mainMenuPrintChk.Name = "mainMenuPrintChk";
					this.mainMenuPrintChk.Size = new System.Drawing.Size(190, 22);
					this.mainMenuPrintChk.Text = "Печать отмеченных";
					this.mainMenuPrintChk.Click += new System.EventHandler(this.mainMenuPrintChk_Click);
					// 
					// toolStripSeparator1
					// 
					this.toolStripSeparator1.Name = "toolStripSeparator1";
					this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
					// 
					// deleteCheckedToolStripMenuItem
					// 
					this.deleteCheckedToolStripMenuItem.Name = "deleteCheckedToolStripMenuItem";
					this.deleteCheckedToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
					this.deleteCheckedToolStripMenuItem.Text = "Удалить отмеченные";
					this.deleteCheckedToolStripMenuItem.Click += new System.EventHandler(this.deleteCheckedToolStripMenuItem_Click);
					// 
					// personalToolStripMenuItem
					// 
					this.personalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserCardToolStripMenuItem});
					this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
					this.personalToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
					this.personalToolStripMenuItem.Text = "Персонал";
					// 
					// addUserCardToolStripMenuItem
					// 
					this.addUserCardToolStripMenuItem.Name = "addUserCardToolStripMenuItem";
					this.addUserCardToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
					this.addUserCardToolStripMenuItem.Text = "Добавление персонала";
					this.addUserCardToolStripMenuItem.Click += new System.EventHandler(this.addUserCardToolStripMenuItem_Click_1);
					// 
					// groupBox1
					// 
					this.groupBox1.Controls.Add(this.listBox1);
					this.groupBox1.Controls.Add(this.labelResult);
					this.groupBox1.Location = new System.Drawing.Point(12, 40);
					this.groupBox1.Name = "groupBox1";
					this.groupBox1.Size = new System.Drawing.Size(415, 153);
					this.groupBox1.TabIndex = 9;
					this.groupBox1.TabStop = false;
					this.groupBox1.Text = " groupBox1";
					// 
					// listBox1
					// 
					this.listBox1.FormattingEnabled = true;
					this.listBox1.Location = new System.Drawing.Point(8, 91);
					this.listBox1.Name = "listBox1";
					this.listBox1.Size = new System.Drawing.Size(401, 56);
					this.listBox1.TabIndex = 11;
					// 
					// labelResult
					// 
					this.labelResult.AutoSize = true;
					this.labelResult.Location = new System.Drawing.Point(6, 29);
					this.labelResult.Name = "labelResult";
					this.labelResult.Size = new System.Drawing.Size(10, 13);
					this.labelResult.TabIndex = 10;
					this.labelResult.Text = ":";
					// 
					// dgMembers
					// 
					this.dgMembers.AllowUserToAddRows = false;
					this.dgMembers.BackgroundColor = System.Drawing.SystemColors.Control;
					this.dgMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
					this.dgMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check,
            this.uid,
            this.userName,
            this.tabNum});
					this.dgMembers.ContextMenuStrip = this.contextMenu1;
					this.dgMembers.Location = new System.Drawing.Point(12, 212);
					this.dgMembers.Name = "dgMembers";
					this.dgMembers.RowHeadersVisible = false;
					this.dgMembers.Size = new System.Drawing.Size(415, 150);
					this.dgMembers.TabIndex = 11;
					// 
					// check
					// 
					this.check.ContextMenuStrip = this.contextMenu1;
					this.check.Frozen = true;
					this.check.HeaderText = "";
					this.check.Name = "check";
					this.check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
					this.check.Width = 40;
					// 
					// uid
					// 
					this.uid.ContextMenuStrip = this.contextMenu1;
					this.uid.Frozen = true;
					this.uid.HeaderText = "uid";
					this.uid.Name = "uid";
					this.uid.Visible = false;
					this.uid.Width = 40;
					// 
					// userName
					// 
					this.userName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
					this.userName.ContextMenuStrip = this.contextMenu1;
					this.userName.HeaderText = "Сотрудники";
					this.userName.Name = "userName";
					// 
					// tabNum
					// 
					this.tabNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
					this.tabNum.ContextMenuStrip = this.contextMenu1;
					this.tabNum.HeaderText = "Табельный номер";
					this.tabNum.Name = "tabNum";
					this.tabNum.Width = 130;
					// 
					// usersBindingSource
					// 
					this.usersBindingSource.DataMember = "users";
					this.usersBindingSource.DataSource = this.database1DataSet1;
					// 
					// usersTableAdapter
					// 
					this.usersTableAdapter.ClearBeforeFill = true;
					// 
					// checkBox2
					// 
					this.checkBox2.AutoSize = true;
					this.checkBox2.Location = new System.Drawing.Point(27, 216);
					this.checkBox2.Name = "checkBox2";
					this.checkBox2.Size = new System.Drawing.Size(15, 14);
					this.checkBox2.TabIndex = 13;
					this.checkBox2.UseVisualStyleBackColor = true;
					this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
					// 
					// Form1
					// 
					this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
					this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
					this.ClientSize = new System.Drawing.Size(731, 374);
					this.Controls.Add(this.checkBox2);
					this.Controls.Add(this.dgMembers);
					this.Controls.Add(this.menuMain);
					this.Controls.Add(this.groupBox1);
					this.Controls.Add(this.label1);
					this.Controls.Add(this.label2);
					this.Controls.Add(this.textBox2);
					this.Controls.Add(this.buttonTest);
					this.Controls.Add(this.textBox1);
					this.MainMenuStrip = this.menuMain;
					this.Name = "Form1";
					this.Text = "Form1";
					this.Load += new System.EventHandler(this.Form1_Load);
					((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
					this.contextMenu1.ResumeLayout(false);
					this.menuMain.ResumeLayout(false);
					this.menuMain.PerformLayout();
					this.groupBox1.ResumeLayout(false);
					this.groupBox1.PerformLayout();
					((System.ComponentModel.ISupportInitialize)(this.dgMembers)).EndInit();
					((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
					this.ResumeLayout(false);
					this.PerformLayout();

        }

        #endregion

				private Database1DataSet database1DataSet1;
				private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.TextBox textBox1;
				private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
				private System.Windows.Forms.ContextMenuStrip contextMenu1;
				private System.Windows.Forms.ToolStripMenuItem printCheckedToolStripMenuItem;
				private System.Windows.Forms.MenuStrip menuMain;
				private System.Windows.Forms.ToolStripMenuItem mainMenu;
				private System.Windows.Forms.ToolStripMenuItem mainMenuPrintChk;
				private System.Windows.Forms.GroupBox groupBox1;
				private System.Windows.Forms.Label labelResult;
				private System.Windows.Forms.ListBox listBox1;
				private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
				private System.Windows.Forms.ToolStripMenuItem deleteCheckedToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
				private System.Windows.Forms.ToolStripMenuItem addUserCardToolStripMenuItem;
				private System.Windows.Forms.DataGridView dgMembers;
				private System.Windows.Forms.BindingSource usersBindingSource;
				private Database1DataSetTableAdapters.usersTableAdapter usersTableAdapter;
				private System.Windows.Forms.CheckBox checkBox2;
				private System.Windows.Forms.DataGridViewCheckBoxColumn check;
				private System.Windows.Forms.DataGridViewTextBoxColumn uid;
				private System.Windows.Forms.DataGridViewTextBoxColumn userName;
				private System.Windows.Forms.DataGridViewTextBoxColumn tabNum;
    }
}

