namespace ProjectRothSSA1.Forms {
    partial class BrandFrm {
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
            dgBrand = new DataGridView();
            txtBrId = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            txtBrName = new TextBox();
            groupBox2 = new GroupBox();
            deleteBtn = new Button();
            saveBtn = new Button();
            updateBtn = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgBrand).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgBrand
            // 
            dgBrand.AllowUserToAddRows = false;
            dgBrand.AllowUserToDeleteRows = false;
            dgBrand.AllowUserToResizeRows = false;
            dgBrand.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgBrand.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgBrand.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dgBrand.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgBrand.Location = new Point(12 , 173);
            dgBrand.Name = "dgBrand";
            dgBrand.ReadOnly = true;
            dgBrand.RowTemplate.Height = 25;
            dgBrand.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgBrand.Size = new Size(776 , 265);
            dgBrand.TabIndex = 0;
            dgBrand.CellContentDoubleClick += dgBrand_CellContentDoubleClick;
            // 
            // txtBrId
            // 
            txtBrId.Enabled = false;
            txtBrId.Location = new Point(88 , 22);
            txtBrId.Name = "txtBrId";
            txtBrId.Size = new Size(277 , 23);
            txtBrId.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtBrId);
            groupBox1.Controls.Add(txtBrName);
            groupBox1.Location = new Point(12 , 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(371 , 110);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6 , 54);
            label2.Name = "label2";
            label2.Size = new Size(76 , 15);
            label2.TabIndex = 5;
            label2.Text = "Brand Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6 , 25);
            label1.Name = "label1";
            label1.Size = new Size(55 , 15);
            label1.TabIndex = 3;
            label1.Text = "Brand ID:";
            // 
            // txtBrName
            // 
            txtBrName.Location = new Point(88 , 51);
            txtBrName.Name = "txtBrName";
            txtBrName.Size = new Size(277 , 23);
            txtBrName.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(deleteBtn);
            groupBox2.Controls.Add(saveBtn);
            groupBox2.Controls.Add(updateBtn);
            groupBox2.Location = new Point(668 , 57);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(120 , 110);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Action";
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(6 , 80);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(108 , 23);
            deleteBtn.TabIndex = 1;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(6 , 22);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(108 , 23);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(6 , 51);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(108 , 23);
            updateBtn.TabIndex = 0;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI" , 24F , FontStyle.Bold , GraphicsUnit.Point);
            label3.Location = new Point(12 , 9);
            label3.Name = "label3";
            label3.Size = new Size(299 , 45);
            label3.TabIndex = 4;
            label3.Text = "Brand Information";
            // 
            // BrandFrm
            // 
            AutoScaleDimensions = new SizeF(7F , 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800 , 450);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgBrand);
            Name = "BrandFrm";
            Text = "BrandFrm";
            Load += BrandFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dgBrand).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgBrand;
        private TextBox txtBrId;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtBrName;
        private GroupBox groupBox2;
        private Button saveBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Label label3;
    }
}