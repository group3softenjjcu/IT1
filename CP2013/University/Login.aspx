<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="University.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Sigh in Management System</title>
    <link href="Employees/css/screen.css" rel="stylesheet" type="text/css" /> 
</head>
<body id="login-bg">
<form id="form1" runat="server">


<!-- Start: login-holder -->
<div id="login-holder">

	<!-- start logo -->
	<div id="logo-login">
		<a href="#"></a>
	</div>
	<!-- end logo -->
	
	<div class="clear"></div>
	
	<!--  start loginbox ................................................................................. -->
	<div id="loginbox">
	
	<!--  start login-inner -->
	<div id="login-inner">
		<table border="0" cellpadding="0" cellspacing="0">
		<tr>
			<th>Username</th>
			<td>
                <asp:TextBox ID="TextBox_Username" runat="server" CssClass="login-inp" TabIndex="1"></asp:TextBox>
			    <!-- html <input type="text"  class="login-inp" /> -->
	        </td>
		</tr>
		<tr>
			<th>Password</th>
			<td>
			    <!-- html pass <input type="password" value="************"  onfocus="this.value=''" class="login-inp" /> -->
			    <asp:TextBox ID="TextBox_Password" runat="server" TextMode="Password" 
                    CssClass="login-inp" TabIndex="2"  ></asp:TextBox>    
		    </td>
		</tr>	
			
		<tr>
			<th></th>
			<td valign="top"><input type="checkbox" class="checkbox-size" id="login-check"  /><label for="login-check">Remember me</label></td>
		</tr>
		<tr>
			<th></th>
			<td>
                <asp:Button ID="Button_Submit" runat="server" Text="Submit" 
                    CssClass="submit-login" OnClick="Button_Submit_Click" />
			</td>
		</tr>
		</table>
	</div>
 	<!--  end login-inner -->
	<div class="clear"></div>
	<a href="Home.aspx" class="forgot-pwd">Index | Home</a>
 </div>
 <!--  end loginbox -->
 
	<!--  start forgotbox ................................................................................... -->
	<div id="forgotbox">
		<div id="forgotbox-text">Please type in your email and we'll reset your password.</div>
		<!--  start forgot-inner -->
		<div id="forgot-inner">
		<table border="0" cellpadding="0" cellspacing="0">
		<tr>
			<th>Email address:</th>
			<td><input type="text" value=""   class="login-inp" /></td>
		</tr>
		<tr>
			<th> </th>
			<td><input type="button" class="submit-login"  /></td>
		</tr>
		</table>
		</div>
		<!--  end forgot-inner -->
		<div class="clear"></div>
		<a href="" class="back-login">Back to login</a>
	</div>
	<!--  end forgotbox -->

</div>
<!-- End: login-holder -->
</form>
</body>
</html>
