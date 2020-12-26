using Flunt.Notifications;
using PaymentContext.Domain.Commands;
using PaymentContext.Shared.Commands;
using PaymentContext.Shared.Handlers;

namespace PaymentContext.Domain.Handlers
{
    public class SubscriptionHandler : Notifiable, IHandler<CreateBoletoSubscriptionCommand>
    {
        //private readonly IStudentRepository _repository;
        // public SubscriptionHandler(IStudentRepository repository)
        // {
        //     _repository = repository;
        // }
        public ICommandResult Handle(CreateBoletoSubscriptionCommand command)
        {
            command.Validate();

            // fail fast validations here

            /*
            Deve:
                Verificar se o documento já está cadastrado
                
                Verificar se o e-mail já está cadastrado
                
                Gerar os VO's
                
                Gerar as entidades
                
                Aplicar as validações
                
                Salvar as informações

                Enviar e-mail de boas vindas

                Retornar as informações
            */
            return new CommandResult(true, "Assinatura realizada com sucesso.");
        }
    }
}