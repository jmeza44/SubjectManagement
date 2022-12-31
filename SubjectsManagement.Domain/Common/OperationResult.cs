namespace SubjectsManagement.Domain.Common
{
    public class OperationResult<T>
    {
        public string Message { get; set; } = "Not specified";
        public string Description { get; set; } = "Not specified";
        public T Result { get; set; }
    }
}
