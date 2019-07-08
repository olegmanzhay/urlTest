namespace test2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.long_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.short_url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countPassing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtUrlLong = new System.Windows.Forms.TextBox();
            this.txtUrlShort = new System.Windows.Forms.TextBox();
            this.lblUrlLong = new System.Windows.Forms.Label();
            this.lblUrlShort = new System.Windows.Forms.Label();
            this.wbShortUrl = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.long_url,
            this.short_url,
            this.date,
            this.countPassing});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            // 
            // long_url
            // 
            resources.ApplyResources(this.long_url, "long_url");
            this.long_url.Name = "long_url";
            // 
            // short_url
            // 
            resources.ApplyResources(this.short_url, "short_url");
            this.short_url.Name = "short_url";
            // 
            // date
            // 
            resources.ApplyResources(this.date, "date");
            this.date.Name = "date";
            // 
            // countPassing
            // 
            resources.ApplyResources(this.countPassing, "countPassing");
            this.countPassing.Name = "countPassing";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtUrlLong
            // 
            resources.ApplyResources(this.txtUrlLong, "txtUrlLong");
            this.txtUrlLong.Name = "txtUrlLong";
            // 
            // txtUrlShort
            // 
            resources.ApplyResources(this.txtUrlShort, "txtUrlShort");
            this.txtUrlShort.Name = "txtUrlShort";
            // 
            // lblUrlLong
            // 
            resources.ApplyResources(this.lblUrlLong, "lblUrlLong");
            this.lblUrlLong.Name = "lblUrlLong";
            // 
            // lblUrlShort
            // 
            resources.ApplyResources(this.lblUrlShort, "lblUrlShort");
            this.lblUrlShort.Name = "lblUrlShort";
            // 
            // wbShortUrl
            // 
            resources.ApplyResources(this.wbShortUrl, "wbShortUrl");
            this.wbShortUrl.Name = "wbShortUrl";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wbShortUrl);
            this.Controls.Add(this.lblUrlShort);
            this.Controls.Add(this.lblUrlLong);
            this.Controls.Add(this.txtUrlShort);
            this.Controls.Add(this.txtUrlLong);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn long_url;
        private System.Windows.Forms.DataGridViewTextBoxColumn short_url;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn countPassing;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtUrlLong;
        private System.Windows.Forms.TextBox txtUrlShort;
        private System.Windows.Forms.Label lblUrlLong;
        private System.Windows.Forms.Label lblUrlShort;
        private System.Windows.Forms.WebBrowser wbShortUrl;
    }
}

