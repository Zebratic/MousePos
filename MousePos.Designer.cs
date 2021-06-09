
namespace MousePosForm
{
    partial class MousePos
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
            this.components = new System.ComponentModel.Container();
            this.MouseRecorder = new System.Windows.Forms.Timer(this.components);
            this.XPos = new System.Windows.Forms.Label();
            this.YPos = new System.Windows.Forms.Label();
            this.MouseArea = new System.Windows.Forms.PictureBox();
            this.Drawer = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.MaxDotsAllowed = new System.Windows.Forms.NumericUpDown();
            this.lblMaxDots = new System.Windows.Forms.Label();
            this.lblClickToDraw = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MouseArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxDotsAllowed)).BeginInit();
            this.SuspendLayout();
            // 
            // MouseRecorder
            // 
            this.MouseRecorder.Enabled = true;
            this.MouseRecorder.Interval = 10;
            this.MouseRecorder.Tick += new System.EventHandler(this.MouseRecorder_Tick);
            // 
            // XPos
            // 
            this.XPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XPos.AutoSize = true;
            this.XPos.Location = new System.Drawing.Point(407, 9);
            this.XPos.Name = "XPos";
            this.XPos.Size = new System.Drawing.Size(32, 13);
            this.XPos.TabIndex = 0;
            this.XPos.Text = "XPos";
            // 
            // YPos
            // 
            this.YPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.YPos.AutoSize = true;
            this.YPos.Location = new System.Drawing.Point(407, 22);
            this.YPos.Name = "YPos";
            this.YPos.Size = new System.Drawing.Size(32, 13);
            this.YPos.TabIndex = 1;
            this.YPos.Text = "YPos";
            // 
            // MouseArea
            // 
            this.MouseArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MouseArea.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MouseArea.Location = new System.Drawing.Point(10, 9);
            this.MouseArea.Name = "MouseArea";
            this.MouseArea.Size = new System.Drawing.Size(391, 400);
            this.MouseArea.TabIndex = 2;
            this.MouseArea.TabStop = false;
            // 
            // Drawer
            // 
            this.Drawer.Enabled = true;
            this.Drawer.Interval = 10;
            this.Drawer.Tick += new System.EventHandler(this.Drawer_Tick);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(407, 386);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MaxDotsAllowed
            // 
            this.MaxDotsAllowed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxDotsAllowed.Location = new System.Drawing.Point(407, 360);
            this.MaxDotsAllowed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaxDotsAllowed.Name = "MaxDotsAllowed";
            this.MaxDotsAllowed.Size = new System.Drawing.Size(84, 20);
            this.MaxDotsAllowed.TabIndex = 4;
            this.MaxDotsAllowed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblMaxDots
            // 
            this.lblMaxDots.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxDots.AutoSize = true;
            this.lblMaxDots.Location = new System.Drawing.Point(404, 344);
            this.lblMaxDots.Name = "lblMaxDots";
            this.lblMaxDots.Size = new System.Drawing.Size(95, 13);
            this.lblMaxDots.TabIndex = 5;
            this.lblMaxDots.Text = "Max Allowed Dots:";
            // 
            // lblClickToDraw
            // 
            this.lblClickToDraw.AutoSize = true;
            this.lblClickToDraw.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblClickToDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickToDraw.Location = new System.Drawing.Point(10, 9);
            this.lblClickToDraw.Name = "lblClickToDraw";
            this.lblClickToDraw.Size = new System.Drawing.Size(224, 37);
            this.lblClickToDraw.TabIndex = 6;
            this.lblClickToDraw.Text = "Click to draw!";
            // 
            // MousePos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 421);
            this.Controls.Add(this.lblClickToDraw);
            this.Controls.Add(this.lblMaxDots);
            this.Controls.Add(this.MaxDotsAllowed);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.MouseArea);
            this.Controls.Add(this.YPos);
            this.Controls.Add(this.XPos);
            this.Name = "MousePos";
            this.Text = "Mouse Pos";
            ((System.ComponentModel.ISupportInitialize)(this.MouseArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxDotsAllowed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MouseRecorder;
        private System.Windows.Forms.Label XPos;
        private System.Windows.Forms.Label YPos;
        private System.Windows.Forms.PictureBox MouseArea;
        private System.Windows.Forms.Timer Drawer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown MaxDotsAllowed;
        private System.Windows.Forms.Label lblMaxDots;
        private System.Windows.Forms.Label lblClickToDraw;
    }
}

