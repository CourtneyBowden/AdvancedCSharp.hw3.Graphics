namespace hw3.Bowden
{
    partial class frmThreadGraphics
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
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblShape = new System.Windows.Forms.Label();
            this.cboShape = new System.Windows.Forms.ComboBox();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.btnAddShape = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.lblThreadCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // nudSpeed
            // 
            this.nudSpeed.Location = new System.Drawing.Point(398, 76);
            this.nudSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(120, 20);
            this.nudSpeed.TabIndex = 18;
            this.nudSpeed.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(301, 78);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblSpeed.TabIndex = 17;
            this.lblSpeed.Text = "Speed";
            // 
            // lblShape
            // 
            this.lblShape.AutoSize = true;
            this.lblShape.Location = new System.Drawing.Point(301, 33);
            this.lblShape.Name = "lblShape";
            this.lblShape.Size = new System.Drawing.Size(38, 13);
            this.lblShape.TabIndex = 16;
            this.lblShape.Text = "Shape";
            // 
            // cboShape
            // 
            this.cboShape.FormattingEnabled = true;
            this.cboShape.Items.AddRange(new object[] {
            "Circle",
            "Rectangle",
            "Triangle"});
            this.cboShape.Location = new System.Drawing.Point(397, 30);
            this.cboShape.Name = "cboShape";
            this.cboShape.Size = new System.Drawing.Size(121, 21);
            this.cboShape.TabIndex = 10;
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDraw.Location = new System.Drawing.Point(10, 113);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(695, 318);
            this.pnlDraw.TabIndex = 15;
            // 
            // btnAddShape
            // 
            this.btnAddShape.AutoSize = true;
            this.btnAddShape.Location = new System.Drawing.Point(551, 68);
            this.btnAddShape.Name = "btnAddShape";
            this.btnAddShape.Size = new System.Drawing.Size(98, 23);
            this.btnAddShape.TabIndex = 0;
            this.btnAddShape.Text = "Add Shape";
            this.btnAddShape.UseVisualStyleBackColor = true;
            this.btnAddShape.Click += new System.EventHandler(this.btnAddShape_Click);
            // 
            // btnColor
            // 
            this.btnColor.AutoSize = true;
            this.btnColor.Location = new System.Drawing.Point(551, 28);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(98, 23);
            this.btnColor.TabIndex = 13;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Location = new System.Drawing.Point(10, 68);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnResume
            // 
            this.btnResume.AutoSize = true;
            this.btnResume.Enabled = false;
            this.btnResume.Location = new System.Drawing.Point(10, 23);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(253, 26);
            this.btnResume.TabIndex = 11;
            this.btnResume.Text = "Pause";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // lblThreadCount
            // 
            this.lblThreadCount.AutoSize = true;
            this.lblThreadCount.Location = new System.Drawing.Point(10, 434);
            this.lblThreadCount.Name = "lblThreadCount";
            this.lblThreadCount.Size = new System.Drawing.Size(90, 13);
            this.lblThreadCount.TabIndex = 19;
            this.lblThreadCount.Text = "Thread Count = 0";
            // 
            // frmThreadGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 458);
            this.Controls.Add(this.nudSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblShape);
            this.Controls.Add(this.cboShape);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.btnAddShape);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.lblThreadCount);
            this.Name = "frmThreadGraphics";
            this.Text = "Homework 3: Courtney Bowden";
            this.Load += new System.EventHandler(this.frmThreadGraphics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblShape;
        private System.Windows.Forms.ComboBox cboShape;
        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Button btnAddShape;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.Label lblThreadCount;
    }
}