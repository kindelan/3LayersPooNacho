namespace WindowsFormsApp1
{
    partial class AlumnoShowForm
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
            this.GridAlumnos = new System.Windows.Forms.DataGridView();
            this.txt = new System.Windows.Forms.Button();
            this.json = new System.Windows.Forms.Button();
            this.xml = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // GridAlumnos
            // 
            this.GridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAlumnos.Location = new System.Drawing.Point(44, 73);
            this.GridAlumnos.Name = "GridAlumnos";
            this.GridAlumnos.Size = new System.Drawing.Size(649, 316);
            this.GridAlumnos.TabIndex = 0;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(587, 415);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(75, 23);
            this.txt.TabIndex = 1;
            this.txt.Text = "TXT";
            this.txt.UseVisualStyleBackColor = true;
            this.txt.Click += new System.EventHandler(this.txt_Click);
            // 
            // json
            // 
            this.json.Location = new System.Drawing.Point(320, 415);
            this.json.Name = "json";
            this.json.Size = new System.Drawing.Size(75, 23);
            this.json.TabIndex = 2;
            this.json.Text = "JSON";
            this.json.UseVisualStyleBackColor = true;
            this.json.Click += new System.EventHandler(this.json_Click);
            // 
            // xml
            // 
            this.xml.Location = new System.Drawing.Point(44, 415);
            this.xml.Name = "xml";
            this.xml.Size = new System.Drawing.Size(75, 23);
            this.xml.TabIndex = 3;
            this.xml.Text = "XML";
            this.xml.UseVisualStyleBackColor = true;
            this.xml.Click += new System.EventHandler(this.xml_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(713, 73);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 4;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(89, 16);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 5;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(41, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(33, 13);
            this.name.TabIndex = 6;
            this.name.Text = "name";
            // 
            // AlumnoShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.search);
            this.Controls.Add(this.xml);
            this.Controls.Add(this.json);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.GridAlumnos);
            this.Name = "AlumnoShowForm";
            this.Text = "AlumnoShowForm";
            ((System.ComponentModel.ISupportInitialize)(this.GridAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridAlumnos;
        private System.Windows.Forms.Button txt;
        private System.Windows.Forms.Button json;
        private System.Windows.Forms.Button xml;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label name;
    }
}