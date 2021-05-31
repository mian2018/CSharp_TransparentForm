using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_悬浮球
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 当鼠标划过 更换gif
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labGIF_MouseEnter(object sender, EventArgs e)
        {
            labGIF.Image = Properties.Resources.鼠标滑过;
        }

        /// <summary>
        /// 当鼠标离开控件 更换GIF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labGIF_MouseLeave(object sender, EventArgs e)
        {
            labGIF.Image = Properties.Resources.正常状态;
        }

        /// <summary>
        /// 记录鼠标按下坐标
        /// </summary>
        Point startPoint = new Point();
        /// <summary>
        /// 记录鼠标左键是否已经按下
        /// </summary>
        bool isDown = false;
        /// <summary>
        /// 鼠标按下回调函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labGIF_MouseDown(object sender, MouseEventArgs e)
        {
            //左键按下 记住按下坐标
            if(e.Button is MouseButtons.Left)
            {
                startPoint = e.Location;
                isDown = true;
            }
            
        }
        /// <summary>
        /// 鼠标弹起回调函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labGIF_MouseUp(object sender, MouseEventArgs e)
        {
            //左键弹起 清除按下标志位
            if (e.Button is MouseButtons.Left)
            {
                isDown = false;
            }
        }
        /// <summary>
        /// 鼠标在控件上移动回调函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labGIF_MouseMove(object sender, MouseEventArgs e)
        {
            //左键移动 修改窗体坐标
            if (e.Button is MouseButtons.Left && isDown)
            {
                this.Location = this.PointToScreen(new Point(e.X - startPoint.X, e.Y - startPoint.Y));
            }
        }
    }
}
