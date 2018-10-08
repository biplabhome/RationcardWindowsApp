﻿namespace RationCard
{
    partial class FrmSearchResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchResult));
            this.pnlCriteriaSelect = new System.Windows.Forms.Panel();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.rdName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbCardCat = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdAdhar = new System.Windows.Forms.RadioButton();
            this.rdCardNo = new System.Windows.Forms.RadioButton();
            this.rdPhone = new System.Windows.Forms.RadioButton();
            this.grdVwSearchResult = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpBoxSearchCriteria = new System.Windows.Forms.GroupBox();
            this.lblCriteria = new System.Windows.Forms.Label();
            this.lblSearchResult = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pnlRptHeader = new System.Windows.Forms.Panel();
            this.lblDtToday = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblSignature = new System.Windows.Forms.Label();
            this.lblDt = new System.Windows.Forms.Label();
            this.lblColDealerName = new System.Windows.Forms.Label();
            this.lblColMrShopNo = new System.Windows.Forms.Label();
            this.lblColLiscenceNo = new System.Windows.Forms.Label();
            this.lblMRShopNo = new System.Windows.Forms.Label();
            this.lblLiscenceNo = new System.Windows.Forms.Label();
            this.lblDealerName = new System.Windows.Forms.Label();
            this.lblHdrMrShopNo = new System.Windows.Forms.Label();
            this.lblHdrLiscenceNo = new System.Windows.Forms.Label();
            this.lblHdrDealerName = new System.Windows.Forms.Label();
            this.pnlCriteriaSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwSearchResult)).BeginInit();
            this.grpBoxSearchCriteria.SuspendLayout();
            this.pnlRptHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCriteriaSelect
            // 
            this.pnlCriteriaSelect.Controls.Add(this.lblSearchBy);
            this.pnlCriteriaSelect.Controls.Add(this.rdName);
            this.pnlCriteriaSelect.Controls.Add(this.btnSearch);
            this.pnlCriteriaSelect.Controls.Add(this.label19);
            this.pnlCriteriaSelect.Controls.Add(this.label17);
            this.pnlCriteriaSelect.Controls.Add(this.cmbCardCat);
            this.pnlCriteriaSelect.Controls.Add(this.txtSearch);
            this.pnlCriteriaSelect.Controls.Add(this.rdAdhar);
            this.pnlCriteriaSelect.Controls.Add(this.rdCardNo);
            this.pnlCriteriaSelect.Controls.Add(this.rdPhone);
            this.pnlCriteriaSelect.Location = new System.Drawing.Point(11, 10);
            this.pnlCriteriaSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCriteriaSelect.Name = "pnlCriteriaSelect";
            this.pnlCriteriaSelect.Size = new System.Drawing.Size(1493, 41);
            this.pnlCriteriaSelect.TabIndex = 22;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBy.Location = new System.Drawing.Point(1468, 11);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(0, 17);
            this.lblSearchBy.TabIndex = 5;
            this.lblSearchBy.Visible = false;
            // 
            // rdName
            // 
            this.rdName.AutoSize = true;
            this.rdName.Location = new System.Drawing.Point(271, 9);
            this.rdName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdName.Name = "rdName";
            this.rdName.Size = new System.Drawing.Size(66, 21);
            this.rdName.TabIndex = 16;
            this.rdName.Text = "Name";
            this.rdName.UseVisualStyleBackColor = true;
            this.rdName.CheckedChanged += new System.EventHandler(this.rdName_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1255, 10);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(149, 26);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(564, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 17);
            this.label19.TabIndex = 15;
            this.label19.Text = "Search";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(987, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 17);
            this.label17.TabIndex = 14;
            this.label17.Text = "Category";
            // 
            // cmbCardCat
            // 
            this.cmbCardCat.DisplayMember = "Cat_Desc";
            this.cmbCardCat.FormattingEnabled = true;
            this.cmbCardCat.Location = new System.Drawing.Point(1061, 12);
            this.cmbCardCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCardCat.Name = "cmbCardCat";
            this.cmbCardCat.Size = new System.Drawing.Size(164, 24);
            this.cmbCardCat.TabIndex = 14;
            this.cmbCardCat.ValueMember = "Cat_Id";
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Location = new System.Drawing.Point(621, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(343, 22);
            this.txtSearch.TabIndex = 4;
            // 
            // rdAdhar
            // 
            this.rdAdhar.AutoSize = true;
            this.rdAdhar.Location = new System.Drawing.Point(172, 10);
            this.rdAdhar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdAdhar.Name = "rdAdhar";
            this.rdAdhar.Size = new System.Drawing.Size(93, 21);
            this.rdAdhar.TabIndex = 2;
            this.rdAdhar.Text = "Adhar No.";
            this.rdAdhar.UseVisualStyleBackColor = true;
            this.rdAdhar.CheckedChanged += new System.EventHandler(this.rdAdhar_CheckedChanged);
            // 
            // rdCardNo
            // 
            this.rdCardNo.AutoSize = true;
            this.rdCardNo.Location = new System.Drawing.Point(81, 9);
            this.rdCardNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdCardNo.Name = "rdCardNo";
            this.rdCardNo.Size = new System.Drawing.Size(85, 21);
            this.rdCardNo.TabIndex = 1;
            this.rdCardNo.Text = "Card No.";
            this.rdCardNo.UseVisualStyleBackColor = true;
            this.rdCardNo.CheckedChanged += new System.EventHandler(this.rdCardNo_CheckedChanged);
            // 
            // rdPhone
            // 
            this.rdPhone.AutoSize = true;
            this.rdPhone.Location = new System.Drawing.Point(3, 7);
            this.rdPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdPhone.Name = "rdPhone";
            this.rdPhone.Size = new System.Drawing.Size(70, 21);
            this.rdPhone.TabIndex = 0;
            this.rdPhone.Text = "Phone";
            this.rdPhone.UseVisualStyleBackColor = true;
            this.rdPhone.CheckedChanged += new System.EventHandler(this.rdPhone_CheckedChanged);
            // 
            // grdVwSearchResult
            // 
            this.grdVwSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVwSearchResult.Location = new System.Drawing.Point(19, 190);
            this.grdVwSearchResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdVwSearchResult.Name = "grdVwSearchResult";
            this.grdVwSearchResult.RowTemplate.Height = 24;
            this.grdVwSearchResult.Size = new System.Drawing.Size(1485, 476);
            this.grdVwSearchResult.TabIndex = 23;
            this.grdVwSearchResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVwSearchResult_CellDoubleClick);
            this.grdVwSearchResult.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grdVwSearchResult_DataBindingComplete);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(659, 679);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(295, 50);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grpBoxSearchCriteria
            // 
            this.grpBoxSearchCriteria.Controls.Add(this.lblCriteria);
            this.grpBoxSearchCriteria.Controls.Add(this.lblSearchResult);
            this.grpBoxSearchCriteria.Location = new System.Drawing.Point(13, 62);
            this.grpBoxSearchCriteria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxSearchCriteria.Name = "grpBoxSearchCriteria";
            this.grpBoxSearchCriteria.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpBoxSearchCriteria.Size = new System.Drawing.Size(1491, 57);
            this.grpBoxSearchCriteria.TabIndex = 25;
            this.grpBoxSearchCriteria.TabStop = false;
            this.grpBoxSearchCriteria.Text = "Search Criteria";
            this.grpBoxSearchCriteria.Visible = false;
            // 
            // lblCriteria
            // 
            this.lblCriteria.AutoSize = true;
            this.lblCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriteria.Location = new System.Drawing.Point(188, 17);
            this.lblCriteria.Name = "lblCriteria";
            this.lblCriteria.Size = new System.Drawing.Size(111, 17);
            this.lblCriteria.TabIndex = 4;
            this.lblCriteria.Text = "Searched For ";
            // 
            // lblSearchResult
            // 
            this.lblSearchResult.AutoSize = true;
            this.lblSearchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchResult.Location = new System.Drawing.Point(20, 17);
            this.lblSearchResult.Name = "lblSearchResult";
            this.lblSearchResult.Size = new System.Drawing.Size(96, 17);
            this.lblSearchResult.TabIndex = 3;
            this.lblSearchResult.Text = "Total Result";
            // 
            // pnlRptHeader
            // 
            this.pnlRptHeader.Controls.Add(this.lblDtToday);
            this.pnlRptHeader.Controls.Add(this.lblLine);
            this.pnlRptHeader.Controls.Add(this.lblSignature);
            this.pnlRptHeader.Controls.Add(this.lblDt);
            this.pnlRptHeader.Controls.Add(this.lblColDealerName);
            this.pnlRptHeader.Controls.Add(this.lblColMrShopNo);
            this.pnlRptHeader.Controls.Add(this.lblColLiscenceNo);
            this.pnlRptHeader.Controls.Add(this.lblMRShopNo);
            this.pnlRptHeader.Controls.Add(this.lblLiscenceNo);
            this.pnlRptHeader.Controls.Add(this.lblDealerName);
            this.pnlRptHeader.Controls.Add(this.lblHdrMrShopNo);
            this.pnlRptHeader.Controls.Add(this.lblHdrLiscenceNo);
            this.pnlRptHeader.Controls.Add(this.lblHdrDealerName);
            this.pnlRptHeader.Location = new System.Drawing.Point(14, 123);
            this.pnlRptHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlRptHeader.Name = "pnlRptHeader";
            this.pnlRptHeader.Size = new System.Drawing.Size(1490, 63);
            this.pnlRptHeader.TabIndex = 26;
            this.pnlRptHeader.Visible = false;
            // 
            // lblDtToday
            // 
            this.lblDtToday.AutoSize = true;
            this.lblDtToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtToday.Location = new System.Drawing.Point(437, 7);
            this.lblDtToday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDtToday.Name = "lblDtToday";
            this.lblDtToday.Size = new System.Drawing.Size(105, 20);
            this.lblDtToday.TabIndex = 47;
            this.lblDtToday.Text = "Today Date";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.Location = new System.Drawing.Point(1277, 6);
            this.lblLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(198, 20);
            this.lblLine.TabIndex = 46;
            this.lblLine.Text = "_____________________";
            // 
            // lblSignature
            // 
            this.lblSignature.AutoSize = true;
            this.lblSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignature.Location = new System.Drawing.Point(1326, 38);
            this.lblSignature.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSignature.Name = "lblSignature";
            this.lblSignature.Size = new System.Drawing.Size(89, 20);
            this.lblSignature.TabIndex = 45;
            this.lblSignature.Text = "Signature";
            // 
            // lblDt
            // 
            this.lblDt.AutoSize = true;
            this.lblDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDt.Location = new System.Drawing.Point(379, 9);
            this.lblDt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDt.Name = "lblDt";
            this.lblDt.Size = new System.Drawing.Size(50, 20);
            this.lblDt.TabIndex = 44;
            this.lblDt.Text = "Date:";
            // 
            // lblColDealerName
            // 
            this.lblColDealerName.AutoSize = true;
            this.lblColDealerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColDealerName.Location = new System.Drawing.Point(181, 9);
            this.lblColDealerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColDealerName.Name = "lblColDealerName";
            this.lblColDealerName.Size = new System.Drawing.Size(14, 20);
            this.lblColDealerName.TabIndex = 43;
            this.lblColDealerName.Text = ":";
            // 
            // lblColMrShopNo
            // 
            this.lblColMrShopNo.AutoSize = true;
            this.lblColMrShopNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColMrShopNo.Location = new System.Drawing.Point(710, 9);
            this.lblColMrShopNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColMrShopNo.Name = "lblColMrShopNo";
            this.lblColMrShopNo.Size = new System.Drawing.Size(14, 20);
            this.lblColMrShopNo.TabIndex = 42;
            this.lblColMrShopNo.Text = ":";
            // 
            // lblColLiscenceNo
            // 
            this.lblColLiscenceNo.AutoSize = true;
            this.lblColLiscenceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColLiscenceNo.Location = new System.Drawing.Point(1077, 9);
            this.lblColLiscenceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColLiscenceNo.Name = "lblColLiscenceNo";
            this.lblColLiscenceNo.Size = new System.Drawing.Size(14, 20);
            this.lblColLiscenceNo.TabIndex = 41;
            this.lblColLiscenceNo.Text = ":";
            // 
            // lblMRShopNo
            // 
            this.lblMRShopNo.AutoSize = true;
            this.lblMRShopNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMRShopNo.Location = new System.Drawing.Point(746, 9);
            this.lblMRShopNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMRShopNo.Name = "lblMRShopNo";
            this.lblMRShopNo.Size = new System.Drawing.Size(156, 20);
            this.lblMRShopNo.TabIndex = 40;
            this.lblMRShopNo.Text = "MR Shop Number";
            // 
            // lblLiscenceNo
            // 
            this.lblLiscenceNo.AutoSize = true;
            this.lblLiscenceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiscenceNo.Location = new System.Drawing.Point(1113, 9);
            this.lblLiscenceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiscenceNo.Name = "lblLiscenceNo";
            this.lblLiscenceNo.Size = new System.Drawing.Size(156, 20);
            this.lblLiscenceNo.TabIndex = 39;
            this.lblLiscenceNo.Text = "Liscence Number";
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerName.Location = new System.Drawing.Point(217, 9);
            this.lblDealerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(119, 20);
            this.lblDealerName.TabIndex = 38;
            this.lblDealerName.Text = "Dealer Name";
            // 
            // lblHdrMrShopNo
            // 
            this.lblHdrMrShopNo.AutoSize = true;
            this.lblHdrMrShopNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHdrMrShopNo.Location = new System.Drawing.Point(550, 9);
            this.lblHdrMrShopNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHdrMrShopNo.Name = "lblHdrMrShopNo";
            this.lblHdrMrShopNo.Size = new System.Drawing.Size(142, 20);
            this.lblHdrMrShopNo.TabIndex = 37;
            this.lblHdrMrShopNo.Text = "MR Shop Number";
            // 
            // lblHdrLiscenceNo
            // 
            this.lblHdrLiscenceNo.AutoSize = true;
            this.lblHdrLiscenceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHdrLiscenceNo.Location = new System.Drawing.Point(917, 9);
            this.lblHdrLiscenceNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHdrLiscenceNo.Name = "lblHdrLiscenceNo";
            this.lblHdrLiscenceNo.Size = new System.Drawing.Size(141, 20);
            this.lblHdrLiscenceNo.TabIndex = 36;
            this.lblHdrLiscenceNo.Text = "Liscence Number";
            // 
            // lblHdrDealerName
            // 
            this.lblHdrDealerName.AutoSize = true;
            this.lblHdrDealerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHdrDealerName.Location = new System.Drawing.Point(21, 9);
            this.lblHdrDealerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHdrDealerName.Name = "lblHdrDealerName";
            this.lblHdrDealerName.Size = new System.Drawing.Size(108, 20);
            this.lblHdrDealerName.TabIndex = 35;
            this.lblHdrDealerName.Text = "Dealer Name";
            // 
            // FrmSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 750);
            this.Controls.Add(this.pnlRptHeader);
            this.Controls.Add(this.grpBoxSearchCriteria);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grdVwSearchResult);
            this.Controls.Add(this.pnlCriteriaSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmSearchResult";
            this.Text = "Search Rationcard";
            this.Load += new System.EventHandler(this.FrmSearchResult_Load);
            this.pnlCriteriaSelect.ResumeLayout(false);
            this.pnlCriteriaSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVwSearchResult)).EndInit();
            this.grpBoxSearchCriteria.ResumeLayout(false);
            this.grpBoxSearchCriteria.PerformLayout();
            this.pnlRptHeader.ResumeLayout(false);
            this.pnlRptHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCriteriaSelect;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbCardCat;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdAdhar;
        private System.Windows.Forms.RadioButton rdCardNo;
        private System.Windows.Forms.RadioButton rdPhone;
        private System.Windows.Forms.RadioButton rdName;
        private System.Windows.Forms.DataGridView grdVwSearchResult;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox grpBoxSearchCriteria;
        private System.Windows.Forms.Label lblSearchResult;
        private System.Windows.Forms.Label lblCriteria;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel pnlRptHeader;
        private System.Windows.Forms.Label lblColDealerName;
        private System.Windows.Forms.Label lblColMrShopNo;
        private System.Windows.Forms.Label lblColLiscenceNo;
        private System.Windows.Forms.Label lblMRShopNo;
        private System.Windows.Forms.Label lblLiscenceNo;
        private System.Windows.Forms.Label lblDealerName;
        private System.Windows.Forms.Label lblHdrMrShopNo;
        private System.Windows.Forms.Label lblHdrLiscenceNo;
        private System.Windows.Forms.Label lblHdrDealerName;
        private System.Windows.Forms.Label lblDtToday;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblSignature;
        private System.Windows.Forms.Label lblDt;
    }
}