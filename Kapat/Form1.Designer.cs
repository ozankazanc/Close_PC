
namespace Kapat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txTime = new System.Windows.Forms.TextBox();
            this.btnOkey = new System.Windows.Forms.Button();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFixBug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txTime
            // 
            this.txTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txTime.Location = new System.Drawing.Point(132, 60);
            this.txTime.Name = "txTime";
            this.txTime.Size = new System.Drawing.Size(191, 38);
            this.txTime.TabIndex = 0;
            // 
            // btnOkey
            // 
            this.btnOkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOkey.Location = new System.Drawing.Point(329, 12);
            this.btnOkey.Name = "btnOkey";
            this.btnOkey.Size = new System.Drawing.Size(119, 86);
            this.btnOkey.TabIndex = 1;
            this.btnOkey.Text = "Başlat";
            this.btnOkey.UseVisualStyleBackColor = true;
            this.btnOkey.Click += new System.EventHandler(this.BtnOkey_Click);
            // 
            // cbTime
            // 
            this.cbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Location = new System.Drawing.Point(132, 12);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(191, 39);
            this.cbTime.TabIndex = 2;
            this.cbTime.Click += new System.EventHandler(this.CbTime_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.Location = new System.Drawing.Point(454, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 86);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Durdur";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seç:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Elle Gir:";
            // 
            // btnFixBug
            // 
            this.btnFixBug.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFixBug.Location = new System.Drawing.Point(579, 12);
            this.btnFixBug.Name = "btnFixBug";
            this.btnFixBug.Size = new System.Drawing.Size(119, 86);
            this.btnFixBug.TabIndex = 6;
            this.btnFixBug.Text = "Fix Bug";
            this.btnFixBug.UseVisualStyleBackColor = true;
            this.btnFixBug.Click += new System.EventHandler(this.BtnFixBug_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 120);
            this.Controls.Add(this.btnFixBug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.btnOkey);
            this.Controls.Add(this.txTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kapat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txTime;
        private System.Windows.Forms.Button btnOkey;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFixBug;
    }
}

