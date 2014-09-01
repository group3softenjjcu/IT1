<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddAccommodation.aspx.cs" Inherits="University.Admin.AddAccommodation" %>
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
                <h3>New Accommodation</h3>
              </div>
              <div class="gadgetblock">   
                  <asp:ScriptManager ID="ScriptManager1" runat="server">
                  </asp:ScriptManager>
                  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                    
                         <table style="width:100%; display:block;" >
            <tr>
                <td class="style1"><label for="Address" class="label">Address: </label></td>
                <td><input id="TextAddress" name="Address" class="textbox" runat="server" /></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ErrorMessage="Not Null!!!!" Text="Address not null!!!" ControlToValidate="TextAddress"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style1"><label for="Room" class="label">Room: </label></td>
                <td><input id="TextRoom" name="Room" class="textbox"  runat="server" /></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Not Null!!!" Text="Room not null" ControlToValidate="TextRoom" ></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style1"><label for="Pax" class="label">Max pax: </label></td>
                <td><input id="TextPax" name="Pax" class="textbox"  runat="server" type="text" /></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Not Null!!!" Text="Not null" ControlToValidate="TextPax" ></asp:RequiredFieldValidator>
                </td>
            </tr>            
            <tr>
                <td class="style1"><label for="Price" class="label">Price: </label></td>
                <td><input id="TextPrice" name="Price" class="textbox"  runat="server" type="text" /></td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Not Null!!!" Text="Not null" ControlToValidate="TextPrice" ></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style1"><label for="Picture" class="label">Picture: </label></td>
                <td><asp:FileUpload ID="FileUploadImage" runat="server" /></td>
                <td />
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
