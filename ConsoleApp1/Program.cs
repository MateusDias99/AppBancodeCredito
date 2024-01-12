using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int DisplayTelas_1 = 1;
        string Entrar_cpf_cadastre = "123456789";
        int contador_repeticao = 0;
        string senha_usuario_colocou = string.Empty;

        while (contador_repeticao < 3)
        {
            Console.WriteLine("Digite SEU CPF: ");
            string cpf = Console.ReadLine();

            if (cpf == Entrar_cpf_cadastre)
            {
                Console.WriteLine("Digite sua senha: ");
                senha_usuario_colocou = Console.ReadLine();

                if (senha_usuario_colocou == "123456789")
                {
                    Console.WriteLine("Logado.... ");
                    Console.WriteLine("Saldo: Eur:1000, Pix, Deposito, Trasferencia Bancaria, Doação, \n CDB (deposite e trasforme seu deposito em limite de credito");
                    break;
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
