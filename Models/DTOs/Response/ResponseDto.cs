namespace EMR.Dto;


public class ApiResponse
{
    public bool Success { get; set; }
    public object? Data { get; set; }
    public MessagesDto? Messages { get; set; }
}

public class ApiErrorResponse : ApiResponse
{
    public ApiErrorResponse(MessagesDto messages)
    {
        Data = null;
        Messages = messages;
    }
}

public class ApiSuccessResponse<TData> : ApiResponse
{
    public ApiSuccessResponse(TData data, MessagesDto? messages = null)
    {
        Success = true;
        Data = data;
        Messages = messages ?? new MessagesDto();
    }
}

