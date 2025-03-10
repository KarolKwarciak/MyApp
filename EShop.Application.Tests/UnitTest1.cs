namespace EShop.Application.Tests;
using EShop.Application;

    public class UnitTest1
    {
        [Theory]
        [InlineData("1234")]
        [InlineData("123456789")]
        [InlineData("3213123")]
        public void ValidateCard_ReturnFalse_TooShort(string b)
        {
        var result = ValidateCard(b);
        Assert.Equal(False, result);
        }

        [Theory]
        [InlineData("12345678912347656765756757657")]
        [InlineData("1234567891234897879789595879789")]
        [InlineData("123456789123454353464564564563546")]

        public void ValidateCard_ReturnFalse_TooLong(string a)
        { 
        var result = ValidateCard(a);
        Assert.Equal(False, result);
        }


    [Theory]
        [InlineData("1234567891234")]
        [InlineData("1234567891234567")]
        [InlineData("12345678912345678")]
        public void ValidateCard_ReturnTrue(string s)
        {
        var result = ValidateCard(s);
        Assert.Equal(True, result);
        }
       
    }
