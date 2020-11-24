namespace DownloadMuti
{
    partial class RadForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RadForm1));
            this.btnStart = new Telerik.WinControls.UI.RadButton();
            this.office2010BlueTheme1 = new Telerik.WinControls.Themes.Office2010BlueTheme();
            this.st = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblStatus = new Telerik.WinControls.UI.RadLabelElement();
            this.txtNum = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btn_SetFolder = new Telerik.WinControls.UI.RadButton();
            this.ckbTopic = new System.Windows.Forms.ComboBox();
            this.ckb_MoTa = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.st)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SetFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_MoTa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(38, 90);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(202, 24);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Tiến hành tải xuống";
            this.btnStart.ThemeName = "Office2010Blue";
            this.btnStart.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // st
            // 
            this.st.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblStatus});
            this.st.Location = new System.Drawing.Point(0, 158);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(294, 21);
            this.st.TabIndex = 2;
            this.st.ThemeName = "Office2010Blue";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.st.SetSpring(this.lblStatus, false);
            this.lblStatus.Text = "Trạng thái";
            this.lblStatus.TextWrap = true;
            // 
            // txtNum
            // 
            this.txtNum.Enabled = false;
            this.txtNum.Location = new System.Drawing.Point(119, 12);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(121, 20);
            this.txtNum.TabIndex = 3;
            this.txtNum.Text = "1000";
            this.txtNum.ThemeName = "Office2010Blue";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(90, 18);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Số lượng cần tải:";
            this.radLabel1.ThemeName = "Office2010Blue";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 36);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(44, 18);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Chủ đề:";
            this.radLabel2.ThemeName = "Office2010Blue";
            // 
            // btn_SetFolder
            // 
            this.btn_SetFolder.Location = new System.Drawing.Point(12, 120);
            this.btn_SetFolder.Name = "btn_SetFolder";
            this.btn_SetFolder.Size = new System.Drawing.Size(270, 25);
            this.btn_SetFolder.TabIndex = 8;
            this.btn_SetFolder.Text = "Chọn thư mục lưu";
            this.btn_SetFolder.ThemeName = "Office2010Blue";
            this.btn_SetFolder.Click += new System.EventHandler(this.btn_SetFolder_Click);
            // 
            // ckbTopic
            // 
            this.ckbTopic.FormattingEnabled = true;
            this.ckbTopic.Items.AddRange(new object[] {
            "Không chủ đề",
            "Kiến trúc",
            "Thể thao",
            "Du lịch",
            "Làm đẹp",
            "Thời trang",
            "Vật nuôi",
            "Nghệ thuật",
            "Nhiếp ảnh",
            "Ẩm thực"});
            this.ckbTopic.Location = new System.Drawing.Point(119, 39);
            this.ckbTopic.Name = "ckbTopic";
            this.ckbTopic.Size = new System.Drawing.Size(121, 21);
            this.ckbTopic.TabIndex = 9;
            // 
            // ckb_MoTa
            // 
            this.ckb_MoTa.Location = new System.Drawing.Point(119, 66);
            this.ckb_MoTa.Name = "ckb_MoTa";
            this.ckb_MoTa.Size = new System.Drawing.Size(91, 18);
            this.ckb_MoTa.TabIndex = 10;
            this.ckb_MoTa.Text = "Tải kèm mô tả";
            // 
            // RadForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 179);
            this.Controls.Add(this.ckb_MoTa);
            this.Controls.Add(this.ckbTopic);
            this.Controls.Add(this.btn_SetFolder);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.st);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RadForm1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Download Muti Support";
            this.ThemeName = "Office2010Blue";
            this.Load += new System.EventHandler(this.RadForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.st)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_SetFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckb_MoTa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btnStart;
        private Telerik.WinControls.Themes.Office2010BlueTheme office2010BlueTheme1;
        private Telerik.WinControls.UI.RadStatusStrip st;
        private Telerik.WinControls.UI.RadTextBox txtNum;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btn_SetFolder;
        private System.Windows.Forms.ComboBox ckbTopic;
        private Telerik.WinControls.UI.RadCheckBox ckb_MoTa;
        private Telerik.WinControls.UI.RadLabelElement lblStatus;
    }
}