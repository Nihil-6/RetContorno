int largura, altura;

Console.Write("Largura: ");
largura = Convert.ToInt32(Console.ReadLine());

Console.Write("Altura: ");
altura = Convert.ToInt32(Console.ReadLine());

for (int linha = 1; linha <= altura; linha++)
{
    for (int coluna = 1; coluna <= largura; coluna++)
    {
        if (linha == 1 || linha == altura)
        {
            Console.Write("*");
        }
        else if (coluna == 1 || coluna == largura)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }

    Console.WriteLine(); 
}