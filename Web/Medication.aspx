<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Medication.aspx.cs" Inherits="Medication" %>



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
                            Medical History
                        </h1>
                        <ol class="breadcrumb">
                            <li>
                                <i class="fa fa-hospital-o"></i>  <a href="Managepatient.aspx">NFC Hospital</a>
                            </li>
                            <li class="active">
                                <i class="fa fa-fw fa-medkit"></i> Medical History
                            </li>
                        </ol>
                    </div>
                </div>

    
        
             <div class="jumbotron">
                 <div class="row">
            <div class="col-lg-12 ">
                <div class="panel panel-default table-responsive" >
                    
                        <h3 class="panel-title" style="font-size: 16px; margin-top: 5px;">ประวัติการรักษา <button type="button" class="btn-success glyphicon-plus"  data-toggle="modal" data-target="#myModal"></button></h3>

                    
                    <div class="panel-body" runat="server">
                       
                        <table id="table-Medical" class="table table-striped table-bordered dataTables_wrapper" style="background-color: white;">                          
                                 <thead>
                                      
                                <tr>                                   
                                    <th style="text-align: center; font-size: 12px; ">รหัสการรักษา </th>
                                    <th style="text-align: center; font-size: 12px; ">ชื่อผู้ป่วย </th>
                                    <th style="text-align: center; font-size: 12px; ">วันที่รักษา </th>
                                    <th style="text-align: center; font-size: 12px; ">น้ำหนัก(กิโลกรัม) </th>
                                    <th style="text-align: center; font-size: 12px; ">ส่วนสูง(เซนติเมตร) </th>
                                    <th style="text-align: center; font-size: 12px; ">อัตราการเต้นชีพจร(ครั้ง/นาที) </th>
                                    <th style="text-align: center; font-size: 12px; ">อัตราการหายใจ(ครั้ง/นาที) </th>
                                    <th style="text-align: center; font-size: 12px; ">ความดันโลหิต(มิลลิเมตรปรอท) </th>
                                    <th style="text-align: center; font-size: 12px; ">อาการของผู้ป่วย </th>
                                    <th style="text-align: center; font-size: 12px; ">ผลการวินิจฉัย </th>
                                    <th style="text-align: center; font-size: 12px; ">ชื่อแพทย์ </th>
                                    <th style="text-align: center; font-size: 12px; ">แก้ไข </th>
                                    <th style="text-align: center; font-size: 12px; ">ลบ </th>
                                    
                                    
                                    
                                    
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
                            <h4 class="modal-title">เพิ่มการรักษา</h4>
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">ชื่อผู้ป่วย</label>
                            <select class="form-control" id="select_ptid" style="width:200px" runat="server">
                                    
                                    
                                </select>
                        </div>

                        <div class="modal-body">
                            
                            <label class=" col-xs-3 control-label  ">วันที่รักษา</label>
                            <div class="input-group date ">
                            <input type='text' class="form-control" id='datetimepicker' maxlength="19" style="width:200px" />
                        </div>
                           </div>

                            <div class="modal-body">
                            <label class=" col-xs-3 control-label  ">น้ำหนัก(กิโลกรัม)</label>
                           <input   id="txtweight" class="form-control" style="width:200px" onkeypress='return event.charCode >= 46 && event.charCode <= 57' maxlength="5"   />
                                </div>

                                <div class="modal-body">
                            <label class=" col-xs-3 control-label  ">ส่วนสูง(เซนติเมตร)</label>
                            <input  id="txtheight" class="form-control" style="width:200px" onkeypress='return event.charCode >= 46 && event.charCode <= 57' maxlength="5" />
                        </div>
                                    
                                    <div class="modal-body">
                            <label class=" col-xs-3 control-label  ">อัตราการเต้นชีพจร(ครั้ง/นาที)</label>
                            <input    id="txtpulse" class="form-control" style="width:200px;" onkeypress='return event.charCode >= 46 && event.charCode <= 57' maxlength="3" />
                        </div>

                                        <div class="modal-body">
                            <label class=" col-xs-3 control-label  ">อัตราการหายใจ(ครั้ง/นาที)</label>
                            <input   id="txtrespiratory" class="form-control" style="width:200px" onkeypress='return event.charCode >= 46 && event.charCode <= 57' maxlength="3"/>
                        </div>

                                            <div class="modal-body">
                            <label class=" col-xs-3 control-label  ">ความดันโลหิต(มิลเมตรปรอท)</label>
                            <input  id="txtbloodpressure" class="form-control" style="width:200px" onkeypress='return event.charCode >= 46 && event.charCode <= 57' maxlength="6" />
                        </div>

                                            <div class="modal-body">
                            <label class=" col-xs-3 control-label  ">อาการของผู้ป่วย</label>
                            <textarea  id="txtcondition" class="form-control"  ></textarea>
                        </div>
                        

                        <div class="modal-body">
                            <label class=" col-xs-3 control-label  ">ผลการวินิจฉัย</label>
                            <textarea  id="txttreatdetail" class="form-control" ></textarea>
                        </div>
                            

                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">ชื่อแพทย์</label>
                            <select class="form-control" id="select_dtid" style="width:200px" runat="server">
                                    
                                    
                                </select>
                        </div>
                                                

                        

                        <div class="modal-footer">
                            <center>
                            <button type="button" class="btn btn-success" onclick="AddMedic()">เพิ่มการรักษา</button>
                            <button type="button" class="btn btn-default" data-dismiss="modal">ปิด</button>
                        </center></div>
                        </div>
                    </div>

        <div class="modal fade" id="myModalE" role="dialog">
                <div class="modal-dialog">
                    <!-- Modal content-->
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h4 class="modal-title">แก้ไขประวัติการรักษา</h4>
                        </div>
                        

                        <div class="modal-body">
                            
                            <label class=" col-xs-3 control-label  ">วันที่รักษา</label>
                            <div class="input-group date ">
                            <input type='text' class="form-control" id='dateetimepicker' maxlength="19" style="width:200px" />
                        </div>
                           </div>

                            <div class="modal-body">
                            <label class=" col-xs-3 control-label  ">น้ำหนัก(กิโลกรัม)</label>
                           <input   id="txteweight" class="form-control" style="width:200px" onkeypress='return event.charCode >= 46 && event.charCode <= 57' maxlength="5"   />
                                </div>

                                <div class="modal-body">
                            <label class=" col-xs-3 control-label  ">ส่วนสูง(เซนติเมตร)</label>
                            <input  id="txteheight" class="form-control" style="width:200px" onkeypress='return event.charCode >= 46 && event.charCode <= 57' maxlength="5" />
                        </div>
                                    
                                    <div class="modal-body">
                            <label class=" col-xs-3 control-label  ">อัตราการเต้นชีพจร(ครั้ง/นาที)</label>
                            <input    id="txtepulse" class="form-control" style="width:200px;" onkeypress='return event.charCode >= 46 && event.charCode <= 57' maxlength="3" />
                        </div>

                                        <div class="modal-body">
                            <label class=" col-xs-3 control-label  ">อัตราการหายใจ(ครั้ง/นาที)</label>
                            <input   id="txterespiratory" class="form-control" style="width:200px" onkeypress='return event.charCode >= 46 && event.charCode <= 57' maxlength="3"/>
                        </div>

                                            <div class="modal-body">
                            <label class=" col-xs-3 control-label  ">ความดันโลหิต(มิลเมตรปรอท)</label>
                            <input  id="txtebloodpressure" class="form-control" style="width:200px" onkeypress='return event.charCode >= 46 && event.charCode <= 57' maxlength="6" />
                        </div>

                                            <div class="modal-body">
                            <label class=" col-xs-3 control-label  ">อาการของผู้ป่วย</label>
                            <textarea  id="txtecondition" class="form-control"  ></textarea>
                        </div>
                        

                        <div class="modal-body">
                            <label class=" col-xs-3 control-label  ">ผลการวินิจฉัย</label>
                            <textarea  id="txtetreatdetail" class="form-control" ></textarea>
                        </div>
                            

                        
                                                

                        

                        <div class="modal-footer">
                            <center>
                            <button type="button" class="btn btn-success" onclick="EditMedic()">แก้ไขการรักษา</button>
                            <button type="button" class="btn btn-default" data-dismiss="modal">ปิด</button>
                        </center></div>
                        </div>
                    </div>
        </div>
                   
                    
                     
                            
                             
                       
                        
                           
                    

                         
                       
                        
                        
                        
                    
                        
                   
        

    <input type="hidden" id="hdn_treat_id"/>
    
    
    <script>
        $("#datetimepicker").datetimepicker({
            format: "Y-m-d H:i:00"
            
        });
        
        
    </script>
    <script>
        $("#dateetimepicker").datetimepicker({
            format: "d/m/Y H:m "
        });
        
        
    </script>
     <script type="text/javascript">
         $(document).ready(function () {

             
             
            
            
             
             var oTable = $('#table-Medical').dataTable({

                "ajax": {
                    "url": "/AJAX/AJAXTREATMENT.aspx?action=Show",
                    "dataSrc": ""
                },
                "columns": [

                    { "data": "Treat_id" },
                    { "data": "PFirstname" },
                    { "data": "Treatdate" },
                    { "data": "Weight" },
                    { "data": "Height" },
                    { "data": "Pulse" },
                    { "data": "Respiratory_rate" },
                    { "data": "Bloodpressure" },
                    { "data": "Condition" },
                    { "data": "Treatdetail" },
                    { "data": "DFirstname" },
                    { "data": "BBUTTON1" },
                    { "data": "BBUTTON2" }

                          ]
            });
         });

         function AddMedic() {

             
             var patient_id = $("select[id$='select_ptid']").val();
             var treatdate = $("input[id$='datetimepicker']").val();
             var weight = $("input[id$='txtweight']").val();
             var height = $("input[id$='txtheight']").val();
             var pulse = $("input[id$='txtpulse']").val();
             var respiratory = $("input[id$='txtrespiratory']").val();
             var bloodpressure = $("input[id$='txtbloodpressure']").val();
             var condition = $("[id$='txtcondition']").val();
             var treatdetail = $("[id$='txttreatdetail']").val();
             var doctor_id = $("select[id$='select_dtid']").val();
             
             


            

             var url = '/AJAX/AJAXTREATMENT.aspx?action=AddMedic&patient_id=' + patient_id + '&treatdate=' + treatdate + '&weight=' + weight + '&height=' + height + '&pulse=' + pulse + '&respiratory=' + respiratory + '&bloodpressure=' + bloodpressure + '&condition=' + condition + '&treatdetail=' + treatdetail + '&doctor_id=' + doctor_id;
                 $.get(url, function (data) {
                     if (data) {
                         window.location = "/Medication.aspx";
                     }
                     else {
                         alert("Saveไม่ลงจ่ะ");
                     }
                 });
             }
         
         
        

         function Edit() {

             var Treat_id = $("select[id$='hdn_treat_id']").val();
             var treatdate = $("input[id$='datetimepicker']").val();
             var weight = $("input[id$='txtweight']").val();
             var height = $("input[id$='txtheight']").val();
             var pulse = $("input[id$='txtpulse']").val();
             var respiratory = $("input[id$='txtrespiratory']").val();
             var bloodpressure = $("input[id$='txtbloodpressure']").val();
             var condition = $("[id$='txtcondition']").val();
             var treatdetail = $("[id$='txttreatdetail']").val();
             var doctor_id = $("select[id$='select_dtid']").val();

             


             var url = '/AJAX/AJAXPATIENT.aspx?action=Update&patient_ide=' + patient_ide + '&username=' + username + '&password=' + password + '&firstname=' + firstname + '&lastname=' + lastname + '&nickname=' + nickname + '&birth=' + birth + '&gender=' + gender + '&address=' + address + '&email=' + email + '&tel=' + tel + '&id_card=' + id_card + '&chronicd=' + chronicd + '&bloodtype=' + bloodtype + '&rh=' + rh + '&allergydrug=' + allergydrug + '&cousin=' + cousin + '&cousintell=' + cousintell;
             $.get(url, function (data) {
                 if (data) {
                     window.location = "/Managepatient.aspx";
                 }
                 else {
                     alert("Saveไม่ลงจ่ะ");
                 }
             });
         }  
       function fn_view(id) {
           $.ajax({
               url: "/AJAX/AJAXTREATMENT.aspx?action=Showdis&treat_id=" + id,
               success: function (data) {
                   
                  
                   
                   

                   
                   $("[id$='hdn_treat_id']").val(id);

                  

                   
               }
           });

         }

       
       
       
       
</script>

    </asp:Content>

