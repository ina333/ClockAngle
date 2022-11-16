using System;

namespace ReizTech_assignment
{
    class ClockAngle
    {
       public static void Main(string[] args)
        {
            //initializing hour && minute with value of '0.00'
            double hour = 0.00; 
            double minute = 0.00;
            string angleInDegree = "";
            Console.WriteLine("Please enter the hour :");
            //reading the input that is completed by user
            hour =Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Please enter the minutes :");
            minute = Convert.ToInt64(Console.ReadLine());
            //validation of hours && minutes 
            angleInDegree = (hour < 0 || minute < 0 || hour > 60 || minute > 60) ?  "Wrong Input": calculateAngle(hour, minute);
            //calling the method and passing the read parameters 
           // angleInDegree = ;
            Console.WriteLine(angleInDegree);
        }

        /// <summary>
        /// This method will calculate the angle of clock.
        /// </summary>
        /// <param name="h">the h->hours completed by user</param>
        /// <param name="min">the min->minutes completed by user</param>
        static string calculateAngle(double h,double min) 
        {
            int angleCalculation = 0;
            ///<remarks> The minute hand moves 360 degrees in 60 minute=>360/60 = 6 degrees in one minute and hour hand moves 360 degrees in 12 hours(12*60 minutes=720) =>360/720 = 0.5 degrees in 1 minute</remarks>
            int hour_angle = (int)(0.5 * (h * 60 + min));
            int minute_angle = (int)(6 * min);

            angleCalculation = Math.Abs(hour_angle - minute_angle);
            int ang = 360 - angleCalculation;
            // smaller angle of hour angles and minutes angle
            angleCalculation = (int)((ang > angleCalculation) ? angleCalculation : ang);
            return "Lesser angle in degrees between hours=" + h + " and minutes=" + min + " is " + angleCalculation+" ." ;

        }
        
    }
}
