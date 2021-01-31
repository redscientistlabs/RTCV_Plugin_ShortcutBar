namespace SHORTCUTBAR.UI
{

    partial class PluginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginForm));
            this.btnTest = new System.Windows.Forms.Button();
            this.btnAddShortcut = new System.Windows.Forms.Button();
            this.btnRemoveShortcut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Location = new System.Drawing.Point(6, 5);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(143, 45);
            this.btnTest.TabIndex = 4;
            this.btnTest.Tag = "color:dark2";
            this.btnTest.Text = "Test Test Test Test Test Test Test Test Test ";
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Visible = false;
            // 
            // btnAddShortcut
            // 
            this.btnAddShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddShortcut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAddShortcut.FlatAppearance.BorderSize = 0;
            this.btnAddShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShortcut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShortcut.ForeColor = System.Drawing.Color.White;
            this.btnAddShortcut.Location = new System.Drawing.Point(129, 362);
            this.btnAddShortcut.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddShortcut.Name = "btnAddShortcut";
            this.btnAddShortcut.Size = new System.Drawing.Size(21, 23);
            this.btnAddShortcut.TabIndex = 7;
            this.btnAddShortcut.Tag = "color:dark2";
            this.btnAddShortcut.Text = "+";
            this.btnAddShortcut.UseVisualStyleBackColor = false;
            this.btnAddShortcut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnAddShortcut_MouseDown);
            // 
            // btnRemoveShortcut
            // 
            this.btnRemoveShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveShortcut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnRemoveShortcut.FlatAppearance.BorderSize = 0;
            this.btnRemoveShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveShortcut.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveShortcut.ForeColor = System.Drawing.Color.White;
            this.btnRemoveShortcut.Location = new System.Drawing.Point(103, 362);
            this.btnRemoveShortcut.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveShortcut.Name = "btnRemoveShortcut";
            this.btnRemoveShortcut.Size = new System.Drawing.Size(21, 23);
            this.btnRemoveShortcut.TabIndex = 8;
            this.btnRemoveShortcut.Tag = "color:dark2";
            this.btnRemoveShortcut.Text = "-";
            this.btnRemoveShortcut.UseVisualStyleBackColor = false;
            this.btnRemoveShortcut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRemoveShortcut_MouseDown);
            // 
            // PluginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(154, 389);
            this.Controls.Add(this.btnRemoveShortcut);
            this.Controls.Add(this.btnAddShortcut);
            this.Controls.Add(this.btnTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(0, 250);
            this.Name = "PluginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "color:dark3";
            this.Text = "Plugin Form";
            this.Load += new System.EventHandler(this.PluginForm_Load);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnAddShortcut;
        private System.Windows.Forms.Button btnRemoveShortcut;
    }
}
