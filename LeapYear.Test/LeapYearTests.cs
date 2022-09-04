namespace LeapYear.Test;

public class UnitTest1
{
    [Fact]
    public void If2020ThenFalse()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

         // Act
        var program = Assembly.Load(nameof(LeapYear));
        program.EntryPoint?.Invoke(null, new[] { new string[] {"2020"}});

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("False");
    }

    [Fact]
    public void If2000ThenTrue()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

         // Act
        var program = Assembly.Load(nameof(LeapYear));
        program.EntryPoint?.Invoke(null, new[] { new string[] {"2000"}});

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("True");
    }

    [Fact]
    public void If1600ThenTrue()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

         // Act
        var program = Assembly.Load(nameof(LeapYear));
        program.EntryPoint?.Invoke(null, new[] { new string[] {"1600"}});

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("True");
    }


    [Fact]
    public void If1900ThenFalse()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

         // Act
        var program = Assembly.Load(nameof(LeapYear));
        program.EntryPoint?.Invoke(null, new[] { new string[] {"1900"}});

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("False");
    }

    [Fact]
    public void If1800ThenFalse()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

         // Act
        var program = Assembly.Load(nameof(LeapYear));
        program.EntryPoint?.Invoke(null, new[] { new string[] {"1800"}});

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("False");
    }

    [Fact]
    public void If1700ThenTrue()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

         // Act
        var program = Assembly.Load(nameof(LeapYear));
        program.EntryPoint?.Invoke(null, new[] { new string[] {"1700"}});

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("False");
    }

    [Fact]
    public void IfLessThan1582ThenFalse()
    {
        for (int i = 0; i < 1582; i++)
        {
            // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

         // Act
        var program = Assembly.Load(nameof(LeapYear));
        program.EntryPoint?.Invoke(null, new[] { new string[] {i + ""}});

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("False");
        }
    }
}