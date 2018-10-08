using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using homework4;

namespace Clock
{
    class ClassClock
    {
        //定义闹钟的所处时间
        private int h, m, s;
        //定义闹钟的设置时间
        private int H, M, S;
        //构造函数
        public ClassClock(int h,int m,int s)
        {
            this.h = h;
            this.m = m;
            this.s = s;
        }
        //建立一个闹铃
        public void setClock(int h,int m,int s)
        {
            if (h < 0 || h >= 24 || m >= 60 || m < 0 || s >= 60 || s < 0)
            {
                Exception e = new Exception("输入的时间超出合理范围，已终止");
                throw e;
            }
            else
            {
                this.H = h;
                this.M = m;
                this.S = s;
            }           
        }

        //闹钟提醒时间到
        public void runClock(object sender, EventArgs args)
        {
            Console.WriteLine("时间到啦~~~\n时间到啦~~~\n时间到啦~~~\n");
            
            System.Media.SystemSounds.Asterisk.Play();
        }

        //定义事件，相当于申明一个委托实例，初值为null
        public event ClickHandler OnClick;
        
        public void Click()
        {
            //触发Click事件
            EventArgs eventArgs = new EventArgs();
            OnClick(this, eventArgs);
        }

        public int getHour()
        {
            return H;
        }
        public int getMinute()
        {
            return M;
        }
        public int getSecond()
        {
            return S;
        }
    }
}
