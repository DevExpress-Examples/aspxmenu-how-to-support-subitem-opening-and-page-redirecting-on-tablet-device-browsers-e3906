using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using DevExpress.Web.ASPxMenu;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for MenuItemTemplate
/// </summary>
public class MenuItemTemplate : ITemplate
{	
	public MenuItemTemplate()
	{	
	}
	
	public void InstantiateIn(Control container) {
		DevExpress.Web.ASPxMenu.MenuItemTemplateContainer c = container as DevExpress.Web.ASPxMenu.MenuItemTemplateContainer;
		DevExpress.Web.ASPxMenu.MenuItem item = c.Item;
		if (String.IsNullOrEmpty(item.NavigateUrl)) {
			Literal l = new Literal {
				Text = item.Text
			};
			c.Controls.Add(l);
		}else if (c.Item.HasChildren) {
			string itemText = String.Format("<div onclick=\"javascript:PageRedirectTo(event,\'{0}\')\">{1}</div>",
				c.ResolveUrl(item.NavigateUrl), item.Text);
			Literal l = new Literal {
				Text = itemText
			};
			c.Controls.Add(l);
		}
		else {
			HyperLink a = new HyperLink {
				NavigateUrl = item.NavigateUrl,
				Text = item.Text
			};
			c.Controls.Add(a);
		}
	}
}