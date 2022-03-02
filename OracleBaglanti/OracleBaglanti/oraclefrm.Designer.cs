namespace OracleBaglanti
{
    partial class oraclefrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adsoyadtxt = new System.Windows.Forms.TextBox();
            this.epostatxt = new System.Windows.Forms.TextBox();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.listelebtn = new System.Windows.Forms.Button();
            this.tablegrd = new System.Windows.Forms.DataGridView();
            this.silbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablegrd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eposta";
            // 
            // adsoyadtxt
            // 
            this.adsoyadtxt.Location = new System.Drawing.Point(88, 26);
            this.adsoyadtxt.Name = "adsoyadtxt";
            this.adsoyadtxt.Size = new System.Drawing.Size(100, 20);
            this.adsoyadtxt.TabIndex = 2;
            // 
            // epostatxt
            // 
            this.epostatxt.Location = new System.Drawing.Point(88, 49);
            this.epostatxt.Name = "epostatxt";
            this.epostatxt.Size = new System.Drawing.Size(100, 20);
            this.epostatxt.TabIndex = 3;
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(209, 24);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(75, 23);
            this.kaydetbtn.TabIndex = 4;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // listelebtn
            // 
            this.listelebtn.Location = new System.Drawing.Point(209, 47);
            this.listelebtn.Name = "listelebtn";
            this.listelebtn.Size = new System.Drawing.Size(75, 23);
            this.listelebtn.TabIndex = 5;
            this.listelebtn.Text = "Listele";
            this.listelebtn.UseVisualStyleBackColor = true;
            this.listelebtn.Click += new System.EventHandler(this.listelebtn_Click);
            // 
            // tablegrd
            // 
            this.tablegrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablegrd.Location = new System.Drawing.Point(12, 76);
            this.tablegrd.Name = "tablegrd";
            this.tablegrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablegrd.Size = new System.Drawing.Size(386, 177);
            this.tablegrd.TabIndex = 6;
            // 
            // silbtn
            // 
            this.silbtn.Location = new System.Drawing.Point(308, 24);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(75, 23);
            this.silbtn.TabIndex = 7;
            this.silbtn.Text = "Sil";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // oraclefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 265);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.tablegrd);
            this.Controls.Add(this.listelebtn);
            this.Controls.Add(this.kaydetbtn);
            this.Controls.Add(this.epostatxt);
            this.Controls.Add(this.adsoyadtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "oraclefrm";
            this.Text = "Oracle Bağlantısı";
            ((System.ComponentModel.ISupportInitialize)(this.tablegrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adsoyadtxt;
        private System.Windows.Forms.TextBox epostatxt;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Button listelebtn;
        private System.Windows.Forms.DataGridView tablegrd;
        private System.Windows.Forms.Button silbtn;
    }
}

