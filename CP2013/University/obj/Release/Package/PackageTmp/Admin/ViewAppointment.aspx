<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ViewAppointment.aspx.cs" Inherits="University.Admin.ViewAppointment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">    
    <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>    
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>        
    <div class="gadget">            
            <div class="titlebar vertsortable_head">
                <a href="#" class="hidegadget" rel="hide_block"><img src="images/spacer.gif" alt="picture" width="19" height="33" /></a>
                <h3>List Appointment</h3>
            </div>
                </div>    
                
            <div class="gadgetblock">
                <div>
              <span style="color:Blue; font-size:14px; font-weight:bold;">
                    Filter Appointment By Subject 
              </span>
              <span>
                  <asp:DropDownList ID="DropDownListSubject" runat="server" style="width:180px; vertical-align:central" TabIndex="3" 
                        AutoPostBack="true" OnSelectedIndexChanged="DropDownListSubject_SelectedIndexChanged" >
                  </asp:DropDownList>
              </span>
              
                  
              
              <span style="color:Blue; font-weight:bold; font-size:14px; margin-left:100px;">The 
                    Total Appointment: </span>
                        <span>
                            <asp:Label ID="LabelAppointment" runat="server" Text="Label" style="color:Lime; font-size:14px; font-weight:bold;"></asp:Label>
                        </span>
              </div>

                <br />           
                                    
            <asp:Repeater ID="RepeaterAppointment" runat="server">
                <HeaderTemplate>
                    <table style="width:100%;" border = "1" cellpadding ="2" cellspacing="2">
                        <tr bgcolor="blue" style="color:white">
                            <th>Subject</th>
                            <th>Date</th>
                            <th>Time</th>
                            <th>Room</th>
                            <th>Description</th>
                            <th>Functions</th>
                        </tr>                                            
                </HeaderTemplate>

                <ItemTemplate>
                        <tr>
                            <td align="center" style="width:60px;"><%# Eval("sub_id")%></td>
                            <td align="center" style="width:80px;"><%# Eval("ap_date", "{0:MM-dd-yyyy}")%></td>   
                            <td align="center" style="width:80px;"><%# Eval("ap_time") %></td>
                            <td align="center" style="width:80px;"><%# Eval("ap_room") %></td>
                            <td><%# Eval("ap_description")%></td>
                            <td style="width:170px;" align="center" ><a href='<%# "EditAppointment.aspx?ap_id="+Eval("ap_id") %>'><img src="images/function/viewdetails2.jpg" /></a> <a href='<%# "DeleteAppointment.aspx?ap_id="+Eval("ap_id") %>' onclick="return confirm('Are you sure you wanna Delete???')"><img src="images/function/deletes.jpg" /></a></td>
                        </tr>
                </ItemTemplate>
                
                <FooterTemplate>
                    <tr>
                        <th colspan="6" style="height:20px;"></th>
                    </tr>
                    <tr>
                        <th colspan="6"><a href="AddAppointment.aspx" style="font-size:14px; font-weight:bold; color:Red; text-decoration: no underline">
                            Add New Appointment</a></th>
                    </tr>
                </table>
                </FooterTemplate>                
            </asp:Repeater>
            
            <table width="400" style="margin-left:180px;">
            <tr style="height:30px;">
                <td style="width:50px;" align="center">
                    <asp:ImageButton ID="ImageButtonFirstAp" runat="server" 
                        ImageUrl="~/images/Paging/first.png" 
                        style="width:30px; height:30px; float:right" onclick="ImageButtonFirstAp_Click" 
                         />
                </td>
                <td style="width:50px;">
                    <asp:ImageButton ID="ImageButtonPreAp" ImageUrl="~/images/Paging/prve.jpg" 
                        style="width:30px; height:30px; float:right " runat="server" onclick="ImageButtonPreAp_Click" 
                       />
                </td>
                <td style="width:50px;" align="center" valign="bottom">
                    <asp:Label ID="LabelStatusAppointment" runat="server" style="padding-left:10px; padding-top:10px; width:30px; height:30px; font-size:14px; font-weight:bold; color:Blue"></asp:Label>
                </td>
                <td style="width:50px;">
                    <asp:ImageButton ID="ImageButtonNextAp" ImageUrl="~/images/Paging/next.jpg" 
                        style="width:30px; height:30px; float:right" runat="server" onclick="ImageButtonNextAp_Click"
                        />
                </td>
                <td style="width:50px;">
                    <asp:ImageButton ID="ImageButtonLastAp" ImageUrl="~/images/Paging/last.png" 
                        style="width:30px; height:30px; float:right" runat="server" onclick="ImageButtonLastAp_Click"
                        />
                </td>
                
            </tr>                                
        </table>
                </div>
                    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>        
    <div class="gadget">            
            <div class="titlebar vertsortable_head">
                <a href="#" class="hidegadget" rel="hide_block"><img src="images/spacer.gif" alt="picture" width="19" height="33" /></a>
                <h3>List Subject By Employee</h3>
            </div>
                </div>                                                
                        
            <asp:Repeater ID="RepeaterSubject" runat="server">
                <HeaderTemplate>
                    <table style="width:100%;" border = "1" cellpadding ="2" cellspacing="2">
                        <tr bgcolor="blue" style="color:white">
                            <th>Subject ID</th>
                            <th>Subject Name</th>
                            <th>Subject Description</th>                            
                        </tr>                                            
                </HeaderTemplate>

                <ItemTemplate>
                        <tr>
                            <td align="center"><%# Eval("sub_id")%></td>   
                            <td align="center"><%# Eval("sub_name") %></td>
                            <td align="center"><%# Eval("sub_description") %></td>
                            
                        </tr>
                </ItemTemplate>
                
                <FooterTemplate>
                    <tr>
                        <th colspan="4" style="height:20px;"></th>
                    </tr>                    
                </table>
                </FooterTemplate>                
            </asp:Repeater>
            
            <table width="400" style="margin-left:180px;">
            <tr style="height:30px;">
                <td style="width:50px;" align="center">
                    <asp:ImageButton ID="ImageButtonFirstSubject" runat="server" 
                        ImageUrl="~/images/Paging/first.png" 
                        style="width:30px; height:30px; float:right" onclick="ImageButtonFirstSubject_Click" 
                         />
                </td>
                <td style="width:50px;">
                    <asp:ImageButton ID="ImageButtonPreSubject" ImageUrl="~/images/Paging/prve.jpg" 
                        style="width:30px; height:30px; float:right " runat="server" onclick="ImageButtonPreSubject_Click" 
                       />
                </td>
                <td style="width:50px;" align="center" valign="bottom">
                    <asp:Label ID="LabelStatusSubject" runat="server" style="padding-left:10px; padding-top:10px; width:30px; height:30px; font-size:14px; font-weight:bold; color:Blue"></asp:Label>
                </td>
                <td style="width:50px;">
                    <asp:ImageButton ID="ImageButtonNextSubject" ImageUrl="~/images/Paging/next.jpg" 
                        style="width:30px; height:30px; float:right" runat="server" onclick="ImageButtonNextSubject_Click"
                        />
                </td>
                <td style="width:50px;">
                    <asp:ImageButton ID="ImageButtonLastSubject" ImageUrl="~/images/Paging/last.png" 
                        style="width:30px; height:30px; float:right" runat="server" onclick="ImageButtonLastSubject_Click"
                        />
                </td>
            </tr>                                
        </table>
                    </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
