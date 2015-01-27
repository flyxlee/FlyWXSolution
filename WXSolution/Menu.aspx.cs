using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WXService.Message;
using WXService.Entity.Menu;
using WXService.Handlers;
using WXService.Entity.ReturnCode;

namespace WXSolution
{
    public partial class Menu : System.Web.UI.Page
    {
        string token;
        protected void Page_Load(object sender, EventArgs e)
        {
            AccessTokenHandler ath = new AccessTokenHandler();
            token = ath.GetAccessToken("wxfde96913568e3a92", "7aabcdc7c2d855b01db56000071e839f");
        }

        protected void CreateBtn_Click(object sender, EventArgs e)
        {         
            IMenuApi menuapi = new MenuApi();
            MenuJson MJ = DealWithMenu.GetMenuJson();
            ErrJson EJ = menuapi.CreateMenu(token, MJ);
            lblMsg.Text = EJ.errcode +":"+ EJ.errmsg;
        }

        protected void GetBtn_Click(object sender, EventArgs e)
        {
            IMenuApi menuapi = new MenuApi();
            MenuJson MJ = menuapi.GetMenu(token);
            lblMsg.Text = MJ.ToJson();
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            IMenuApi menuapi = new MenuApi();
            ErrJson EJ = menuapi.DeleteMenu(token);
            lblMsg.Text = EJ.errcode + ":" + EJ.errmsg;
        }

    }
}