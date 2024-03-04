internal class Program
{
    private static void Main(string[] args)
    {
        string nome;
        int idade;
        char sexo;
        bool reservista;

        Console.Write("qual seu nome?: ");
        nome = Console.ReadLine();

        Console.Write("qual a sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("qual a seu sexo: ");
        sexo = Convert.ToChar(Console.ReadLine().ToUpper()); 

        reservista = idade >= 18 && sexo == 'M';

        if (reservista)
        {
            Console.WriteLine("Faça seu cadastro {0} ",  nome );
        }
        else
        {
            if(sexo == 'f')
            { 
            Console.Write("mulheres não precisam se cadastrar");
            }
            
             else
            {
            Console.WriteLine("Aguarde completar 18 anos {0}",nome);
            } 
        }
    }
}