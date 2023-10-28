namespace PR_4 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.in_label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.out_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вхідний: ";
            // 
            // in_label
            // 
            this.in_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.in_label.Location = new System.Drawing.Point(186, 43);
            this.in_label.Name = "in_label";
            this.in_label.Size = new System.Drawing.Size(500, 30);
            this.in_label.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(36, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Вихідний: ";
            // 
            // out_label
            // 
            this.out_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.out_label.Location = new System.Drawing.Point(186, 82);
            this.out_label.Name = "out_label";
            this.out_label.Size = new System.Drawing.Size(500, 30);
            this.out_label.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(36, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Підрахуй";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.out_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.in_label);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Практична 4";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label in_label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label out_label;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}