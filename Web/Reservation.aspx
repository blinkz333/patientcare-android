<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Reservation.aspx.cs" Inherits="Reservation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="../CSS/dataTables.bootstrap.css" rel="stylesheet" />
    <link href="../CSS/jquery.dataTables.css" rel="stylesheet" />
    <script src="../JS/jquery.dataTables.js"></script>
    
    
    <div id="page-wrapper">

            <div class="container-fluid">

                <!-- Page Heading -->
                <div class="row">
                    <div class="col-lg-12">
                        <h1 class="page-header">
                            Appointment
                        </h1>
                        <ol class="breadcrumb">
                            <li>
                                <i class="fa fa-hospital-o"></i>  <a href="Managepatient.aspx">NFC Hospital</a>
                            </li>
                            <li class="active">
                                <i class="fa fa-calendar"></i> Appointment
                            </li>
                        </ol>
                    </div>
                </div>

    
        
             <div class="jumbotron">
                 <div class="row">
            <div class="col-lg-12 ">
                <div class="panel panel-default table-responsive" >
                    
                        <h3 class="panel-title" style="font-size: 16px; margin-top: 5px;">การนัดแพทย์ <button type="button" class="btn-success glyphicon-plus"  data-toggle="modal" data-target="#myModal"></button></h3>

                    
                    <div class="panel-body" runat="server">
                       
                        <table id="table-Appoint" class="table table-striped table-bordered dataTables_wrapper" style="background-color: white;">                          
                                 <thead>
                                      
                                <tr>                                   
                                    <th style="text-align: center; font-size: 12px; ">รหัสการนัดแพทย์ </th>
                                    <th style="text-align: center; font-size: 12px; ">ชื่อผู้ป่วย </th>
                                    <th style="text-align: center; font-size: 12px; ">ชื่อแพทย์ </th>
                                    <th style="text-align: center; font-size: 12px; ">วัน/เวลาที่นัด </th>
                                    <th style="text-align: center; font-size: 12px; ">สถานะ </th>
                                    <th style="text-align: center; font-size: 12px; ">ชื่อผู้ที่ทำการนัด </th>
                                    <th style="text-align: center; font-size: 12px; ">อัพเดทสถานะ </th>
                                    
                                </tr>

                            </thead>
                            
                        </table>
                           
                    </div>
                    </div>
                </div>
            </div>
                </div>
                </div>
     </div>
    <div class="modal fade" id="myModal" role="dialog">
                <div class="modal-dialog">
                    <!-- Modal content-->
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h4 class="modal-title">Add Appointment</h4>
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">ชื่อผู้ป่วย</label>
                            <select class="form-control" id="select_ptid" style="width:200px" runat="server">
                                    
                                    
                                </select>
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">ชื่อแพทย์</label>
                            <select class="form-control" id="select_dtid" style="width:200px" runat="server">
                                    
                                    
                                </select>
                        </div>
                        
                        <div class="modal-body">
                            
                            <label class=" col-xs-3 control-label  ">วันเวลาที่นัด</label>
                            <div class="input-group date ">
                            <input type='text' class="form-control" id='datetimepicker' maxlength="19"  />
                        </div>
                            </div>

                         
                       
                        
                        <div class="modal-footer">
                            <center>
                            <button type="button" class="btn btn-success" onclick="AddAppoint()">Add Appointment</button>
                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                        </center></div>
                        </div>
                    </div>
                    </div>
                    
                     <div class="modal fade" id="myModalE" role="dialog">
                <div class="modal-dialog">
                    <!-- Modal content-->
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h4 class="modal-title">Update Appointment</h4>
                        </div>
                       <%-- <div class="modal-body">
                            <label class=" col-xs-3 control-label ">ชื่อผู้ป่วย</label>
                            <select class="form-control" id="selecte_ptid" style="width:200px" runat="server">
                                    
                                    
                                </select>
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">ชื่อแพทย์</label>
                            <select class="form-control" id="selecte_dtid" style="width:200px" runat="server">
                                    
                                    
                                </select>
                        </div>
                        
                        <div class="modal-body">
                            
                            <label class=" col-xs-3 control-label  ">วันเวลาที่นัด</label>
                            <div class="input-group date ">
                            <input type='text' class="form-control" id='dateetimepicker' maxlength="19" />
                        </div>
                            </div> --%>

                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">สถานะ</label>
                            <select class="form-control" style="width:200px" id="txtestatus" runat="server" >
                            <option value="">Please Select</option>
                            <option value="รอยืนยัน">รอยืนยัน</option>
                            <option value="รอตรวจ">รอตรวจ</option>
                            <option value="ตรวจแล้ว">ตรวจแล้ว</option>
                            <option value="ยกเลิก">ยกเลิก</option> 
                            </select>
                        </div>

                         
                       
                        
                        <div class="modal-footer">
                            <center>
                            <button type="button" class="btn btn-success" onclick="EditAppoint()">Update</button>
                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                        </center></div>
                        </div>
                    </div>
                        </div>
                   
        

    <input type="hidden" id="hdn_appoint_id"/>
    
    
    <script>
        $("#datetimepicker").datetimepicker({
            minDate: 0,
            format: "Y-m-d H:i:00"
            
            
        });
        
        
    </script>
    <script>
        $("#dateetimepicker").datetimepicker({
            format: "d/m/Y H:i"
        });
        
        
    </script>
     <script type="text/javascript">
         $(document).ready(function () {

             
             
            
            
             
             var oTable = $('#table-Appoint').dataTable({

                "ajax": {
                    "url": "/AJAX/AJAXQUEUE.aspx?action=Show",
                    "dataSrc": ""
                },
                "columns": [

                    { "data": "Appoint_id" },
                    { "data": "PFirstname" },
                    { "data": "DFirstname" },
                    { "data": "AppointDate" },
                    { "data": "Status" },
                    { "data": "Raiseby" },
                    { "data": "BBUTTON1" }
                    
                    
                    
                    
                ]
            });

        });

        

         function AddAppoint() {
           
           var patient_id = $("select[id$='select_ptid']").val();
           var doctor_id = $("select[id$='select_dtid']").val();
           var appointdate = $("input[id$='datetimepicker']").val();
           
           

            

           var url = '/AJAX/AJAXQUEUE.aspx?action=AddAppoint&patient_id=' + patient_id + '&doctor_id=' + doctor_id + '&appointdate=' + appointdate;
           $.get(url, function (data) {
               if (data) {
                   window.location = "/Reservation.aspx";
               }
               else {
                   alert("Saveไม่ลงจ่ะ");
               }
           });
       }
       function fn_view(id) {
           $.ajax({
               url: "/AJAX/AJAXQUEUE.aspx?action=Edit&appoint_id=" + id,
               success: function (data) {
                   var data_array = JSON.parse(data);
                   var patient_id = data_array[0]["Patient_id"];
                   var doctor_id = data_array[0]["Doctor_id"];
                   var appointdate = data_array[0]["AppointDate"];
                   var status = data_array[0]["Status"];
                   

                   $("select[id$='selecte_ptid']").val(patient_id);
                   $("select[id$='selecte_dtid']").val(doctor_id);
                   $("input[id$='dateetimepicker']").val(appointdate);
                   $("select[id$='txtestatus']").val(status);
                   $("[id$='hdn_appoint_id']").val(id);

                  

                   
               }
           });
       }
       function EditAppoint() {
           var appoint_ide = $("[id$='hdn_appoint_id']").val();
          // var patient_id = $("select[id$='selecte_ptid']").val();
          // var doctor_id = $("select[id$='selecte_dtid']").val();
          // var appointdate = $("input[id$='dateetimepicker']").val();
           var status = $("select[id$='txtestatus']").val();
           


           //var url = '/AJAX/AJAXQUEUE.aspx?action=Update&appoint_ide=' + appoint_ide + '&patient_id=' + patient_id + '&doctor_id=' + doctor_id + '&appointdate=' + appointdate + '&status=' + status;
           var url = '/AJAX/AJAXQUEUE.aspx?action=Update&appoint_ide=' + appoint_ide + '&status=' + status;
           $.get(url, function (data) {
               if (data) {
                   window.location = "/Reservation.aspx";
               }
               else {
                   alert("Saveไม่ลงจ่ะ");
               }
           });
       }
       function Delete() {

           var appoint_id = $("[id$='hdn_appoint_id']").val();


           var url = '/AJAX/AJAXQUEUE.aspx?action=Delete&appoint_id=' + appoint_id;
           $.get(url, function (data) {
               if (data) {
                   window.location = "/Reservation.aspx";
               }
               else {
                   alert("Saveไม่ลงจ่ะ");
               }
           });
       }
</script>

    </asp:Content>

