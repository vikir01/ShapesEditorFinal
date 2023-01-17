namespace ShapesEditor
{
    partial class FormProperties
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
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.buttonCalcel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonColor = new System.Windows.Forms.Button();
            this.panelRectangle = new System.Windows.Forms.Panel();
            this.panelCircle = new System.Windows.Forms.Panel();
            this.labelRadius = new System.Windows.Forms.Label();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.panelSquare = new System.Windows.Forms.Panel();
            this.labelSize = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.panelRectangle.SuspendLayout();
            this.panelCircle.SuspendLayout();
            this.panelSquare.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(3, 25);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(216, 20);
            this.textBoxHeight.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(3, 78);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(216, 20);
            this.textBoxWidth.TabIndex = 3;
            // 
            // buttonCalcel
            // 
            this.buttonCalcel.Location = new System.Drawing.Point(91, 326);
            this.buttonCalcel.Name = "buttonCalcel";
            this.buttonCalcel.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcel.TabIndex = 4;
            this.buttonCalcel.Text = "Cancel";
            this.buttonCalcel.UseVisualStyleBackColor = true;
            this.buttonCalcel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonCalcel_MouseClick);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(194, 326);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonOK_MouseClick);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(9, 326);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 6;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelRectangle
            // 
            this.panelRectangle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRectangle.AutoSize = true;
            this.panelRectangle.Controls.Add(this.textBoxHeight);
            this.panelRectangle.Controls.Add(this.label1);
            this.panelRectangle.Controls.Add(this.label2);
            this.panelRectangle.Controls.Add(this.textBoxWidth);
            this.panelRectangle.Location = new System.Drawing.Point(9, 6);
            this.panelRectangle.Name = "panelRectangle";
            this.panelRectangle.Size = new System.Drawing.Size(877, 111);
            this.panelRectangle.TabIndex = 7;
            this.panelRectangle.Visible = false;
            // 
            // panelCircle
            // 
            this.panelCircle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCircle.AutoSize = true;
            this.panelCircle.Controls.Add(this.labelRadius);
            this.panelCircle.Controls.Add(this.textBoxRadius);
            this.panelCircle.Location = new System.Drawing.Point(12, 123);
            this.panelCircle.Name = "panelCircle";
            this.panelCircle.Size = new System.Drawing.Size(877, 54);
            this.panelCircle.TabIndex = 8;
            this.panelCircle.Visible = false;
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(0, 0);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(40, 13);
            this.labelRadius.TabIndex = 2;
            this.labelRadius.Text = "Radius";
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(3, 16);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(216, 20);
            this.textBoxRadius.TabIndex = 3;
            // 
            // panelSquare
            // 
            this.panelSquare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSquare.AutoSize = true;
            this.panelSquare.Controls.Add(this.labelSize);
            this.panelSquare.Controls.Add(this.textBoxSize);
            this.panelSquare.Location = new System.Drawing.Point(9, 183);
            this.panelSquare.Name = "panelSquare";
            this.panelSquare.Size = new System.Drawing.Size(877, 54);
            this.panelSquare.TabIndex = 9;
            this.panelSquare.Visible = false;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(0, 0);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(27, 13);
            this.labelSize.TabIndex = 2;
            this.labelSize.Text = "Size";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Location = new System.Drawing.Point(3, 16);
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(216, 20);
            this.textBoxSize.TabIndex = 3;
            // 
            // FormProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 467);
            this.Controls.Add(this.panelSquare);
            this.Controls.Add(this.panelCircle);
            this.Controls.Add(this.panelRectangle);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCalcel);
            this.Name = "FormProperties";
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.FormProperties_Load);
            this.panelRectangle.ResumeLayout(false);
            this.panelRectangle.PerformLayout();
            this.panelCircle.ResumeLayout(false);
            this.panelCircle.PerformLayout();
            this.panelSquare.ResumeLayout(false);
            this.panelSquare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Button buttonCalcel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Panel panelRectangle;
        private System.Windows.Forms.Panel panelCircle;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Panel panelSquare;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.TextBox textBoxSize;
    }
}