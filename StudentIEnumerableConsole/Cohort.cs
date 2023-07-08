using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StudentIEnumerableConsole
{
    public class Cohort : IEnumerable
    {
        Student[] StudentsCohort = new Student[]
                {
                    new Student("Student1", 18.2),
                    new Student("Student2", 10.2),
                    new Student("Student3", 11.2),
                    new Student("Student4", 8.2),
                    new Student("Student5", 16.2),
                    new Student("Student6", 20.0),
                    new Student("Student7", 20),
                    new Student("Student8", 9),
                    new Student("Student9", 1),
                    new Student("Student10", 7),
                    new Student("Student11", 0),
                    new Student("Student12", 0),
                    new Student("Student13", 20),
                    new Student("Student14", 19.6),
                };

        public IEnumerator GetEnumerator() 
        {
            return new StudentEnumerator(StudentsCohort);
        }

    }
}
