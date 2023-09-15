namespace BasicQueuingCashier
{
    partial class CashierWindowQueueForm
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
            components = new System.ComponentModel.Container();
            btnrefresh = new Button();
            btnnext = new Button();
            listCashierQueue = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            labelnext = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnrefresh
            // 
            btnrefresh.BackColor = Color.FromArgb(255, 128, 128);
            btnrefresh.Location = new Point(48, 35);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(82, 32);
            btnrefresh.TabIndex = 0;
            btnrefresh.Text = "REFRESH";
            btnrefresh.UseVisualStyleBackColor = false;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // btnnext
            // 
            btnnext.BackColor = Color.FromArgb(255, 128, 128);
            btnnext.Location = new Point(48, 89);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(82, 30);
            btnnext.TabIndex = 1;
            btnnext.Text = "NEXT";
            btnnext.UseVisualStyleBackColor = false;
            btnnext.Click += btnnext_Click;
            // 
            // listCashierQueue
            // 
            listCashierQueue.FormattingEnabled = true;
            listCashierQueue.ItemHeight = 15;
            listCashierQueue.Location = new Point(183, 35);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(172, 259);
            listCashierQueue.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // labelnext
            // 
            labelnext.AutoSize = true;
            labelnext.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelnext.Location = new Point(25, 182);
            labelnext.Name = "labelnext";
            labelnext.Size = new Size(0, 32);
            labelnext.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 147);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 4;
            label1.Text = "number in line";
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 324);
            Controls.Add(label1);
            Controls.Add(labelnext);
            Controls.Add(listCashierQueue);
            Controls.Add(btnnext);
            Controls.Add(btnrefresh);
            Name = "CashierWindowQueueForm";
            Text = "CashierWindowQueueForm";
            Load += CashierWindowQueueForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnrefresh;
        private Button btnnext;
        private System.Windows.Forms.Timer timer1;
        private Label labelnext;
        public ListBox listCashierQueue;
        private Label label1;
    }
}