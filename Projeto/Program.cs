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
            // Inicializa os estilos visuais da aplicação. Define a compatibilidade com a renderização de texto.
            // Inicia a aplicação, exibindo o formulário de login como ponto sendo o primeiro a ser executado.

            Application.EnableVisualStyles(); 
            Application.SetCompatibleTextRenderingDefault(false); 
            Application.Run(new FormLogin()); 
        }

        public static void IntNumber(KeyPressEventArgs e)
        {
            // Validador de textBox para utilização exclusiva de números.
            // Verifica se o caractere digitado não é um dígito numérico (0-9) e não é a tecla Backspace (código 8).

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}