using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        int CountOrgNum = 0;
        string[] TeaList = new string[] { "홍차", "녹차", "루이보스차", "국화차" };
        string orgStr = "";

        int blackTea;
        int greenTea;
        int rooibosTea;
        int chrysanthemum;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0; i<TeaList.Length; i++)
            {
                this.cbList.Items.Add(TeaList[i]);
            }
            if (cbList.Items.Count > 0)
            {
                this.cbList.SelectedIndex = 0;
            }
        }

        private void btTea_Click(object sender, EventArgs e)
        {
          if(orgStr == "홍차")
            {
                MessageBox.Show("홍차를 선택하셨습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.blackTea = 120;
                this.CountOrgNum = Convert.ToInt32(this.blackTea);
                this.Timer.Enabled = true;
            }
            else if (orgStr == "녹차")
            {
                MessageBox.Show("녹차를 선택하셨습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.greenTea = 180;
                this.CountOrgNum = Convert.ToInt32(this.greenTea);
                this.Timer.Enabled = true;
            }
            else if (orgStr == "루이보스차")
            {
                MessageBox.Show("루이보스차를 선택하셨습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.rooibosTea = 300;
                this.CountOrgNum = Convert.ToInt32(this.rooibosTea);
                this.Timer.Enabled = true;
            }
            else if (orgStr == "국화차")
            {
                MessageBox.Show("국화차를 선택하셨습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.chrysanthemum = 120;
                this.CountOrgNum = Convert.ToInt32(this.chrysanthemum);
                this.Timer.Enabled = true;
            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (CountOrgNum < 1)
            {
                this.Timer.Enabled = false;
                MessageBox.Show("티백을 건지세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtTime.Text = "";
                this.cbList.Focus();
            }
            else
            {
                this.CountOrgNum--;
                this.txtTime.Text = Convert.ToString(this.CountOrgNum);
            }
        }

        private void cbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbList.SelectedIndex >= 0)
            {
                this.orgStr = this.cbList.Text;
            }
        }
    }
}
