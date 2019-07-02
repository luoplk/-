using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary2
{
    public enum WATER_STATE { Stop, In, Out };
    public enum ROTATE_STATE { Stop, ForwardRotating, ReversaRotating };


    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();

            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                        ControlStyles.ResizeRedraw |
                        ControlStyles.AllPaintingInWmPaint, true);  

        }

        private double waterLevel;

        public double WaterLevel
        {
            get { return waterLevel; }
            set { waterLevel = value; this.Refresh(); }
        }

        private WATER_STATE waterState;

        public WATER_STATE WaterState
        {
            get { return waterState; }
            set { waterState = value; this.Refresh(); }
        }

        private ROTATE_STATE rotateState;

        public ROTATE_STATE RotateState
        {
            get { return rotateState; }
            set { rotateState = value; this.Refresh(); }
        }


        float angle;

        public float Angle
        {
            get { return angle; }
            set { angle = value; }
        }

        float rotateSpd = 3;

        public float RotateSpd
        {
            get { return rotateSpd; }
            set { rotateSpd = value; }
        }
        

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            //画边框
            Graphics g = e.Graphics;
            g.DrawRectangle(new Pen(Color.Black, 3), 0,-3,this.Width-3,this.Height);

            //画变化的水位
            int waterHeight = (int)(waterLevel / 100.0 * this.Height);
            Rectangle waterRect = new Rectangle(2,this.Height -waterHeight -4 , this.Width - 6, waterHeight);
            g.FillRectangle(Brushes.SkyBlue, waterRect);

            //画旋转的滚筒
            Image imgFans = Properties.Resources.fans3;


            int xPos = (this.Width - imgFans.Width)/2 ;
            int yPos = (this.Height - imgFans.Height) / 2;

            Point imgRotateCenterPos = new Point(imgFans.Width/2,imgFans.Height/2); //旋转中心在图片坐标(相对于图片本身)
            Rectangle rcShow = new Rectangle(xPos, yPos, imgFans.Width,imgFans.Height);　//图片要绘制的位置区域.
            
            //把 相对于图片的旋转中心坐标  转换为  绘制区域的坐标
            PointF centerPos = new Point(imgRotateCenterPos.X+rcShow.Left, imgRotateCenterPos.Y+rcShow.Top);
            
            g.TranslateTransform(centerPos.X,centerPos.Y); //源点移动到旋转中心
            g.RotateTransform(angle); //旋转
            g.TranslateTransform(-centerPos.X, -centerPos.Y);//还原源点
            
            //在某个起点显示图像
            g.DrawImage(imgFans, rcShow.Left,rcShow.Top,rcShow.Width, rcShow.Height);

        }

     

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (WaterState == WATER_STATE.In)
            {
                WaterLevel += 0.1;

                if (WaterLevel >= 100.0)
                {
                    WaterLevel = 100.0;
                }
            }

            if (WaterState == WATER_STATE.Out)
            {
                WaterLevel -= 0.1;

                if (WaterLevel <= 0.0)
                {
                    WaterLevel = 0.0;
                }
            }

            if (RotateState == ROTATE_STATE.ForwardRotating)
            {
                Angle += rotateSpd;
            }
            if (RotateState == ROTATE_STATE.ReversaRotating)
            {
                Angle -= rotateSpd;
            }


        }
    }
}
