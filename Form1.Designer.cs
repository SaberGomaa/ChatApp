namespace ChatApp
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
            txt_name = new TextBox();
            txt_msg = new TextBox();
            txt_grp = new TextBox();
            btn_send = new Button();
            btn_join = new Button();
            btn_send_grp = new Button();
            list_msg = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.Location = new Point(322, 25);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(110, 25);
            txt_name.TabIndex = 0;
            // 
            // txt_msg
            // 
            txt_msg.Location = new Point(70, 78);
            txt_msg.Name = "txt_msg";
            txt_msg.Size = new Size(110, 25);
            txt_msg.TabIndex = 1;
            // 
            // txt_grp
            // 
            txt_grp.Location = new Point(70, 130);
            txt_grp.Name = "txt_grp";
            txt_grp.Size = new Size(110, 25);
            txt_grp.TabIndex = 2;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(225, 78);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(83, 25);
            btn_send.TabIndex = 3;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            // 
            // btn_join
            // 
            btn_join.Location = new Point(225, 130);
            btn_join.Name = "btn_join";
            btn_join.Size = new Size(83, 25);
            btn_join.TabIndex = 4;
            btn_join.Text = "Join";
            btn_join.UseVisualStyleBackColor = true;
            // 
            // btn_send_grp
            // 
            btn_send_grp.Location = new Point(140, 173);
            btn_send_grp.Name = "btn_send_grp";
            btn_send_grp.Size = new Size(127, 25);
            btn_send_grp.TabIndex = 5;
            btn_send_grp.Text = "Send To Group";
            btn_send_grp.UseVisualStyleBackColor = true;
            // 
            // list_msg
            // 
            list_msg.FormattingEnabled = true;
            list_msg.ItemHeight = 17;
            list_msg.Location = new Point(70, 259);
            list_msg.Name = "list_msg";
            list_msg.Size = new Size(383, 174);
            list_msg.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(265, 27);
            label1.Name = "label1";
            label1.Size = new Size(43, 17);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 55);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 8;
            label2.Text = "Message";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 107);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 9;
            label3.Text = "Group";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(list_msg);
            Controls.Add(btn_send_grp);
            Controls.Add(btn_join);
            Controls.Add(btn_send);
            Controls.Add(txt_grp);
            Controls.Add(txt_msg);
            Controls.Add(txt_name);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private TextBox txt_msg;
        private TextBox txt_grp;
        private Button btn_send;
        private Button btn_join;
        private Button btn_send_grp;
        private ListBox list_msg;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}