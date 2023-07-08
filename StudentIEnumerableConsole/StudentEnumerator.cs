using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StudentIEnumerableConsole
{
    public class StudentEnumerator : IEnumerator
    {
        int Position = -1;
        Student[] cohort;
        public StudentEnumerator(Student[] array)
        {
            cohort = new Student[array.Length];
            for(int i=0; i<array.Length; i++)
                cohort[i] = array[i];
            Array.Sort(cohort, (c1, c2) => c2.Grade.CompareTo(c1.Grade));
        }
        public object? Current
        {
            get
            {
                if (Position == -1)
                    throw new InvalidOperationException();
                if (Position >= cohort.Length)
                    throw new InvalidOperationException();

                return $"{cohort[Position].Name} has got {cohort[Position].Grade}";
            }
        }

        public bool MoveNext()
        {
            Position++;
            if (Position < cohort.Length)
            {
                if(cohort[Position].Grade >= 18)
                {
                    return true;
                }
                return MoveNext();
            }
            if (Position > cohort.Length)
            {
                return false;
            }
            return false;

        }

        public void Reset()
        {
            Position = -1;
        }

    }
}
