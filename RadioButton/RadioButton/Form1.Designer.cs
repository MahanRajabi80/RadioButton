namespace RadioButton
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
            this.btnShow = new System.Windows.Forms.Button();
            this.rdiNone = new System.Windows.Forms.RadioButton();
            this.rdiFixedSingle = new System.Windows.Forms.RadioButton();
            this.rdiFixed3D = new System.Windows.Forms.RadioButton();
            this.rdiFixedDialog = new System.Windows.Forms.RadioButton();
            this.rdiSizeable = new System.Windows.Forms.RadioButton();
            this.rdiFixedToolWindow = new System.Windows.Forms.RadioButton();
            this.rdiSizeableToolWindow = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(322, 242);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(125, 39);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show Form Border";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // rdiNone
            // 
            this.rdiNone.AutoSize = true;
            this.rdiNone.Location = new System.Drawing.Point(322, 46);
            this.rdiNone.Name = "rdiNone";
            this.rdiNone.Size = new System.Drawing.Size(51, 17);
            this.rdiNone.TabIndex = 1;
            this.rdiNone.Text = "None";
            this.rdiNone.UseVisualStyleBackColor = true;
            // 
            // rdiFixedSingle
            // 
            this.rdiFixedSingle.AutoSize = true;
            this.rdiFixedSingle.Location = new System.Drawing.Point(322, 69);
            this.rdiFixedSingle.Name = "rdiFixedSingle";
            this.rdiFixedSingle.Size = new System.Drawing.Size(79, 17);
            this.rdiFixedSingle.TabIndex = 2;
            this.rdiFixedSingle.Text = "FixedSingle";
            this.rdiFixedSingle.UseVisualStyleBackColor = true;
            // 
            // rdiFixed3D
            // 
            this.rdiFixed3D.AutoSize = true;
            this.rdiFixed3D.Location = new System.Drawing.Point(322, 92);
            this.rdiFixed3D.Name = "rdiFixed3D";
            this.rdiFixed3D.Size = new System.Drawing.Size(64, 17);
            this.rdiFixed3D.TabIndex = 3;
            this.rdiFixed3D.Text = "Fixed3D";
            this.rdiFixed3D.UseVisualStyleBackColor = true;
            // 
            // rdiFixedDialog
            // 
            this.rdiFixedDialog.AutoSize = true;
            this.rdiFixedDialog.Location = new System.Drawing.Point(322, 115);
            this.rdiFixedDialog.Name = "rdiFixedDialog";
            this.rdiFixedDialog.Size = new System.Drawing.Size(80, 17);
            this.rdiFixedDialog.TabIndex = 4;
            this.rdiFixedDialog.Text = "FixedDialog";
            this.rdiFixedDialog.UseVisualStyleBackColor = true;
            // 
            // rdiSizeable
            // 
            this.rdiSizeable.AutoSize = true;
            this.rdiSizeable.Checked = true;
            this.rdiSizeable.Location = new System.Drawing.Point(322, 138);
            this.rdiSizeable.Name = "rdiSizeable";
            this.rdiSizeable.Size = new System.Drawing.Size(65, 17);
            this.rdiSizeable.TabIndex = 5;
            this.rdiSizeable.TabStop = true;
            this.rdiSizeable.Text = "Sizeable";
            this.rdiSizeable.UseVisualStyleBackColor = true;
            // 
            // rdiFixedToolWindow
            // 
            this.rdiFixedToolWindow.AutoSize = true;
            this.rdiFixedToolWindow.Location = new System.Drawing.Point(322, 161);
            this.rdiFixedToolWindow.Name = "rdiFixedToolWindow";
            this.rdiFixedToolWindow.Size = new System.Drawing.Size(110, 17);
            this.rdiFixedToolWindow.TabIndex = 6;
            this.rdiFixedToolWindow.Text = "FixedToolWindow";
            this.rdiFixedToolWindow.UseVisualStyleBackColor = true;
            // 
            // rdiSizeableToolWindow
            // 
            this.rdiSizeableToolWindow.AutoSize = true;
            this.rdiSizeableToolWindow.Location = new System.Drawing.Point(322, 184);
            this.rdiSizeableToolWindow.Name = "rdiSizeableToolWindow";
            this.rdiSizeableToolWindow.Size = new System.Drawing.Size(125, 17);
            this.rdiSizeableToolWindow.TabIndex = 7;
            this.rdiSizeableToolWindow.Text = "SizeableToolWindow";
            this.rdiSizeableToolWindow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdiSizeableToolWindow);
            this.Controls.Add(this.rdiFixedToolWindow);
            this.Controls.Add(this.rdiSizeable);
            this.Controls.Add(this.rdiFixedDialog);
            this.Controls.Add(this.rdiFixed3D);
            this.Controls.Add(this.rdiFixedSingle);
            this.Controls.Add(this.rdiNone);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.RadioButton rdiNone;
        private System.Windows.Forms.RadioButton rdiFixedSingle;
        private System.Windows.Forms.RadioButton rdiFixed3D;
        private System.Windows.Forms.RadioButton rdiFixedDialog;
        private System.Windows.Forms.RadioButton rdiSizeable;
        private System.Windows.Forms.RadioButton rdiFixedToolWindow;
        private System.Windows.Forms.RadioButton rdiSizeableToolWindow;
    }
}

