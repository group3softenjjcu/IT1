<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="University.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="homepage" class="clear">
        <div id="left_column">
          <h2>Change Profile</h2>
          <div class="imgholder"><a href="ChangeProfile.aspx"><img src="images/demo/profile/profile.png" width="220" height="80" alt=""></a></div>
          <h2>Change Password</h2>
          <div class="imgholder"><a href="ChangePassword.aspx"><img src="images/demo/profile/password.jpg" width="220" height="100" alt=""></a></div>
          <h2>Make an appointment</h2>
          <div class="imgholder"><a href="ViewSubject.aspx"><img src="images/demo/appointment.jpg" width="220" height="100" alt=""></a></div>          
            <h2>View appointment</h2>
          <div class="imgholder"><a href="ViewAppointment.aspx"><img src="images/demo/profile/viewappointment.jpg" width="220" height="100" alt=""></a></div>          
        </div>

        <div id="latestnews">
            <h2>Student Profile</h2>
          <ul>
            <li class="clear">
              <div class="imgl" style="border:0;">Old Password: </div>
              <div class="latestnews">
                <p><asp:TextBox ID="TextBoxOldPass" TextMode="Password" runat="server" Height="19px" Width="169px"></asp:TextBox></p>                
              </div>
              
              <div class="imgl" style="border:0;">New Password: </div>
              <div class="latestnews">
                <p><asp:TextBox ID="TextBoxNewPass" TextMode="Password" runat="server" Height="19px" Width="169px"></asp:TextBox></p>                
              </div>

              <div class="imgl" style="border:0;">Confirm Password: </div>
              <div class="latestnews">                  
                <p><asp:TextBox ID="TextBoxConfirmNewPass" TextMode="Password" runat="server" Height="19px" Width="169px"></asp:TextBox></p>                
              </div>
              
              <div class="latestnews">                  
                <asp:Button ID="ButtonChange" runat="server" Text="Change" OnClick="ButtonChange_Click" />
              </div>
                                
            </li>              
              <asp:HiddenField ID="HiddenFieldUsername" runat="server" />
              <asp:HiddenField ID="HiddenFieldPassword" runat="server" />
              <asp:HiddenField ID="HiddenFieldFullname" runat="server" />              
              <asp:HiddenField ID="HiddenFieldPhone" runat="server" />
              <asp:HiddenField ID="HiddenFieldGender" runat="server" />
              <asp:HiddenField ID="HiddenFieldActive" runat="server" />              
              <asp:HiddenField ID="HiddenFieldImage" runat="server" />
            </ul>
        </div>
    </div>
</asp:Content>
