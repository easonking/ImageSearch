namespace 以图搜图
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtDirectory = new TextBox();
            btnDirectory = new Button();
            btnPic = new Button();
            txtPic = new TextBox();
            label2 = new Label();
            btnSearch = new Button();
            btnIndex = new Button();
            picSource = new PictureBox();
            picDest = new PictureBox();
            label3 = new Label();
            dgvResult = new DataGridView();
            dgvContextMenuStrip = new ContextMenuStrip(components);
            打开所在文件夹 = new ToolStripMenuItem();
            label4 = new Label();
            lbIndexCount = new Label();
            label5 = new Label();
            lbElpased = new Label();
            lblDestInfo = new Label();
            lbSrcInfo = new Label();
            lbSpeed = new Label();
            numLike = new NumericUpDown();
            cbRotate = new CheckBox();
            cbFlip = new CheckBox();
            lblProcess = new Label();
            cbRemoveInvalidIndex = new CheckBox();
            buttonClipSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)picSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            dgvContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numLike).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 13);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 24);
            label1.TabIndex = 0;
            label1.Text = "添加搜索文件夹:";
            // 
            // txtDirectory
            // 
            txtDirectory.AllowDrop = true;
            txtDirectory.Location = new Point(177, 9);
            txtDirectory.Margin = new Padding(4, 4, 4, 4);
            txtDirectory.Name = "txtDirectory";
            txtDirectory.Size = new Size(789, 30);
            txtDirectory.TabIndex = 1;
            txtDirectory.DragDrop += txtDirectory_DragDrop;
            txtDirectory.DragEnter += txtDirectory_DragEnter;
            // 
            // btnDirectory
            // 
            btnDirectory.Location = new Point(975, 9);
            btnDirectory.Margin = new Padding(4, 4, 4, 4);
            btnDirectory.Name = "btnDirectory";
            btnDirectory.Size = new Size(100, 33);
            btnDirectory.TabIndex = 2;
            btnDirectory.Text = "选择";
            btnDirectory.UseVisualStyleBackColor = true;
            btnDirectory.Click += btnDirectory_Click;
            // 
            // btnPic
            // 
            btnPic.Location = new Point(975, 56);
            btnPic.Margin = new Padding(4, 4, 4, 4);
            btnPic.Name = "btnPic";
            btnPic.Size = new Size(100, 33);
            btnPic.TabIndex = 5;
            btnPic.Text = "选择";
            btnPic.UseVisualStyleBackColor = true;
            btnPic.Click += btnPic_Click;
            // 
            // txtPic
            // 
            txtPic.AllowDrop = true;
            txtPic.Location = new Point(177, 56);
            txtPic.Margin = new Padding(4, 4, 4, 4);
            txtPic.Name = "txtPic";
            txtPic.Size = new Size(789, 30);
            txtPic.TabIndex = 0;
            txtPic.DragDrop += txtPic_DragDrop;
            txtPic.DragEnter += txtPic_DragEnter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 59);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 24);
            label2.TabIndex = 3;
            label2.Text = "用于检索的图片:";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(583, 93);
            btnSearch.Margin = new Padding(4, 4, 4, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 33);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "搜索";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnIndex
            // 
            btnIndex.Location = new Point(1085, 9);
            btnIndex.Margin = new Padding(4, 4, 4, 4);
            btnIndex.Name = "btnIndex";
            btnIndex.Size = new Size(118, 33);
            btnIndex.TabIndex = 7;
            btnIndex.Text = "更新索引";
            btnIndex.UseVisualStyleBackColor = true;
            btnIndex.Click += btnIndex_Click;
            // 
            // picSource
            // 
            picSource.Location = new Point(971, 131);
            picSource.Margin = new Padding(4, 4, 4, 4);
            picSource.Name = "picSource";
            picSource.Size = new Size(428, 236);
            picSource.SizeMode = PictureBoxSizeMode.Zoom;
            picSource.TabIndex = 9;
            picSource.TabStop = false;
            picSource.LoadCompleted += picSource_LoadCompleted;
            picSource.DoubleClick += picSource_Click;
            // 
            // picDest
            // 
            picDest.Location = new Point(971, 407);
            picDest.Margin = new Padding(4, 4, 4, 4);
            picDest.Name = "picDest";
            picDest.Size = new Size(428, 267);
            picDest.SizeMode = PictureBoxSizeMode.Zoom;
            picDest.TabIndex = 10;
            picDest.TabStop = false;
            picDest.LoadCompleted += picDest_LoadCompleted;
            picDest.DoubleClick += picDest_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 99);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 24);
            label3.TabIndex = 11;
            label3.Text = "查找相似度：";
            // 
            // dgvResult
            // 
            dgvResult.AllowUserToAddRows = false;
            dgvResult.AllowUserToDeleteRows = false;
            dgvResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvResult.BackgroundColor = SystemColors.Control;
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(19, 131);
            dgvResult.Margin = new Padding(4, 4, 4, 4);
            dgvResult.Name = "dgvResult";
            dgvResult.ReadOnly = true;
            dgvResult.RowHeadersWidth = 62;
            dgvResult.RowTemplate.Height = 25;
            dgvResult.Size = new Size(950, 544);
            dgvResult.TabIndex = 13;
            dgvResult.CellClick += dgvResult_CellClick;
            dgvResult.CellContentClick += dgvResult_CellContentClick;
            dgvResult.CellDoubleClick += dgvResult_CellDoubleClick;
            dgvResult.CellMouseDown += dgvResult_CellMouseDown;
            dgvResult.KeyDown += dgvResult_KeyDown;
            dgvResult.KeyUp += dgvResult_KeyUp;
            // 
            // dgvContextMenuStrip
            // 
            dgvContextMenuStrip.ImageScalingSize = new Size(24, 24);
            dgvContextMenuStrip.Items.AddRange(new ToolStripItem[] { 打开所在文件夹 });
            dgvContextMenuStrip.Name = "dgvContextMenuStrip";
            dgvContextMenuStrip.Size = new Size(207, 34);
            // 
            // 打开所在文件夹
            // 
            打开所在文件夹.Name = "打开所在文件夹";
            打开所在文件夹.Size = new Size(206, 30);
            打开所在文件夹.Text = "打开所在文件夹";
            打开所在文件夹.Click += 打开所在文件夹_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1096, 59);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 24);
            label4.TabIndex = 14;
            label4.Text = "索引总数量：";
            // 
            // lbIndexCount
            // 
            lbIndexCount.AutoSize = true;
            lbIndexCount.Location = new Point(1229, 59);
            lbIndexCount.Margin = new Padding(4, 0, 4, 0);
            lbIndexCount.Name = "lbIndexCount";
            lbIndexCount.Size = new Size(0, 24);
            lbIndexCount.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(832, 99);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 24);
            label5.TabIndex = 16;
            label5.Text = "搜索耗时：";
            // 
            // lbElpased
            // 
            lbElpased.AutoSize = true;
            lbElpased.Location = new Point(947, 97);
            lbElpased.Margin = new Padding(4, 0, 4, 0);
            lbElpased.Name = "lbElpased";
            lbElpased.Size = new Size(0, 24);
            lbElpased.TabIndex = 17;
            // 
            // lblDestInfo
            // 
            lblDestInfo.AutoSize = true;
            lblDestInfo.Location = new Point(986, 649);
            lblDestInfo.Margin = new Padding(4, 0, 4, 0);
            lblDestInfo.Name = "lblDestInfo";
            lblDestInfo.Size = new Size(0, 24);
            lblDestInfo.TabIndex = 18;
            // 
            // lbSrcInfo
            // 
            lbSrcInfo.AutoSize = true;
            lbSrcInfo.Location = new Point(983, 344);
            lbSrcInfo.Margin = new Padding(4, 0, 4, 0);
            lbSrcInfo.Name = "lbSrcInfo";
            lbSrcInfo.Size = new Size(0, 24);
            lbSrcInfo.TabIndex = 19;
            // 
            // lbSpeed
            // 
            lbSpeed.AutoSize = true;
            lbSpeed.Location = new Point(1096, 95);
            lbSpeed.Margin = new Padding(4, 0, 4, 0);
            lbSpeed.Name = "lbSpeed";
            lbSpeed.Size = new Size(20, 24);
            lbSpeed.TabIndex = 20;
            lbSpeed.Text = "  ";
            // 
            // numLike
            // 
            numLike.Location = new Point(179, 95);
            numLike.Margin = new Padding(4, 4, 4, 4);
            numLike.Minimum = new decimal(new int[] { 70, 0, 0, 0 });
            numLike.Name = "numLike";
            numLike.Size = new Size(70, 30);
            numLike.TabIndex = 21;
            numLike.Value = new decimal(new int[] { 90, 0, 0, 0 });
            // 
            // cbRotate
            // 
            cbRotate.AutoSize = true;
            cbRotate.Location = new Point(268, 97);
            cbRotate.Margin = new Padding(4, 4, 4, 4);
            cbRotate.Name = "cbRotate";
            cbRotate.Size = new Size(126, 28);
            cbRotate.TabIndex = 22;
            cbRotate.Text = "查找已旋转";
            cbRotate.UseVisualStyleBackColor = true;
            // 
            // cbFlip
            // 
            cbFlip.AutoSize = true;
            cbFlip.Location = new Point(432, 97);
            cbFlip.Margin = new Padding(4, 4, 4, 4);
            cbFlip.Name = "cbFlip";
            cbFlip.Size = new Size(126, 28);
            cbFlip.TabIndex = 23;
            cbFlip.Text = "查找已翻转";
            cbFlip.UseVisualStyleBackColor = true;
            // 
            // lblProcess
            // 
            lblProcess.AutoSize = true;
            lblProcess.Location = new Point(1246, 11);
            lblProcess.Margin = new Padding(4, 0, 4, 0);
            lblProcess.Name = "lblProcess";
            lblProcess.Size = new Size(15, 24);
            lblProcess.TabIndex = 27;
            lblProcess.Text = " ";
            // 
            // cbRemoveInvalidIndex
            // 
            cbRemoveInvalidIndex.AutoSize = true;
            cbRemoveInvalidIndex.Location = new Point(1210, 13);
            cbRemoveInvalidIndex.Margin = new Padding(4, 4, 4, 4);
            cbRemoveInvalidIndex.Name = "cbRemoveInvalidIndex";
            cbRemoveInvalidIndex.Size = new Size(144, 28);
            cbRemoveInvalidIndex.TabIndex = 28;
            cbRemoveInvalidIndex.Text = "移除无效索引";
            cbRemoveInvalidIndex.UseVisualStyleBackColor = true;
            // 
            // buttonClipSearch
            // 
            buttonClipSearch.Location = new Point(671, 93);
            buttonClipSearch.Margin = new Padding(4, 4, 4, 4);
            buttonClipSearch.Name = "buttonClipSearch";
            buttonClipSearch.Size = new Size(151, 33);
            buttonClipSearch.TabIndex = 30;
            buttonClipSearch.Text = "从剪切板搜索";
            buttonClipSearch.UseVisualStyleBackColor = true;
            buttonClipSearch.Click += buttonClipSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1418, 715);
            Controls.Add(buttonClipSearch);
            Controls.Add(cbRemoveInvalidIndex);
            Controls.Add(lblProcess);
            Controls.Add(cbFlip);
            Controls.Add(cbRotate);
            Controls.Add(numLike);
            Controls.Add(lbSpeed);
            Controls.Add(lbSrcInfo);
            Controls.Add(lblDestInfo);
            Controls.Add(lbElpased);
            Controls.Add(label5);
            Controls.Add(lbIndexCount);
            Controls.Add(label4);
            Controls.Add(dgvResult);
            Controls.Add(label3);
            Controls.Add(picDest);
            Controls.Add(picSource);
            Controls.Add(btnIndex);
            Controls.Add(btnSearch);
            Controls.Add(btnPic);
            Controls.Add(txtPic);
            Controls.Add(label2);
            Controls.Add(btnDirectory);
            Controls.Add(txtDirectory);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "本地搜图小工具";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDest).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            dgvContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numLike).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDirectory;
        private Button btnDirectory;
        private Button btnPic;
        private TextBox txtPic;
        private Label label2;
        private Button btnSearch;
        private Button btnIndex;
        private PictureBox picSource;
        private PictureBox picDest;
        private Label label3;
        private DataGridView dgvResult;
        private Label label4;
        private Label lbIndexCount;
        private Label label5;
        private Label lbElpased;
        private Label lblDestInfo;
        private Label lbSrcInfo;
        private Label lbSpeed;
        private NumericUpDown numLike;
        private CheckBox cbRotate;
        private CheckBox cbFlip;
        private Label lblProcess;
        private CheckBox cbRemoveInvalidIndex;
        private Button buttonClipSearch;
        private ContextMenuStrip dgvContextMenuStrip;
        private ToolStripMenuItem 打开所在文件夹;
    }
}