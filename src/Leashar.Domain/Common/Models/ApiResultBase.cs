using Newtonsoft.Json;

namespace Leashar.Domain.Common.Models;

public abstract class ApiResultBase
{
    [JsonConstructor]
    public ApiResultBase(bool isSuccess)
    {
        IsSuccess = isSuccess;
    }
    public bool IsSuccess { get; set; }
}