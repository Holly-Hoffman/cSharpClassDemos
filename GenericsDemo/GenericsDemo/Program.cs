namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lists can utilize generics!");

            //<string> means only strings can be there
            List<string> names = new() { "Chris", "Sarika", "Holly", "Graham" };
            names.Add("Brandon");

            List<int> numbers = new() { 1, 2, 3, 4, 5 };

            //this has both an int and a string.
            //it can only accept an int and then a string.
            Dictionary<int, string> months = new Dictionary<int, string>();
            months.Add(1, "Jan");
            months.Add(2, "Feb");
            months.Add(3, "Mar");
            months.Add(4, "Apr");
            months.Add(5, "May");
            months.Add(6, "Jun");


            Console.WriteLine($"Month 5 = {months[5]}");
        }


        //generic interface
        internal interface DAO<T>
        {
            List<T> GetAll();
            T GetById(int id);
            void Add(T t);
            void Update(T t);
            void Delete(T t);
        }
    }
}
