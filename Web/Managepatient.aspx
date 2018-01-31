<%@ Page Title="" Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Managepatient.aspx.cs" Inherits="Managepatient" %>

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
                            Manage Patient
                        </h1>
                        <ol class="breadcrumb">
                            <li>
                                <i class="fa fa-hospital-o"></i>  <a href="Managepatient.aspx">NFC Hospital</a>
                            </li>
                            <li class="active">
                                <i class="fa fa-user"></i> Managepatient
                            </li>
                        </ol>
                    </div>
                </div>
                <!-- /.row -->
                <div class="jumbotron">
                <div class="row">
                    
                        <div class="table-responsive">
                            <div class="col-lg-12 ">
                                <div class="panel panel-default table-responsive" >
                                    
                                    <h3 class="panel-title" style="font-size: 16px; margin-top: 5px;">ข้อมูลผู้ป่วยในระบบ   <button type="button" class="btn-success glyphicon-plus"  data-toggle="modal" data-target="#myModal"></button></h3>

                                    
                                        <div class="panel-body" runat="server">
                               <table id="table-Patient" class="table table-striped table-bordered dataTables_wrapper" style="background-color: white;">                          
                                <thead>   
                                    <tr>                                   
                                        <th style="text-align: center; font-size: 12px; ">รหัสผู้ป่วย </th>
                                        <th style="text-align: center; font-size: 12px; ">ชื่อจริง </th>
                                        <th style="text-align: center; font-size: 12px; ">นามสกุล </th>
                                        <th style="text-align: center; font-size: 12px; ">ชื่อเล่น </th>
                                        <th style="text-align: center; font-size: 12px; ">วันที่เกิด </th>
                                        <th style="text-align: center; font-size: 12px; ">เพศ </th>
                                        <th style="text-align: center; font-size: 12px; ">ที่อยู่ </th>
                                        <th style="text-align: center; font-size: 12px; ">อีเมล </th>
                                        <th style="text-align: center; font-size: 12px; ">เบอร์โทร </th>
                                        <th style="text-align: center; font-size: 12px; ">เลขบัตรประชาชน </th>
                                        <th style="text-align: center; font-size: 12px; ">โรคประจำตัว </th>
                                        <th style="text-align: center; font-size: 12px; ">กรุ๊ปเลือด </th>
                                        <th style="text-align: center; font-size: 12px; ">Rh </th>
                                        <th style="text-align: center; font-size: 12px; ">แพ้ยา </th>
                                        <th style="text-align: center; font-size: 12px; ">ญาติ </th>
                                        <th style="text-align: center; font-size: 12px; ">เบอร์โทรญาติ </th>
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
    </div>
            
        
    
   <!-- Modal-->
     <div class="modal fade" id="myModal" role="dialog">
                <div class="modal-dialog">
                    <!-- Modal content-->
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <center><h4 class="modal-title">เพิ่มผู้ป่วย</h4></center>
                        </div>

                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">username</label>
                            <input type="text" id="txtuname" class="form-control" style="width:200px" placeholder="*จำเป็นต้องกรอก" />
                            
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">password</label>
                            <input type="text" id="txtpass" class="form-control" style="width:200px" placeholder="*จำเป็นต้องกรอก" />
                        </div>

                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">ชื่อจริง</label>
                            <input type="text" id="txtfname" class="form-control" style="width:200px" placeholder="*จำเป็นต้องกรอก" />
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">นามสกุล</label>
                            <input type="text" id="txtlname" class="form-control" style="width:200px" placeholder="*จำเป็นต้องกรอก" />
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">ชื่อเล่น</label>
                            <input type="text" id="txtnname" class="form-control" style="width:200px" placeholder="*จำเป็นต้องกรอก" />
                        </div>
                        <div class="modal-body">
                            
                            <label class=" col-xs-3 control-label  ">วันที่เกิด</label>
                            <div class="input-group date " data-provide="datepicker">
                            <input type="text" id="datepicker" class="form-control  " maxlength="10" placeholder="*จำเป็นต้องกรอก"/>
                        </div>
                            </div>

                         
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">เพศ</label>
                            
                            <select class="form-control" style="width:200px" id="txtgender" runat="server" >
                            <option value="">กรุณาเลือก</option>
                            <option value="ชาย">ชาย</option>
                            <option value="หญิง">หญิง</option>
                            </select>
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">ที่อยู่</label>
                            <input type="text" id="txtaddress" class="form-control" style="width:200px" placeholder="*จำเป็นต้องกรอก" />
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">อีเมล์</label>
                            <input type="text" id="txtemail" class="form-control" style="width:200px"  />
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">เบอร์โทร</label>
                            <input type="text"  id="txttel" onkeypress='return event.charCode >= 48 && event.charCode <= 57' maxlength="10" class="form-control" style="width:200px" placeholder="*จำเป็นต้องกรอก" />
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">เลขบัตรประชาชน</label>
                            <input type="text" id="txtidcard" onkeypress='return event.charCode >= 48 && event.charCode <= 57' maxlength="13" class="form-control" style="width:200px" placeholder="*จำเป็นต้องกรอก" />
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">กรุ๊ปเลือด</label>
                            <select class="form-control" style="width:200px" id="txtblood" runat="server" >
                            <option value="">กรุณาเลือก</option>
                            <option value="A">A</option>
                            <option value="B">B</option>
                                <option value="AB">AB</option>
                            <option value="O">O</option>
                            </select>
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">Rh</label>
                            <select class="form-control" style="width:200px" id="txtrh" runat="server" >
                            <option value="">กรุณาเลือก</option>
                            <option value="Rh%2B">Rh+</option>
                            <option value="Rh-">Rh-</option>
                            </select>
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">โรคประจำตัว</label>
                            <textarea  id="txtchronicd" class="form-control" ></textarea>
                        </div>
                        
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">แพ้ยา</label>
                            <textarea  id="txtallergy" class="form-control" ></textarea>
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">ญาติ</label>
                            <input type="text" id="txtcousin" class="form-control" style="width:200px"  />
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">เบอร์โทรญาติ</label>
                            <input type="text"  id="txtcousintell" onkeypress='return event.charCode >= 48 && event.charCode <= 57' maxlength="10" class="form-control" style="width:200px"  />
                        </div>
                        <!-- Modal Footer-->
                        <div class="modal-footer">
                            <center>
                            <button type="button" class="btn btn-success" onclick="AddPatient()">Add Patient</button>
                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                                </center>
                        </div>
                        </div>
            </div>
        </div>

    <div class="modal fade" id="myModalE" role="dialog">
                <div class="modal-dialog">
                    <!-- Modal content-->
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h4 class="modal-title">แก้ไขข้อมูลผู้ป่วย</h4>
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">username</label>
                            <input type="text" id="txteuname" class="form-control" style="width:200px" placeholder="*จำเป็นต้องกรอก" />
                            
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">password</label>
                            <input type="text" id="txtepass" class="form-control" style="width:200px" placeholder="*จำเป็นต้องกรอก" />
                        </div>

                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">ชื่อจริง</label>
                            <input type="text" id="txtefname" class="form-control" style="width:200px" placeholder="*จำเป็นต้องกรอก" />
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">นามสกุล</label>
                            <input type="text" id="txtelname" class="form-control" style="width:200px" placeholder="*จำเป็นต้องกรอก" />
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">ชื่อเล่น</label>
                            <input type="text" id="txtenname" class="form-control" style="width:200px" placeholder="*จำเป็นต้องกรอก" />
                        </div>
                        <div class="modal-body">
                            
                            <label class=" col-xs-3 control-label  ">วันที่เกิด</label>
                            <div class="input-group date " data-provide="datepicker">
                            <input type="text" id="dateepicker" class="form-control  " maxlength="10" placeholder="*จำเป็นต้องกรอก"/>
                        </div>
                            </div>

                         
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">เพศ</label>
                            
                            <select class="form-control" style="width:200px" id="txtegender" runat="server" >
                            <option value="">กรุณาเลือก</option>
                            <option value="ชาย">ชาย</option>
                            <option value="หญิง">หญิง</option>
                            </select>
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">ที่อยู่</label>
                            <input type="text" id="txteaddress" class="form-control" style="width:200px" placeholder="*จำเป็นต้องกรอก" />
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">อีเมล์</label>
                            <input type="text" id="txteemail" class="form-control" style="width:200px"  />
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">เบอร์โทร</label>
                            <input type="text"  id="txtetel" onkeypress='return event.charCode >= 48 && event.charCode <= 57' maxlength="10" class="form-control" style="width:200px" placeholder="*จำเป็นต้องกรอก" />
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">เลขบัตรประชาชน</label>
                            <input type="text" id="txteidcard" onkeypress='return event.charCode >= 48 && event.charCode <= 57' maxlength="13" class="form-control" style="width:200px" placeholder="*จำเป็นต้องกรอก" />
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">กรุ๊ปเลือด</label>
                            <select class="form-control" style="width:200px" id="txteblood" runat="server" >
                            <option value="">กรุณาเลือก</option>
                            <option value="A">A</option>
                            <option value="B">B</option>
                                <option value="AB">AB</option>
                            <option value="O">O</option>
                            </select>
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">Rh</label>
                            <select class="form-control" style="width:200px" id="txterh" runat="server" >
                            <option value="">กรุณาเลือก</option>
                            <option value="Rh%2B">Rh+</option>
                            <option value="Rh-">Rh-</option>
                            </select>
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">โรคประจำตัว</label>
                            <textarea  id="txtechronicd" class="form-control" ></textarea>
                        </div>
                        
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">แพ้ยา</label>
                            <textarea  id="txteallergy" class="form-control" ></textarea>
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">ญาติ</label>
                            <input type="text" id="txtecousin" class="form-control" style="width:200px"  />
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">เบอร์โทรญาติ</label>
                            <input type="text"  id="txtecousintell" onkeypress='return event.charCode >= 48 && event.charCode <= 57' maxlength="10" class="form-control" style="width:200px"  />
                        </div>
                        
                        <div class="modal-footer">
                            <center>
                            <button type="button" class="btn btn-info" onclick="Edit()">Edit Patient</button>
                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                        </center>

                        </div>
                        </div>
            </div>
        </div>


            <div class="modal fade" id="myModalD" role="dialog">
                <div class="modal-dialog">
                    <!-- Modal content-->
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h4 class="modal-title">ลบผู้ป่วย</h4>
                        </div>
                        <div class="modal-body">
                            <label class="alert alert-warning">คุณแน่ใจหรือว่าต้องการลบผู้ป่วยออกจากระบบ? <br />(การลบผู้ป่วยออกจากระบบจะทำให้ข้อมูลการนัดแพทและประวัติการรักษาหายไป)</label>        
                        </div>
                  
                        <div class="modal-footer">
                            <center>
                            <button type="button" class="btn btn-warning" onclick="Delete()">Delete</button>
                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                       </center>
                        </div>
                        </div>
                    </div>
            </div> 
        
    <input type="hidden" id="hdn_patient_id"/>
     <script type="text/javascript">
         $(function () {
        $("#datepicker").datetimepicker({
            format: "d/m/Y"
           
            
             });
         });

    </script>
    <script>
        $("#dateepicker").datetimepicker({
            format: "d/m/Y"
        });


    </script>
    <script type="text/javascript">
        
            
        $(document).ready(function () {
           


             var oTable = $('#table-Patient').dataTable({

                 "ajax": {
                     "url": "/AJAX/AJAXPATIENT.aspx?action=Show",
                     "dataSrc": ""

                 },
                 "columns": [
                    
                    { "data": "Patient_id" },
                    { "data": "Firstname" },
                    { "data": "Lastname" },
                    { "data": "Nickname" },
                    { "data": "Birth"  },
                    { "data": "Gender" },
                    { "data": "Address" },
                    { "data": "Email" },
                    { "data": "Tel" },
                    { "data": "Id_card" },
                    { "data": "ChronicD" },
                    { "data": "Bloodtype" },
                    { "data": "Rh" },
                    { "data": "Allergydrug" },
                    { "data": "Cousin" },
                    { "data": "Cousintell" },
                    { "data": "BBUTTON1" },
                    { "data": "BBUTTON2" }



                 ]

            });

        });



        function AddPatient() {
            var checkuser;
            var username = $("input[id$='txtuname']").val();
            var password = $("input[id$='txtpass']").val();
            var firstname = $("input[id$='txtfname']").val();
            var lastname = $("input[id$='txtlname']").val();
            var nickname = $("input[id$='txtnname']").val();
            var birth = $("input[id$='datepicker']").val();
            var gender = $("select[id$='txtgender']").val();
            var address = $("input[id$='txtaddress']").val();
            var email = $("input[id$='txtemail']").val();
            var tel = $("input[id$='txttel']").val();
            var id_card = $("input[id$='txtidcard']").val();
            var chronicd = $("[id$='txtchronicd']").val();
            var bloodtype = $("select[id$='txtblood']").val();
            var rh = $("select[id$='txtrh']").val();
            var allergydrug = $("[id$='txtallergy']").val();
            var cousin = $("input[id$='txtcousin']").val();
            var cousintell = $("input[id$='txtcousintell']").val();


            if (username == "" && password == "" && firstname == "" && lastname == "" && nickname == "" && birth == "" && address == "" && tel == "" && id_card == "") {
                alert("กรอกข้อมูลไม่ครบ");
            } else {

                var url = '/AJAX/AJAXPATIENT.aspx?action=AddPatient&firstname=' + firstname + '&lastname=' + lastname + '&nickname=' + nickname + '&birth=' + birth + '&gender=' + gender + '&address=' + address + '&email=' + email + '&tel=' + tel + '&id_card=' + id_card + '&chronicd=' + chronicd + '&bloodtype=' + bloodtype + '&rh=' + rh + '&allergydrug=' + allergydrug + '&cousin=' + cousin + '&cousintell=' + cousintell + '&username=' + username + '&password=' + password;
                $.get(url, function (data) {
                    if (data) {
                        window.location = "/Managepatient.aspx";
                    }
                    else {
                        alert("Saveไม่ลงจ่ะ");
                    }
                });
            }
        }
       function fn_view(id) {
           $.ajax({
               url: "/AJAX/AJAXPATIENT.aspx?action=Edit&patient_id=" + id,
               success: function (data) {
                   var data_array = JSON.parse(data);
                   var username = data_array[0]["username"];
                   var password = data_array[0]["password"];
                   var firstname = data_array[0]["Firstname"];
                   var lastname = data_array[0]["Lastname"];
                   var nickname = data_array[0]["Nickname"];
                   var birth = data_array[0]["Birth"];
                   var gender = data_array[0]["Gender"];
                   var address = data_array[0]["Address"];
                   var email = data_array[0]["Email"];
                   var tel = data_array[0]["Tel"];
                   var id_card = data_array[0]["Id_card"];
                   var chronicd = data_array[0]["ChronicD"];
                   var bloodtype = data_array[0]["Bloodtype"];
                   var rh = data_array[0]["Rh"];
                   var allergydrug = data_array[0]["Allergydrug"];
                   var cousin = data_array[0]["Cousin"];
                   var cousintell = data_array[0]["Cousintell"];

                   $("input[id$='txteuname']").val(username);
                   $("input[id$='txtepass']").val(password);
                   $("input[id$='txtefname']").val(firstname);
                   $("input[id$='txtelname']").val(lastname);
                   $("input[id$='txtenname']").val(nickname);
                   $("input[id$='dateepicker']").val(birth);
                   $("select[id$='txtegender']").val(gender);
                   $("input[id$='txteaddress']").val(address);
                   $("input[id$='txteemail']").val(email);
                   $("input[id$='txtetel']").val(tel);
                   $("input[id$='txteidcard']").val(id_card);
                   $("[id$='txtechronicd']").val(chronicd);
                   $("select[id$='txteblood']").val(bloodtype);
                   $("select[id$='txterh']").val(rh);
                   $("[id$='txteallergy']").val(allergydrug);
                   $("input[id$='txtecousin']").val(cousin);
                   $("input[id$='txtecousintell']").val(cousintell);
                   $("[id$='hdn_patient_id']").val(id);




               }
           });
       }
       function Edit() {
           var patient_ide = $("[id$='hdn_patient_id']").val();
           var username = $("input[id$='txteuname']").val();
           var password = $("input[id$='txtepass']").val();
           var firstname = $("input[id$='txtefname']").val();
           var lastname = $("input[id$='txtelname']").val();
           var nickname = $("input[id$='txtenname']").val();
           var birth = $("input[id$='dateepicker']").val();
           var gender = $("select[id$='txtegender']").val();
           var address = $("input[id$='txteaddress']").val();
           var email = $("input[id$='txteemail']").val();
           var tel = $("input[id$='txtetel']").val();
           var id_card = $("input[id$='txteidcard']").val();
           var chronicd = $("[id$='txtechronicd']").val();
           var bloodtype = $("select[id$='txteblood']").val();
           var rh = $("select[id$='txterh']").val();
           var allergydrug = $("[id$='txteallergy']").val();
           var cousin = $("input[id$='txtecousin']").val();
           var cousintell = $("input[id$='txtecousintell']").val();


           var url = '/AJAX/AJAXPATIENT.aspx?action=Update&patient_ide=' + patient_ide + '&username=' + username + '&password=' + password + '&firstname=' + firstname + '&lastname=' + lastname + '&nickname=' + nickname + '&birth=' + birth + '&gender=' + gender + '&address=' + address + '&email=' + email + '&tel=' + tel + '&id_card=' + id_card + '&chronicd=' + chronicd + '&bloodtype=' + bloodtype + '&rh=' + rh + '&allergydrug=' + allergydrug + '&cousin=' + cousin + '&cousintell=' + cousintell ;
           $.get(url, function (data) {
               if (data) {
                   window.location = "/Managepatient.aspx";
               }
               else {
                   alert("Saveไม่ลงจ่ะ");
               }
           });
       }
       function Delete() {

           var patient_id = $("[id$='hdn_patient_id']").val();


           var url = '/AJAX/AJAXPATIENT.aspx?action=Delete&patient_id=' + patient_id;
           $.get(url, function (data) {
               if (data) {
                   window.location = "/Managepatient.aspx";
               }
               else {
                   alert("Saveไม่ลงจ่ะ");
               }
           });
       }
    </script>

</asp:Content>

   

