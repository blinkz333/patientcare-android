using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Model_Appoint
/// </summary>
public class Model_Appoint
{
    public int Appoint_id { get; set; }
    public int Patient_id { get; set; }
    public String Firstname { get; set; }
    public int Doctor_id { get; set; }
    public String DFirstname { get; set; }
    public String AppointDate { get; set; }
    public String Status { get; set; }
    

}