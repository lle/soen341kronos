using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Kronos.CLASSES
{
    //base class
    //use polymorphism and inheritence for sub classes of base class
    // to use polymorphism you use the keywork override
    //make a call to the base constructor to intialize specific values, and then fill the rest with the sub-constructor
    //there should be 4 sub classes, 1 only lecture, 1 with tutorial and lecture, and 1 with tutorials and labs and lectures, and 1 with lectures and labs no tutorials
    public class BaseCourse
    {
        protected  float class_time;
        protected  LinkedList<globalvariables.day> class_days;
        protected  string class_section;
        protected virtual float get_set_class_time { get { return class_time; } set { value = class_time; } }
        protected virtual LinkedList<globalvariables.day> get_set_linkedlist_courses { get { return class_days; } set { value = class_days; } }
        protected virtual  string get_set_class_sections { get { return class_section; } set { value = class_section; } }


        public BaseCourse(globalvariables.day[] class_days, float class_time, string class_section)
        {
            this.class_days = new LinkedList<globalvariables.day>();

            foreach (globalvariables.day count_days in class_days)
                this.class_days.AddLast(count_days);

            this.class_section = class_section;
            this.class_time = class_time;
        }
        

    }
}