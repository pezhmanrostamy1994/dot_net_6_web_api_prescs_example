namespace EMR.Dto;

using EMR.Models.Enums;





public class MessageDto
{
    public string? Msg { get; set; }
    public MessageTypeEnum? Type { get; set; }

}
public class MessagesDto
{
    public List<MessageDto> MessagesList { get; set; }

    public MessagesDto()
    {
        MessagesList = new List<MessageDto>();
    }
}

