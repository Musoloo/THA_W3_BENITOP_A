namespace tha_20_march
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
            this.components = new System.ComponentModel.Container();
            this.nextformbutton = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.myfavoriteartist = new System.Windows.Forms.Label();
            this.favoritetextbox = new System.Windows.Forms.TextBox();
            this.agreement = new System.Windows.Forms.CheckBox();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextformbutton
            // 
            this.nextformbutton.Location = new System.Drawing.Point(610, 365);
            this.nextformbutton.Name = "nextformbutton";
            this.nextformbutton.Size = new System.Drawing.Size(117, 45);
            this.nextformbutton.TabIndex = 0;
            this.nextformbutton.Text = "Open Next Form";
            this.nextformbutton.UseVisualStyleBackColor = true;
            this.nextformbutton.Click += new System.EventHandler(this.nextformbutton_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(56, 59);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(50, 16);
            this.name.TabIndex = 1;
            this.name.Text = "Name :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(190, 59);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(144, 22);
            this.nametextbox.TabIndex = 3;
            // 
            // myfavoriteartist
            // 
            this.myfavoriteartist.AutoSize = true;
            this.myfavoriteartist.Location = new System.Drawing.Point(56, 96);
            this.myfavoriteartist.Name = "myfavoriteartist";
            this.myfavoriteartist.Size = new System.Drawing.Size(115, 16);
            this.myfavoriteartist.TabIndex = 4;
            this.myfavoriteartist.Text = "My Favorite Artist :";
            // 
            // favoritetextbox
            // 
            this.favoritetextbox.Location = new System.Drawing.Point(190, 96);
            this.favoritetextbox.Name = "favoritetextbox";
            this.favoritetextbox.Size = new System.Drawing.Size(144, 22);
            this.favoritetextbox.TabIndex = 5;
            // 
            // agreement
            // 
            this.agreement.AutoSize = true;
            this.agreement.Location = new System.Drawing.Point(59, 145);
            this.agreement.Name = "agreement";
            this.agreement.Size = new System.Drawing.Size(235, 20);
            this.agreement.TabIndex = 7;
            this.agreement.Text = "All of the content I put above is true!";
            this.agreement.UseVisualStyleBackColor = true;
            this.agreement.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // submit
            // 
            this.submit.Enabled = false;
            this.submit.Location = new System.Drawing.Point(352, 190);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 8;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.agreement);
            this.Controls.Add(this.favoritetextbox);
            this.Controls.Add(this.myfavoriteartist);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nextformbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextformbutton;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.Label myfavoriteartist;
        private System.Windows.Forms.TextBox favoritetextbox;
        private System.Windows.Forms.CheckBox agreement;
        private System.Windows.Forms.Button submit;
    }
}

