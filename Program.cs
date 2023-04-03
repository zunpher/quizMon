class Program {
    static double FindMax(double a, double b) {
        if (a > b) {
            return a;
        } 
        return b;
    }

    static double FindMin(double a, double b) {
        if (a < b) {
            return a;
        } 
        return b;
    }
    static void Main(string[] args) {
        int maxInputs = 100;
        int i = 0;
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double num3 = double.Parse(Console.ReadLine());
        double num4 = double.Parse(Console.ReadLine());

        string operation = Console.ReadLine();
        switch (operation) {
            case "FindMax" :
            double result1 = FindMax(num1,num2);
            double result2 = FindMax(num3,num4);
            double final1 = FindMax(result1,result2);
            Console.WriteLine(final1);
            break;

            case "FindMin" :
            double result3 = FindMin(num1,num2);
            double result4 = FindMin(num3,num4);
            double final2 = FindMin(result3,result4);
            Console.WriteLine(final2);
            break;

            case "FindMean" :
            double final3 = (num1+num2+num3+num4)/4;
            Console.WriteLine(final3);
            break;

            default :
            Console.WriteLine("Invalid mode");
            break;
        }
    }
}