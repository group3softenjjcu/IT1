<%@ Page Title="" Language="C#" MasterPageFile="~/Student.Master" AutoEventWireup="true" CodeBehind="gallery.aspx.cs" Inherits="University.gallery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">      
      <!-- ####################################################################################################### -->
      <div id="gallery" class="clear">
        <h2 class="title">Latest Images From The University</h2>
        <ul>
          <li><a href="images/demo/jcu_images/1.jpg" rel="prettyPhoto[gallery1]" title="Image 1"><img src="images/demo/jcu_images/1.jpg" width="120" height="120" alt=""></a></li>
          <li><a href="images/demo/jcu_images/2.jpg" rel="prettyPhoto[gallery1]" title="Image 2"><img src="images/demo/jcu_images/2.jpg" width="120" height="120" alt=""></a></li>
          <li><a href="images/demo/jcu_images/3.jpg" rel="prettyPhoto[gallery1]" title="Image 3"><img src="images/demo/jcu_images/3.jpg" width="120" height="120" alt=""></a></li>
          <li class="last"><a href="images/demo/jcu_images/4.jpg" rel="prettyPhoto[gallery1]" title="Image 4"><img src="images/demo/jcu_images/4.jpg" width="120" height="120" alt=""></a></li>
          <li><a href="images/demo/jcu_images/5.jpg" rel="prettyPhoto[gallery1]" title="Image 5"><img src="images/demo/jcu_images/5.jpg" width="120" height="120" alt=""></a></li>
          <li><a href="images/demo/jcu_images/6.jpg" rel="prettyPhoto[gallery1]" title="Image 6"><img src="images/demo/jcu_images/6.jpg" width="120" height="120" alt=""></a></li>
          <li><a href="images/demo/jcu_images/7.jpg" rel="prettyPhoto[gallery1]" title="Image 7"><img src="images/demo/jcu_images/7.jpg" width="120" height="120" alt=""></a></li>
          <li><a href="images/demo/jcu_images/8.jpg" rel="prettyPhoto[gallery1]" title="Image 8"><img src="images/demo/jcu_images/8.jpg" width="120" height="120" alt=""></a></li>
          <li  class="last"><a href="images/demo/jcu_images/9.jpg" rel="prettyPhoto[gallery1]" title="Image 9"><img src="images/demo/jcu_images/9.jpg" width="120" height="120" alt=""></a></li>
          <li><a href="images/demo/jcu_images/10.jpg" rel="prettyPhoto[gallery1]" title="Image 10"><img src="images/demo/jcu_images/10.jpg" width="120" height="120" alt=""></a></li>
          <li><a href="images/demo/jcu_images/11.jpg" rel="prettyPhoto[gallery1]" title="Image 11"><img src="images/demo/jcu_images/11.jpg" width="120" height="120" alt=""></a></li>
          <li><a href="images/demo/jcu_images/12.jpg" rel="prettyPhoto[gallery1]" title="Image 12"><img src="images/demo/jcu_images/12.jpg" width="120" height="120" alt=""></a></li>
          <li><a href="images/demo/jcu_images/13.jpg" rel="prettyPhoto[gallery1]" title="Image 13"><img src="images/demo/jcu_images/13.jpg" width="120" height="120" alt=""></a></li>
          <li  class="last"><a href="images/demo/jcu_images/14.jpg" rel="prettyPhoto[gallery1]" title="Image 14"><img src="images/demo/jcu_images/14.jpg" width="120" height="120" alt=""></a></li>
          <li><a href="images/demo/jcu_images/15.jpg" rel="prettyPhoto[gallery1]" title="Image 15"><img src="images/demo/jcu_images/15.jpg" width="120" height="120" alt=""></a></li>
        </ul>
      </div>
      <!-- ####################################################################################################### -->
      <div class="pagination">
        <ul>
          <li class="prev"><a href="#">« Previous</a></li>
          <li><a href="#">1</a></li>
          <li><a href="#">2</a></li>
          <li class="splitter">&#8230;</li>
          <li><a href="#">6</a></li>
          <li class="current">7</li>
          <li><a href="#">8</a></li>
          <li><a href="#">9</a></li>
          <li class="splitter">&#8230;</li>
          <li><a href="#">14</a></li>
          <li><a href="#">15</a></li>
          <li class="next"><a href="#">Next »</a></li>
        </ul>
      </div>
      <!-- ####################################################################################################### -->

</asp:Content>
