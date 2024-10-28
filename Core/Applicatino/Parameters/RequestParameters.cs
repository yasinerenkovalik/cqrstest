using System;

namespace Applicatino.Parameters;

public class RequestParameters
{
    public int PageSize { get; set; }
    public int PageNumber { get; set; }
    public RequestParameters(int pageNumber,int pageSize)
    {
        PageNumber=pageNumber;
        PageSize=pageSize;
    }

}
