namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("######################################## ROBÔ TUPINIQUIM #########################################");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            Console.Write("Digite as coordenadas do canto superior direito (dois números inteiros separados por um espaço): "); //tamanho do grid
            string coordenadas = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite a posição inicial do robô '1' (dois números inteiros separados por um espaço, mais a direção que o robô está olhando - sendo N para norte, S para sul, L para leste e O para oeste): ");
            string posicaoInicialRobo1 = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite as instruções de movimento do robô '1' (sendo E - girar para esquerda, D - girar para direita e M - mover para frente): ");
            string instrucoesMovimentoRobo1 = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite a posição inicial do robô '2' (dois números inteiros separados por um espaço, mais a direção que o robô está olhando - sendo N para norte, S para sul, L para leste e O para oeste): ");
            string posicaoInicialRobo2 = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Digite as instruções de movimento do robô '2' (sendo E - girar para esquerda, D - girar para direita e M - mover para frente): ");
            string instrucoesMovimentoRobo2 = Console.ReadLine();
            Console.WriteLine();

            Console.Clear();

            string[] coordenadasSeparadas = coordenadas.Split(" ");
            int eixoX = Convert.ToInt32(coordenadasSeparadas[0]);
            int eixoY = Convert.ToInt32(coordenadasSeparadas[1]);

            string[] posicoesSeparadasRobo1 = posicaoInicialRobo1.Split(" ");
            int posicaoInicialXRobo1 = Convert.ToInt32(posicoesSeparadasRobo1[0]);
            int posicaoInicialYRobo1 = Convert.ToInt32(posicoesSeparadasRobo1[1]);
            char direcaoInicialRobo1 = Convert.ToChar(posicoesSeparadasRobo1[2]);

            char[] movimentosRobo1 = instrucoesMovimentoRobo1.ToCharArray();

            string[] posicoesSeparadasRobo2 = posicaoInicialRobo2.Split(" ");
            int posicaoInicialXRobo2 = Convert.ToInt32(posicoesSeparadasRobo2[0]);
            int posicaoInicialYRobo2 = Convert.ToInt32(posicoesSeparadasRobo2[1]);
            char direcaoInicialRobo2 = Convert.ToChar(posicoesSeparadasRobo2[2]);

            char[] movimentosRobo2 = instrucoesMovimentoRobo2.ToCharArray();

            CriarRobo1(posicaoInicialXRobo1, posicaoInicialYRobo1, direcaoInicialRobo1, movimentosRobo1);

            CriarRobo2(posicaoInicialXRobo2, posicaoInicialYRobo2, direcaoInicialRobo2, movimentosRobo2);
        }
        private static void CriarRobo1(int posicaoInicialXRobo1, int posicaoInicialYRobo1, char direcaoInicialRobo1, char[] movimentosRobo1)
        {
            int posicaoAtualXRobo1 = posicaoInicialXRobo1;
            int posicaoAtualYRobo1 = posicaoInicialYRobo1;
            char direcaoAtualRobo1 = direcaoInicialRobo1;

            foreach (char movimento in movimentosRobo1)
            {
                switch (movimento)
                {
                    case 'D':
                        GirarRobo(ref direcaoAtualRobo1, 'D');
                        break;

                    case 'E':
                        GirarRobo(ref direcaoAtualRobo1, 'E');
                        break;

                    case 'M':
                        MovimentarRobo(ref posicaoAtualXRobo1, ref posicaoAtualYRobo1, direcaoAtualRobo1);
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine($"A atual posição do robô 1 é: {posicaoAtualXRobo1} {posicaoAtualYRobo1} {direcaoAtualRobo1}");
            Console.WriteLine();
        }
        private static void CriarRobo2(int posicaoInicialXRobo2, int posicaoInicialYRobo2, char direcaoInicialRobo2, char[] movimentosRobo2)
        {
            int posicaoAtualXRobo2 = posicaoInicialXRobo2;
            int posicaoAtualYRobo2 = posicaoInicialYRobo2;
            char direcaoAtualRobo2 = direcaoInicialRobo2;

            foreach (char movimento in movimentosRobo2)
            {
                switch (movimento)
                {
                    case 'D':
                        GirarRobo(ref direcaoAtualRobo2, 'D');
                        break;

                    case 'E':
                        GirarRobo(ref direcaoAtualRobo2, 'E');
                        break;

                    case 'M':
                        MovimentarRobo(ref posicaoAtualXRobo2, ref posicaoAtualYRobo2, direcaoAtualRobo2);
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine($"A atual posição do robô 2 é: {posicaoAtualXRobo2} {posicaoAtualYRobo2} {direcaoAtualRobo2}");
            Console.WriteLine();
        }
        public static void MovimentarRobo(ref int posicaoX, ref int posicaoY, char direcao)
        {
            switch (direcao)
            {
                case 'N':
                    posicaoY = posicaoY + 1;
                    break;

                case 'S':
                    posicaoY = posicaoY - 1;
                    break;

                case 'L':
                    posicaoX = posicaoX + 1;
                    break;

                case 'O':
                    posicaoX = posicaoX - 1;
                    break;

                default:
                    break;
            }
        }
        public static void GirarRobo(ref char direcao, char giro)
        {
            switch (direcao)
            {
                case 'N':
                    switch (giro)
                    {
                        case 'E':
                            direcao = 'O';
                            break;

                        case 'D':
                            direcao = 'L';
                            break;

                        default:
                            break;
                    }
                    break;

                case 'S':
                    switch (giro)
                    {
                        case 'E':
                            direcao = 'L';
                            break;

                        case 'D':
                            direcao = 'O';
                            break;

                        default:
                            break;
                    }
                    break;

                case 'L':
                    switch (giro)
                    {
                        case 'E':
                            direcao = 'N';
                            break;

                        case 'D':
                            direcao = 'S';
                            break;

                        default:
                            break;
                    }
                    break;

                case 'O':
                    switch (giro)
                    {
                        case 'E':
                            direcao = 'S';
                            break;

                        case 'D':
                            direcao = 'N';
                            break;

                        default:
                            break;
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
