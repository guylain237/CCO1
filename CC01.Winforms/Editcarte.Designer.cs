﻿
namespace CC01.Winforms
{
    partial class Editcarte
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oobservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonimage = new System.Windows.Forms.Button();
            this.buttonsupprim = new System.Windows.Forms.Button();
            this.buttonmodif = new System.Windows.Forms.Button();
            this.buttonajout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(644, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 5);
            this.panel1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.Silver;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(723, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 34);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "recherche";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 141);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 34);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.equipement,
            this.quantite,
            this.oobservation,
            this.Column1,
            this.Column2,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1483, 511);
            this.dataGridView1.TabIndex = 16;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "Nom";
            this.numero.HeaderText = "NOM";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            // 
            // equipement
            // 
            this.equipement.DataPropertyName = "Prenom";
            this.equipement.HeaderText = "PRENOM";
            this.equipement.MinimumWidth = 6;
            this.equipement.Name = "equipement";
            // 
            // quantite
            // 
            this.quantite.DataPropertyName = "Date_naissance";
            this.quantite.HeaderText = "Date naissance";
            this.quantite.MinimumWidth = 6;
            this.quantite.Name = "quantite";
            // 
            // oobservation
            // 
            this.oobservation.DataPropertyName = "Lieu";
            this.oobservation.HeaderText = "LIEU";
            this.oobservation.MinimumWidth = 6;
            this.oobservation.Name = "oobservation";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Contact";
            this.Column1.HeaderText = "CONCTACT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Matricule";
            this.Column2.HeaderText = "MATRICULE";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Email";
            this.Column4.HeaderText = "EMAIL";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Blue;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(138, 181);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1190, 10);
            this.flowLayoutPanel2.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Blue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(138, 82);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1190, 10);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // buttonimage
            // 
            this.buttonimage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonimage.BackColor = System.Drawing.Color.Black;
            this.buttonimage.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonimage.ForeColor = System.Drawing.Color.White;
            this.buttonimage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonimage.Location = new System.Drawing.Point(1081, 27);
            this.buttonimage.Name = "buttonimage";
            this.buttonimage.Size = new System.Drawing.Size(223, 49);
            this.buttonimage.TabIndex = 15;
            this.buttonimage.Text = "Imprimer";
            this.buttonimage.UseVisualStyleBackColor = false;
            // 
            // buttonsupprim
            // 
            this.buttonsupprim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonsupprim.BackColor = System.Drawing.Color.Black;
            this.buttonsupprim.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsupprim.ForeColor = System.Drawing.Color.White;
            this.buttonsupprim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonsupprim.Location = new System.Drawing.Point(779, 27);
            this.buttonsupprim.Name = "buttonsupprim";
            this.buttonsupprim.Size = new System.Drawing.Size(223, 49);
            this.buttonsupprim.TabIndex = 14;
            this.buttonsupprim.Text = "Supprimer";
            this.buttonsupprim.UseVisualStyleBackColor = false;
            // 
            // buttonmodif
            // 
            this.buttonmodif.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonmodif.BackColor = System.Drawing.Color.Black;
            this.buttonmodif.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonmodif.ForeColor = System.Drawing.Color.White;
            this.buttonmodif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonmodif.Location = new System.Drawing.Point(448, 27);
            this.buttonmodif.Name = "buttonmodif";
            this.buttonmodif.Size = new System.Drawing.Size(223, 49);
            this.buttonmodif.TabIndex = 13;
            this.buttonmodif.Text = "Modifier";
            this.buttonmodif.UseVisualStyleBackColor = false;
            this.buttonmodif.Click += new System.EventHandler(this.buttonmodif_Click);
            // 
            // buttonajout
            // 
            this.buttonajout.BackColor = System.Drawing.Color.Black;
            this.buttonajout.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonajout.ForeColor = System.Drawing.Color.White;
            this.buttonajout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonajout.Location = new System.Drawing.Point(138, 27);
            this.buttonajout.Name = "buttonajout";
            this.buttonajout.Size = new System.Drawing.Size(223, 49);
            this.buttonajout.TabIndex = 11;
            this.buttonajout.Text = "Ajouter";
            this.buttonajout.UseVisualStyleBackColor = false;
            this.buttonajout.Click += new System.EventHandler(this.buttonajout_Click);
            // 
            // Editcarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1516, 761);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.buttonimage);
            this.Controls.Add(this.buttonsupprim);
            this.Controls.Add(this.buttonmodif);
            this.Controls.Add(this.buttonajout);
            this.Name = "Editcarte";
            this.Text = "Editcarte";
            this.Load += new System.EventHandler(this.Editcarte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonimage;
        private System.Windows.Forms.Button buttonsupprim;
        private System.Windows.Forms.Button buttonmodif;
        private System.Windows.Forms.Button buttonajout;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipement;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn oobservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}