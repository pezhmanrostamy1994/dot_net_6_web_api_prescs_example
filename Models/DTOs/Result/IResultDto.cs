namespace EMR.Dto;


public class ResultDto<T>
{
    public T? Data { get; set; }
    public MessagesDto? Messages { get; set; } = new MessagesDto() { };
}
