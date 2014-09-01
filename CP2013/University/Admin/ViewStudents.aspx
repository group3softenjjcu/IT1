<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ViewStudents.aspx.cs" Inherits="University.Admin.ViewStudents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>    
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>        
                        <div class="gadget">            
            <div class="titlebar vertsortable_head">
                <a href="#" class="hidegadget" rel="hide_block"><img src="images/spacer.gif" alt="picture" width="19" height="33" /></a>
                <h3>List Student</h3>
            </div>
                </div>      
                <asp:Repeater ID="RepeaterStudent" runat="server">
                <HeaderTemplate>
                    <table style="width:100%;" border = "1" cellpadding ="2" cellspacing="2">
                        <tr bgcolor="blue" style="color:white">
                            <th>Username</th>
                            <th>Fullname</th>
                            <th>Picture</th>
                            <th>Active</th>                            
                            <th>Function</th>
                        </tr>                                            
                </HeaderTemplate>

                <ItemTemplate>
                        <tr>
                            <th align="left"><%# Eval("s_username")%></th>   
                            <td><%# Eval("s_fullname") %></td>
                            <td align="center" style="width:120px;"><img src='<%# "upload/student/"+Eval("s_picture") %>' width="100" height="100" /></td>
                            <th><asp:CheckBox ID="CheckBoxActive" runat="server"  Enabled="false" Checked='<%# Eval("s_active") %>'/></th>
                            <td style="width:170px;" align="center" ><a href='<%# "EditStatusStudent.aspx?s_username="+Eval("s_username") %>'><img src="images/function/update.jpg" width="80" /></a> </td>
                        </tr>
                </ItemTemplate>
                
                <FooterTemplate>
                    <tr>
                        <th colspan="5" style="height:20px;"></th>
                    </tr>                    
                    <tr>
                        <th colspan="6"><a href="AddStudents.aspx" style="font-size:14px; font-weight:bold; color:Red; text-decoration: no underline">
                            Add New Student</a></th>
                    </tr>
                </table>
                </FooterTemplate>                
            </asp:Repeater>

                        <table width="400" style="margin-left:180px;">
            <tr style="height:30px;">
                <td style="width:50px;" align="center">
                    <asp:ImageButton ID="ImageButtonFirstStudent" runat="server" 
                        ImageUrl="~/images/Paging/first.png" 
                        style="width:30px; height:30px; float:right" onclick="ImageButtonFirstStudent_Click" 
                         />
                </td>
                <td style="width:50px;">
                    <asp:ImageButton ID="ImageButtonPreStudent" ImageUrl="~/images/Paging/prve.jpg" 
                        style="width:30px; height:30px; float:right " runat="server" onclick="ImageButtonPreStudent_Click" 
                       />
                </td>
                <td style="width:50px;" align="center" valign="bottom">
                    <asp:Label ID="LabelStatusStudent" runat="server" style="padding-left:10px; padding-top:10px; width:30px; height:30px; font-size:14px; font-weight:bold; color:Blue"></asp:Label>
                </td>
                <td style="width:50px;">
                    <asp:ImageButton ID="ImageButtonNextStudent" ImageUrl="~/images/Paging/next.jpg" 
                        style="width:30px; height:30px; float:right" runat="server" onclick="ImageButtonNextStudent_Click"
                        />
                </td>
                <td style="width:50px;">
                    <asp:ImageButton ID="ImageButtonLastStudent" ImageUrl="~/images/Paging/last.png" 
                        style="width:30px; height:30px; float:right" runat="server" onclick="ImageButtonLastStudent_Click"
                        />
                </td>
                
            </tr>                                
        </table>
            
                    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
