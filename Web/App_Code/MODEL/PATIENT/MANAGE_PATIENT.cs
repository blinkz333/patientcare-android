using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MANAGE_PATIENT
/// </summary>
public class MANAGE_PATIENT
{
    //PATIENT
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

    //APPOINTMENT
    public int Appoint_id { get; set; }
    public String AppointDate { get; set; }
    public String Status { get; set; }
    public String Raiseby { get; set; }

    //DOCTOR
    public int Doctor_id { get; set; }
    public String DFirstname { get; set; }
    public String DLastname { get; set; }

    //TREATMENT
    public int Treat_id { get; set; }
    public String Treatdate { get; set; }
    public Double Weight { get; set; }
    public Double Height { get; set; }
    public int Pulse { get; set; }
    public int Respiratory { get; set; }
    public String Bloodpressure { get; set; }
    public String Condition { get; set; }
    public String Treatdetail { get; set; }
    


    //PHRAMACIST
    public int Pharma_id { get; set; }
    public String PHFirstname { get; set; }
    
    //DISPENSATION
    public int Dispen_id { get; set; }
    public String Quantity { get; set; }
    public String Unit { get; set; }


    //MEDICINE
    public int Medic_id { get; set; }
    public String MedicName{ get; set; }




}