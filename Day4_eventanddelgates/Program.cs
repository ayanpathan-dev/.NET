namespace Day4_eventanddelgates
{
    public delegate void MyHandler(int mrk);
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your marks:");
            Student student = new Student();
            student._Pass += new MyHandler(student.student_Pass);
            student._Fail += new MyHandler(student.student_Fail);

            student.Marks = Convert.ToInt32(Console.ReadLine());
            student.TriggerEvents(student.Marks);
        }
    }
    public class Student
    {


        public event MyHandler _Pass;
        public event MyHandler _Fail;

        private int _Marks;

        public int Marks
        {
            set
            {
                _Marks = value;
                if (_Marks > 40)
                {
                    _Pass(_Marks);
                }
                else
                {
                    _Fail.Invoke(_Marks);
                }
            }
            get
            {
                return _Marks;
            }
        }
        public void TriggerEvents(int mrk)
        {
            if (mrk > 40)
            {
                _Pass(_Marks);
            }
            else
            {
                _Fail.Invoke(mrk);
            }
        }
        public void student_Pass(int marks)
        {
            Console.WriteLine($"Congratulations!!!, you have passed with {marks} marks!!!");
        }
        public void student_Fail(int marks)
        {
            Console.WriteLine($"Congratulations!!!, you have failed with {marks} marks!!!");
        }
    }
}
