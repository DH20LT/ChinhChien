﻿
namespace ChinChin.Forms_QuanLy
{
    partial class QuanLyKhoHang
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
            this.VatLieuGridView = new System.Windows.Forms.DataGridView();
            this.MaVatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteButton = new FontAwesome.Sharp.IconButton();
            this.NewButton = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.VatLieuGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VatLieuGridView
            // 
            this.VatLieuGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VatLieuGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaVatLieu});
            this.VatLieuGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VatLieuGridView.Location = new System.Drawing.Point(0, 0);
            this.VatLieuGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VatLieuGridView.Name = "VatLieuGridView";
            this.VatLieuGridView.RowHeadersWidth = 51;
            this.VatLieuGridView.RowTemplate.Height = 24;
            this.VatLieuGridView.Size = new System.Drawing.Size(600, 366);
            this.VatLieuGridView.TabIndex = 0;
            // 
            // MaVatLieu
            // 
            this.MaVatLieu.HeaderText = "Mã Vật Liệu";
            this.MaVatLieu.MinimumWidth = 6;
            this.MaVatLieu.Name = "MaVatLieu";
            this.MaVatLieu.Width = 125;
            // 
            // EditButton
            // 
            this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.EditButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.EditButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditButton.IconSize = 40;
            this.EditButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.EditButton.Location = new System.Drawing.Point(394, 0);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(89, 46);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.NewButton);
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 48);
            this.panel1.TabIndex = 2;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.DeleteButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.DeleteButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DeleteButton.IconSize = 40;
            this.DeleteButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.DeleteButton.Location = new System.Drawing.Point(488, 0);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(110, 46);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // NewButton
            // 
            this.NewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.NewButton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.NewButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NewButton.IconSize = 40;
            this.NewButton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.NewButton.Location = new System.Drawing.Point(301, 0);
            this.NewButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(89, 46);
            this.NewButton.TabIndex = 2;
            this.NewButton.Text = "New";
            this.NewButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewButton.UseVisualStyleBackColor = true;
            // 
            // QuanLyKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VatLieuGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QuanLyKhoHang";
            this.Text = "QuanLyKhoHang";
            ((System.ComponentModel.ISupportInitialize)(this.VatLieuGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VatLieuGridView;
        private FontAwesome.Sharp.IconButton EditButton;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton NewButton;
        private FontAwesome.Sharp.IconButton DeleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaVatLieu;
    }
}