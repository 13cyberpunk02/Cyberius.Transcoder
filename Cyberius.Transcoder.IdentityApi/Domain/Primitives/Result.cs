namespace Cyberius.Transcoder.IdentityApi.Domain.Primitives;

public class Result
{
    public bool IsSucces { get; }
    public string? Error { get; }
    
    public static Result Success() => new(true, null);
    public static Result Failure(string error) => new(false, error);
    protected Result(bool isSuccess, string? error = null)
    {
        IsSucces = isSuccess;
        Error = error;
    }
}

public class Result<T> : Result
{
    public T? Value { get; }
    public static Result<T> Success(T value) => new Result<T>(true, value, null);
    public static new Result<T> Failure(string error) => new Result<T>(false, default, error);
    protected Result(bool isSuccess, T? value, string? error = null)
        : base(isSuccess, error)
    {
        Value = value;
    }
}
