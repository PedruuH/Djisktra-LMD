namespace wfProjetoDjisktra
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_partida = new System.Windows.Forms.ComboBox();
            this.cb_destino = new System.Windows.Forms.ComboBox();
            this.go_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Local de partida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(673, 546);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local de destino";
            // 
            // cb_partida
            // 
            this.cb_partida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_partida.FormattingEnabled = true;
            this.cb_partida.Items.AddRange(new object[] {
            "Araguari",
            "Capinópolis",
            "Cascalho Rico",
            "Centralina",
            "Douradinhos",
            "Estrela do Sul",
            "Grupiara",
            "Indianópolis",
            "Ituiutaba",
            "Itumbiara",
            "Monte Alegre de Minas",
            "Romaria",
            "São Juliana",
            "Tupaciguara",
            "Uberlândia"});
            this.cb_partida.Location = new System.Drawing.Point(536, 576);
            this.cb_partida.Name = "cb_partida";
            this.cb_partida.Size = new System.Drawing.Size(121, 21);
            this.cb_partida.TabIndex = 3;
            // 
            // cb_destino
            // 
            this.cb_destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_destino.FormattingEnabled = true;
            this.cb_destino.Items.AddRange(new object[] {
            "Araguari",
            "Capinópolis",
            "Cascalho Rico",
            "Centralina",
            "Douradinhos",
            "Estrela do Sul",
            "Grupiara",
            "Indianópolis",
            "Ituiutaba",
            "Itumbiara",
            "Monte Alegre de Minas",
            "Romaria",
            "São Juliana",
            "Tupaciguara",
            "Uberlândia"});
            this.cb_destino.Location = new System.Drawing.Point(676, 575);
            this.cb_destino.Name = "cb_destino";
            this.cb_destino.Size = new System.Drawing.Size(121, 21);
            this.cb_destino.TabIndex = 4;
            // 
            // go_btn
            // 
            this.go_btn.Location = new System.Drawing.Point(803, 574);
            this.go_btn.Name = "go_btn";
            this.go_btn.Size = new System.Drawing.Size(46, 23);
            this.go_btn.TabIndex = 5;
            this.go_btn.Text = "Go";
            this.go_btn.UseVisualStyleBackColor = true;
            this.go_btn.Click += new System.EventHandler(this.go_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(532, 542);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 76);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(645, 478);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 617);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.go_btn);
            this.Controls.Add(this.cb_destino);
            this.Controls.Add(this.cb_partida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Shortest Path Finder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_partida;
        private System.Windows.Forms.ComboBox cb_destino;
        private System.Windows.Forms.Button go_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;

    }
}

