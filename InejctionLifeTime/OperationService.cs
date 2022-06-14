namespace InectionLifeTime
{
    public class OperationService
    {
        public ITransientOperation TransientOperation { get; }
        public IScopedOperation ScopedOperation { get; }
        public ISingletonOperation SingletonOperation { get; }
        public OperationService(ITransientOperation TransientOperation, IScopedOperation ScopedOperation, ISingletonOperation SingletonOperation)
        {
            this.ScopedOperation = ScopedOperation;
            this.SingletonOperation = SingletonOperation;
            this.TransientOperation = TransientOperation;
        }
    }
}
