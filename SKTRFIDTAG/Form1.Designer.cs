
namespace SKTRFIDTAG
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtTag = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtQueue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTypeWeight = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTypeCane = new System.Windows.Forms.TextBox();
            this.txtTypeTruck = new System.Windows.Forms.TextBox();
            this.txtTruck = new System.Windows.Forms.TextBox();
            this.txtRFID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusConnect = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Angsana New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 30);
            this.label7.TabIndex = 28;
            this.label7.Text = "สถานะคิว";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTag
            // 
            this.txtTag.Font = new System.Drawing.Font("Angsana New", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTag.Location = new System.Drawing.Point(356, 183);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(330, 44);
            this.txtTag.TabIndex = 34;
            this.txtTag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Angsana New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 43);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(318, 112);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "1. วางบัตร RFID ลงในเครื่องอ่านเขียนบัตรตัว common\n2. เลือกข้อมูลบัตรที่ตรงกับเลข" +
    "บัตร RFID\n3. กดเขียนบัตร , อ่านบัตร";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Font = new System.Drawing.Font("Angsana New", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(356, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 168);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "วิธีใช้งาน";
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnWrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWrite.Enabled = false;
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(356, 284);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(165, 95);
            this.btnWrite.TabIndex = 32;
            this.btnWrite.Text = "เขียนบัตร";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtQueue
            // 
            this.txtQueue.Location = new System.Drawing.Point(133, 321);
            this.txtQueue.Name = "txtQueue";
            this.txtQueue.ReadOnly = true;
            this.txtQueue.Size = new System.Drawing.Size(155, 44);
            this.txtQueue.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Angsana New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 30);
            this.label6.TabIndex = 26;
            this.label6.Text = "ประเภทชั่ง";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Angsana New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 30);
            this.label5.TabIndex = 25;
            this.label5.Text = "รหัสชั่ง";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Angsana New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 30);
            this.label4.TabIndex = 24;
            this.label4.Text = "ประเถทอ้อย";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Angsana New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 30);
            this.label2.TabIndex = 23;
            this.label2.Text = "ประเภทรถ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Angsana New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "ทะเบียนรถ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTypeWeight
            // 
            this.txtTypeWeight.Location = new System.Drawing.Point(133, 272);
            this.txtTypeWeight.Name = "txtTypeWeight";
            this.txtTypeWeight.ReadOnly = true;
            this.txtTypeWeight.Size = new System.Drawing.Size(155, 44);
            this.txtTypeWeight.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Angsana New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 30);
            this.label8.TabIndex = 20;
            this.label8.Text = "รหัส RFID";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTypeCane
            // 
            this.txtTypeCane.Location = new System.Drawing.Point(133, 225);
            this.txtTypeCane.Name = "txtTypeCane";
            this.txtTypeCane.ReadOnly = true;
            this.txtTypeCane.Size = new System.Drawing.Size(155, 44);
            this.txtTypeCane.TabIndex = 4;
            // 
            // txtTypeTruck
            // 
            this.txtTypeTruck.Location = new System.Drawing.Point(133, 131);
            this.txtTypeTruck.Name = "txtTypeTruck";
            this.txtTypeTruck.ReadOnly = true;
            this.txtTypeTruck.Size = new System.Drawing.Size(155, 44);
            this.txtTypeTruck.TabIndex = 2;
            // 
            // txtTruck
            // 
            this.txtTruck.Location = new System.Drawing.Point(133, 84);
            this.txtTruck.Name = "txtTruck";
            this.txtTruck.ReadOnly = true;
            this.txtTruck.Size = new System.Drawing.Size(155, 44);
            this.txtTruck.TabIndex = 1;
            // 
            // txtRFID
            // 
            this.txtRFID.Enabled = false;
            this.txtRFID.Location = new System.Drawing.Point(133, 37);
            this.txtRFID.MaxLength = 6;
            this.txtRFID.Name = "txtRFID";
            this.txtRFID.Size = new System.Drawing.Size(155, 44);
            this.txtRFID.TabIndex = 0;
            this.txtRFID.TextChanged += new System.EventHandler(this.txtRFID_TextChanged);
            this.txtRFID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRFID_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtQueue);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTypeWeight);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtTypeCane);
            this.groupBox1.Controls.Add(this.txtBarcode);
            this.groupBox1.Controls.Add(this.txtTypeTruck);
            this.groupBox1.Controls.Add(this.txtTruck);
            this.groupBox1.Controls.Add(this.txtRFID);
            this.groupBox1.Font = new System.Drawing.Font("Angsana New", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 371);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลในบัตร";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(133, 178);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.Size = new System.Drawing.Size(155, 44);
            this.txtBarcode.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusConnect});
            this.statusStrip1.Location = new System.Drawing.Point(0, 396);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(708, 22);
            this.statusStrip1.TabIndex = 35;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusConnect
            // 
            this.toolStripStatusConnect.Font = new System.Drawing.Font("Angsana New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusConnect.Name = "toolStripStatusConnect";
            this.toolStripStatusConnect.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusConnect.Size = new System.Drawing.Size(0, 17);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRead.Enabled = false;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(527, 284);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(165, 95);
            this.btnRead.TabIndex = 36;
            this.btnRead.Text = "อ่านบัตร";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(356, 233);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(330, 45);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "รีเช็ต";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 418);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtTag);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SKT RFID READ WRITE TAG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtQueue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTypeWeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTypeCane;
        private System.Windows.Forms.TextBox txtTypeTruck;
        private System.Windows.Forms.TextBox txtTruck;
        private System.Windows.Forms.TextBox txtRFID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusConnect;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnClear;
    }
}

