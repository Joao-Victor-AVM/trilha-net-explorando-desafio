namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // IMPLMENTADO!!!
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // IMPLEMENTADO!!!
                throw new Exception("Capacidade da suíte e o número de hóspedes não é válido.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // IMPLEMENTADO!!!
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // IMPLMENTADO!!!
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria;

            // IMPLEMENTADO!!!
            if (DiasReservados >= 10)
            {
                decimal desconto = (valor * (decimal)0.10);
                decimal valorDesconto = valor - desconto;
                valor = valorDesconto;
            }

            return valor;
        }
    }
}