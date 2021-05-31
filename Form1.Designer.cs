
namespace CSharp_悬浮球
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labGIF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labGIF
            // 
            this.labGIF.Image = global::CSharp_悬浮球.Properties.Resources.正常状态;
            this.labGIF.Location = new System.Drawing.Point(0, 0);
            this.labGIF.Name = "labGIF";
            this.labGIF.Size = new System.Drawing.Size(90, 120);
            this.labGIF.TabIndex = 0;
            this.labGIF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labGIF_MouseDown);
            this.labGIF.MouseEnter += new System.EventHandler(this.labGIF_MouseEnter);
            this.labGIF.MouseLeave += new System.EventHandler(this.labGIF_MouseLeave);
            this.labGIF.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labGIF_MouseMove);
            this.labGIF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labGIF_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(92, 120);
            this.ControlBox = false;
            this.Controls.Add(this.labGIF);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labGIF;
    }
}

