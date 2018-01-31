using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Model_User
/// </summary>
public class Model_User
{
    public int Patient_id { get; set; }
    public String Firstname { get; set; }
    public String Lastname { get; set; }
    public String Nickname { get; set; }
    public String Birth { get; set; }
    public String Gender { get; set; }
    public String Address { get; set; }
    public String Email { get; set; }
    public String Tel { get; set; }
    public Int64 Id_card { get; set; }
    public String ChronicD { get; set; }
    public String Bloodtype { get; set; }
    public String Rh { get; set; }
    public String Allergydrug { get; set; }
    public String Cousin { get; set; }
    public String Cousintell { get; set; }
    public String username { get; set; }
    public String password { get; set; }

    

    public List<Model_Login> userlist = new List<Model_Login>();

}