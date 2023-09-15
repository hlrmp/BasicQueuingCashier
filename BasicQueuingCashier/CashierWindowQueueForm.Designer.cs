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
            btnrefresh = new Button();
            btnnext = new Button();
            listCashierQueue = new ListBox();
            SuspendLayout();
            // 
            // btnrefresh
            // 
            btnrefresh.Location = new Point(48, 35);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(82, 32);
            btnrefresh.TabIndex = 0;
            btnrefresh.Text = "REFRESH";
            btnrefresh.UseVisualStyleBackColor = true;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // btnnext
            // 
            btnnext.Location = new Point(48, 85);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(82, 30);
            btnnext.TabIndex = 1;
            btnnext.Text = "NEXT";
            btnnext.UseVisualStyleBackColor = true;
            // 
            // listCashierQueue
            // 
            listCashierQueue.FormattingEnabled = true;
            listCashierQueue.ItemHeight = 15;
            listCashierQueue.Location = new Point(177, 12);
            listCashierQueue.Name = "listCashierQueue";
            listCashierQueue.Size = new Size(172, 214);
            listCashierQueue.TabIndex = 2;
            // 
            // CashierWindowQueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 265);
            Controls.Add(listCashierQueue);
            Controls.Add(btnnext);
            Controls.Add(btnrefresh);
            Name = "CashierWindowQueueForm";
            Text = "CashierWindowQueueForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnrefresh;
        private Button btnnext;
        private ListBox listCashierQueue;
    }
}