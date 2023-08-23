namespace Educate.Service.Helpers;

public class Response<T>
{
    public int StatusCode { get; set; }
    public string Message { get; set; } = default!;
    public T? Data { get; set; } = default!;
}
