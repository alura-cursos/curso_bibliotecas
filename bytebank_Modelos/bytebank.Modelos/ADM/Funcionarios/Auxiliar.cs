namespace bytebank.Modelos.ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.1;
        }

        protected internal override double getBonificacao()
        {
            return Salario * 0.2;
        }
    }
}
