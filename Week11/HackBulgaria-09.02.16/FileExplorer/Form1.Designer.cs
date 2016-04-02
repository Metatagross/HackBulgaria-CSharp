namespace FileExplorer
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
        protected override void Dispose ( bool disposing )
        {
            if(disposing && (components != null))
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
        private void InitializeComponent ( )
        {
            this.tview1 = new System.Windows.Forms.TreeView();
            this.lview1 = new System.Windows.Forms.ListView();
            this.lblFB = new System.Windows.Forms.Label();
            this.lblEF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tview1
            // 
            this.tview1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tview1.Location = new System.Drawing.Point(12, 105);
            this.tview1.Name = "tview1";
            this.tview1.Size = new System.Drawing.Size(173, 194);
            this.tview1.TabIndex = 0;
            this.tview1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tview1_AfterSelect);
            // 
            // lview1
            // 
            this.lview1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lview1.Location = new System.Drawing.Point(215, 105);
            this.lview1.Name = "lview1";
            this.lview1.Size = new System.Drawing.Size(157, 194);
            this.lview1.TabIndex = 1;
            this.lview1.UseCompatibleStateImageBehavior = false;
            this.lview1.View = System.Windows.Forms.View.List;
            this.lview1.SelectedIndexChanged += new System.EventHandler(this.lview1_SelectedIndexChanged);
            // 
            // lblFB
            // 
            this.lblFB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFB.AutoSize = true;
            this.lblFB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblFB.Location = new System.Drawing.Point(50, 57);
            this.lblFB.Name = "lblFB";
            this.lblFB.Size = new System.Drawing.Size(281, 31);
            this.lblFB.TabIndex = 2;
            this.lblFB.Text = "THE FILE BROWSER";
            this.lblFB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEF
            // 
            this.lblEF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEF.AutoSize = true;
            this.lblEF.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblEF.Location = new System.Drawing.Point(128, 9);
            this.lblEF.Name = "lblEF";
            this.lblEF.Size = new System.Drawing.Size(143, 39);
            this.lblEF.TabIndex = 3;
            this.lblEF.Text = "ExFindo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FileExplorer.Properties.Resources.Lady_Gaga_Artpop;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.lblEF);
            this.Controls.Add(this.lblFB);
            this.Controls.Add(this.lview1);
            this.Controls.Add(this.tview1);
            this.Name = "Form1";
            this.Text = "File Explorer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tview1;
        private System.Windows.Forms.ListView lview1;
        private System.Windows.Forms.Label lblFB;
        private System.Windows.Forms.Label lblEF;
    }
}

