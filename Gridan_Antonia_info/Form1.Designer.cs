
namespace Gridan_Antonia_info
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
            this.meridionali = new System.Windows.Forms.Label();
            this.orientali = new System.Windows.Forms.Label();
            this.occidentali = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // meridionali
            // 
            this.meridionali.BackColor = System.Drawing.Color.Transparent;
            this.meridionali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.meridionali.Location = new System.Drawing.Point(124, 237);
            this.meridionali.Name = "meridionali";
            this.meridionali.Size = new System.Drawing.Size(316, 68);
            this.meridionali.TabIndex = 0;
            this.meridionali.Click += new System.EventHandler(this.label1_Click);
            // 
            // orientali
            // 
            this.orientali.BackColor = System.Drawing.Color.Transparent;
            this.orientali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orientali.Location = new System.Drawing.Point(318, 38);
            this.orientali.Name = "orientali";
            this.orientali.Size = new System.Drawing.Size(159, 199);
            this.orientali.TabIndex = 1;
            this.orientali.Click += new System.EventHandler(this.orientali_Click);
            // 
            // occidentali
            // 
            this.occidentali.BackColor = System.Drawing.Color.Transparent;
            this.occidentali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.occidentali.Location = new System.Drawing.Point(155, 127);
            this.occidentali.Name = "occidentali";
            this.occidentali.Size = new System.Drawing.Size(100, 101);
            this.occidentali.TabIndex = 2;
            this.occidentali.Click += new System.EventHandler(this.occidentali_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(571, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Răspunde la întrebări!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gridan_Antonia_info.Properties.Resources.carpati;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.occidentali);
            this.Controls.Add(this.orientali);
            this.Controls.Add(this.meridionali);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label meridionali;
        private System.Windows.Forms.Label orientali;
        private System.Windows.Forms.Label occidentali;
        private System.Windows.Forms.Button button1;
    }
}

