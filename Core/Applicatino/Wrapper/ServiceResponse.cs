using System;

namespace Applicatino.Wrapper;

public class ServiceResponse<T>
{
    public T Value { get; set; }
    public ServiceResponse(T value)
    {
        Value=value;
    }
    public ServiceResponse()
    {
        
    }

}
