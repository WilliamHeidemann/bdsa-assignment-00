namespace HelloWorld.Test;

public class LeapYearTests
{
    [Fact]
    public void theYear2000IsLeapYear()
    {
        var leapYear = new LeapYear();
        bool output = leapYear.IsLeapYear(2000);
        output.Should().Be(true);
    }
    
    [Fact]
    public void theYear1900IsNotLeapYear()
    {
        var leapYear = new LeapYear();
        bool output = leapYear.IsLeapYear(1900);
        output.Should().Be(false);
    }

    [Fact]
    public void theYear2004IsLeapYear()
    {
        var leapYear = new LeapYear();
        bool output = leapYear.IsLeapYear(2004);
        output.Should().Be(true);
    }
    
    [Fact]
    public void theYear1929IsNotLeapYear()
    {
        var leapYear = new LeapYear();
        bool output = leapYear.IsLeapYear(1929);
        output.Should().Be(false);
    }


    [Fact]
    public void theYear1234IsNotLeapYear()
    {
        var leapYear = new LeapYear();
        bool output = leapYear.IsLeapYear(1234);
        output.Should().Be(false);
    }

    
    
}