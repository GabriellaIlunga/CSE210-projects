using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        
        Running run1 = new Running("03 Nov 2022", 30, 4.8);
        Cycling bike1 = new Cycling("04 Nov 2022", 45, 20.0);
        Swimming swim1 = new Swimming("05 Nov 2022", 20, 20);

    
        activities.Add(run1);
        activities.Add(bike1);
        activities.Add(swim1);

        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}