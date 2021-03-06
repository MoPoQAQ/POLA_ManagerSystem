﻿using BLL;
using Model;
using System;
using System.Windows.Forms;

namespace POLA_MMS.Member_UI
{
    public partial class frmMember_Transfer : Form
    {
        private string _strMemberId = "";

        public frmMember_Transfer(string memberid)
        {
            InitializeComponent();
            this._strMemberId = memberid;
        }

        private void frmMember_Transfer_Load(object sender, EventArgs e)
        {
            Member objMember = new MemberManager().LoadMemberInfo(this._strMemberId);
            this.lblOldID.Text = objMember.ID;
            this.lblName.Text = objMember.Name;
            this.lblBalance.Text = "￥" + objMember.Balance.ToString("f2");
            this.numMoney.Maximum = objMember.Balance;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtNewID.Text.Trim() == "")
            {
                MessageBox.Show("【转入会员卡号】不能为空，请输入。", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNewID.Focus();
                return;
            }
            if (Common.ValidateMember(this.txtNewID.Text.Trim()) == "")
            {
                MessageBox.Show("【转入会员卡号】不存在，请重新输入。", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNewID.Focus();
                return;
            }
            if (new MemberManager().LoadMemberInfo(this.txtNewID.Text.Trim()).Status == 1)
            {
                MessageBox.Show("【转入会员卡号】已停用，不能转账，请重新输入。", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNewID.Focus();
                return;
            }
            if (this.txtNewID.Text.Trim() == this._strMemberId)
            {
                MessageBox.Show("【转入会员卡号】与转出会员卡号相同，请重新输入。", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNewID.Focus();
                return;
            }
            if (this.numMoney.Value <= 0)
            {
                MessageBox.Show("【转入金额】必须大于0元，请重新输入。", "消息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.numMoney.Focus();
                return;
            }

            //转出
            Deposit objDeposit = new Deposit();
            objDeposit.Mode = 1;
            objDeposit.MemberID = this._strMemberId;
            objDeposit.Money = 0 - this.numMoney.Value;
            objDeposit.Date = DateTime.Now;
            objDeposit.Remark = "余额转账：转入到卡号" + this.txtNewID.Text.Trim();

            //转入
            Deposit objDeposit2 = new Deposit();
            objDeposit2.Mode = 2;
            objDeposit2.MemberID = this.txtNewID.Text.Trim();
            objDeposit2.Money = this.numMoney.Value;
            objDeposit2.Date = objDeposit.Date;
            objDeposit2.Remark = "余额转账：从卡号" + this._strMemberId + "转出";

            if (new DepositManager().Transfer(objDeposit, objDeposit2))
            {
                int Msg = new MemberManager().TransferBalance(this._strMemberId, this.txtNewID.Text.Trim(), this.numMoney.Value);//更新会员余额
                switch (Msg)
                {
                    case 0:
                        MessageBox.Show("转账成功！","提示");
                        break;
                    case 1:
                        MessageBox.Show("转出账户余额更新失败！", "提示");
                        break;
                    case 2:
                        MessageBox.Show("转入账户余额更新失败！", "提示");
                        break;
                    case 3:
                        MessageBox.Show("转账操作错误：未执行！", "提示");
                        break;
                }
                DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Common.NumberAccpter(sender, e, false);
        }
    }
}
