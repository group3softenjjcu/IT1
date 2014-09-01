<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="University.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="homepage" class="clear">
        <!-- ###### -->
    <div id="left_column">
          <h2>Prospective Students</h2>
          <div class="imgholder"><a href="#"><img src="images/demo/prospective.jpg" width="220" height="80" alt=""></a></div>
          <h2>Current Students</h2>
          <div class="imgholder"><a href="#"><img src="images/demo/current.jpg" width="220" height="80" alt=""></a></div>
          <h2>International Students</h2>
          <div class="imgholder"><a href="#"><img src="images/demo/international.jpg" width="220" height="80" alt=""></a></div>
          <h2>Alumni</h2>
          <div class="imgholder"><a href="#"><img src="images/demo/alumni.jpg" width="220" height="80" alt=""></a></div>
     </div>
    <!--###########################-->
    <div id="latestnews">
            <h2>Latest News &amp; Events</h2>
          <ul>
            <li class="clear">
              <div class="imgl"><img src="images/demo/beach.jpg" width="125" height="125" alt=""></div>
              <div class="latestnews">
                <p><a href="#">Beach Party in 8 August</a></p>
                <p>In order to help new alumnus acquaint themselve with university new enviroment. </a></p>
              </div>
            </li>
            <li class="clear">
              <div class="imgl"><img src="images/demo/writing.jpg" width="125" height="125" alt=""></div>
              <div class="latestnews">
                <p><a href="#">Improve your writing skill.</a></p>
                <p>Want to get a good grade for your essay assignments? How do you do that? One way is to write to that your work showcases your thinking ability.. Do you know how to do that?</p>
              </div>
            </li>
            <li class="last clear">
              <div class="imgl"><img src="images/demo/math.jpg" width="125" height="125" alt=""></div>
              <div class="latestnews">
                <p><a href="#">Having problem with your Mathematics?</a></p>
                <p>MESH Centre is where your seniors peer tutor you if you&#8217;re having problems with your Mathematics, English Language or Statistics.  It&#8217;s on every Thursday, in C02-03/05 (Apple Rooms), from 4.00pm-6.00pm. </p>
              </div>
            </li>
          </ul>
          <p class="readmore"><a href="#">Click here to view all of the latest news and events »</a></p>
        </div>

    <!-- ###### -->
        <div id="right_column">
          <div class="holder">
            <h2>Virtual Tour</h2>
            <a href="#"><img src="images/demo/video.gif" alt=""></a> </div>
          <div class="holder">
            <h2>Quick Information</h2>
            <div class="apply"><a href="#"><img src="images/demo/application.jpg" width="100" height="100" alt=""> <strong>Make An Application</strong></a></div>
            <div class="apply"><a href="#"><img src="images/demo/appointment.jpg" width="100" height="100" alt=""> <strong>Make An Appointment</strong></a></div>
          </div>
        </div>
        <!-- ###### -->
    </div>
</asp:Content>
