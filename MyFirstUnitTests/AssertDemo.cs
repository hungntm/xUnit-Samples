using System.Threading.Tasks;
using System;
using Xunit;

namespace MyFirstUnitTests
{
    public class AssertDemo
    {
        [Fact]
        public async Task AssertsDemo()
        {
            // Any values
            int value = 0;
            Assert.Equal(42, value);
            Assert.NotEqual(42, value);

            // Boolean
            bool b = true;
            Assert.True(b, "b should be true");
            Assert.False(b, "b should be false");

            // Strings
            var str = "";
            Assert.Equal("", str, ignoreCase: false, ignoreLineEndingDifferences: false, ignoreWhiteSpaceDifferences: false);
            Assert.StartsWith("prefix", str, StringComparison.Ordinal);
            Assert.EndsWith("suffix", str, StringComparison.Ordinal);
            Assert.Matches("[0-9]+", str);

            // Collections
            var collection = new[] { 1, 2, 3 };
            Assert.Empty(collection);
            Assert.NotEmpty(collection);
            Assert.Single(collection); // Contains only 1 item
            Assert.Single(collection, item => item == 1); // Contains only 1 item
            Assert.Equal(new int[] { 1, 2, 3 }, collection);
            Assert.Contains(0, collection);
            Assert.Contains(collection, item => item == 1);

            // Assert each items of the collection match the condition
            Assert.All(collection, item => Assert.InRange(item, low: 0, high: 10));

            // Assert the collection contains 3 items and the items match the conditions (in the declared order)
            Assert.Collection(collection,
                            item => Assert.Equal(1, item),
                            item => Assert.Equal(2, item),
                            item => Assert.Equal(3, item));

            // Exceptions
            var ex1 = Assert.Throws<Exception>(() => Console.WriteLine()); // Return the thrown exception
            var ex2 = await Assert.ThrowsAsync<Exception>(() => Task.FromResult(1)); // Return the thrown exception
            Assert.Equal("message", ex1.Message);

        }
    }
}
