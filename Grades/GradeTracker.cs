using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Grades
{
    public abstract class GradeTracker : IGradeTracker
    {

        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter destination);

        protected string _name;

        public event NameChangedDelegate NameChanged;
        
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {

                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;
                        NameChanged(this, args);
                    }
                    _name = value;
                }
            }
        } //derived classes can access protected.

        public abstract IEnumerator GetEnumerator();
    }
}
