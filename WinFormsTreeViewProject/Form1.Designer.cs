namespace WinFormsTreeViewProject
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
            this.trvDrive = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // trvDrive
            // 
            this.trvDrive.Location = new System.Drawing.Point(12, 12);
            this.trvDrive.Name = "trvDrive";
            this.trvDrive.Size = new System.Drawing.Size(439, 399);
            this.trvDrive.TabIndex = 1;
            this.trvDrive.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvDrive_BeforeExpand);
            this.trvDrive.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvDrive_BeforeSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.trvDrive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private TreeView trvDrive;
    }
}