
using Xunit;
namespace AzureUnitTesting
{
    public class AzureFunctionTest
    {

        [Theory]
        [InlineData("Hello World!")]
        public void IsHelloWordPass(string data)
        {
            Assert.NotEmpty(data);
            Assert.Equal("Hello World!",data);
        }

        [Theory]
        [InlineData("")]
        public void IsHelloWordFail(string data)
        {
            Assert.Empty(data);
            Assert.NotEqual("Hello World!",data);
        }
    }
}