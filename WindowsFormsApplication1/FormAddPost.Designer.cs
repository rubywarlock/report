namespace WindowsFormsApplication1 {
	partial class FormAddPost {
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
			this.tbPostName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAddPost = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbPostName
			// 
			this.tbPostName.Location = new System.Drawing.Point(12, 31);
			this.tbPostName.Name = "tbPostName";
			this.tbPostName.Size = new System.Drawing.Size(299, 20);
			this.tbPostName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Название должности";
			// 
			// btnAddPost
			// 
			this.btnAddPost.Location = new System.Drawing.Point(28, 57);
			this.btnAddPost.Name = "btnAddPost";
			this.btnAddPost.Size = new System.Drawing.Size(75, 23);
			this.btnAddPost.TabIndex = 2;
			this.btnAddPost.Text = "Добавить";
			this.btnAddPost.UseVisualStyleBackColor = true;
			this.btnAddPost.Click += new System.EventHandler(this.btnAddPost_Click);
			// 
			// FormAddPost
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(321, 98);
			this.Controls.Add(this.btnAddPost);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbPostName);
			this.Name = "FormAddPost";
			this.Text = "Добавить новую должность";
			this.Load += new System.EventHandler(this.FormAddPost_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbPostName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddPost;
	}
}