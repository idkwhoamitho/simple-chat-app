
namespace test_App_2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.portLocal = new System.Windows.Forms.TextBox();
            this.ipLocal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.portRemote = new System.Windows.Forms.TextBox();
            this.ipRemote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listConnect = new System.Windows.Forms.ListBox();
            this.listMsg = new System.Windows.Forms.ListBox();
            this.textInput = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.portLocal);
            this.groupBox1.Controls.Add(this.ipLocal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(396, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "My Connections Info";
            // 
            // portLocal
            // 
            this.portLocal.Location = new System.Drawing.Point(98, 83);
            this.portLocal.Name = "portLocal";
            this.portLocal.Size = new System.Drawing.Size(49, 20);
            this.portLocal.TabIndex = 4;
            // 
            // ipLocal
            // 
            this.ipLocal.Location = new System.Drawing.Point(57, 25);
            this.ipLocal.Name = "ipLocal";
            this.ipLocal.Size = new System.Drawing.Size(179, 20);
            this.ipLocal.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.portRemote);
            this.groupBox2.Controls.Add(this.ipRemote);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connect To";
            // 
            // portRemote
            // 
            this.portRemote.Location = new System.Drawing.Point(74, 68);
            this.portRemote.Name = "portRemote";
            this.portRemote.Size = new System.Drawing.Size(49, 20);
            this.portRemote.TabIndex = 3;
            // 
            // ipRemote
            // 
            this.ipRemote.Location = new System.Drawing.Point(49, 28);
            this.ipRemote.Name = "ipRemote";
            this.ipRemote.Size = new System.Drawing.Size(179, 20);
            this.ipRemote.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // listConnect
            // 
            this.listConnect.FormattingEnabled = true;
            this.listConnect.Location = new System.Drawing.Point(24, 153);
            this.listConnect.Name = "listConnect";
            this.listConnect.Size = new System.Drawing.Size(131, 264);
            this.listConnect.TabIndex = 2;
            this.listConnect.SelectedIndexChanged += new System.EventHandler(this.listConnect_SelectedIndexChanged);
            // 
            // listMsg
            // 
            this.listMsg.FormattingEnabled = true;
            this.listMsg.Location = new System.Drawing.Point(200, 153);
            this.listMsg.Name = "listMsg";
            this.listMsg.Size = new System.Drawing.Size(541, 212);
            this.listMsg.TabIndex = 3;
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(200, 397);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(357, 20);
            this.textInput.TabIndex = 5;
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(567, 388);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(66, 36);
            this.sendBtn.TabIndex = 6;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(275, 49);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(66, 36);
            this.connectBtn.TabIndex = 7;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(685, 49);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(66, 36);
            this.startBtn.TabIndex = 8;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.listMsg);
            this.Controls.Add(this.listConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox portLocal;
        private System.Windows.Forms.TextBox ipLocal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox portRemote;
        private System.Windows.Forms.TextBox ipRemote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listConnect;
        private System.Windows.Forms.ListBox listMsg;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button startBtn;
    }
}

