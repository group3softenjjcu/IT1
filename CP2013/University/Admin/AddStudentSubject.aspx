<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddStudentSubject.aspx.cs" Inherits="University.Admin.AddStudentSubject" %>
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
        width:250px;	
    }
</style>
    <div class="gadget">
              <div class="titlebar vertsortable_head">
                <a href="#" class="hidegadget" rel="hide_block"><img src="images/spacer.gif" alt="picture" width="19" height="33" /></a>
                <h3>New Student - Subject</h3>
              </div>
              <div class="gadgetblock">   
                  
                  <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                    
                         <table style="width:100%; display:block;" >
                             <tr>
                                <td class="style1"><label for="Subject" class="label">Subject: </label></td>
                                <td>
                                    <asp:DropDownList ID="DropDownListSubject" runat="server" Width="180" TabIndex="1">                    
                                    </asp:DropDownList>
                                </td>
                                
                            </tr>
                            
                             <tr>
                                <td class="style1"><label for="Student" class="label">Student: </label></td>
                                <td>
                                    <asp:DropDownList ID="DropDownListStudent" runat="server" Width="180" TabIndex="1">                    
                                    </asp:DropDownList>
                                </td>
                                
                            </tr>
                                                                             
                            <tr>    
                                <th></th>            
                                <td><asp:ImageButton ID="ImageButtonCreate" runat="server"  ImageUrl="~/Admin/images/function/create.jpg" OnClick="ImageCreate_Click"/></td>                
                                 
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
