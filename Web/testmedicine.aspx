<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="testmedicine.aspx.cs" Inherits="testmedicine" %>



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
                            TEST MEDICINE
                        </h1>
                        <ol class="breadcrumb">
                            <li>
                                <i class="fa fa-hospital-o"></i>  <a href="Managepatient.aspx">NFC Hospital</a>
                            </li>
                            <li class="active">
                                <i class="fa fa-fw fa-medkit"></i> test medicine
                            </li>
                        </ol>
                    </div>
                </div>

    
        
             <div class="jumbotron">
                 <div class="row">
            <div class="col-lg-12 ">
                <div class="panel panel-default table-responsive" >
                    
                        <h3 class="panel-title" style="font-size: 16px; margin-top: 5px;">Medical <button type="button" class="btn-success glyphicon-plus"  data-toggle="modal" data-target="#myModal"></button></h3>

                    
                    <div class="panel-body" runat="server">
                       <table id="table-Dispen" class="table table-striped table-bordered dataTables_wrapper" style="background-color: white;">                          
                                 <thead>
                                      
                                <tr>      
                                    <th style="text-align: center; font-size: 12px; ">รหัสการรักษา </th>
                                    <th style="text-align: center; font-size: 12px; ">รหัสยา </th>
                                    <th style="text-align: center; font-size: 12px; ">ชื่อยา </th>
                                    <th style="text-align: center; font-size: 12px; ">จำนวน </th>
                                    
                                    
                                    
                                    
                                    
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
                            <h4 class="modal-title">Add Medical</h4>
                        </div>
                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">ชื่อผู้ป่วย</label>
                            <select class="form-control" id="select_ptid" style="width:200px" runat="server">
                                    
                                    
                                </select>
                        </div>

                        <div class="modal-body">
                            
                            <label class=" col-xs-3 control-label  ">วันที่รักษา</label>
                            <div class="input-group date ">
                            <input type='text' class="form-control" id='datetimepicker' maxlength="19" />
                        </div>
                            </div>

                        <div class="modal-body">
                            
                            <label class=" col-xs-3 control-label  ">ผลการรักษา</label>
                            <div class="input-group date ">
                            <input type='text' class="form-control" id='txttreatdetail'  />
                        </div>
                            </div>

                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">ชื่อแพทย์</label>
                            <select class="form-control" id="select_dtid" style="width:200px" runat="server">
                                    
                                    
                                </select>
                        </div>

                        <div class="modal-body">
                            <label class=" col-xs-3 control-label ">ชื่อเภสัช</label>
                            <select class="form-control" id="select_phid" style="width:200px" runat="server">
                                    
                                    
                                </select>
                        </div>

                        <div class="modal-footer">
                            <center>
                            <button type="button" class="btn btn-success" onclick="AddMedic()">Add Medical</button>
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
                            
                             
                       
                        
                           
                    </div>

                         
                       
                        
                        
                        </div>
                    </div>
                        </div>
                   
        

    <input type="hidden" id="hdn_treat_id"/>
    
    
        
    
     <script type="text/javascript">
        
         $(document).ready(function () {
             var oTable = $('#table-Dispen').DataTable({

             

             "ajax": {
                 "url": "/AJAX/AJAXTREATMENT.aspx?action=Showdis",
                 "dataSrc": ""
             },
             "columns": [
                 { "data": "Treat_id" },
                 { "data": "Medic_id" },
                 { "data": "MedicName" },
                 { "data": "Quantity" }





             ]
         });
         });
        

         
       
</script>

    </asp:Content>

