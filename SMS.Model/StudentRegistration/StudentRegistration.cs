using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.Model.StudentRegistration
{
    public class Student
    {
       public long SID { get; set; }
       public long AID { get; set; }
       public DateTime  ADMISSION_DATE { get; set; }
       public  string   FIRST_NAME { get; set; }
        public long    MIDDLE_NAME { get; set; }
        public int    LAST_NAME { get; set; }
        public int    CLASS_ID { get; set; }
        public  int AY_ID { get; set; }
        public   DateTime  DOB { get; set; }
        public  string   AADHAAR_NO { get; set; }
        public   string  PLACE_OF_BIRTH { get; set; }
        public int    COUNTRY_ID { get; set; }
        public int    STATE_ID { get; set; }
        public int    DISTRICT_ID { get; set; }
        public  string   RESIDENTIAL_ADDRESS { get; set; }
        public string    PIN_CODE { get; set; }
        public int    RELIGION_ID { get; set; }
        public   int  GENDER_ID { get; set; }
        public   int   CASTE_CATEGORY_ID { get; set; }
        public    int  MOTHER_TOUNGE_ID { get; set; }
        public  int   BLOOD_GROUP_ID { get; set; }
        public   string  IDENTIFICATION_MARK_1 { get; set; }
        public   string  IDENTIFICATION_MARK_2 { get; set; }
        public   string  ROLL_NO { get; set; }
        public   int  STATUS { get; set; }
        public   long  LAST_STD_AD_ID { get; set; }
        public    int  GUARDIAN_NAME { get; set; }
        public    int  GUARDIAN_RELATION_ID { get; set; }
        public    string GURADIAN_CONTACT_NO_1 { get; set; }
        public   string  GURADIAN_CONTACT_NO_2 { get; set; }

    }
}
