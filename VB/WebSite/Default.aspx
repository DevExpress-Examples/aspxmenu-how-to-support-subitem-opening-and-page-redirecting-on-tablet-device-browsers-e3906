<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxMenu" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
	<script language="javascript" type="text/javascript">
		function PageRedirectTo(event, url) {
			window.location.href = url;
			ASPxClientUtils.PreventEventAndBubble(event);
		}    
	</script>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<dx:ASPxMenu ID="ASPxMenu1" runat="server" OnInit="ASPxMenu1_Init" AppearAfter="5000">
			<Items>
				<dx:MenuItem Text="Root menu item">
					<Items>
						<dx:MenuItem Text="Item 1" NavigateUrl="~/Default2.aspx">
							<Items>
								<dx:MenuItem NavigateUrl="~/Default2.aspx">
								</dx:MenuItem>
								<dx:MenuItem NavigateUrl="~/Default2.aspx">
								</dx:MenuItem>
								<dx:MenuItem NavigateUrl="~/Default2.aspx">
								</dx:MenuItem>
							</Items>
						</dx:MenuItem>
						<dx:MenuItem Text="Item 2" NavigateUrl="~/Default2.aspx">
							<Items>
								<dx:MenuItem NavigateUrl="~/Default2.aspx">
								</dx:MenuItem>
								<dx:MenuItem NavigateUrl="~/Default2.aspx">
								</dx:MenuItem>
								<dx:MenuItem NavigateUrl="~/Default2.aspx">
								</dx:MenuItem>
							</Items>
						</dx:MenuItem>
						<dx:MenuItem Text="Item 3" NavigateUrl="~/Default2.aspx">
							<Items>
								<dx:MenuItem NavigateUrl="~/Default2.aspx">
								</dx:MenuItem>
								<dx:MenuItem NavigateUrl="~/Default2.aspx">
								</dx:MenuItem>
							</Items>
						</dx:MenuItem>
					</Items>
				</dx:MenuItem>
			</Items>
		</dx:ASPxMenu>
	</div>
	</form>
</body>
</html>