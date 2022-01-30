namespace PixelCounter
{
    partial class MainForm
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
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbSkipTransparentPixels = new System.Windows.Forms.RadioButton();
            this.rbPaintTransparentPixels = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbImage = new PixelCounter.ClearPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(12, 12);
            this.btnChooseImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(117, 44);
            this.btnChooseImage.TabIndex = 0;
            this.btnChooseImage.Text = "Choose image";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(306, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 147);
            this.panel1.TabIndex = 1;
            // 
            // rbSkipTransparentPixels
            // 
            this.rbSkipTransparentPixels.AutoSize = true;
            this.rbSkipTransparentPixels.Checked = true;
            this.rbSkipTransparentPixels.Location = new System.Drawing.Point(19, 62);
            this.rbSkipTransparentPixels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSkipTransparentPixels.Name = "rbSkipTransparentPixels";
            this.rbSkipTransparentPixels.Size = new System.Drawing.Size(172, 21);
            this.rbSkipTransparentPixels.TabIndex = 3;
            this.rbSkipTransparentPixels.TabStop = true;
            this.rbSkipTransparentPixels.Text = "Skip transparent pixels";
            this.rbSkipTransparentPixels.UseVisualStyleBackColor = true;
            // 
            // rbPaintTransparentPixels
            // 
            this.rbPaintTransparentPixels.AutoSize = true;
            this.rbPaintTransparentPixels.Location = new System.Drawing.Point(19, 89);
            this.rbPaintTransparentPixels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPaintTransparentPixels.Name = "rbPaintTransparentPixels";
            this.rbPaintTransparentPixels.Size = new System.Drawing.Size(215, 21);
            this.rbPaintTransparentPixels.TabIndex = 4;
            this.rbPaintTransparentPixels.Text = "Make transparent pixels white";
            this.rbPaintTransparentPixels.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Height:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(272, 179);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(0, 17);
            this.lblHeight.TabIndex = 8;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(272, 163);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(0, 17);
            this.lblWidth.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(306, 163);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 426);
            this.panel2.TabIndex = 2;
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImage.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.pbImage.Location = new System.Drawing.Point(12, 337);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(252, 252);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 10;
            this.pbImage.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 600);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbPaintTransparentPixels);
            this.Controls.Add(this.rbSkipTransparentPixels);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnChooseImage);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbSkipTransparentPixels;
        private System.Windows.Forms.RadioButton rbPaintTransparentPixels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Panel panel2;
        private ClearPictureBox pbImage;
    }
}

