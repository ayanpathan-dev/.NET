using System.Text.Json.Nodes;
using System.Xml;

namespace Day3_DocReport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a choice:");
                Console.WriteLine("1.pdf, 2.xml, 3.doc, 4.json");
                int choice=Convert.ToInt32(Console.ReadLine());

                ReportFactory Factory = new ReportFactory();
                Report report = Factory.GetSomeMethod(choice);
                report.generateReport();

               
            }




        }
    }
    public class ReportFactory

    {
        public Report GetSomeMethod( int choice)
        {
            Report someReport = null;
            switch (choice)
            {
                case 1:
                    someReport = new pdf();
                    break;

                    case 2:
                    someReport = new Xml();
                    break;

                case 3:
                    someReport = new Doc();
                    break;

                case 4:
                    someReport = new Json();
                    break;

            }
            return someReport;
        }

    }
    public abstract class Report
        
    {
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void save();

        public virtual void generateReport()
        {
            Parse();
            Validate();
            save();
            Console.WriteLine("report is generated");
        }


    }
    public abstract class SpecialReport : Report
    {
        protected abstract void Revalidate();

        public override void generateReport()
        {
            Parse();
            Validate();
            Revalidate();
            save();
            Console.WriteLine("special report is generated");
        }
    }

    public class pdf : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("pdf is parsed");
        }

        protected override void Validate()
        {
            Console.WriteLine("pdf is validate");
        }
        protected override void save()
        {
            Console.WriteLine("pdf is save");
        }






    }
    public class Xml : SpecialReport
    {
        protected override void Parse()
        {
            Console.WriteLine("xml is parse");

        }
        protected override void Validate()
        {
            Console.WriteLine("xml is validate");

        }
        protected override void Revalidate()
        {
            Console.WriteLine("xml is revalidate");

        }
        protected override void save()
        {
            Console.WriteLine("xml is save");

        }
    }

    public class Json : SpecialReport
    {
        protected override void Parse()
        {
            Console.WriteLine("Json is parse");
        }

       protected override void Validate()
        {
            Console.WriteLine("Json is validate");
        }

        protected override void Revalidate()
        {
            Console.WriteLine("json is revalidate");
        }


        protected override void save()
        {
            Console.WriteLine("Json is save");
        }
    }

    public class Doc : Report
    {
        protected override void Parse()
        {
            Console.WriteLine("Doc is parsed");
        }

        protected override void Validate()
        {
            Console.WriteLine("doc is validate");
        }

        protected override void save()
        {
            Console.WriteLine("doc is save");
        }

    }
}