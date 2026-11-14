namespace oyutnii_burtge
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
            TreeNode treeNode1 = new TreeNode("Компьютерын ухаан");
            TreeNode treeNode2 = new TreeNode("Мэдээллийн технологи");
            TreeNode treeNode3 = new TreeNode("Программ хангамж");
            TreeNode treeNode4 = new TreeNode("Мэдээллийн ухааны сургууль", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Математик");
            TreeNode treeNode6 = new TreeNode("Физик");
            TreeNode treeNode7 = new TreeNode("Байгалийн ухааны сургууль", new TreeNode[] { treeNode5, treeNode6 });
            txtCode = new TextBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            chkScholar = new CheckBox();
            radioButton1 = new RadioButton();
            checkedListBox1 = new CheckedListBox();
            nudAge = new NumericUpDown();
            cmbDept = new ComboBox();
            mtbPhone = new MaskedTextBox();
            dtpBirth = new DateTimePicker();
            btnRegister = new Button();
            lstLang = new ListBox();
            lblPhoto = new Label();
            lvStudents = new ListView();
            colName = new ColumnHeader();
            colPhone = new ColumnHeader();
            colAge = new ColumnHeader();
            tvSchool = new TreeView();
            rtbInfo = new RichTextBox();
            picPhoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)nudAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPhoto).BeginInit();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(8, 42);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(120, 27);
            txtCode.TabIndex = 0;
            txtCode.Text = "M.IT24D040";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 46);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 1;
            label1.Text = "Нийт:1";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(303, 46);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(73, 20);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Цэвэрлэх";
            // 
            // chkScholar
            // 
            chkScholar.AutoSize = true;
            chkScholar.Location = new Point(10, 88);
            chkScholar.Name = "chkScholar";
            chkScholar.Size = new Size(108, 24);
            chkScholar.TabIndex = 3;
            chkScholar.Text = "Тэтгэлэгтэй";
            chkScholar.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(10, 112);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(140, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Өдрийн сургалт";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Программчлал", "Өгөгдлийн бүтэц", "Алгоритм", "Өгөгдлийн сан", "Сүлжээ" });
            checkedListBox1.Location = new Point(8, 156);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 92);
            checkedListBox1.TabIndex = 5;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // nudAge
            // 
            nudAge.Location = new Point(8, 270);
            nudAge.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            nudAge.Minimum = new decimal(new int[] { 21, 0, 0, 0 });
            nudAge.Name = "nudAge";
            nudAge.Size = new Size(120, 27);
            nudAge.TabIndex = 6;
            nudAge.Value = new decimal(new int[] { 21, 0, 0, 0 });
            // 
            // cmbDept
            // 
            cmbDept.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDept.FormattingEnabled = true;
            cmbDept.Items.AddRange(new object[] { "Мэдээллийн технологи Компьютерийн ухаан Программ хангамж" });
            cmbDept.Location = new Point(8, 334);
            cmbDept.Name = "cmbDept";
            cmbDept.Size = new Size(120, 28);
            cmbDept.TabIndex = 7;
            // 
            // mtbPhone
            // 
            mtbPhone.Location = new Point(8, 362);
            mtbPhone.Mask = "0000-0000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.Size = new Size(120, 27);
            mtbPhone.TabIndex = 8;
            mtbPhone.Text = "99999999";
            // 
            // dtpBirth
            // 
            dtpBirth.Format = DateTimePickerFormat.Short;
            dtpBirth.Location = new Point(8, 390);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(120, 27);
            dtpBirth.TabIndex = 9;
            dtpBirth.Value = new DateTime(2026, 10, 25, 22, 24, 0, 0);
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.Blue;
            btnRegister.Location = new Point(8, 436);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(136, 40);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Бүртгэх";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lstLang
            // 
            lstLang.FormattingEnabled = true;
            lstLang.Items.AddRange(new object[] { "Монгол", "Англи", "Орос", "Хятад", "Япон", "Солонгос" });
            lstLang.Location = new Point(163, 97);
            lstLang.Name = "lstLang";
            lstLang.Size = new Size(125, 84);
            lstLang.TabIndex = 11;
            // 
            // lblPhoto
            // 
            lblPhoto.AutoSize = true;
            lblPhoto.Location = new Point(163, 196);
            lblPhoto.Name = "lblPhoto";
            lblPhoto.Size = new Size(86, 20);
            lblPhoto.TabIndex = 12;
            lblPhoto.Text = "Цээж зураг";
            // 
            // lvStudents
            // 
            lvStudents.Columns.AddRange(new ColumnHeader[] { colName, colPhone, colAge });
            lvStudents.FullRowSelect = true;
            lvStudents.GridLines = true;
            lvStudents.Location = new Point(300, 97);
            lvStudents.Name = "lvStudents";
            lvStudents.Size = new Size(200, 95);
            lvStudents.TabIndex = 14;
            lvStudents.UseCompatibleStateImageBehavior = false;
            lvStudents.View = View.Details;
            lvStudents.SelectedIndexChanged += lvStudents_SelectedIndexChanged;
            // 
            // colName
            // 
            colName.Tag = "";
            colName.Text = "Овог нэр";
            colName.Width = 90;
            // 
            // colPhone
            // 
            colPhone.Text = "Утас";
            colPhone.Width = 65;
            // 
            // colAge
            // 
            colAge.Text = "Нас";
            colAge.Width = 40;
            // 
            // tvSchool
            // 
            tvSchool.Location = new Point(300, 222);
            tvSchool.Name = "tvSchool";
            treeNode1.Name = "Node2";
            treeNode1.Text = "Компьютерын ухаан";
            treeNode2.Name = "Node3";
            treeNode2.Text = "Мэдээллийн технологи";
            treeNode3.Name = "Node4";
            treeNode3.Text = "Программ хангамж";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Мэдээллийн ухааны сургууль";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Математик";
            treeNode6.Name = "Node6";
            treeNode6.Text = "Физик";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Байгалийн ухааны сургууль";
            tvSchool.Nodes.AddRange(new TreeNode[] { treeNode4, treeNode7 });
            tvSchool.Size = new Size(200, 130);
            tvSchool.TabIndex = 15;
            // 
            // rtbInfo
            // 
            rtbInfo.Location = new Point(163, 362);
            rtbInfo.Name = "rtbInfo";
            rtbInfo.ReadOnly = true;
            rtbInfo.Size = new Size(337, 223);
            rtbInfo.TabIndex = 16;
            rtbInfo.Text = "ОЮУТНЫ БҮРТГЭЛ\n\nКод: M.M.IT24D040\nУтас: 9999-9999\nНас: 20\nТөрсөн өдөр: 2006-09-18\nСуралга: Өдрийн\nТэнхим: Мэдээллийн технологи\nТэтгэлэг: Тийм\nХичээл: Программчлал, Өгөгдлийн бүтэц\nХэл: Монгол";
            // 
            // picPhoto
            // 
            picPhoto.BorderStyle = BorderStyle.FixedSingle;
            picPhoto.Image = Properties.Resources.Screenshot_2026_11_14_232818;
            picPhoto.Location = new Point(163, 222);
            picPhoto.Name = "picPhoto";
            picPhoto.Size = new Size(125, 130);
            picPhoto.SizeMode = PictureBoxSizeMode.CenterImage;
            picPhoto.TabIndex = 13;
            picPhoto.TabStop = false;
            picPhoto.Click += picPhoto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 586);
            Controls.Add(rtbInfo);
            Controls.Add(tvSchool);
            Controls.Add(lvStudents);
            Controls.Add(picPhoto);
            Controls.Add(lblPhoto);
            Controls.Add(lstLang);
            Controls.Add(btnRegister);
            Controls.Add(dtpBirth);
            Controls.Add(mtbPhone);
            Controls.Add(cmbDept);
            Controls.Add(nudAge);
            Controls.Add(checkedListBox1);
            Controls.Add(radioButton1);
            Controls.Add(chkScholar);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(txtCode);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оюутны бүртгэлийн программ";
            ((System.ComponentModel.ISupportInitialize)nudAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCode;
        private Label label1;
        private LinkLabel linkLabel1;
        private CheckBox chkScholar;
        private RadioButton radioButton1;
        private CheckedListBox checkedListBox1;
        private NumericUpDown nudAge;
        private ComboBox cmbDept;
        private MaskedTextBox mtbPhone;
        private DateTimePicker dtpBirth;
        private Button btnRegister;
        private ListBox lstLang;
        private Label lblPhoto;
        private ListView lvStudents;
        private ColumnHeader colName;
        private ColumnHeader colPhone;
        private ColumnHeader colAge;
        private TreeView tvSchool;
        private RichTextBox rtbInfo;
        private PictureBox picPhoto;
    }
}
