using System.Collections;

namespace SubjectsManagement.Domain.Common
{
    public class OperationResult<T>
    {
        public string Message { get; set; } = "Not specified";
        public string Description { get; set; } = "Not specified";
        public T Result { get; set; }
    }
    public class AddedOperationResult<T> : OperationResult<T>
    {
        public AddedOperationResult(T result, string entity)
        {
            Result = result;
            if (Result != null)
            {
                Message = "Success";
                Description = $"{entity} added propertly";
            }
            else
            {
                Message = "Error";
                Description = $"{entity} couldn't be added";
            }
        }
    }
    public class DeletedOperationResult<T> : OperationResult<T>
    {
        public DeletedOperationResult(T result, string entity, int id)
        {
            Result = result;
            if (Result != null)
            {
                Message = "Success";
                Description = $"{entity} with id {id} deleted propertly";
            }
            else
            {
                Message = "Error";
                Description = $"{entity} with id {id} couldn't be found";
            }
        }
    }
    public class GetAllOperationResult<T> : OperationResult<T>
    {
        public GetAllOperationResult(T result, string entity, int count)
        {
            Result = result;
            if (Result != null)
            {
                Message = "Success";
                Description = $"{count} {entity}(s) retrieved propertly";
            }
        }
    }
    public class GetOperationResult<T> : OperationResult<T>
    {
        public GetOperationResult(T result, string entity, int id)
        {
            Result = result;
            if (Result != null)
            {
                Message = "Success";
                Description = $"{entity} with id {id} found";
            }
            else
            {
                Message = "Error";
                Description = $"{entity} with id {id} couldn't be found";
            }
        }
    }
    public class UpdateOperationResult<T> : OperationResult<T>
    {
        public UpdateOperationResult(T result, string entity, int id)
        {
            Result = result;
            if (Result != null)
            {
                Message = "Success";
                Description = $"{entity} updated propertly";
            }
            else
            {
                Message = "Error";
                Description = $"{entity} with id {id} couldn't be found";
            }
        }
    }
}
