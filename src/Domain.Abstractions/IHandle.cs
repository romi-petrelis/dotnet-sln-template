namespace RenameMe.Domain;

public interface IHandle<in TMessage>
{
    Task Handle(TMessage message);
}