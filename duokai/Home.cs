using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace shuangkai
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        #region 定义
        string jisuanjishijian = DateTime.Now.ToLocalTime().ToString();//检测当前电脑时间
        #endregion

        #region 判断微信和企业微信是否安装
        public void wechat_wework() 
        {
            #region 判断微信是否安装
            Object wechat = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Tencent\WeChat", "InstallPath", null);
            if (wechat != null)
            {//注册表键值存在
                
            }
            else
            {//注册表键值不存在
                wechat_shuangkai.Hide();
                MessageBox.Show("未安装微信,因此该功能暂不可用", "提示：");
            }  
            #endregion

            #region 判断企微是否安装
            Object wework = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Tencent\WXWork", "Executable", null);
            if (wework != null)
            {//注册表键值存在
                
            }
            else
            {//注册表键值不存在
                wework_shuangkai.Hide();
                MessageBox.Show("未安装企微,因此该功能暂不可用", "提示：");
            }
            #endregion
        }
        #endregion

        #region 修改企业微信双开注册表
        string qywxsk = "0";
        public void xgqywxzcb() 
        {
            #region 修改企业微信双开注册表
            string strNum1 = textBox1.Text;
            string strNum2 = "3";
            float flNum1 = Convert.ToSingle(strNum1);
            float flNum2 = Convert.ToSingle(strNum2);
            float sum = flNum1 + flNum2;
            qywxsk = Convert.ToString(sum);

            RegistryKey key = Registry.CurrentUser;
            RegistryKey software = key.OpenSubKey("SOFTWARE\\Tencent\\WXWork", true); //该项必须已存在
            software.SetValue("multi_instances", qywxsk);
            //HKEY_CURRENT_USER\SOFTWARE\Tencent\WXWork下创建一个名为“multi_instances”，值为“3”的键值。
            //如果该键值原本已经存在，则会修改替换原来的键值，如果不存在则是创建该键值。
            // 注意：SetValue()还有第三个参数，主要是用于设置键值的类型，如：字符串，二进制，Dword等等~~默认是字符串。如：
            // software.SetValue("test", "0", RegistryValueKind.DWord); //二进制信息
            key.Close();
            #endregion
        }
        #endregion

        #region 加载主页
        private void Home_Load(object sender, EventArgs e)
        {
            #region 判断微信和企微是否安装
            wechat_wework();
            #endregion

            #region 控件居中
            base.OnResize(e);//控件居中
            int x1 = (int)(0.5 * (this.Width - banquan.Width));
            int y1 = banquan.Location.Y;
            banquan.Location = new System.Drawing.Point(x1, y1);
            #endregion

            #region 获取年份
            string nianfen = jisuanjishijian.Substring(0,4);//截取字符串前4位字符
            time_nian.Text = nianfen;
            #endregion

            #region 读取企微安装路径
            RegistryKey registryKeywework = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Tencent\WXWork");
            string wework_path = (string)registryKeywework.GetValue("Executable".ToUpper());
            textBox3.Text = wework_path;
            #endregion

            #region 读取微信安装路径
            RegistryKey registryKeywechat = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Tencent\WeChat");
            string wechat_path = (string)registryKeywechat.GetValue("InstallPath".ToUpper());
            textBox2.Text = wechat_path + "\\WeChat.exe";
            #endregion
        }
        #endregion

        #region 前往官网
        private void rootlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.root.tax/", "Open web site");  //打开网站
        }
        #endregion

        #region 限制textbox只能输入数字,且首字不能为0
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键 
            {
                int len = textBox1.Text.Length;
                if (len < 1 && e.KeyChar == '0')
                {
                    e.Handled = true;
                }
                else if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字 
                {
                    e.Handled = true;
                }
            }
        }
        #endregion

        #region 多开
        string chat_shu = "0";
        private void wechat_shuangkai_Click(object sender, EventArgs e)
        {//微信
            #region 判断微信是否安装,如安装,及执行多开
            Object obj = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Tencent\WeChat", "InstallPath", null);
            if (obj != null)
            {//注册表键值存在
                wechat_time.Enabled = true;//开启计时器
            }
            else
            {//注册表键值不存在
                MessageBox.Show("未安装微信,因此该功能暂不可用", "提示：");
            }
            #endregion
        }

        string work_shu = "0";
        private void wework_shuangkai_Click(object sender, EventArgs e)
        {//企业微信
            xgqywxzcb();//修改企业微信双开注册表

            #region 判断企微是否安装,如安装,及执行多开
            Object obj = Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Tencent\WXWork", "Executable", null);
            if (obj != null)
            {//注册表键值存在
                wework_time.Enabled = true;//开启计时器
            }
            else
            {//注册表键值不存在
                MessageBox.Show("未安装企微,因此该功能暂不可用", "提示：");
            }
            #endregion
        }
        #endregion

        #region 循环开启微信&企业微信
        string jieguo = "";
        private void wechat_time_Tick(object sender, EventArgs e)
        {//循环开启微信
            if (chat_shu == textBox1.Text)
            {
                wechat_time.Enabled = false;//关闭计时器
                chat_shu = "0";
            }
            else
            {
                string strNum1 = chat_shu;
                string strNum2 = "1";
                float flNum1 = Convert.ToSingle(strNum1);
                float flNum2 = Convert.ToSingle(strNum2);
                float sum = flNum1 + flNum2;
                chat_shu = Convert.ToString(sum);

                Process.Start(@textBox2.Text, "Open program");//打开程序 
            }
        }

        private void wework_time_Tick(object sender, EventArgs e)
        {//循环开启企业微信
            xgqywxzcb();//修改企业微信双开注册表

            if (work_shu == textBox1.Text)
            {
                wework_time.Enabled = false;//关闭计时器
                work_shu = "0";
            }
            else 
            {
                string strNum1 = work_shu;
                string strNum2 = "1";
                float flNum1 = Convert.ToSingle(strNum1);
                float flNum2 = Convert.ToSingle(strNum2);
                float sum = flNum1 + flNum2;
                work_shu = Convert.ToString(sum);

                Process.Start(@textBox3.Text, "Open program");//打开程序 
            }
        }
        #endregion
    }
}