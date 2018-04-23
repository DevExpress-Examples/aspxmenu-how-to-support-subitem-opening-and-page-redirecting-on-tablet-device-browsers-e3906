using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Web.ASPxMenu;
 
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
	protected void ASPxMenu1_Init(object sender, EventArgs e) {
		(sender as ASPxMenu).ItemTextTemplate = new MenuItemTemplate();
	}
}