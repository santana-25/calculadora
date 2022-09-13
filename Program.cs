class Program
{
    ///isso é um teste do github
    static void Main()
    {
        Console.Write("escolha um numero: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("escolha outro numero: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("esolha uma operação");
        Console.WriteLine(" digite 1 para soma \r\n digite 2 para subtrair \r\n digite 3 para multiplicar \r\n digite 4 para dividir");
       int calculo = Convert.ToInt32(Console.ReadLine());
        
        if (calculo == 1) 
        {
         double soma = numero1 + numero2;
         Console.WriteLine($"a soma deu {soma}");
        }
        else if (calculo ==2)
        {
           double soma = numero1 - numero2;
         Console.WriteLine($"a soma deu {soma}"); 
        }
        else if (calculo ==3)
        {
           double soma = numero1 * numero2;
         Console.WriteLine($"a soma deu {soma}"); 
        }
        else if (calculo ==4)
        {
            if (numero1 ==0 || numero2 ==0){
                Console.WriteLine("não existe divisão por 0");
            }
           double soma = numero1 / numero2;
         Console.WriteLine($"a soma deu {soma}"); 
        }
    }
}