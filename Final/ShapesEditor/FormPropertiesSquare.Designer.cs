namespace ShapesEditor
{
    partial class FormPropertiesSquare
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
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCalcel = new System.Windows.Forms.Button();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(12, 65);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 13;
            this.buttonColor.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(153, 104);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCalcel
            // 
            this.buttonCalcel.Location = new System.Drawing.Point(72, 104);
            this.buttonCalcel.Name = "buttonCalcel";
            this.buttonCalcel.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcel.TabIndex = 11;
            this.buttonCalcel.Text = "Cancel";
            this.buttonCalcel.UseVisualStyleBackColor = true;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(12, 29);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(216, 20);
            this.textBoxWidth.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Size";
            // 
            // FormPropertiesSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 147);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCalcel);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.label2);
            this.Name = "FormPropertiesSquare";
            this.Text = "FormPropertiesSquare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCalcel;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label label2;
    }
}