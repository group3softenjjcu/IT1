<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="ViewAccommodation.aspx.cs" Inherits="University.ViewAccommodation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="homepage" class="clear">
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
                    <td rowspan="3" style="width: 135px;">
                        <asp:Image ID="Image1" runat="server" Height="140px" ImageUrl='<%# "Admin/Upload/"+Eval("accom_picture") %>'
                            Width="150px"  /></td>
                    <td style="width: 180px">                        
                        <b>Price :</b>
                        <asp:Label ID="LabelPrice" runat="server" Font-Bold="True" Text='<%# Eval("accom_price") %>'></asp:Label>&nbsp;
                        </td>                    
                </tr>
                <tr>
                    <td>
                        <b>Rating: </b>
                        <asp:Label ID="LabelDescription" runat="server" Font-Bold="True" Text="4/5"></asp:Label>&nbsp;
                    </td>
                </tr>
                <tr>
                    <td style="width: 135px">
                        <a href='<%# "DetailAccommodation.aspx?accom_id="+Eval("accom_id") %>'>Read More.....</a>
                        
                        </td>
                </tr>
            </table>
        </ItemTemplate>        
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                                
        <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    </asp:DataList>   
        
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>                 

        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                  <ContentTemplate>
                  
     <table>
            <tr style="height:30px;">
                <td align="center">
                    <asp:ImageButton ID="ImageButtonFirst" runat="server" 
                        ImageUrl="~/images/Paging/first.png" 
                        style="width:30px; height:30px; float:right" onclick="ImageButtonFirst_Click" />
                </td>
                <td>
                    <asp:ImageButton ID="ImageButtonPre" ImageUrl="~/images/Paging/prve.jpg" 
                        style="width:30px; height:30px; float:right " runat="server" 
                        onclick="ImageButtonPre_Click" />
                </td>
                <td align="center" valign="bottom" style="width:100px; text-align:center">
                    <asp:Label ID="LabelStatus" runat="server" style="width:30px; height:30px; font-size:16px; font-weight:bold; color:Blue; text-align:center"></asp:Label>
                </td>
                <td>
                    <asp:ImageButton ID="ImageButtonNext" ImageUrl="~/images/Paging/next.jpg" 
                        style="width:30px; height:30px;" runat="server" 
                        onclick="ImageButtonNext_Click" />
                </td>
                <td>
                    <asp:ImageButton ID="ImageButtonLast" ImageUrl="~/images/Paging/last.png" 
                        style="width:30px; height:30px;" runat="server" 
                        onclick="ImageButtonLast_Click" />
                </td>
            </tr>                                
        </table>
            </ContentTemplate>
                  </asp:UpdatePanel>
    </div>
</asp:Content>
