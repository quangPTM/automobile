namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            btnNew = new Button();
            btnLoad = new Button();
            txtReleaseYear = new TextBox();
            txtPrice = new TextBox();
            txtCarName = new TextBox();
            txtCarID = new TextBox();
            lbReleaseYear = new Label();
            lbPrice = new Label();
            lbManufacturer = new Label();
            lbCarName = new Label();
            lbCarID = new Label();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            txtManufacturer = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.Location = new Point(357, 169);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 23;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(154, 169);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 22;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(542, 70);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(203, 23);
            txtReleaseYear.TabIndex = 20;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(542, 30);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(203, 23);
            txtPrice.TabIndex = 19;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(154, 70);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(203, 23);
            txtCarName.TabIndex = 18;
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(154, 30);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(203, 23);
            txtCarID.TabIndex = 17;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(427, 73);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(68, 15);
            lbReleaseYear.TabIndex = 16;
            lbReleaseYear.Text = "ReleaseYear";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(427, 33);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 15;
            lbPrice.Text = "Price";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(39, 122);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(79, 15);
            lbManufacturer.TabIndex = 14;
            lbManufacturer.Text = "Manufactorer";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(39, 73);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 13;
            lbCarName.Text = "Car Name";
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new Point(39, 33);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(39, 15);
            lbCarID.TabIndex = 12;
            lbCarID.Text = "Car ID";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(585, 169);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(39, 213);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.RowTemplate.Height = 25;
            dgvCarList.Size = new Size(706, 150);
            dgvCarList.TabIndex = 25;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(357, 379);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 26;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(154, 120);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(203, 23);
            txtManufacturer.TabIndex = 27;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtManufacturer);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Name = "frmCarManagement";
            Text = "frmCarManagement";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNew;
        private Button btnLoad;
        private TextBox txtReleaseYear;
        private TextBox txtPrice;
        private TextBox txtCarName;
        private TextBox txtCarID;
        private Label lbReleaseYear;
        private Label lbPrice;
        private Label lbManufacturer;
        private Label lbCarName;
        private Label lbCarID;
        private Button btnDelete;
        private DataGridView dgvCarList;
        private Button btnClose;
        private TextBox txtManufacturer;
    }
}