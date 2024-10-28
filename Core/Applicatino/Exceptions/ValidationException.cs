using System;

namespace Applicatino.Exceptions;

public class ValidationException:Exception
{
    public ValidationException():this("validation error ")
    {
        
    }
    public ValidationException(String Message):base(Message)
    {
        
    }
    public ValidationException(Exception ex):this(ex.Message)
    {
        
    }

}
