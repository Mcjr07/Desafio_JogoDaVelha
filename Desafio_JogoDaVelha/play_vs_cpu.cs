using System;


namespace play_vs_cpu
{
    class Program
    {
        static char[,] tabuleiro = new char[3, 3];
        static char jogadorAtual = '1'; // A CPU começa
        static char jogadorHumano = '2';
        static bool jogoEncerrado = false;
        static Random rand = new Random();

        static void Main()
        {
            while (true)
            {
                InicializarTabuleiro();
                jogoEncerrado = false;

                while (!jogoEncerrado)
                {
                    ExibirTabuleiro();

                    if (jogadorAtual == '1')
                    {
                        RealizarJogadaCPU();
                    }
                    else
                    {
                        RealizarJogadaPlay();
                    }

                    VerificarVitoria();
                    if (!jogoEncerrado)
                        TrocarJogador();
                }

                Console.Write("Deseja jogar novamente? (S/N): ");
                char escolha = char.ToUpper(Console.ReadKey().KeyChar);

                if (escolha != 'S')
                    break;
            }
        }

        static void InicializarTabuleiro()
        {
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    tabuleiro[linha, coluna] = ' ';
                }
            }
        }

        static void ExibirTabuleiro()
        {
            Console.Clear();
            Console.WriteLine("Jogo da Velha");
            Console.WriteLine("-------------");

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"| {tabuleiro[linha, coluna]} ");
                }
                Console.WriteLine("|");
                Console.WriteLine("-------------");
            }
        }

        static void RealizarJogadaPlay()
        {
            int linha, coluna;

            do
            {
                Console.WriteLine($"Play {jogadorAtual}, é sua vez.");
                Console.Write("Informe a linha (1-3): ");
                linha = int.Parse(Console.ReadLine()) - 1;
                Console.Write("Informe a coluna (1-3): ");
                coluna = int.Parse(Console.ReadLine()) - 1;

                if (linha < 0 || linha > 2 || coluna < 0 || coluna > 2 || tabuleiro[linha, coluna] != ' ')
                {
                    Console.WriteLine("Jogada inválida. Tente novamente.");
                }
                else
                {
                    tabuleiro[linha, coluna] = jogadorAtual;
                    break;
                }
            } while (true);
        }

        static void RealizarJogadaCPU()
        {
            int linha, coluna;

            do
            {
                linha = rand.Next(0, 3);
                coluna = rand.Next(0, 3);

                if (tabuleiro[linha, coluna] == ' ')
                {
                    tabuleiro[linha, coluna] = jogadorAtual;
                    break;
                }
            } while (true);
        }

        static void VerificarVitoria()
        {
            for (int i = 0; i < 3; i++)
            {
                if (tabuleiro[i, 0] == jogadorAtual && tabuleiro[i, 1] == jogadorAtual && tabuleiro[i, 2] == jogadorAtual)
                {
                    Console.WriteLine($"Play {jogadorAtual} venceu!");
                    jogoEncerrado = true;
                    return;
                }
                if (tabuleiro[0, i] == jogadorAtual && tabuleiro[1, i] == jogadorAtual && tabuleiro[2, i] == jogadorAtual)
                {
                    Console.WriteLine($"Play {jogadorAtual} venceu!");
                    jogoEncerrado = true;
                    return;
                }
            }

            if (tabuleiro[0, 0] == jogadorAtual && tabuleiro[1, 1] == jogadorAtual && tabuleiro[2, 2] == jogadorAtual)
            {
                Console.WriteLine($"Play {jogadorAtual} venceu!");
                jogoEncerrado = true;
                return;
            }

            if (tabuleiro[0, 2] == jogadorAtual && tabuleiro[1, 1] == jogadorAtual && tabuleiro[2, 0] == jogadorAtual)
            {
                Console.WriteLine($"Play {jogadorAtual} venceu!");
                jogoEncerrado = true;
                return;
            }

            // Verificar empate
            bool tabuleiroCheio = true;
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    if (tabuleiro[linha, coluna] == ' ')
                    {
                        tabuleiroCheio = false;
                        break;
                    }
                }
                if (!tabuleiroCheio)
                    break;
            }

            if (tabuleiroCheio)
            {
                Console.WriteLine("Empate!");
                jogoEncerrado = true;
            }
        }

        static void TrocarJogador()
        {
            jogadorAtual = (jogadorAtual == '1') ? '2' : '1';
        }
    }
}
