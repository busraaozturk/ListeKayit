namespace Araba
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbKasa = new ComboBox();
            cmbModel = new ComboBox();
            cmbMarka = new ComboBox();
            txtKapiSayisi = new TextBox();
            txtPencereSayisi = new TextBox();
            dgwSiparisVerilen = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwSiparisVerilen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 75);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Marka : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 75);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Model : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(512, 75);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 2;
            label3.Text = "Kasa Tipi : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 132);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 3;
            label4.Text = "Pencere Sayısı : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(147, 132);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 4;
            label5.Text = "Kapı Sayısı : ";
            // 
            // cmbKasa
            // 
            cmbKasa.FormattingEnabled = true;
            cmbKasa.Location = new Point(580, 72);
            cmbKasa.Name = "cmbKasa";
            cmbKasa.Size = new Size(156, 23);
            cmbKasa.TabIndex = 5;
            cmbKasa.SelectedIndexChanged += cmbKasa_SelectedIndexChanged;
            // 
            // cmbModel
            // 
            cmbModel.Location = new Point(334, 72);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(121, 23);
            cmbModel.TabIndex = 12;
            cmbModel.SelectedIndexChanged += cmbModel_SelectedIndexChanged;
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(92, 72);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(152, 23);
            cmbMarka.TabIndex = 7;
            cmbMarka.SelectedIndexChanged += cmbMarka_SelectedIndexChanged;
            // 
            // txtKapiSayisi
            // 
            txtKapiSayisi.Location = new Point(224, 129);
            txtKapiSayisi.Name = "txtKapiSayisi";
            txtKapiSayisi.Size = new Size(146, 23);
            txtKapiSayisi.TabIndex = 8;
            // 
            // txtPencereSayisi
            // 
            txtPencereSayisi.Location = new Point(498, 129);
            txtPencereSayisi.Name = "txtPencereSayisi";
            txtPencereSayisi.Size = new Size(146, 23);
            txtPencereSayisi.TabIndex = 9;
            // 
            // dgwSiparisVerilen
            // 
            dgwSiparisVerilen.BackgroundColor = SystemColors.Control;
            dgwSiparisVerilen.BorderStyle = BorderStyle.None;
            dgwSiparisVerilen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwSiparisVerilen.Location = new Point(120, 207);
            dgwSiparisVerilen.Name = "dgwSiparisVerilen";
            dgwSiparisVerilen.RowTemplate.Height = 25;
            dgwSiparisVerilen.Size = new Size(573, 200);
            dgwSiparisVerilen.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(676, 165);
            button1.Name = "button1";
            button1.Size = new Size(91, 33);
            button1.TabIndex = 11;
            button1.Text = "Kayıt Listele";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 450);
            Controls.Add(button1);
            Controls.Add(dgwSiparisVerilen);
            Controls.Add(txtPencereSayisi);
            Controls.Add(txtKapiSayisi);
            Controls.Add(cmbMarka);
            Controls.Add(cmbModel);
            Controls.Add(cmbKasa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwSiparisVerilen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbKasa;
        private ComboBox cmbModel;
        private ComboBox cmbMarka;
        private TextBox txtKapiSayisi;
        private TextBox txtPencereSayisi;
        private DataGridView dgwSiparisVerilen;
        private Button button1;
    }
}