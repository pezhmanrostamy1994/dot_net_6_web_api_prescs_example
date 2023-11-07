// using Microsoft.AspNetCore.Mvc.Testing;
// using Microsoft.VisualStudio.TestTools.UnitTesting;

// namespace MyApiTests
// {
//     [TestClass]
//     public class CityTest
//     {
//         private readonly HttpClient _client;

//         public CityTest()
//         {
//             // راه‌اندازی وب اپلیکیشن فکتوری برای تست
//             var appFactory = new WebApplicationFactory<Program>();
//             _client = appFactory.CreateClient();
//         }

//         [TestMethod]
//         public async Task PostUser_ReturnsSuccessStatusCode()
//         {
//             // Act
//             var response = await _client.GetAsync("/api/cities");

//             // Assert
//             response.EnsureSuccessStatusCode(); // بررسی برای داشتن استاتوس کد موفقیت‌آمیز
//         }
//     }
// }