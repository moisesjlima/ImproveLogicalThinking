namespace JsonString
{
    internal class JsonString
    {
        static void Main(string[] args)
        {
            var stringWay = "{nome: \"Moisés\" , idade: \"23\"}";

            ///var stringWay = """{nome: "Moisés" , idade: "23"}"""; // c# version available >= 11

            Console.WriteLine(stringWay);
        }
    }
}