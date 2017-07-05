using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**************************************
 * Name: Elisabeth Feeley
 * Date: 7/2/2012
 * Assignment: HW1-3_EKF (Test Patient)
 * Resources: Previous code
 * ***********************************/

namespace HW1_3_EKF
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPatient Ann = new TestPatient();

            Ann.Number = "42";
            Ann.BirthDate = "07/2/2012";

            Console.WriteLine(Ann.Number);
            Console.WriteLine(Ann.BirthDate);

            Console.ReadLine();
        }//end static void Main
    }//end class Program

    public class TestPatient
    {
        //Attributes
        private String patientNumber;
        private String dateOfBirth;


        //Methods
        public String Number
        {
            get { return patientNumber; }
            set { patientNumber = value; }
        }//public String Number

        public String BirthDate
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }//end public String BirthDate

    }//end class TestPatient

}//end namespace HW1-3_EKF
