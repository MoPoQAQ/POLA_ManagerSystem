﻿using Model;
using System;
using POLA_MMS.Pays_UI;
using WinFormsUI.Docking;
using System.Windows.Forms;
using POLA_MMS.SystemTool_UI;
using POLA_MMS.Member_UI;
using POLA_MMS.WasteBook_UI;
using POLA_MMS.Report_UI;
using POLA_MMS.Items_UI;
using POLA_MMS.UI_Card;
using POLA_MMS.UI_Subject;
using POLA_MMS.UI_Employee;
using POLA_MMS.UI_Control;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace POLA_MMS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.tssrMain_Timer.Text = DateTime.Now.ToString();
            this.dPanelMain_AutoSize();

            if (StaticValue.User_Type == "1")
            {
                menuMain_Table.Enabled = false;
                menuMain_System.Enabled = false;
                menuMain_Day_Book.Enabled = false;
                toolStripButton3.Enabled = false;
                toolStripButton4.Enabled = false;
                toolStripButton5.Enabled = false;
                toolStripButton6.Enabled = false;
                toolStripButton7.Enabled = false;
                toolStripButton8.Enabled = false;
            }
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(item =>
            {
                frmPays_List objfrmPaysList = new frmPays_List();
                this.BeginInvoke(new Action(() =>
                {
                    this.ShowWindows_Click(objfrmPaysList);
                }));
            });
        }

        /// <summary>
        /// 设置选项卡随主窗体大小变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Resize(object sender, EventArgs e)
        {
            this.dPanelMain_AutoSize();
        }

        private void dPanelMain_AutoSize()
        {
            this.dPanelMain.Width = this.ClientSize.Width;
            this.dPanelMain.Height = this.ClientSize.Height - 45;
        }


        #region 检查选项卡是否存在...

        /// <summary>检查选项卡是否存在。</summary>
        /// <param name="text">选项卡名称</param>
        /// <returns></returns>
        private IDockContent FindTab(string text)
        {
            if (this.dPanelMain.DocumentStyle == DocumentStyle.SystemMdi)
            {
                foreach (Form form in MdiChildren)
                {
                    if (form.Text == text)
                    {
                        return form as IDockContent;
                    }
                }
            }
            else
            {
                foreach (IDockContent content in this.dPanelMain.Documents)
                {
                    if (content.DockHandler.TabText == text)
                    {
                        return content;
                    }
                }
            }
            return null;
        }

        #endregion

        #region 打开选项卡窗体..

        /// <summary>打开窗体</summary>
        /// <param name="form">窗体实例</param>
        private void ShowWindows_Click(DockContent form)
        {
            string strText = form.Text;
            if (this.FindTab(strText) == null)
            {
                form.Show(this.dPanelMain);
            }
            else
            {
                this.FindTab(strText).DockHandler.Show();
            }
        }

        #endregion

        #region 日常操作...

        /// <summary>消费单据</summary>
        private void menuMain_Day_Pay_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(item =>
            {
                frmPays_List objfrmPaysList = new frmPays_List();
                this.BeginInvoke(new Action(() =>
                {
                    this.ShowWindows_Click(objfrmPaysList);
                }));
            });
        }

        /// <summary>会员信息管理</summary>
        private void menuMain_Day_Member_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(item =>
            {
                frmMember_List objfrmMemberList = new frmMember_List();
                this.BeginInvoke(new Action(() =>
                {
                    this.ShowWindows_Click(objfrmMemberList);
                }));
            });
        }

        /// <summary>账目清单</summary>
        private void menuMain_Day_Book_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(item =>
            {
                frmWasteBook_List objfrmWasteBookList = new frmWasteBook_List();
                this.BeginInvoke(new Action(() =>
                {
                    this.ShowWindows_Click(objfrmWasteBookList);
                }));
            });
        }

        #endregion

        #region 统计报表...

        /// <summary>会员续费统计</summary>
        private void menuMain_Table_Deposit_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(item =>
            {
                frmDeposit objfrmDeposit = new frmDeposit();
                this.BeginInvoke(new Action(() =>
                {
                    this.ShowWindows_Click(objfrmDeposit);
                }));
            });
        }

        /// <summary>员工工资统计</summary>
        private void menuMain_Table_Salary_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(item =>
            {
                frmSalary objfrmSalary = new frmSalary();
                this.BeginInvoke(new Action(() =>
                {
                    this.ShowWindows_Click(objfrmSalary);
                }));
            });
        }

        /// <summary>每月收支汇总</summary>
        private void menuMain_Table_Month_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(item =>
            {
                frmReport_Month objfrmReportMonth = new frmReport_Month();
                this.BeginInvoke(new Action(() =>
                {
                    this.ShowWindows_Click(objfrmReportMonth);
                }));
            });
        }

        #endregion

        #region 系统维护...

        /// <summary>商品信息管理</summary>
        private void menuMain_System_Item_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(item =>
            {
                frmItems_List objfrmItemsList = new frmItems_List();
                this.BeginInvoke(new Action(() =>
                {
                    this.ShowWindows_Click(objfrmItemsList);
                }));
            });
        }

        /// <summary>会员卡设置</summary>
        private void menuMain_System_Card_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(item =>
            {
                frmCard_List objfrmCardList = new frmCard_List();
                this.BeginInvoke(new Action(() =>
                {
                    this.ShowWindows_Click(objfrmCardList);
                }));
            });        
        }

        /// <summary>收支项目管理</summary>
        private void menuMain_System_Subject_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(item =>
            {
                frmSubject_List objfrmSubjectList = new frmSubject_List();
                this.BeginInvoke(new Action(() =>
                {
                    this.ShowWindows_Click(objfrmSubjectList);
                }));
            });          
        }

        /// <summary>员工信息管理</summary>
        private void menuMain_System_Employee_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(item =>
            {
                frmEmployee_List objfrmEmployeeList = new frmEmployee_List();
                this.BeginInvoke(new Action(() =>
                {
                    this.ShowWindows_Click(objfrmEmployeeList);
                }));
            });          
        }

        /// <summary>系统设置</summary>
        private void menuMain_System_Config_Click(object sender, EventArgs e)
        {
            frmConfig objfrmConfig = new frmConfig();
            objfrmConfig.ShowDialog();
        }

        private void menuMain_System_Log_Click(object sender, EventArgs e)
        {

        }

        private void menuMain_System_Pwd_Click(object sender, EventArgs e)
        {
            frmChangePass frmChangePass = new frmChangePass();
            frmChangePass.ShowDialog();
        }

        /// <summary>退出</summary>
        private void menuMain_System_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            menuMain_Day_Pay_Click(null, null);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            menuMain_Day_Member_Click(null, null);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            menuMain_Day_Book_Click(null, null);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            menuMain_Table_Deposit_Click(null, null);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            menuMain_Table_Salary_Click(null, null);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            menuMain_Table_Month_Click(null, null);
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            menuMain_System_Item_Click(null, null);
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            menuMain_System_Config_Click(null, null);
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            this.tssrMain_Timer.Text = DateTime.Now.ToString();
        }
    }
}

