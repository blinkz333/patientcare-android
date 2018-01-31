using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Model_Treat
/// </summary>
public class Model_Treat 
{
    
    public int Treat_id { get; set; }
    public int Patient_id { get; set; }
    public String Firstname { get; set; }
    public String Treatdate { get; set; }
    public Double Weight { get; set; }
    public Double height { get; set; }
    public int Pulse { get; set; }
    public int Respiratory { get; set; }
    public String Bloodpressure { get; set; }
    public String Condition { get; set; }
    public String Treatdetail { get; set; }


}