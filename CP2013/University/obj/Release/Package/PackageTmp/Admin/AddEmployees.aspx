<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddEmployees.aspx.cs" Inherits="University.Admin.AddEmployees" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
    .label
    {
        	float:left;
        	font-size:13px;
        	font-weight:bold;
        	padding:6px 0px;
        	height:20px;    
        	color:Blue; 
        	width:100px;   	
    }
    .style1
    {
        width: 110px;
    }
    .textbox
    {
        height:30px;
        width:220px;	
    }
</style>
<div class="gadget">
              <div class="titlebar vertsortable_head">
                <a href="#" class="hidegadget" rel="hide_block"><img src="images/spacer.gif" alt="picture" width="19" height="33" /></a>
                <h3>New Employees</h3>
              </div>
              <div class="gadgetblock">   
                  <asp:ScriptManager ID="ScriptManager1" runat="server">
                  </asp:ScriptManager>
                  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                    
                         <table style="width:100%; display:block;" >
            <tr>
                <td class="style1"><label for="Username" class="label">UserName: </label></td>
                <td><input id="TextUsername" name="User_Name" class="textbox" runat="server" /></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="Not Null!!!!" Text="User_Name not null!!!" ControlToValidate="TextUsername"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style1"><label for="Password" class="label">Password: </label></td>
                <td><input id="TextPassword" name="Password" class="textbox"  runat="server" type="password" /></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Not Null!!!" Text="Password not null" ControlToValidate="TextPassword" ></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style1"><label for="Name" class="label">Full Name: </label></td>
                <td><input id="TextName" name="Name" class="textbox"  runat="server" type="text" /></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Not Null!!!" Text="Name not null" ControlToValidate="TextName" ></asp:RequiredFieldValidator>
                </td>
            </tr>            
            <tr>
                <td class="style1"><label for="Phone" class="label">Phone: </label></td>
                <td><input id="TextPhone" name="Phone" class="textbox"  runat="server" type="text" /></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Not Null!!!" Text="Phone not null!!!" ControlToValidate="TextPhone" ></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="RegularExpressionValidator" 
             ControlToValidate="TextPhone" ValidationExpression="^[0-9][0-9]-\d{3}-\d{3}$" Text="Phone is wrong format!!!"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style1"><label for="Gender" class="label">Gender: </label></td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonListGender" runat="server" CellSpacing="2" 
                        CellPadding="2" RepeatColumns="3" Width="200px">
                        <asp:ListItem Value="True" Selected="True">Male</asp:ListItem>
                        <asp:ListItem Value="False">FeMale</asp:ListItem>
                    </asp:RadioButtonList>
                </td>  
                <td />   
            </tr>            
            <tr>
                <td class="style1"><label for="Picture" class="label">Picture: </label></td>
                <td><asp:FileUpload ID="FileUploadImage" runat="server" /></td>
                <td />
            </tr>
            <tr>
                <td class="style1"><label for="Department" class="label">Department: </label></td>
                <td>
                    <asp:DropDownList ID="DropDownListDepartment" runat="server" Width="180" TabIndex="1">                    
                    </asp:DropDownList>
                </td>
                <td />
            </tr>
            
            <tr>                
                <td class="style1"><label for="Department_head" class="label">Head: </label></td>
                <td>
                    <asp:CheckBox ID="CheckBoxHead" runat="server" Checked="false" />
                </td>
                <td />
            </tr>
            <tr>
                <td class="style1"><label for="Active" class="label">Active: </label></td>
                <td>
                    <asp:CheckBox ID="CheckBoxActive" runat="server" Checked="true" />
                </td>
            </tr>            
            <tr>    
                <th></th>            
                <td><asp:ImageButton ID="ImageButtonCreate" runat="server"  ImageUrl="~/Admin/images/function/create.jpg" OnClick="ImageCreate_Click"/></td>                
                 <td />
            </tr>
          </table>
                    </ContentTemplate>
                  </asp:UpdatePanel>
              </div>
</div>              
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
