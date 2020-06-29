namespace FrameControl
{
    partial class MoveTB
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContain = new System.Windows.Forms.Panel();
            this.textBox1 = new FrameControl.ShowTB();
            this.panelR = new System.Windows.Forms.Panel();
            this.panelBR = new System.Windows.Forms.Panel();
            this.panelB = new System.Windows.Forms.Panel();
            this.panelBL = new System.Windows.Forms.Panel();
            this.panelL = new System.Windows.Forms.Panel();
            this.panelTR = new System.Windows.Forms.Panel();
            this.panelTL = new System.Windows.Forms.Panel();
            this.panelT = new System.Windows.Forms.Panel();
            this.panelContain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContain
            // 
            this.panelContain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContain.Controls.Add(this.textBox1);
            this.panelContain.Location = new System.Drawing.Point(2, 2);
            this.panelContain.Name = "panelContain";
            this.panelContain.Size = new System.Drawing.Size(146, 26);
            this.panelContain.TabIndex = 0;
            this.panelContain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.UserControl1_MouseDoubleClick);
            this.panelContain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveCtr_MouseDown);
            this.panelContain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MoveCtr_MouseMove);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Code = "12345678";
            this.textBox1.CodeType = FrameControl.CodeType.无;
            this.textBox1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 26);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "New Item";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.CodeTypeChange += new System.Action<object>(this.textBox1_CodeTypeChange);
            // 
            // panelR
            // 
            this.panelR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelR.Location = new System.Drawing.Point(145, 13);
            this.panelR.Name = "panelR";
            this.panelR.Size = new System.Drawing.Size(5, 5);
            this.panelR.TabIndex = 33;
            // 
            // panelBR
            // 
            this.panelBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelBR.Location = new System.Drawing.Point(145, 25);
            this.panelBR.Name = "panelBR";
            this.panelBR.Size = new System.Drawing.Size(5, 5);
            this.panelBR.TabIndex = 32;
            // 
            // panelB
            // 
            this.panelB.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panelB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelB.Location = new System.Drawing.Point(73, 25);
            this.panelB.Name = "panelB";
            this.panelB.Size = new System.Drawing.Size(5, 5);
            this.panelB.TabIndex = 31;
            // 
            // panelBL
            // 
            this.panelBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelBL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelBL.Location = new System.Drawing.Point(0, 25);
            this.panelBL.Name = "panelBL";
            this.panelBL.Size = new System.Drawing.Size(5, 5);
            this.panelBL.TabIndex = 30;
            // 
            // panelL
            // 
            this.panelL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelL.Location = new System.Drawing.Point(0, 13);
            this.panelL.Name = "panelL";
            this.panelL.Size = new System.Drawing.Size(5, 5);
            this.panelL.TabIndex = 27;
            // 
            // panelTR
            // 
            this.panelTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTR.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTR.Location = new System.Drawing.Point(145, 0);
            this.panelTR.Name = "panelTR";
            this.panelTR.Size = new System.Drawing.Size(5, 5);
            this.panelTR.TabIndex = 29;
            // 
            // panelTL
            // 
            this.panelTL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelTL.Location = new System.Drawing.Point(0, 0);
            this.panelTL.Name = "panelTL";
            this.panelTL.Size = new System.Drawing.Size(5, 5);
            this.panelTL.TabIndex = 28;
            // 
            // panelT
            // 
            this.panelT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelT.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelT.Location = new System.Drawing.Point(73, 0);
            this.panelT.Name = "panelT";
            this.panelT.Size = new System.Drawing.Size(5, 5);
            this.panelT.TabIndex = 26;
            // 
            // MoveTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.panelR);
            this.Controls.Add(this.panelBR);
            this.Controls.Add(this.panelB);
            this.Controls.Add(this.panelBL);
            this.Controls.Add(this.panelL);
            this.Controls.Add(this.panelTR);
            this.Controls.Add(this.panelTL);
            this.Controls.Add(this.panelT);
            this.Controls.Add(this.panelContain);
            this.Name = "MoveTB";
            this.Size = new System.Drawing.Size(150, 30);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveTB_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MoveTB_KeyPress);
            this.panelContain.ResumeLayout(false);
            this.panelContain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContain;
        private System.Windows.Forms.Panel panelR;
        private System.Windows.Forms.Panel panelBR;
        private System.Windows.Forms.Panel panelB;
        private System.Windows.Forms.Panel panelBL;
        private System.Windows.Forms.Panel panelL;
        private System.Windows.Forms.Panel panelTR;
        private System.Windows.Forms.Panel panelTL;
        private System.Windows.Forms.Panel panelT;
        private ShowTB textBox1;
    }
}
