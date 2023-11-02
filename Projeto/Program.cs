using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles(); // Inicializa os estilos visuais da aplicação.
            Application.SetCompatibleTextRenderingDefault(false); // Define a compatibilidade com a renderização de texto.
            Application.Run(new FormLogin()); // Inicia a aplicação, exibindo o formulário de login como ponto de entrada.
        }

        public static void IntNumber(KeyPressEventArgs e)
        {
            // Verifica se o caractere digitado não é um dígito numérico (0-9) e não é a tecla Backspace (código 8).
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

    }
}