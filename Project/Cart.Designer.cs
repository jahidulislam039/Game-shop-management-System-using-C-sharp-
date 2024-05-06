
namespace Project
{
    partial class Cart
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
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Checkoutbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(16, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 32);
            this.button4.TabIndex = 184;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(309, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 183;
            this.label1.Text = "Product ID";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(410, 43);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(166, 33);
            this.ID.TabIndex = 182;
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Deletebtn.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.White;
            this.Deletebtn.Location = new System.Drawing.Point(512, 519);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(166, 41);
            this.Deletebtn.TabIndex = 181;
            this.Deletebtn.Text = "Remove Item";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(120, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 373);
            this.dataGridView1.TabIndex = 180;
            // 
            // Checkoutbtn
            // 
            this.Checkoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Checkoutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Checkoutbtn.Font = new System.Drawing.Font("Rockwell Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkoutbtn.ForeColor = System.Drawing.Color.White;
            this.Checkoutbtn.Location = new System.Drawing.Point(324, 519);
            this.Checkoutbtn.Name = "Checkoutbtn";
            this.Checkoutbtn.Size = new System.Drawing.Size(118, 41);
            this.Checkoutbtn.TabIndex = 186;
            this.Checkoutbtn.Text = "Checkout";
            this.Checkoutbtn.UseVisualStyleBackColor = false;
            this.Checkoutbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1000, 623);
            this.Controls.Add(this.Checkoutbtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cart";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Checkoutbtn;
    }
}