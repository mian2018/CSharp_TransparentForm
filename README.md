# CSharp_TransparentForm
# C# 学习笔记（10）加速球
>利用窗体透明和GIF透明背景，实现加速球类似效果（QQ宠物，老年人大概也知道）  
>
![在这里插入图片描述](https://img-blog.csdnimg.cn/20210601195942615.gif)  

1. 新建一个工程winForm工程
2. 设置窗体属性
>设置窗体大小（和你找的GIF大小相同即可）  
>设置窗体出现位置（屏幕中心）  
>设置窗体不会出现在任务栏上
>设置窗体在桌面最顶层（不会被其他应用程序界面遮住）
>设置窗体背景透明色（和窗体背景色一样）
>设置窗体格式（无边框）  

![在这里插入图片描述](https://img-blog.csdnimg.cn/20210601201125509.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)

>这时窗体就是一个白板  

![在这里插入图片描述](https://img-blog.csdnimg.cn/20210601201210740.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)

3. 添加控件label（只有label可以直接让GIF动态显示）
>将label控件的自动大小属性关掉
>设置label控件的位置和大小（大于等于GIF大小）
>设置label控件的背景图片（一定要是透明背景的GIF（不是白色背景是透明背景的））
>将文本属性设置为空  

![在这里插入图片描述](https://img-blog.csdnimg.cn/20210601201459416.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)

4. 点击运行，就会出现一个和加速球效果类似的悬浮窗
>但是现在还有一些问题：
>1. 运行后无法移动位置
>2. 鼠标移上去后想要切换动作
>3. 打开后不能关闭

5. 添加鼠标事件，运行后可以拖动
>选中label控件，给label添加鼠标按下事件、移动事件和弹起事件  

![在这里插入图片描述](https://img-blog.csdnimg.cn/2021060120213087.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)

```csharp
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
```
6. 鼠标放到窗体上，更换GIF效果
>选中label控件，给label添加MouseEnter事件和MouseLeave事件
>就是当鼠标进入控件时，给label换一张背景图
>当然也可以自己添加一些其他的，比如双击或者什么的  

![在这里插入图片描述](https://img-blog.csdnimg.cn/20210601202657599.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)

```csharp
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
```

7. 推出程序
>拖一个右键菜单到窗体上  

![在这里插入图片描述](https://img-blog.csdnimg.cn/20210601202852658.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)  

>将刚才拖的右键菜单和label关联起来  

![在这里插入图片描述](https://img-blog.csdnimg.cn/2021060120304161.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)  

>给右键菜单注册单击事件  

![在这里插入图片描述](https://img-blog.csdnimg.cn/20210601203159583.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MjM3ODMxOQ==,size_16,color_FFFFFF,t_70)

```csharp
private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
{
    this.Close();
}
```

[源码地址](https://github.com/mian2018/CSharp_TransparentForm)https://github.com/mian2018/CSharp_TransparentForm
