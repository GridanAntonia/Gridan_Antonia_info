
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // meridionali
            // 
            this.meridionali.BackColor = System.Drawing.Color.Transparent;
            this.meridionali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.meridionali.Location = new System.Drawing.Point(165, 292);
            this.meridionali.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.meridionali.Name = "meridionali";
            this.meridionali.Size = new System.Drawing.Size(421, 84);
            this.meridionali.TabIndex = 0;
            this.meridionali.Click += new System.EventHandler(this.label1_Click);
            // 
            // orientali
            // 
            this.orientali.BackColor = System.Drawing.Color.Transparent;
            this.orientali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.orientali.Location = new System.Drawing.Point(424, 47);
            this.orientali.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orientali.Name = "orientali";
            this.orientali.Size = new System.Drawing.Size(212, 245);
            this.orientali.TabIndex = 1;
            this.orientali.Click += new System.EventHandler(this.orientali_Click);
            // 
            // occidentali
            // 
            this.occidentali.BackColor = System.Drawing.Color.Transparent;
            this.occidentali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.occidentali.Location = new System.Drawing.Point(207, 156);
            this.occidentali.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.occidentali.Name = "occidentali";
            this.occidentali.Size = new System.Drawing.Size(133, 124);
            this.occidentali.TabIndex = 2;
            this.occidentali.Click += new System.EventHandler(this.occidentali_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(34, 486);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Răspunde la întrebări!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 95);
            this.label1.TabIndex = 4;
            this.label1.Text = "Munții României";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(760, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dați click pe lanțurile muntoase!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gridan_Antonia_info.Properties.Resources.carpati;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 551);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.occidentali);
            this.Controls.Add(this.orientali);
            this.Controls.Add(this.meridionali);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

