namespace kNearest
{
    partial class kNearest
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.opnFile = new System.Windows.Forms.OpenFileDialog();
            this.gridNormalized = new System.Windows.Forms.DataGridView();
            this.lblNormalized = new System.Windows.Forms.Label();
            this.gridTruth = new System.Windows.Forms.DataGridView();
            this.gridDistance = new System.Windows.Forms.DataGridView();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblkTruth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridNormalized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTruth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPath.Location = new System.Drawing.Point(118, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(422, 20);
            this.txtPath.TabIndex = 0;
            // 
            // btnChoose
            // 
            this.btnChoose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChoose.Location = new System.Drawing.Point(546, 12);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(114, 23);
            this.btnChoose.TabIndex = 1;
            this.btnChoose.Text = "Choose Data File";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpload.Location = new System.Drawing.Point(117, 38);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(543, 23);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Upload Data";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // opnFile
            // 
            this.opnFile.FileName = "Data File";
            // 
            // gridNormalized
            // 
            this.gridNormalized.AllowUserToAddRows = false;
            this.gridNormalized.AllowUserToDeleteRows = false;
            this.gridNormalized.AllowUserToResizeColumns = false;
            this.gridNormalized.AllowUserToResizeRows = false;
            this.gridNormalized.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridNormalized.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridNormalized.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.gridNormalized.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridNormalized.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridNormalized.Location = new System.Drawing.Point(117, 109);
            this.gridNormalized.Name = "gridNormalized";
            this.gridNormalized.ReadOnly = true;
            this.gridNormalized.RowHeadersVisible = false;
            this.gridNormalized.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridNormalized.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkBlue;
            this.gridNormalized.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridNormalized.ShowCellErrors = false;
            this.gridNormalized.ShowCellToolTips = false;
            this.gridNormalized.Size = new System.Drawing.Size(542, 115);
            this.gridNormalized.TabIndex = 3;
            // 
            // lblNormalized
            // 
            this.lblNormalized.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNormalized.AutoSize = true;
            this.lblNormalized.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblNormalized.Location = new System.Drawing.Point(114, 74);
            this.lblNormalized.Name = "lblNormalized";
            this.lblNormalized.Size = new System.Drawing.Size(128, 17);
            this.lblNormalized.TabIndex = 4;
            this.lblNormalized.Text = "Normalized Data";
            this.lblNormalized.Visible = false;
            // 
            // gridTruth
            // 
            this.gridTruth.AllowUserToAddRows = false;
            this.gridTruth.AllowUserToDeleteRows = false;
            this.gridTruth.AllowUserToResizeColumns = false;
            this.gridTruth.AllowUserToResizeRows = false;
            this.gridTruth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridTruth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTruth.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.gridTruth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridTruth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridTruth.Location = new System.Drawing.Point(396, 262);
            this.gridTruth.Name = "gridTruth";
            this.gridTruth.ReadOnly = true;
            this.gridTruth.ShowCellErrors = false;
            this.gridTruth.ShowCellToolTips = false;
            this.gridTruth.Size = new System.Drawing.Size(263, 150);
            this.gridTruth.TabIndex = 5;
            // 
            // gridDistance
            // 
            this.gridDistance.AllowUserToAddRows = false;
            this.gridDistance.AllowUserToDeleteRows = false;
            this.gridDistance.AllowUserToResizeColumns = false;
            this.gridDistance.AllowUserToResizeRows = false;
            this.gridDistance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridDistance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDistance.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.gridDistance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDistance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDistance.Location = new System.Drawing.Point(116, 262);
            this.gridDistance.Name = "gridDistance";
            this.gridDistance.ReadOnly = true;
            this.gridDistance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDistance.ShowCellErrors = false;
            this.gridDistance.ShowCellToolTips = false;
            this.gridDistance.Size = new System.Drawing.Size(263, 150);
            this.gridDistance.TabIndex = 6;
            // 
            // lblDistance
            // 
            this.lblDistance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDistance.Location = new System.Drawing.Point(117, 243);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(69, 16);
            this.lblDistance.TabIndex = 7;
            this.lblDistance.Text = "Distance";
            this.lblDistance.Visible = false;
            // 
            // lblkTruth
            // 
            this.lblkTruth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblkTruth.AutoSize = true;
            this.lblkTruth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkTruth.Location = new System.Drawing.Point(396, 243);
            this.lblkTruth.Name = "lblkTruth";
            this.lblkTruth.Size = new System.Drawing.Size(56, 16);
            this.lblkTruth.TabIndex = 8;
            this.lblkTruth.Text = "k-Truth";
            this.lblkTruth.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Optimum K Value";
            // 
            // txtK
            // 
            this.txtK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtK.Location = new System.Drawing.Point(116, 440);
            this.txtK.Name = "txtK";
            this.txtK.ReadOnly = true;
            this.txtK.Size = new System.Drawing.Size(100, 20);
            this.txtK.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.Location = new System.Drawing.Point(323, 440);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(129, 108);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Enter Inputs";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Answer";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAnswer.Location = new System.Drawing.Point(559, 440);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(100, 20);
            this.txtAnswer.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Location = new System.Drawing.Point(559, 466);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 48);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // kNearest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(752, 574);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblkTruth);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.gridDistance);
            this.Controls.Add(this.gridTruth);
            this.Controls.Add(this.lblNormalized);
            this.Controls.Add(this.gridNormalized);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.txtPath);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "kNearest";
            this.Text = "k-Nearest";
            ((System.ComponentModel.ISupportInitialize)(this.gridNormalized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTruth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog opnFile;
        private System.Windows.Forms.DataGridView gridNormalized;
        private System.Windows.Forms.Label lblNormalized;
        private System.Windows.Forms.DataGridView gridTruth;
        private System.Windows.Forms.DataGridView gridDistance;
        private System.Windows.Forms.Label lblkTruth;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch;
    }
}

