﻿using Newtonsoft.Json;

namespace Leashar.Domain.Common.Models;

public abstract class ApiResponseBase
{
    [JsonConstructor]
    public ApiResponseBase(bool isSuccess)
    {
        IsSuccess = isSuccess;
    }
    public bool IsSuccess { get; set; }
}

public class ApiSuccessResponse<T> : ApiResponseBase
{
    [JsonConstructor]
    public ApiSuccessResponse(T? data) : base(true)
    {
        Data = data;
    }
    public T? Data { get; set; }
}

public class ApiErrorResponse : ApiResponseBase
{
    [JsonConstructor]
    public ApiErrorResponse(List<string>? errors) : base(false)
    {
        Errors = errors;
    }
    public List<string>? Errors { get; set; }
}
