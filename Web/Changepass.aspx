<%@ Page Title="" Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Changepass.aspx.cs" Inherits="Changepass" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="container">
        <div class="jumbotron" style="height: 760px;">
            <div class="col-lg-12">
                <div class="panel panel-default">
                    <div class="panel-heading" style="height: 40px;">
                        <h4 class="panel-title" style="font-size: 14px; margin-top: 5px;">CHANGE PASSWORD</h4>
                    </div>
                    <div class="panel-body">

                        

                            <div class="row">

                                <div class="col-lg-12">
                                    <div class="col-lg-2">
                                        <label class=" text-align:right" style="font-size: 12px;">Old Password</label>
                                    </div>
                                    <div class="col-lg-3">
                                        <asp:TextBox type="text" id="txtoldpass" CssClass="form-control" runat="server"/>
                                    </div>
                                </div>
                            </div>


                            <div class="row">
                                <div class="col-lg-12">
                                    <div class="col-lg-2">
                                        <label class=" text-align:right" style="font-size: 12px;">New Password</label>
                                    </div>
                                    <div class="col-lg-3">
                                        <asp:TextBox ID="txtnewpass"  type="text" CssClass="form-control" runat="server"/>
                                    </div>
                                    <div class="col-lg-2">
                                        <label class="text-align:right" style="font-size: 12px;">Confirm New Password</label>
                                    </div>
                                    <div class="col-lg-3">
                                       <asp:TextBox type="text" id="txtnewpass2" CssClass="form-control" runat="server" />
                                    </div>
                                </div>
                            </div>
                    

                          

                                <center>   
                <asp:Button type="button" Text="SUBMIT" runat="server" id="bttsave" class="btn btn-default" value="SAVE" OnClick="bttsave_Click" />
                
            </center>
                            </div>
                        </div>
                    </div>
                </div>
        </div>
                    
               
                


    <script type="text/javascript">

        function Adduser() {
            var com_id = $("select[id$='select_com_id']").val();
            var username = $("input[id$='txtusername']").val();
            var userpass = $("input[id$='txtpassword']").val();
            var userfname = $("input[id$='txtuserfname']").val();
            var userlname = $("input[id$='txtuserlname']").val();
            var tel = $("input[id$='txttel']").val();
            var address = $("input[id$='txtaddress']").val();
            var email = $("input[id$='txtemail']").val();

            

            var url = '/MEMBER/AJAX/AJAXMEMBER.aspx?action=AddMEMBER&com_id=' + com_id + '&username=' + username + '&userpass=' + userpass + '&userfname=' + userfname + '&userlname=' + userlname + '&tel=' + tel + '&email=' + email + '&address=' + address;
            $.get(url, function (data) {
                if (data) {
                    window.location = "/HOME/HOMESUPPORT.aspx";
                }
                else {
                    alert("Saveไม่ลงจ่ะ");
                }
            });
        }
        function Addproject() {
            var com_id = $("select[id$='select_com_id2']").val();
            var projectname = $("input[id$='txtproname']").val();
            
            
            if (com_id == "" && projectname == "") {
                alert("กรอกข้อมูลไม่ครบ");
            } else {


                var url = '/MEMBER/AJAX/AJAXMEMBER.aspx?action=Addproject&com_id=' + com_id + '&projectname=' + projectname;
                $.get(url, function (data) {
                    if (data) {
                        window.location = "/HOME/HOMESUPPORT.aspx";
                    }
                    else {
                        alert("Saveไม่ลงจ่ะ");
                    }
                });
            }
        }
        function Addcom() {
            
            var comname = $("input[id$='txtcomname']").val();



            if (comname == "") {
                alert("กรอกข้อมูลไม่ครบ");
            } else {

                var url = '/MEMBER/AJAX/AJAXMEMBER.aspx?action=Addcom&comname=' + comname;
                $.get(url, function (data) {
                    if (data) {
                        window.location = "/HOME/HOMESUPPORT.aspx";
                    }
                    else {
                        alert("Saveไม่ลงจ่ะ");
                    }
                });
            }

            
        }
       
    </script>
</asp:Content>