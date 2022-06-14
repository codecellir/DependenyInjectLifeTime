namespace InectionLifeTime
{
    public class Operation : ISingletonOperation, IScopedOperation, ITransientOperation
    {
        Guid _guid;
        public Operation()
        {
            _guid = Guid.NewGuid();
        }

        public Guid OperationId => _guid;
    }
}
