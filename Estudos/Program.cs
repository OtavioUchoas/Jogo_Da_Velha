
using System.Text.RegularExpressions;

class Program
{
    public static void Main()
    {
        Console.WriteLine("#############################################################");
        Console.WriteLine("########################JOGO DA VELHA########################");
        Console.WriteLine("#############################################################");
        Console.WriteLine();
        Console.WriteLine("1 - Jogo Player vs Player");
        Console.WriteLine("2 - Jogo Player vs Maquina");
        Console.WriteLine("3 - Sair");
        Console.WriteLine();

        Console.WriteLine("Feito por Otávio");
        Console.WriteLine();
        string regex = "^[0-2][0-2]$";
        string n = Console.ReadLine()!;
        string[,] valores = new string[3, 3];
        valores[0, 0] = "0,0";
        valores[0, 1] = "0,1";
        valores[0, 2] = "0,2";
        valores[1, 0] = "1,0";
        valores[1, 1] = "1,1";
        valores[1, 2] = "1,2";
        valores[2, 0] = "2,0";
        valores[2, 1] = "2,1";
        valores[2, 2] = "2,2";
        int garantia = 0;
        if (n == "1")
        {
            HashSet<string> jogosfeitos = new HashSet<string>();
            HashSet<string> jogosp1 = new HashSet<string>();
            HashSet<string> jogosp2 = new HashSet<string>();

            Console.Clear();
            Console.WriteLine("Nome do jogador 1:");
            string nome1 = Console.ReadLine()!;
            Console.Clear();
            Console.WriteLine("Nome do jogador 2:");
            string nome2 = Console.ReadLine()!;
            Console.Clear();
            string tabuleiro = $" {valores[0, 0]} | {valores[0, 1]} | {valores[0, 2]} \n-----+-----+-----\n {valores[1, 0]} | {valores[1, 1]} | {valores[1, 2]} \n-----+-----+-----\n {valores[2, 0]} | {valores[2, 1]} | {valores[2, 2]}";
            Console.WriteLine(tabuleiro);
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Escolha uma posicao {nome1} :");
                string imput = Console.ReadLine()!;
                bool ctz = Regex.IsMatch(imput, regex);
                if (ctz == true)
                {
                    while (true)
                    {
                        if (jogosfeitos.Contains(imput!) == true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Digite um valor que ainda nao foi jogado");
                            Console.WriteLine($"Escolha uma posicao {nome1} :");
                            imput = Console.ReadLine()!;
                            Console.Clear();
                            tabuleiro = $" {valores[0, 0]} | {valores[0, 1]} | {valores[0, 2]} \n-----+-----+-----\n {valores[1, 0]} | {valores[1, 1]} | {valores[1, 2]} \n-----+-----+-----\n {valores[2, 0]} | {valores[2, 1]} | {valores[2, 2]}";
                            Console.WriteLine(tabuleiro);
                            continue;
                        }
                        else
                        {
                            jogosfeitos.Add(imput);

                            string c = imput[0].ToString();
                            string d = imput[1].ToString();
                            int a1 = int.Parse(c);
                            int a2 = int.Parse(d);
                            valores[a1, a2] = " X ";
                            tabuleiro = $" {valores[0, 0]} | {valores[0, 1]} | {valores[0, 2]} \n-----+-----+-----\n {valores[1, 0]} | {valores[1, 1]} | {valores[1, 2]} \n-----+-----+-----\n {valores[2, 0]} | {valores[2, 1]} | {valores[2, 2]}";
                            Console.Clear();
                            Console.WriteLine(tabuleiro);
                            jogosp1.Add(imput);
                            garantia++;
                            if (Possuevencedor(jogosp1) == true)
                            {
                                Console.WriteLine($"{nome1} venceu!");
                                return;
                            }
                            else if (garantia == 9)
                            {
                                Console.WriteLine("Velha!");
                                return;
                            }

                            break;
                        }
                    }
                }
                else
                {
                    jogosfeitos.Add(imput);

                    string c = imput[0].ToString();
                    string d = imput[1].ToString();
                    int a1 = int.Parse(c);
                    int a2 = int.Parse(d);
                    valores[a1, a2] = " X ";
                    tabuleiro = $" {valores[0, 0]} | {valores[0, 1]} | {valores[0, 2]} \n-----+-----+-----\n {valores[1, 0]} | {valores[1, 1]} | {valores[1, 2]} \n-----+-----+-----\n {valores[2, 0]} | {valores[2, 1]} | {valores[2, 2]}";
                    Console.Clear();
                    Console.WriteLine(tabuleiro);
                    jogosp1.Add(imput);
                    garantia++;
                    if (Possuevencedor(jogosp1) == true)
                    {
                        Console.WriteLine($"{nome1} venceu!");
                        return;
                    }
                    else if (garantia == 9)
                    {
                        Console.WriteLine("Velha!");
                        return;
                    }
                }
                Console.WriteLine();
                Console.WriteLine($"Escolha uma posicao {nome2} :");
                imput = Console.ReadLine()!;
                ctz = Regex.IsMatch(imput, regex);
                if (ctz == true)
                {
                    while (true)
                    {
                        if (jogosfeitos.Contains(imput!) == true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Digite um valor que ainda nao foi jogado");
                            Console.WriteLine($"Escolha uma posicao {nome2} :");
                            imput = Console.ReadLine()!;
                            Console.Clear();
                            tabuleiro = $" {valores[0, 0]} | {valores[0, 1]} | {valores[0, 2]} \n-----+-----+-----\n {valores[1, 0]} | {valores[1, 1]} | {valores[1, 2]} \n-----+-----+-----\n {valores[2, 0]} | {valores[2, 1]} | {valores[2, 2]}";
                            Console.WriteLine(tabuleiro);
                            continue;
                        }
                        else
                        {
                            jogosfeitos.Add(imput);

                            string c = imput[0].ToString();
                            string d = imput[1].ToString();
                            int a1 = int.Parse(c);
                            int a2 = int.Parse(d);
                            valores[a1, a2] = " O ";
                            tabuleiro = $" {valores[0, 0]} | {valores[0, 1]} | {valores[0, 2]} \n-----+-----+-----\n {valores[1, 0]} | {valores[1, 1]} | {valores[1, 2]} \n-----+-----+-----\n {valores[2, 0]} | {valores[2, 1]} | {valores[2, 2]}";
                            Console.Clear();
                            Console.WriteLine(tabuleiro);
                            jogosp2.Add(imput);
                            garantia++;
                            if (Possuevencedor(jogosp2) == true)
                            {
                                Console.WriteLine($"{nome2} venceu!");
                                return;
                            }
                            else if (garantia == 9)
                            {
                                Console.WriteLine("Velha!");
                                return;
                            }
                            break;
                        }
                    }
                }
                else
                {
                    jogosfeitos.Add(imput);

                    string c = imput[0].ToString();
                    string d = imput[1].ToString();
                    int a1 = int.Parse(c);
                    int a2 = int.Parse(d);
                    valores[a1, a2] = " O ";
                    tabuleiro = $" {valores[0, 0]} | {valores[0, 1]} | {valores[0, 2]} \n-----+-----+-----\n {valores[1, 0]} | {valores[1, 1]} | {valores[1, 2]} \n-----+-----+-----\n {valores[2, 0]} | {valores[2, 1]} | {valores[2, 2]}";
                    Console.Clear();
                    Console.WriteLine(tabuleiro);
                    jogosp2.Add(imput);
                    garantia++;
                    if (Possuevencedor(jogosp2) == true)
                    {
                        Console.WriteLine($"{nome1} venceu!");
                        return;
                    }
                    else if (garantia == 9)
                    {
                        Console.WriteLine("Velha!");
                        return;
                    }

                }
            }
        }
        else if (n == "2")
        {
            HashSet<string> jogosfeitos = new HashSet<string>();
            HashSet<string> jogosp1 = new HashSet<string>();
            HashSet<string> jogosp2 = new HashSet<string>();

            Console.Clear();
            Console.WriteLine("Nome do jogador 1:");
            string nome1 = Console.ReadLine()!;
            Console.Clear();
            string tabuleiro = $" {valores[0, 0]} | {valores[0, 1]} | {valores[0, 2]} \n-----+-----+-----\n {valores[1, 0]} | {valores[1, 1]} | {valores[1, 2]} \n-----+-----+-----\n {valores[2, 0]} | {valores[2, 1]} | {valores[2, 2]}";
            Console.WriteLine(tabuleiro);
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine($"Escolha uma posicao {nome1} :");
                string imput = Console.ReadLine()!;
                bool ctz = Regex.IsMatch(imput, regex);
                if (ctz == true)
                {
                    while (true)
                    {
                        if (jogosfeitos.Contains(imput!) == true)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Digite um valor que ainda nao foi jogado");
                            Console.WriteLine($"Escolha uma posicao {nome1} :");
                            imput = Console.ReadLine()!;
                            Console.Clear();
                            tabuleiro = $" {valores[0, 0]} | {valores[0, 1]} | {valores[0, 2]} \n-----+-----+-----\n {valores[1, 0]} | {valores[1, 1]} | {valores[1, 2]} \n-----+-----+-----\n {valores[2, 0]} | {valores[2, 1]} | {valores[2, 2]}";
                            Console.WriteLine(tabuleiro);
                            continue;
                        }
                        else
                        {
                            jogosfeitos.Add(imput);

                            string c = imput[0].ToString();
                            string d = imput[1].ToString();
                            int a1 = int.Parse(c);
                            int a2 = int.Parse(d);
                            valores[a1, a2] = " X ";
                            tabuleiro = $" {valores[0, 0]} | {valores[0, 1]} | {valores[0, 2]} \n-----+-----+-----\n {valores[1, 0]} | {valores[1, 1]} | {valores[1, 2]} \n-----+-----+-----\n {valores[2, 0]} | {valores[2, 1]} | {valores[2, 2]}";
                            Console.Clear();
                            Console.WriteLine(tabuleiro);
                            jogosp1.Add(imput);
                            garantia++;
                            if (Possuevencedor(jogosp1) == true)
                            {
                                Console.WriteLine($"{nome1} venceu!");
                                return;
                            }
                            else if (garantia == 9)
                            {
                                Console.WriteLine("Velha!");
                                return;
                            }

                            break;
                        }
                    }
                }
                else
                {
                    jogosfeitos.Add(imput);

                    string c = imput[0].ToString();
                    string d = imput[1].ToString();
                    int a1 = int.Parse(c);
                    int a2 = int.Parse(d);
                    valores[a1, a2] = " X ";
                    tabuleiro = $" {valores[0, 0]} | {valores[0, 1]} | {valores[0, 2]} \n-----+-----+-----\n {valores[1, 0]} | {valores[1, 1]} | {valores[1, 2]} \n-----+-----+-----\n {valores[2, 0]} | {valores[2, 1]} | {valores[2, 2]}";
                    Console.Clear();
                    Console.WriteLine(tabuleiro);
                    jogosp1.Add(imput);
                    garantia++;
                    if (Possuevencedor(jogosp1) == true)
                    {
                        Console.WriteLine($"{nome1} venceu!");
                        return;
                    }
                    else if (garantia == 9)
                    {
                        Console.WriteLine("Velha!");
                        return;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("O computador esta escolhendo um numero....");
                Thread.Sleep(1500);
                string digitos = "";
                while (true)
                {
                    int cc = Random.Shared.Next(0, 3);
                    int dd = Random.Shared.Next(0, 3);
                    digitos = cc.ToString() + dd.ToString();
                    if (jogosfeitos.Contains(digitos) == true)
                    {
                        continue;
                    }
                    else
                    {
                        jogosfeitos.Add(digitos);
                        break;
                    }
                }

                    string ccc = digitos[0].ToString();
                    string ddd = digitos[1].ToString();
                    int a11 = int.Parse(ccc);
                    int a22 = int.Parse(ddd);
                    valores[a11, a22] = " O ";
                    tabuleiro = $" {valores[0, 0]} | {valores[0, 1]} | {valores[0, 2]} \n-----+-----+-----\n {valores[1, 0]} | {valores[1, 1]} | {valores[1, 2]} \n-----+-----+-----\n {valores[2, 0]} | {valores[2, 1]} | {valores[2, 2]}";
                    Console.Clear();
                    Console.WriteLine(tabuleiro);
                    jogosp2.Add(digitos);
                    garantia++;
                    if (Possuevencedor(jogosp2) == true)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Maquina venceu!");
                        return;
                    }
                    else if (garantia == 9)
                    {
                        Console.WriteLine("Velha!");
                        return;
                    }


            }
        }
        else
        {
            Console.Clear ();
            return;
        }
    }
                
      
    
    public static bool Possuevencedor (HashSet<string> jogo)
    {
        if ((jogo.Contains("00") && jogo.Contains("01") && jogo.Contains("02"))
            || (jogo.Contains("10") && jogo.Contains("11") && jogo.Contains("12"))
            || (jogo.Contains("20") && jogo.Contains("21") && jogo.Contains("22"))
            || (jogo.Contains("00") && jogo.Contains("10") && jogo.Contains("20"))
            || (jogo.Contains("01") && jogo.Contains("11") && jogo.Contains("21"))
            || (jogo.Contains("02") && jogo.Contains("12") && jogo.Contains("22"))
            || (jogo.Contains("00") && jogo.Contains("11") && jogo.Contains("22"))
            || (jogo.Contains("02") && jogo.Contains("11") && jogo.Contains("20")))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}        



    
