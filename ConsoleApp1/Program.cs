using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int DisplayTelas_1 = 1;
        string Entrar_cpf_cadastre = "123456789";
        int contador_repeticao = 0;
        string senha_de_confirmacao = "123456789";
        float saldo = 0;
        float Digite = 0;

        while (contador_repeticao < 3)
        {
            Console.WriteLine("Digite Seu CPF: ");
            string cpf = Console.ReadLine();

            if (cpf == Entrar_cpf_cadastre)
            {
                Console.WriteLine("Digite sua senha: ");
                string Senha_Digitada = Console.ReadLine();

                if (senha_de_confirmacao == Senha_Digitada)
                {
                    Console.WriteLine("Logado.... ");
                    Console.WriteLine("Digite para: Saldo[1] Depositar[2] Sacar[3]:   ");
                    Digite = float.Parse(Console.ReadLine());

                    switch (Digite)
                    {
                        case 1:
                            Console.WriteLine("Saldo = Eur: " + saldo);
                            continue;

                        case 2:
                            Console.WriteLine("Seu saldo é: " + saldo + ". Qual a quantia a ser depositada: ");
                            float Colocar_quantia = float.Parse(Console.ReadLine());
                            saldo += Colocar_quantia;
                            Console.WriteLine("Depositado. Seu saldo agora é: " + saldo);
                            continue;

                        case 3:
                            Console.WriteLine("Está Disponível o saldo de: " + saldo + ". Qual o valor que deseja sacar: ");
                            float tirar = float.Parse(Console.ReadLine());

                            if (tirar <= saldo)
                            {
                                saldo -= tirar;
                                Console.WriteLine("Saque realizado. Seu saldo agora é: " + saldo);
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente para saque.");
                                continue;
                            }

                        default:
                            Console.WriteLine("Opção inválida.");
                            continue;
                    }
                }
                else
                {
                    Console.WriteLine("Senha incorreta.");
                }
            }
            else
            {
                Console.WriteLine("CPF incorreto.");
                contador_repeticao++;
            }

            if (contador_repeticao == 3)
            {
                Console.WriteLine("Limite de tentativas excedido. Conta bloqueada.");
                break;
            }
        }

        while (true)
        {
            Console.WriteLine("Escolha uma opção de recuperação de senha:");
            Console.WriteLine($"Digite {DisplayTelas_1} para recuperação de senha por email.");
            Console.WriteLine("Digite 0 para sair.");

            if (int.TryParse(Console.ReadLine(), out int selecioneaopcao))
            {
                switch (selecioneaopcao)
                {
                    case 0:
                        Console.WriteLine("Saindo do sistema.");
                        break;

                    case 1:
                        Console.WriteLine($"Senha enviada para o email do cliente: emailcliente@dominio.com");
                        Console.WriteLine($"Verifique seu email, lixeira ou caixa de spawn");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        continue;
                }

                break;
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }
        }
    }
}
