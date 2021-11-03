namespace Dev.Business.Notificacoes
{
    public class Notificacao
    {
        public Notificacao(string message)
        {
            Message = message;
        }

        public readonly string Message;
    }
}