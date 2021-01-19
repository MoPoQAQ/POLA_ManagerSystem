﻿using Model;
using System;
using System.Windows.Forms;
using BLL;

namespace POLA_MMS.Member_UI
{
    public partial class frmDeposit_Add : Form
    {
        private string _strMemberId = "";

        public frmDeposit_Add(string memberid)
        {
            InitializeComponent();
            this._strMemberId = memberid;
        }

        private void frmDeposit_Add_Load(object sender, EventArgs e)
        {
            Member objMember = new MemberManager().LoadMemberInfo(this._strMemberId);
            this.lblMemberID.Text = objMember.ID;
            this.lblName.Text = objMember.Name;
            this.lblCardName.Text = objMember.Card.CardName;
            this.lblBalance.Text = "￥" + objMember.Balance.ToString("f2");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Deposit objDeposit = new Deposit();
            objDeposit.MemberID = this._strMemberId;
            objDeposit.Money = this.numMoney.Value;//充值金额
            objDeposit.Remark = this.txtRemark.Text.Trim();
            objDeposit.Date = DateTime.Now;
            objDeposit.Mode = 0;//充值
            if (objDeposit.Money > 0)//充值金额必须大于0
            {
                SystemConfigManager objSystemConfig = new SystemConfigManager();
                string strId = new DepositManager().InsertDeposit(objDeposit);
                if (objSystemConfig.GetIsDeposit())
                {
                    objDeposit.ParentID = decimal.Parse(strId);
                    decimal dMoney = decimal.Parse(objSystemConfig.Select(0, "cfg_deposit_money").VarValue);//获取基数金额
                    decimal dSend = decimal.Parse(objSystemConfig.Select(1, "cfg_deposit_send").VarValue);//获取增送金额
                    string result = (objDeposit.Money / dMoney).ToString();
                    if (result.IndexOf('.') > -1)
                    {
                        result = result.Substring(0, result.IndexOf('.'));
                    }
                    if (decimal.Parse(result) > 0)
                    {
                        dSend = dSend * decimal.Parse(result);
                        objDeposit.Remark = "活动：充" + objDeposit.Money.ToString() + "元，送" + dSend + "元";
                        objDeposit.Money = dSend;
                        objDeposit.Mode = 3;//增送
                        new DepositManager().InsertDeposit(objDeposit);
                    }
                }
                new MemberManager().UpdateBalance(this._strMemberId);//更新余额
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
