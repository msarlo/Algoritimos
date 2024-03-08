class Program
{
    static void Main(string[] args)
    {
        double peso, altura, total;

        Console.Write("informe o seu peso (Ex.: 70Kg); ");
        peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("informe sua altura(Ex.: 1,70)");
        altura = Convert.ToDouble(Console.ReadLine());

        total = peso / (altura * altura);

        if(total <= 18.5)
        {
            Console.Write("seu IMC é {0:N1}, vc está magro", total);
        }
        else if (total >= 18.5 && total <= 24.9)
        { 
            Console.Write("seu IMC é {0:N1}, vc está normal", total);
        }
        else if (total >= 25 &&  total<= 29.9)
        {
            Console.Write("seu IMC é {0:N1}, vc está com sobrepeso", total );
        }
        else if (total >= 30 && total<= 39.9)
        {
            Console.Write("seu IMC é {0:N1}, vc está com sobrepeso 2 o inimigo agora é outro", total );
        }
        else if (total > 40)
        {
             Console.Write("seu IMC é {0:N1}, vc está com Robertinho", total );
        }
    }

}