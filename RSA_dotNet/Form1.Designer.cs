namespace RSA_dotNet
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.GB_1_e = new System.Windows.Forms.GroupBox();
			this.CB_1eCreate = new System.Windows.Forms.Button();
			this.tB_1encOut = new System.Windows.Forms.TextBox();
			this.tB_1encIn = new System.Windows.Forms.TextBox();
			this.GB_1_d = new System.Windows.Forms.GroupBox();
			this.CB_1dCreate = new System.Windows.Forms.Button();
			this.tB_1decOut = new System.Windows.Forms.TextBox();
			this.tB_1decIn = new System.Windows.Forms.TextBox();
			this.GB_2_d = new System.Windows.Forms.GroupBox();
			this.CB_2dCreate = new System.Windows.Forms.Button();
			this.tB_2decOut = new System.Windows.Forms.TextBox();
			this.tB_2decIn = new System.Windows.Forms.TextBox();
			this.GB_2_e = new System.Windows.Forms.GroupBox();
			this.CB_2eCreate = new System.Windows.Forms.Button();
			this.tB_2encOut = new System.Windows.Forms.TextBox();
			this.tB_2encIn = new System.Windows.Forms.TextBox();
			this.GB_1 = new System.Windows.Forms.GroupBox();
			this.GB_2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.GB_1_e.SuspendLayout();
			this.GB_1_d.SuspendLayout();
			this.GB_2_d.SuspendLayout();
			this.GB_2_e.SuspendLayout();
			this.GB_1.SuspendLayout();
			this.GB_2.SuspendLayout();
			this.SuspendLayout();
			// 
			// GB_1_e
			// 
			this.GB_1_e.Controls.Add(this.CB_1eCreate);
			this.GB_1_e.Controls.Add(this.tB_1encOut);
			this.GB_1_e.Controls.Add(this.tB_1encIn);
			this.GB_1_e.Location = new System.Drawing.Point(181, 19);
			this.GB_1_e.Name = "GB_1_e";
			this.GB_1_e.Size = new System.Drawing.Size(169, 302);
			this.GB_1_e.TabIndex = 2;
			this.GB_1_e.TabStop = false;
			this.GB_1_e.Text = "Encrytor";
			// 
			// CB_1eCreate
			// 
			this.CB_1eCreate.Location = new System.Drawing.Point(6, 219);
			this.CB_1eCreate.Name = "CB_1eCreate";
			this.CB_1eCreate.Size = new System.Drawing.Size(157, 77);
			this.CB_1eCreate.TabIndex = 2;
			this.CB_1eCreate.Text = "2) Create an encryptor that uses previously made open key of C2.";
			this.CB_1eCreate.UseVisualStyleBackColor = true;
			this.CB_1eCreate.Click += new System.EventHandler(this.CB_1eCreate_Click);
			// 
			// tB_1encOut
			// 
			this.tB_1encOut.Location = new System.Drawing.Point(6, 119);
			this.tB_1encOut.Multiline = true;
			this.tB_1encOut.Name = "tB_1encOut";
			this.tB_1encOut.Size = new System.Drawing.Size(157, 94);
			this.tB_1encOut.TabIndex = 1;
			this.tB_1encOut.Text = "3) Here will appear the encrypted text";
			// 
			// tB_1encIn
			// 
			this.tB_1encIn.Location = new System.Drawing.Point(6, 19);
			this.tB_1encIn.Multiline = true;
			this.tB_1encIn.Name = "tB_1encIn";
			this.tB_1encIn.Size = new System.Drawing.Size(157, 94);
			this.tB_1encIn.TabIndex = 0;
			this.tB_1encIn.Text = "3) Spell some text here and double-click it then.";
			this.tB_1encIn.DoubleClick += new System.EventHandler(this.tB_1encIn_DoubleClick);
			// 
			// GB_1_d
			// 
			this.GB_1_d.Controls.Add(this.CB_1dCreate);
			this.GB_1_d.Controls.Add(this.tB_1decOut);
			this.GB_1_d.Controls.Add(this.tB_1decIn);
			this.GB_1_d.Location = new System.Drawing.Point(6, 19);
			this.GB_1_d.Name = "GB_1_d";
			this.GB_1_d.Size = new System.Drawing.Size(169, 302);
			this.GB_1_d.TabIndex = 3;
			this.GB_1_d.TabStop = false;
			this.GB_1_d.Text = "Decryptor";
			// 
			// CB_1dCreate
			// 
			this.CB_1dCreate.Location = new System.Drawing.Point(6, 219);
			this.CB_1dCreate.Name = "CB_1dCreate";
			this.CB_1dCreate.Size = new System.Drawing.Size(157, 77);
			this.CB_1dCreate.TabIndex = 4;
			this.CB_1dCreate.Text = "1) Create a key pair - it (the open part) will then be used to make an encryptor " +
    "for C2.";
			this.CB_1dCreate.UseVisualStyleBackColor = true;
			this.CB_1dCreate.Click += new System.EventHandler(this.CB_1dCreate_Click);
			// 
			// tB_1decOut
			// 
			this.tB_1decOut.Location = new System.Drawing.Point(6, 119);
			this.tB_1decOut.Multiline = true;
			this.tB_1decOut.Name = "tB_1decOut";
			this.tB_1decOut.Size = new System.Drawing.Size(157, 94);
			this.tB_1decOut.TabIndex = 3;
			this.tB_1decOut.Text = "4) This textbox will be used to show the result. It must be Your open text from C" +
    "2. Or someone is a dummy.";
			// 
			// tB_1decIn
			// 
			this.tB_1decIn.Location = new System.Drawing.Point(6, 19);
			this.tB_1decIn.Multiline = true;
			this.tB_1decIn.Name = "tB_1decIn";
			this.tB_1decIn.Size = new System.Drawing.Size(157, 94);
			this.tB_1decIn.TabIndex = 2;
			this.tB_1decIn.Text = "4) Yeah, paste here something encrypted by C2 and double-click it!";
			this.tB_1decIn.DoubleClick += new System.EventHandler(this.tB_1decIn_DoubleClick);
			// 
			// GB_2_d
			// 
			this.GB_2_d.Controls.Add(this.CB_2dCreate);
			this.GB_2_d.Controls.Add(this.tB_2decOut);
			this.GB_2_d.Controls.Add(this.tB_2decIn);
			this.GB_2_d.Location = new System.Drawing.Point(175, 19);
			this.GB_2_d.Name = "GB_2_d";
			this.GB_2_d.Size = new System.Drawing.Size(169, 302);
			this.GB_2_d.TabIndex = 5;
			this.GB_2_d.TabStop = false;
			this.GB_2_d.Text = "Decryptor";
			// 
			// CB_2dCreate
			// 
			this.CB_2dCreate.Location = new System.Drawing.Point(6, 219);
			this.CB_2dCreate.Name = "CB_2dCreate";
			this.CB_2dCreate.Size = new System.Drawing.Size(157, 77);
			this.CB_2dCreate.TabIndex = 4;
			this.CB_2dCreate.Text = "1) Create a key pair - it (the open part) will then be used to make an encryptor " +
    "for C1.";
			this.CB_2dCreate.UseVisualStyleBackColor = true;
			this.CB_2dCreate.Click += new System.EventHandler(this.CB_2dCreate_Click);
			// 
			// tB_2decOut
			// 
			this.tB_2decOut.Location = new System.Drawing.Point(6, 119);
			this.tB_2decOut.Multiline = true;
			this.tB_2decOut.Name = "tB_2decOut";
			this.tB_2decOut.Size = new System.Drawing.Size(157, 94);
			this.tB_2decOut.TabIndex = 3;
			this.tB_2decOut.Text = "4) This textbox will be used to show the result. It must be Your open text from C" +
    "1. Or someone is a dummy.";
			// 
			// tB_2decIn
			// 
			this.tB_2decIn.Location = new System.Drawing.Point(7, 19);
			this.tB_2decIn.Multiline = true;
			this.tB_2decIn.Name = "tB_2decIn";
			this.tB_2decIn.Size = new System.Drawing.Size(157, 94);
			this.tB_2decIn.TabIndex = 2;
			this.tB_2decIn.Text = "4) Yeah, paste here something encrypted by C1 and double-click it!";
			this.tB_2decIn.DoubleClick += new System.EventHandler(this.tB_2decIn_DoubleClick);
			// 
			// GB_2_e
			// 
			this.GB_2_e.Controls.Add(this.CB_2eCreate);
			this.GB_2_e.Controls.Add(this.tB_2encOut);
			this.GB_2_e.Controls.Add(this.tB_2encIn);
			this.GB_2_e.Location = new System.Drawing.Point(6, 19);
			this.GB_2_e.Name = "GB_2_e";
			this.GB_2_e.Size = new System.Drawing.Size(169, 302);
			this.GB_2_e.TabIndex = 4;
			this.GB_2_e.TabStop = false;
			this.GB_2_e.Text = "Encrytor";
			// 
			// CB_2eCreate
			// 
			this.CB_2eCreate.Location = new System.Drawing.Point(6, 219);
			this.CB_2eCreate.Name = "CB_2eCreate";
			this.CB_2eCreate.Size = new System.Drawing.Size(157, 77);
			this.CB_2eCreate.TabIndex = 3;
			this.CB_2eCreate.Text = "2) Create an encryptor that uses previously made open key of C1.";
			this.CB_2eCreate.UseVisualStyleBackColor = true;
			this.CB_2eCreate.Click += new System.EventHandler(this.CB_2eCreate_Click);
			// 
			// tB_2encOut
			// 
			this.tB_2encOut.Location = new System.Drawing.Point(6, 119);
			this.tB_2encOut.Multiline = true;
			this.tB_2encOut.Name = "tB_2encOut";
			this.tB_2encOut.Size = new System.Drawing.Size(157, 94);
			this.tB_2encOut.TabIndex = 1;
			this.tB_2encOut.Text = "3) Here will appear the encrypted text";
			// 
			// tB_2encIn
			// 
			this.tB_2encIn.Location = new System.Drawing.Point(6, 19);
			this.tB_2encIn.Multiline = true;
			this.tB_2encIn.Name = "tB_2encIn";
			this.tB_2encIn.Size = new System.Drawing.Size(157, 94);
			this.tB_2encIn.TabIndex = 0;
			this.tB_2encIn.Text = "3) Spell some text here and double-click it then.";
			this.tB_2encIn.DoubleClick += new System.EventHandler(this.tB_2encIn_DoubleClick);
			// 
			// GB_1
			// 
			this.GB_1.Controls.Add(this.GB_1_e);
			this.GB_1.Controls.Add(this.GB_1_d);
			this.GB_1.Location = new System.Drawing.Point(12, 46);
			this.GB_1.Name = "GB_1";
			this.GB_1.Size = new System.Drawing.Size(358, 327);
			this.GB_1.TabIndex = 6;
			this.GB_1.TabStop = false;
			this.GB_1.Text = "Client1";
			// 
			// GB_2
			// 
			this.GB_2.Controls.Add(this.GB_2_e);
			this.GB_2.Controls.Add(this.GB_2_d);
			this.GB_2.Location = new System.Drawing.Point(408, 46);
			this.GB_2.Name = "GB_2";
			this.GB_2.Size = new System.Drawing.Size(351, 327);
			this.GB_2.TabIndex = 7;
			this.GB_2.TabStop = false;
			this.GB_2.Text = "Client2";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(260, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(298, 26);
			this.label1.TabIndex = 8;
			this.label1.Text = "RSA. To make it work, You should play according some rules.\r\nDo first things firs" +
    "tly, and the maagic will be Yours. ;)";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(358, 367);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Visible = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(771, 385);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.GB_2);
			this.Controls.Add(this.GB_1);
			this.Name = "Form1";
			this.Text = "I use Unicode!";
			this.GB_1_e.ResumeLayout(false);
			this.GB_1_e.PerformLayout();
			this.GB_1_d.ResumeLayout(false);
			this.GB_1_d.PerformLayout();
			this.GB_2_d.ResumeLayout(false);
			this.GB_2_d.PerformLayout();
			this.GB_2_e.ResumeLayout(false);
			this.GB_2_e.PerformLayout();
			this.GB_1.ResumeLayout(false);
			this.GB_2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox GB_1_e;
		private System.Windows.Forms.TextBox tB_1encOut;
		private System.Windows.Forms.TextBox tB_1encIn;
		private System.Windows.Forms.GroupBox GB_1_d;
		private System.Windows.Forms.TextBox tB_1decOut;
		private System.Windows.Forms.TextBox tB_1decIn;
		private System.Windows.Forms.Button CB_1eCreate;
		private System.Windows.Forms.Button CB_1dCreate;
		private System.Windows.Forms.GroupBox GB_2_d;
		private System.Windows.Forms.Button CB_2dCreate;
		private System.Windows.Forms.TextBox tB_2decOut;
		private System.Windows.Forms.TextBox tB_2decIn;
		private System.Windows.Forms.GroupBox GB_2_e;
		private System.Windows.Forms.Button CB_2eCreate;
		private System.Windows.Forms.TextBox tB_2encOut;
		private System.Windows.Forms.TextBox tB_2encIn;
		private System.Windows.Forms.GroupBox GB_1;
		private System.Windows.Forms.GroupBox GB_2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}

