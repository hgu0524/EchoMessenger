namespace EchoMessenger
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
            title = new Label();
            textmessage = new TextBox();
            btnsend = new Button();
            listBoxchat = new ListBox();
            lblCount = new Label();
            btnDelete = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // title
            // 
            title.Font = new Font("Segoe Script", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title.Location = new Point(36, 9);
            title.Name = "title";
            title.Size = new Size(527, 95);
            title.TabIndex = 0;
            title.Text = "Echo Messenger";
            // 
            // textmessage
            // 
            textmessage.Location = new Point(40, 422);
            textmessage.Name = "textmessage";
            textmessage.Size = new Size(614, 23);
            textmessage.TabIndex = 1;
            textmessage.TextChanged += textBox1_TextChanged;
            textmessage.KeyDown += textmessage_KeyDown;
            // 
            // btnsend
            // 
            btnsend.BackColor = SystemColors.MenuHighlight;
            btnsend.Font = new Font("맑은 고딕", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnsend.Location = new Point(676, 403);
            btnsend.Name = "btnsend";
            btnsend.Size = new Size(128, 60);
            btnsend.TabIndex = 2;
            btnsend.Text = "전송";
            btnsend.UseVisualStyleBackColor = false;
            btnsend.Click += btnsend_Click;
            // 
            // listBoxchat
            // 
            listBoxchat.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            listBoxchat.FormattingEnabled = true;
            listBoxchat.Location = new Point(40, 93);
            listBoxchat.Name = "listBoxchat";
            listBoxchat.Size = new Size(764, 304);
            listBoxchat.TabIndex = 3;
            listBoxchat.SelectedIndexChanged += listBoxchat_SelectedIndexChanged;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(40, 467);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 15);
            lblCount.TabIndex = 4;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(40, 485);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(70, 24);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(116, 485);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 24);
            btnClear.TabIndex = 6;
            btnClear.Text = "전체 삭제";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(919, 521);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(lblCount);
            Controls.Add(listBoxchat);
            Controls.Add(btnsend);
            Controls.Add(textmessage);
            Controls.Add(title);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private TextBox textmessage;
        private Button btnsend;
        private ListBox listBoxchat;
        private Label lblCount;
        private Button btnDelete;
        private Button btnClear;
    }
}
