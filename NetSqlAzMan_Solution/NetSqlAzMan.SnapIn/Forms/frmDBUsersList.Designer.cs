namespace NetSqlAzMan.SnapIn.Forms
{
    partial class frmDBUsersList
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDBUsersList));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lsvDBUsers = new System.Windows.Forms.ListView();
            this.nameColumnHeader = new System.Windows.Forms.ColumnHeader(0);
            this.customSidColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.typeHeader1 = new System.Windows.Forms.ColumnHeader();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "DBUser_16x16.ico");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(392, 298);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(473, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(17, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 1);
            this.panel1.TabIndex = 27;
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.Location = new System.Drawing.Point(50, 271);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(493, 16);
            this.lblInfo.TabIndex = 28;
            this.lblInfo.Text = "DB Users list.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lsvDBUsers
            // 
            this.lsvDBUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvDBUsers.CheckBoxes = true;
            this.lsvDBUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumnHeader,
            this.customSidColumnHeader,
            this.typeHeader1});
            this.lsvDBUsers.HideSelection = false;
            this.lsvDBUsers.LargeImageList = this.imageList1;
            this.lsvDBUsers.Location = new System.Drawing.Point(50, 25);
            this.lsvDBUsers.MultiSelect = false;
            this.lsvDBUsers.Name = "lsvDBUsers";
            this.lsvDBUsers.ShowGroups = false;
            this.lsvDBUsers.Size = new System.Drawing.Size(493, 201);
            this.lsvDBUsers.SmallImageList = this.imageList1;
            this.lsvDBUsers.TabIndex = 0;
            this.lsvDBUsers.UseCompatibleStateImageBehavior = false;
            this.lsvDBUsers.View = System.Windows.Forms.View.Details;
            this.lsvDBUsers.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lsvDBUsers_ColumnClick);
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            this.nameColumnHeader.Width = 162;
            // 
            // customSidColumnHeader
            // 
            this.customSidColumnHeader.Text = "Custom Sid";
            this.customSidColumnHeader.Width = 200;
            // 
            // typeHeader1
            // 
            this.typeHeader1.Text = "Type";
            this.typeHeader1.Width = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "DB Users list";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NetSqlAzMan.SnapIn.Properties.Resources.DBUser_32x32;
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // lblNote
            // 
            this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.Blue;
            this.lblNote.Location = new System.Drawing.Point(47, 229);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(496, 31);
            this.lblNote.TabIndex = 33;
            this.lblNote.Text = "Note: to change DB Users list, modify \"dbo.GetDBUsers\" table-function on NetSqlAz" +
                "ManStorage DB.";
            // 
            // frmDBUsersList
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(558, 333);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lsvDBUsers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(187, 217);
            this.Name = "frmDBUsersList";
            this.Text = " DB Users list";
            this.Activated += new System.EventHandler(this.frmDBUsersList_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDBUsersList_FormClosing);
            this.Load += new System.EventHandler(this.frmDBUsersList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView lsvDBUsers;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader customSidColumnHeader;
        private System.Windows.Forms.ColumnHeader typeHeader1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNote;

    }
}