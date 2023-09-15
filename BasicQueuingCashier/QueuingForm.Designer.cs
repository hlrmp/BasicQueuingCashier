namespace BasicQueuingCashier
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
            btncashier = new Button();
            label1 = new Label();
            label2 = new Label();
            lblQueue = new Label();
            SuspendLayout();
            // 
            // btncashier
            // 
            btncashier.Location = new Point(12, 55);
            btncashier.Name = "btncashier";
            btncashier.Size = new Size(114, 73);
            btncashier.TabIndex = 0;
            btncashier.Text = "CASHIER";
            btncashier.UseVisualStyleBackColor = true;
            btncashier.Click += btncashier_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 38);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 1;
            label1.Text = "Position in Queue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Light", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(114, 13);
            label2.TabIndex = 2;
            label2.Text = "* click to get  a number";
            // 
            // lblQueue
            // 
            lblQueue.AutoSize = true;
            lblQueue.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblQueue.Location = new Point(203, 72);
            lblQueue.Name = "lblQueue";
            lblQueue.Size = new Size(60, 30);
            lblQueue.TabIndex = 3;
            lblQueue.Text = "label";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 268);
            Controls.Add(lblQueue);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btncashier);
            Name = "Form1";
            Text = "QueuingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncashier;
        private Label label1;
        private Label label2;
        private Label lblQueue;
    }
}