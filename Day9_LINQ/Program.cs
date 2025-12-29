namespace Day9_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<emp> emps = new List<emp>() {

            new emp() { Id=1, Name="abc", Address="pune" },
            new emp() { Id = 2, Name = "pqr", Address = "mumbai" },
                };

            Console.WriteLine("Enter first ch of city name :");
            string? ch = Console.ReadLine().ToLower();

            var filteredEmpCollectionBasedOnCity = (from emp in emps
                                                    where emp.Address.ToLower().StartsWith(ch)
                                                    select emp);



            foreach (emp emp in filteredEmpCollectionBasedOnCity)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Address: {emp.Address}");
            }
        }
    }
    public class emp
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Address {  get; set; }

    }
}
