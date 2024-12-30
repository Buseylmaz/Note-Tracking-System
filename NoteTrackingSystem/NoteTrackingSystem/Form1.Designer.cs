
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
            this.tbxMusicUpdate = new System.Windows.Forms.TextBox();
            this.lblPhysical2 = new System.Windows.Forms.Label();
            this.tbxPhysicalUpdate = new System.Windows.Forms.TextBox();
            this.lblMusic2 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.tbxTurkUpdate = new System.Windows.Forms.TextBox();
            this.lblMath2 = new System.Windows.Forms.Label();
            this.tbxMathUpdate = new System.Windows.Forms.TextBox();
            this.lblTurk2 = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.tbxMusicAdd = new System.Windows.Forms.TextBox();
            this.lblPhysical1 = new System.Windows.Forms.Label();
            this.tbxPhysicalAdd = new System.Windows.Forms.TextBox();
            this.lblMusic1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName1 = new System.Windows.Forms.Label();
            this.tbxTurkAdd = new System.Windows.Forms.TextBox();
            this.lblMath1 = new System.Windows.Forms.Label();
            this.tbxMathAdd = new System.Windows.Forms.TextBox();
            this.lblTurk1 = new System.Windows.Forms.Label();
            this.tbxNameAdd = new System.Windows.Forms.TextBox();
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
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.tbxMusicUpdate);
            this.gbxUpdate.Controls.Add(this.lblPhysical2);
            this.gbxUpdate.Controls.Add(this.tbxPhysicalUpdate);
            this.gbxUpdate.Controls.Add(this.lblMusic2);
            this.gbxUpdate.Controls.Add(this.lblName2);
            this.gbxUpdate.Controls.Add(this.tbxTurkUpdate);
            this.gbxUpdate.Controls.Add(this.lblMath2);
            this.gbxUpdate.Controls.Add(this.tbxMathUpdate);
            this.gbxUpdate.Controls.Add(this.lblTurk2);
            this.gbxUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUpdate.Location = new System.Drawing.Point(551, 238);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(490, 249);
            this.gbxUpdate.TabIndex = 22;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a Note";
            // 
            // tbxMusicUpdate
            // 
            this.tbxMusicUpdate.Location = new System.Drawing.Point(222, 158);
            this.tbxMusicUpdate.Name = "tbxMusicUpdate";
            this.tbxMusicUpdate.Size = new System.Drawing.Size(157, 21);
            this.tbxMusicUpdate.TabIndex = 25;
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
            // tbxPhysicalUpdate
            // 
            this.tbxPhysicalUpdate.Location = new System.Drawing.Point(222, 127);
            this.tbxPhysicalUpdate.Name = "tbxPhysicalUpdate";
            this.tbxPhysicalUpdate.Size = new System.Drawing.Size(157, 21);
            this.tbxPhysicalUpdate.TabIndex = 24;
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
            // tbxTurkUpdate
            // 
            this.tbxTurkUpdate.Location = new System.Drawing.Point(222, 93);
            this.tbxTurkUpdate.Name = "tbxTurkUpdate";
            this.tbxTurkUpdate.Size = new System.Drawing.Size(157, 21);
            this.tbxTurkUpdate.TabIndex = 21;
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
            // tbxMathUpdate
            // 
            this.tbxMathUpdate.Location = new System.Drawing.Point(222, 62);
            this.tbxMathUpdate.Name = "tbxMathUpdate";
            this.tbxMathUpdate.Size = new System.Drawing.Size(157, 21);
            this.tbxMathUpdate.TabIndex = 20;
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
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(222, 30);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(157, 21);
            this.tbxNameUpdate.TabIndex = 19;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(238, 200);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.tbxMusicAdd);
            this.gbxAdd.Controls.Add(this.lblPhysical1);
            this.gbxAdd.Controls.Add(this.tbxPhysicalAdd);
            this.gbxAdd.Controls.Add(this.lblMusic1);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.lblName1);
            this.gbxAdd.Controls.Add(this.tbxTurkAdd);
            this.gbxAdd.Controls.Add(this.lblMath1);
            this.gbxAdd.Controls.Add(this.tbxMathAdd);
            this.gbxAdd.Controls.Add(this.lblTurk1);
            this.gbxAdd.Controls.Add(this.tbxNameAdd);
            this.gbxAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAdd.Location = new System.Drawing.Point(12, 238);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(533, 249);
            this.gbxAdd.TabIndex = 21;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Note";
            // 
            // tbxMusicAdd
            // 
            this.tbxMusicAdd.Location = new System.Drawing.Point(191, 161);
            this.tbxMusicAdd.Name = "tbxMusicAdd";
            this.tbxMusicAdd.Size = new System.Drawing.Size(157, 21);
            this.tbxMusicAdd.TabIndex = 15;
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
            // tbxPhysicalAdd
            // 
            this.tbxPhysicalAdd.Location = new System.Drawing.Point(191, 130);
            this.tbxPhysicalAdd.Name = "tbxPhysicalAdd";
            this.tbxPhysicalAdd.Size = new System.Drawing.Size(157, 21);
            this.tbxPhysicalAdd.TabIndex = 13;
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
            // tbxTurkAdd
            // 
            this.tbxTurkAdd.Location = new System.Drawing.Point(191, 96);
            this.tbxTurkAdd.Name = "tbxTurkAdd";
            this.tbxTurkAdd.Size = new System.Drawing.Size(157, 21);
            this.tbxTurkAdd.TabIndex = 6;
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
            // tbxMathAdd
            // 
            this.tbxMathAdd.Location = new System.Drawing.Point(191, 65);
            this.tbxMathAdd.Name = "tbxMathAdd";
            this.tbxMathAdd.Size = new System.Drawing.Size(157, 21);
            this.tbxMathAdd.TabIndex = 5;
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
            // tbxNameAdd
            // 
            this.tbxNameAdd.Location = new System.Drawing.Point(191, 33);
            this.tbxNameAdd.Name = "tbxNameAdd";
            this.tbxNameAdd.Size = new System.Drawing.Size(157, 21);
            this.tbxNameAdd.TabIndex = 4;
            // 
            // dgwNotes
            // 
            this.dgwNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNotes.Location = new System.Drawing.Point(12, 64);
            this.dgwNotes.Name = "dgwNotes";
            this.dgwNotes.Size = new System.Drawing.Size(1029, 154);
            this.dgwNotes.TabIndex = 20;
            this.dgwNotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwNotes_CellClick);
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
        private System.Windows.Forms.TextBox tbxTurkAdd;
        private System.Windows.Forms.Label lblMath1;
        private System.Windows.Forms.TextBox tbxMathAdd;
        private System.Windows.Forms.Label lblTurk1;
        private System.Windows.Forms.TextBox tbxNameAdd;
        private System.Windows.Forms.DataGridView dgwNotes;
        private System.Windows.Forms.TextBox tbxMusicAdd;
        private System.Windows.Forms.Label lblPhysical1;
        private System.Windows.Forms.TextBox tbxPhysicalAdd;
        private System.Windows.Forms.Label lblMusic1;
        private System.Windows.Forms.TextBox tbxMusicUpdate;
        private System.Windows.Forms.Label lblPhysical2;
        private System.Windows.Forms.TextBox tbxPhysicalUpdate;
        private System.Windows.Forms.Label lblMusic2;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.TextBox tbxTurkUpdate;
        private System.Windows.Forms.Label lblMath2;
        private System.Windows.Forms.TextBox tbxMathUpdate;
        private System.Windows.Forms.Label lblTurk2;
        private System.Windows.Forms.TextBox tbxNameUpdate;
    }
}

