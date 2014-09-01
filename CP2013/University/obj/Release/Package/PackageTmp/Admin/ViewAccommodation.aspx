<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ViewAccommodation.aspx.cs" Inherits="University.Admin.ViewAccommodation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="gadget">
              <div class="titlebar vertsortable_head">
                <a href="#" class="hidegadget" rel="hide_block"><img src="images/spacer.gif" alt="picture" width="19" height="33" /></a>
                <h3>List Accommodation</h3>
              </div>
              <div class="gadgetblock">
                    <table style="width: 100%;" border="1" bordercolor="#efd4f7" cellpadding="1" cellspacing="0" style="border-right: #a2d9ee 1px solid;
        border-top: #a2d9ee 1px solid; border-left: #a2d9ee 1px solid;  border-bottom: #a2d9ee 1px solid;">
            <tr>
                <td colspan="3" style="background-image: url(../Employees/images/forms/bg_repeat.gif); height:80px;">
                <strong><span style="font-size: 24pt; color: #ff0066; text-align: center">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" ForeColor="#0000C0"
                    Text="Accommodations" style=" margin-left:250px;"></asp:Label></span></strong></td>
            </tr>
            <tr>
                <td>
                    <asp:DataList ID="DataListAccommodation" runat="server"
            CellPadding="2" CellSpacing="2" GridLines="Both" HorizontalAlign="Center" 
            RepeatColumns="3" RepeatDirection="Horizontal" style="width:100%;">
        <ItemTemplate>
            <table>
                <tr>
                    <td align="left" colspan="2">
                        Address :
                        <asp:Label ID="LabelAddress" runat="server" Font-Bold="True" Text='<%# Eval("accom_address") %>'></asp:Label></td>
                </tr>
                <tr>
                    <td rowspan="2" style="width: 135px">
                        <asp:Image ID="Image1" runat="server" Height="107px" ImageUrl='<%# "Upload/"+Eval("accom_picture") %>'
                            Width="106px" /></td>
                    <td style="width: 180px">                        
                        <b>Price :</b>
                        <asp:Label ID="LabelPrice" runat="server" Font-Bold="True" Text='<%# Eval("accom_price") %>'></asp:Label>&nbsp;
                        </td>                    
                </tr>
                
                <tr>
                    <td style="width: 135px">
                        <a href='<%# "DetailAccommodation.aspx?accom_id="+Eval("accom_id") %>'>Read More.....</a>
                        
                        </td>
                </tr>
            </table>
        </ItemTemplate>

        <FooterTemplate>
                    <tr>
                        <th colspan="6" style="height:20px;"></th>
                    </tr>
                    <tr>
                        <th colspan="6"><a href="AddAccommodation.aspx" style="font-size:14px; font-weight:bold; color:Red; text-decoration: no underline">
                            Add New Accommodation</a></th>
                    </tr>
                </table>
                </FooterTemplate>  
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                                
        <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    </asp:DataList>
                </td>    
            </tr>
     </table>
                  <asp:ScriptManager ID="ScriptManager1" runat="server">
                  </asp:ScriptManager>
                  <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                  <ContentTemplate>
                  
     <table width="400" style="margin-left:180px;">
            <tr style="height:30px;">
                <td style="width:50px;" align="center">
                    <asp:ImageButton ID="ImageButtonFirst" runat="server" 
                        ImageUrl="~/images/Paging/first.png" 
                        style="width:30px; height:30px; float:right" onclick="ImageButtonFirst_Click" />
                </td>
                <td style="width:50px;">
                    <asp:ImageButton ID="ImageButtonPre" ImageUrl="~/images/Paging/prve.jpg" 
                        style="width:30px; height:30px; float:right " runat="server" 
                        onclick="ImageButtonPre_Click" />
                </td>
                <td style="width:50px;" align="center" valign="bottom">
                    <asp:Label ID="LabelStatus" runat="server" style="padding-left:30px; padding-top:10px; width:30px; height:30px; font-size:14px; font-weight:bold; color:Blue"></asp:Label>
                </td>
                <td style="width:50px;">
                    <asp:ImageButton ID="ImageButtonNext" ImageUrl="~/images/Paging/next.jpg" 
                        style="width:30px; height:30px; float:right" runat="server" 
                        onclick="ImageButtonNext_Click" />
                </td>
                <td style="width:50px;">
                    <asp:ImageButton ID="ImageButtonLast" ImageUrl="~/images/Paging/last.png" 
                        style="width:30px; height:30px; float:right" runat="server" 
                        onclick="ImageButtonLast_Click" />
                </td>
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
