using System;

namespace CursoFoop_SOLID_DIP_aderente
{
    class Program
    {
        static void Main(string[] args)
        {
            var conexao = new MySqlConnection();
            var recuperarsenha = new RecuperarSenha(conexao);

            Console.ReadLine();
        }
    }
}
