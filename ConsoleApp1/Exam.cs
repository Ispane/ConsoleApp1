using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Exam : FinalExam
    {
        public float SumEst { get; set; }
        public float Quantity { get; set; }

        public override double GetEstimation() => SumEst / Quantity;
    }
}
