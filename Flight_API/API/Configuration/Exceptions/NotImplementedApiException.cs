
using API.Configuration.Exceptions;

namespace mvc.Configurations.Exceptions;

public class NotImplementedApiException : ApiException
{
    public NotImplementedApiException() : base() { }

    public NotImplementedApiException(string message) : base(message)
    {
    }
}