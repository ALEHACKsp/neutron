namespace NeutronCheatsLoader
{
	// Token: 0x02000004 RID: 4
	public partial class laggoaway : global::System.Windows.Forms.Form
	{
		// Token: 0x06000024 RID: 36 RVA: 0x0000363C File Offset: 0x0000363C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003674 File Offset: 0x00003674
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.bunifuElipse1 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuHTTP_Utils1 = new global::Bunifu.Framework.UI.BunifuHTTP_Utils(this.components);
			this.button1 = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			this.bunifuHTTP_Utils1.JobName = "";
			this.bunifuHTTP_Utils1.Url = "";
			this.button1.Location = new global::System.Drawing.Point(24, 22);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(22, 22, 22);
			base.ClientSize = new global::System.Drawing.Size(128, 350);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "laggoaway";
			this.Text = "laggoaway";
			base.ResumeLayout(false);
		}

		// Token: 0x0400001A RID: 26
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400001B RID: 27
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse1;

		// Token: 0x0400001C RID: 28
		private global::Bunifu.Framework.UI.BunifuHTTP_Utils bunifuHTTP_Utils1;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Button button1;
	}
}
