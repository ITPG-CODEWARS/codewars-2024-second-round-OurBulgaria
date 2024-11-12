namespace URL_Shortener
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
            panel1 = new Panel();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            txtURL = new TextBox();
            label3 = new Label();
            txtOutput = new TextBox();
            button1 = new Button();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(flowLayoutPanel3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 135);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.Yellow;
            flowLayoutPanel3.Location = new Point(52, 567);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(813, 51);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(628, 9);
            label5.Name = "label5";
            label5.Size = new Size(158, 111);
            label5.TabIndex = 2;
            label5.Text = "✂️";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 72F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(125, 9);
            label4.Name = "label4";
            label4.Size = new Size(158, 111);
            label4.TabIndex = 1;
            label4.Text = "✂️";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(275, 38);
            label1.Name = "label1";
            label1.Size = new Size(362, 56);
            label1.TabIndex = 0;
            label1.Text = "URL Shortener";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(125, 174);
            label2.Name = "label2";
            label2.Size = new Size(172, 37);
            label2.TabIndex = 1;
            label2.Text = "Enter URL";
            // 
            // txtURL
            // 
            txtURL.BackColor = Color.Yellow;
            txtURL.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtURL.ForeColor = Color.Red;
            txtURL.Location = new Point(125, 234);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(660, 35);
            txtURL.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(125, 376);
            label3.Name = "label3";
            label3.Size = new Size(130, 37);
            label3.TabIndex = 3;
            label3.Text = "Out Put";
            // 
            // txtOutput
            // 
            txtOutput.BackColor = Color.Yellow;
            txtOutput.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtOutput.ForeColor = Color.Red;
            txtOutput.Location = new Point(125, 431);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(660, 35);
            txtOutput.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(125, 293);
            button1.Name = "button1";
            button1.Size = new Size(221, 46);
            button1.TabIndex = 5;
            button1.Text = "Process";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.ForeColor = Color.Yellow;
            button2.Location = new Point(125, 493);
            button2.Name = "button2";
            button2.Size = new Size(221, 45);
            button2.TabIndex = 6;
            button2.Text = "Copy";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Yellow;
            flowLayoutPanel1.Location = new Point(0, 124);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(51, 494);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Yellow;
            flowLayoutPanel2.Location = new Point(865, 124);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(51, 494);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.Yellow;
            flowLayoutPanel4.Controls.Add(label6);
            flowLayoutPanel4.Controls.Add(label7);
            flowLayoutPanel4.Location = new Point(45, 567);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(820, 51);
            flowLayoutPanel4.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(281, 44);
            label6.TabIndex = 5;
            label6.Text = "URL Shortener";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(290, 0);
            label7.Name = "label7";
            label7.Size = new Size(64, 44);
            label7.TabIndex = 6;
            label7.Text = "🔗";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 192);
            ClientSize = new Size(916, 618);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel4);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtOutput);
            Controls.Add(label3);
            Controls.Add(txtURL);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "URL Shortener";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtURL;
        private Label label3;
        private TextBox txtOutput;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label6;
        private Label label7;
    }
}
