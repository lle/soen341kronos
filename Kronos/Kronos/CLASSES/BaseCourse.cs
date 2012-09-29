using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kronos.CLASSES
{
    //base class
    //use polymorphism and inheritence for sub classes of base class
    // to use polymorphism you use the keywork override
    //to call base constructor or methods use base.()
    public class BaseCourse
    {
        private float classtime;
        private LinkedList<globalvariables.day> thedaysofweek;
        public virtual BaseCourse(globalvariables.day[] the_days_it_has, float  total_course_time)//virtual constructor
        {
            thedaysofweek=new LinkedList<globalvariables.day>();
            
            foreach(globalvariables.day count_days in the_days_it_has)
                        thedaysofweek.AddLast(count_days);



        }

        protected virtual float get_set_class_time { get { return classtime; } set { value = classtime; } }
        private virtual LinkedList<globalvariables.day> get_set_linkedlist_courses { get { return thedaysofweek; } set { value = thedaysofweek; } }


    }
}