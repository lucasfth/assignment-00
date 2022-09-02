namespace HelloWorld.Test;

public class ProgramTests
{
    [Fact]
    public void HelloWorld()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

         // Act
        var program = Assembly.Load(nameof(HelloWorld));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Hello, World!");
    }
}