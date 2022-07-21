namespace SistemaMaisZeroCursos.Comum
{
    public class Cpf
    {
        public static bool validar(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf == "" || !cpf.All(char.IsDigit)) return false;

            int[] prmMultiplicador = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] sgndMultiplicador = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;
            string digito;

            int soma;
            int resto;

            cpf = cpf.Trim();

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(tempCpf[i].ToString()) * prmMultiplicador[i];
            }


            resto = soma % 11;

            if (resto < 2) resto = 0;
            else resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * sgndMultiplicador[i];

            resto = soma % 11;

            if (resto < 2) resto = 0;
            else resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);

        }

        public static string formatarCpf(string cpf)
        {
           cpf = cpf.Replace(".", "").Replace("-", "");
           cpf = cpf.Trim();
            return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
        }
    }
}
