namespace EMR.Extensions;

using EMR.Dto;
using Microsoft.AspNetCore.Mvc;
public static class EmrResponseExtensions
{


    // متد برای ارسال پاسخ‌های موفق
    public static IActionResult SuccessRes<TData>(TData data, int statusCode, MessagesDto? messages = null)
    {
        var response = new ApiSuccessResponse<TData>(data)
        {
            Messages = messages
        };

        // بسته به استاتوس کد، پاسخ مناسب را ارسال کنید
        return new ObjectResult(response) { StatusCode = statusCode };
    }

    // متد برای ارسال پاسخ‌های خطا
    public static IActionResult ErrorRes(int statusCode, MessagesDto messages)
    {
        var result = new ApiErrorResponse(messages)
        {
            Success = false,
        };

        return new ObjectResult(result)
        {
            StatusCode = statusCode
        };
    }
}

