
namespace NoteTrackingSystem
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.tbxMusic2 = new System.Windows.Forms.TextBox();
            this.lblPhysical2 = new System.Windows.Forms.Label();
            this.tbxPhysical2 = new System.Windows.Forms.TextBox();
            this.lblMusic2 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.tbxTurk2 = new System.Windows.Forms.TextBox();
            this.lblMath2 = new System.Windows.Forms.Label();
            this.tbxMath2 = new System.Windows.Forms.TextBox();
            this.lblTurk2 = new System.Windows.Forms.Label();
            this.tbxName2 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.tbxMusic1 = new System.Windows.Forms.TextBox();
            this.lblPhysical1 = new System.Windows.Forms.Label();
            this.tbxPhysical1 = new System.Windows.Forms.TextBox();
            this.lblMusic1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName1 = new System.Windows.Forms.Label();
            this.tbxTurk1 = new System.Windows.Forms.TextBox();
            this.lblMath1 = new System.Windows.Forms.Label();
            this.tbxMath1 = new System.Windows.Forms.TextBox();
            this.lblTurk1 = new System.Windows.Forms.Label();
            this.tbxName1 = new System.Windows.Forms.TextBox();
            this.dgwNotes = new System.Windows.Forms.DataGridView();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(688, 29);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 18;
            this.lblSearch.Text = "Search";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(738, 26);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(303, 20);
            this.tbxSearch.TabIndex = 19;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 23);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(176, 23);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.tbxMusic2);
            this.gbxUpdate.Controls.Add(this.lblPhysical2);
            this.gbxUpdate.Controls.Add(this.tbxPhysical2);
            this.gbxUpdate.Controls.Add(this.lblMusic2);
            this.gbxUpdate.Controls.Add(this.lblName2);
            this.gbxUpdate.Controls.Add(this.tbxTurk2);
            this.gbxUpdate.Controls.Add(this.lblMath2);
            this.gbxUpdate.Controls.Add(this.tbxMath2);
            this.gbxUpdate.Controls.Add(this.lblTurk2);
            this.gbxUpdate.Controls.Add(this.tbxName2);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUpdate.Location = new System.Drawing.Point(551, 238);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(490, 249);
            this.gbxUpdate.TabIndex = 22;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a Note";
            // 
            // tbxMusic2
            // 
            this.tbxMusic2.Location = new System.Drawing.Point(222, 158);
            this.tbxMusic2.Name = "tbxMusic2";
            this.tbxMusic2.Size = new System.Drawing.Size(157, 21);
            this.tbxMusic2.TabIndex = 25;
            // 
            // lblPhysical2
            // 
            this.lblPhysical2.AutoSize = true;
            this.lblPhysical2.Location = new System.Drawing.Point(67, 130);
            this.lblPhysical2.Name = "lblPhysical2";
            this.lblPhysical2.Size = new System.Drawing.Size(111, 15);
            this.lblPhysical2.TabIndex = 22;
            this.lblPhysical2.Text = "Physical Education";
            // 
            // tbxPhysical2
            // 
            this.tbxPhysical2.Location = new System.Drawing.Point(222, 127);
            this.tbxPhysical2.Name = "tbxPhysical2";
            this.tbxPhysical2.Size = new System.Drawing.Size(157, 21);
            this.tbxPhysical2.TabIndex = 24;
            // 
            // lblMusic2
            // 
            this.lblMusic2.AutoSize = true;
            this.lblMusic2.Location = new System.Drawing.Point(67, 161);
            this.lblMusic2.Name = "lblMusic2";
            this.lblMusic2.Size = new System.Drawing.Size(39, 15);
            this.lblMusic2.TabIndex = 23;
            this.lblMusic2.Text = "Music";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(67, 33);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(140, 15);
            this.lblName2.TabIndex = 16;
            this.lblName2.Text = "Student Name Surname";
            // 
            // tbxTurk2
            // 
            this.tbxTurk2.Location = new System.Drawing.Point(222, 93);
            this.tbxTurk2.Name = "tbxTurk2";
            this.tbxTurk2.Size = new System.Drawing.Size(157, 21);
            this.tbxTurk2.TabIndex = 21;
            // 
            // lblMath2
            // 
            this.lblMath2.AutoSize = true;
            this.lblMath2.Location = new System.Drawing.Point(67, 65);
            this.lblMath2.Name = "lblMath2";
            this.lblMath2.Size = new System.Drawing.Size(77, 15);
            this.lblMath2.TabIndex = 17;
            this.lblMath2.Text = "Mathematics";
            // 
            // tbxMath2
            // 
            this.tbxMath2.Location = new System.Drawing.Point(222, 62);
            this.tbxMath2.Name = "tbxMath2";
            this.tbxMath2.Size = new System.Drawing.Size(157, 21);
            this.tbxMath2.TabIndex = 20;
            // 
            // lblTurk2
            // 
            this.lblTurk2.AutoSize = true;
            this.lblTurk2.Location = new System.Drawing.Point(67, 96);
            this.lblTurk2.Name = "lblTurk2";
            this.lblTurk2.Size = new System.Drawing.Size(48, 15);
            this.lblTurk2.TabIndex = 18;
            this.lblTurk2.Text = "Turkish";
            // 
            // tbxName2
            // 
            this.tbxName2.Location = new System.Drawing.Point(222, 30);
            this.tbxName2.Name = "tbxName2";
            this.tbxName2.Size = new System.Drawing.Size(157, 21);
            this.tbxName2.TabIndex = 19;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(238, 200);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.tbxMusic1);
            this.gbxAdd.Controls.Add(this.lblPhysical1);
            this.gbxAdd.Controls.Add(this.tbxPhysical1);
            this.gbxAdd.Controls.Add(this.lblMusic1);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.lblName1);
            this.gbxAdd.Controls.Add(this.tbxTurk1);
            this.gbxAdd.Controls.Add(this.lblMath1);
            this.gbxAdd.Controls.Add(this.tbxMath1);
            this.gbxAdd.Controls.Add(this.lblTurk1);
            this.gbxAdd.Controls.Add(this.tbxName1);
            this.gbxAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAdd.Location = new System.Drawing.Point(12, 238);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(533, 249);
            this.gbxAdd.TabIndex = 21;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Note";
            // 
            // tbxMusic1
            // 
            this.tbxMusic1.Location = new System.Drawing.Point(191, 161);
            this.tbxMusic1.Name = "tbxMusic1";
            this.tbxMusic1.Size = new System.Drawing.Size(157, 21);
            this.tbxMusic1.TabIndex = 15;
            // 
            // lblPhysical1
            // 
            this.lblPhysical1.AutoSize = true;
            this.lblPhysical1.Location = new System.Drawing.Point(36, 133);
            this.lblPhysical1.Name = "lblPhysical1";
            this.lblPhysical1.Size = new System.Drawing.Size(111, 15);
            this.lblPhysical1.TabIndex = 9;
            this.lblPhysical1.Text = "Physical Education";
            // 
            // tbxPhysical1
            // 
            this.tbxPhysical1.Location = new System.Drawing.Point(191, 130);
            this.tbxPhysical1.Name = "tbxPhysical1";
            this.tbxPhysical1.Size = new System.Drawing.Size(157, 21);
            this.tbxPhysical1.TabIndex = 13;
            // 
            // lblMusic1
            // 
            this.lblMusic1.AutoSize = true;
            this.lblMusic1.Location = new System.Drawing.Point(36, 164);
            this.lblMusic1.Name = "lblMusic1";
            this.lblMusic1.Size = new System.Drawing.Size(39, 15);
            this.lblMusic1.TabIndex = 11;
            this.lblMusic1.Text = "Music";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(204, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(36, 36);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(140, 15);
            this.lblName1.TabIndex = 1;
            this.lblName1.Text = "Student Name Surname";
            // 
            // tbxTurk1
            // 
            this.tbxTurk1.Location = new System.Drawing.Point(191, 96);
            this.tbxTurk1.Name = "tbxTurk1";
            this.tbxTurk1.Size = new System.Drawing.Size(157, 21);
            this.tbxTurk1.TabIndex = 6;
            // 
            // lblMath1
            // 
            this.lblMath1.AutoSize = true;
            this.lblMath1.Location = new System.Drawing.Point(36, 68);
            this.lblMath1.Name = "lblMath1";
            this.lblMath1.Size = new System.Drawing.Size(77, 15);
            this.lblMath1.TabIndex = 2;
            this.lblMath1.Text = "Mathematics";
            // 
            // tbxMath1
            // 
            this.tbxMath1.Location = new System.Drawing.Point(191, 65);
            this.tbxMath1.Name = "tbxMath1";
            this.tbxMath1.Size = new System.Drawing.Size(157, 21);
            this.tbxMath1.TabIndex = 5;
            // 
            // lblTurk1
            // 
            this.lblTurk1.AutoSize = true;
            this.lblTurk1.Location = new System.Drawing.Point(36, 99);
            this.lblTurk1.Name = "lblTurk1";
            this.lblTurk1.Size = new System.Drawing.Size(48, 15);
            this.lblTurk1.TabIndex = 3;
            this.lblTurk1.Text = "Turkish";
            // 
            // tbxName1
            // 
            this.tbxName1.Location = new System.Drawing.Point(191, 33);
            this.tbxName1.Name = "tbxName1";
            this.tbxName1.Size = new System.Drawing.Size(157, 21);
            this.tbxName1.TabIndex = 4;
            // 
            // dgwNotes
            // 
            this.dgwNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNotes.Location = new System.Drawing.Point(12, 64);
            this.dgwNotes.Name = "dgwNotes";
            this.dgwNotes.Size = new System.Drawing.Size(1029, 154);
            this.dgwNotes.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 510);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwNotes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.TextBox tbxTurk1;
        private System.Windows.Forms.Label lblMath1;
        private System.Windows.Forms.TextBox tbxMath1;
        private System.Windows.Forms.Label lblTurk1;
        private System.Windows.Forms.TextBox tbxName1;
        private System.Windows.Forms.DataGridView dgwNotes;
        private System.Windows.Forms.TextBox tbxMusic1;
        private System.Windows.Forms.Label lblPhysical1;
        private System.Windows.Forms.TextBox tbxPhysical1;
        private System.Windows.Forms.Label lblMusic1;
        private System.Windows.Forms.TextBox tbxMusic2;
        private System.Windows.Forms.Label lblPhysical2;
        private System.Windows.Forms.TextBox tbxPhysical2;
        private System.Windows.Forms.Label lblMusic2;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.TextBox tbxTurk2;
        private System.Windows.Forms.Label lblMath2;
        private System.Windows.Forms.TextBox tbxMath2;
        private System.Windows.Forms.Label lblTurk2;
        private System.Windows.Forms.TextBox tbxName2;
    }
}

