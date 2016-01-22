using System;

namespace SpotlightSaver
{
    partial class ImageList
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.gvSpotlightImages = new System.Windows.Forms.DataGridView();
            this.txtMinimumWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinimumHeight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvSpotlightImages)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(471, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(363, 348);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(102, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "&Load Images";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(13, 13);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(533, 20);
            this.txtFilePath.TabIndex = 2;
            // 
            // gvSpotlightImages
            // 
            this.gvSpotlightImages.AllowUserToAddRows = false;
            this.gvSpotlightImages.AllowUserToDeleteRows = false;
            this.gvSpotlightImages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSpotlightImages.Location = new System.Drawing.Point(13, 65);
            this.gvSpotlightImages.Name = "gvSpotlightImages";
            this.gvSpotlightImages.Size = new System.Drawing.Size(533, 277);
            this.gvSpotlightImages.TabIndex = 3;
            // 
            // txtMinimumWidth
            // 
            this.txtMinimumWidth.Location = new System.Drawing.Point(98, 39);
            this.txtMinimumWidth.Name = "txtMinimumWidth";
            this.txtMinimumWidth.Size = new System.Drawing.Size(100, 20);
            this.txtMinimumWidth.TabIndex = 4;
            this.txtMinimumWidth.Text = "1920";
            this.txtMinimumWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Minimum Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Minimum Height";
            // 
            // txtMinimumHeight
            // 
            this.txtMinimumHeight.Location = new System.Drawing.Point(302, 39);
            this.txtMinimumHeight.Name = "txtMinimumHeight";
            this.txtMinimumHeight.Size = new System.Drawing.Size(100, 20);
            this.txtMinimumHeight.TabIndex = 6;
            this.txtMinimumHeight.Text = "1080";
            this.txtMinimumHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersOnly_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 383);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinimumHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMinimumWidth);
            this.Controls.Add(this.gvSpotlightImages);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvSpotlightImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.DataGridView gvSpotlightImages;
        private System.Windows.Forms.TextBox txtMinimumWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinimumHeight;
    }
}

