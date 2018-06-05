using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Com.Nidec.Mes.Framework;


namespace Com.Nidec.Mes.VCVP.NCVP_MasterMaintenance
{
    public partial class AddDrawMasterForm : FormCommonNCVP
    {
        public AddDrawMasterForm()
        {
            InitializeComponent();
        }

        public DrawVo vo = null;

        private void AddModelMasterForm_Load(object sender, EventArgs e)
        {
            if (vo.DrawId > 0)
            {
                DrawCode_txt.Text = vo.DrawCode;
                DrawName_txt.Text = vo.DrawName;
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            if (CheckDate())
            {
                DrawVo outVo = new DrawVo();
                DrawVo inVo = new DrawVo
                {
                    DrawId = vo.DrawId,
                    DrawCode = DrawCode_txt.Text,
                    DrawName = DrawName_txt.Text,
                    FactoryCode = UserData.GetUserData().FactoryCode,
                    RegistrationUserCode = UserData.GetUserData().UserCode
                };
                try
                {
                    if (inVo.DrawId > 0)
                    { outVo = (DrawVo)DefaultCbmInvoker.Invoke( new UpdateDrawCbm(), inVo); }
                    else
                    { outVo = (DrawVo)DefaultCbmInvoker.Invoke(new AddDrawCbm(), inVo); }
                }
                catch (Com.Nidec.Mes.Framework.ApplicationException exception)
                {
                    popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                    logger.Error(exception.GetMessageData());
                    return;
                }
                if (outVo.AffectedCount > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

            }
        }

        private bool CheckDate()
        {
            if (DrawCode_txt.Text.Trim().Length == 0)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, DrawCode_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                DrawCode_txt.Focus();
                return false;
            }
            if (DrawName_txt.Text.Trim().Length == 0)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, DrawName_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                DrawName_txt.Focus();
                return false;
            }
            DrawCode_txt.Text = DrawCode_txt.Text.Trim();
            DrawName_txt.Text = DrawName_txt.Text.Trim();
            DrawVo outVo = new DrawVo(),
                inVo = new DrawVo { DrawId = vo.DrawId, DrawCode = DrawCode_txt.Text };
            try
            {
                outVo = (DrawVo)DefaultCbmInvoker.Invoke(new CheckDrawCbm(), inVo);
                if (outVo.AffectedCount > 0)
                {
                    messageData = new MessageData("mmcc00006", Properties.Resources.mmcc00006, DrawCode_lbl.Text);
                    popUpMessage.Warning(messageData, Text);
                    DrawCode_txt.Focus();
                    return false;
                }
            }
            catch (Com.Nidec.Mes.Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
                return false;
            }
            return true;
        }
    }
}
