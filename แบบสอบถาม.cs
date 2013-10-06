using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string str = ("คำตอบของคุณ คือ " + Environment.NewLine);
            str = str + "เพศ : ";                                  //เพศ
            if (optMale.Checked == true)                           
            {
                str = str + "ชาย" + Environment.NewLine;
            }
            else
            {
                str = str + "หญิง" + Environment.NewLine;
            }
            str = str + "อายุ : ";                                   // อายุ
            if (opt3.Checked == true)                               
            {
                str = str + "น้อยกว่า 20 ปี" + Environment.NewLine;
            }
            else if (opt4.Checked == true)
            {
                str = str + "20-30 ปี" + Environment.NewLine;
            }
            else if (opt5.Checked == true)
            {
                str = str + "30-40 ปี" + Environment.NewLine;
            }
            else
            {
                str = str + "มากกว่า 40 ปี" + Environment.NewLine;
            }
            str = str + "อายุรถ : ";                                  //อายุรถ
            if (opt7.Checked == true)                               
            {
                str = str + "ต่ำกว่า 5 ปี" + Environment.NewLine;
            }
            else if (opt8.Checked == true)
            {
                str = str + "5 - 10 ปี" + Environment.NewLine;
            }
            else
            {
                str = str + "มากกว่า 10 ปี" + Environment.NewLine;
            }
            str = str + "คุณตรวจสภาพรถของคุณบ่อยแค่ไหน : ";             //คุณตรวจสภาพรถของคุณบ่อยแค่ไหน
            if (opt10.Checked == true)
            {
                str = str + "บ่อยมาก" + Environment.NewLine;
            }
            else if (opt11.Checked == true)
            {
                str = str + "บ่อย" + Environment.NewLine;
            }
            else if (opt12.Checked == true)
            {
                str = str + "พอสมควร" + Environment.NewLine;
            }
            else if (opt13.Checked == true)
            {
                str = str + "น้อย" + Environment.NewLine;
            }
            else
            {
                str = str + "ไม่เคยเลย" + Environment.NewLine;
            }
            str = str + "คุณตรวจสภาพรถก่อนออกเดินทางหรือไม่ : ";         // คุณตรวจสภาพรถ่อนออกเดินทางหรือไม่
            if (opt15.Checked == true)
            {
                str = str + "ทุกครั้ง" + Environment.NewLine;
            }
            else if (opt16.Checked == true)
            {
                str = str + "เป็นบางครั้ง" + Environment.NewLine;
            }
            else if (opt17.Checked == true)
            {
                str = str + "นาน ๆ ครั้ง" + Environment.NewLine;
            }
            else
            {
                str = str + "ไม่เคยเลย" + Environment.NewLine;
            }
            str = str + "วิธีการตรวจสภาพรถของคุณ : ";                  //วิธีการตรวจสภาพรถของคุณ
            if (opt19.Checked == true)
            {
                str = str + "เข้าศูนย์ฯ" + Environment.NewLine;
            }
            else if (opt20.Checked == true)
            {
                str = str + "เข้าอู่" + Environment.NewLine;
            }
            else if (opt21.Checked == true)
            {
                str = str + "ตรวจด้วยตนเอง" + Environment.NewLine;
            }
            else
            {
                str = str + "ไม่เคยเลย" + Environment.NewLine;
            }
            str = str + "รถของคุณซ่อมบ่อยแค่ไหน : ";                    //รถของคุณซ่อมบ่อยแค่ไหน
            if (opt23.Checked == true)
            {
                str = str + "บ่อยมาก" + Environment.NewLine;
            }
            else if (opt24.Checked == true)
            {
                str = str + "บ่อย" + Environment.NewLine;
            }
            else if (opt25.Checked == true)
            {
                str = str + "พอสมควร" + Environment.NewLine;
            }
            else if (opt26.Checked == true)
            {
                str = str + "น้อย" + Environment.NewLine;
            }
            else
            {
                str = str + "ไม่เคยเลย" + Environment.NewLine;
            }
            str = str + "คุณใส่ใจกับการตรวจสภาพรถของคุณมากแค่ไหน : ";    //คุณใส่ใจกับการตรวจสภาพรถของคุณมากแค่ไหน
            if (opt28.Checked == true)
            {
                str = str + "มากที่สุด" + Environment.NewLine;
            }
            else if (opt29.Checked == true)
            {
                str = str + "มาก" + Environment.NewLine;
            }
            else if (opt30.Checked == true)
            {
                str = str + "พอสมควร" + Environment.NewLine;
            }
            else if (opt31.Checked == true)
            {
                str = str + "น้อย" + Environment.NewLine;
            }
            else
            {
                str = str + "ไม่เคยเลย" + Environment.NewLine;
            }
            MessageBox.Show(str, "คำตอบของคุณ");
        }
    }
}
