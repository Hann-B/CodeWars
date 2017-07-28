using AreWeAlternate;
using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private readonly Kata _kata;
        public UnitTest1()
        {
            _kata = new Kata();
        }

        [Fact]
        public void Amazon()
        {
            var rv = Kata.IsAlt("amazon");
            Assert.True(rv, "is alternating");
        }

        [Fact]
        public void Apple()
        {
            var rv = Kata.IsAlt("apple");
            Assert.False(rv, "is not alternating");
        }

        [Fact]
        public void App()
        {
            var rv = Kata.IsAlt("app");
            Assert.False(rv, "is not alternating");
        }

        [Fact]
        public void Aab()
        {
            var rv = Kata.IsAlt("aab");
            Assert.False(rv, "is not alternating");
        }

        [Fact]
        public void All()
        {
            var rv = Kata.IsAlt("all");
            Assert.False(rv, "is not alternating");
        }

        [Fact]
        public void Alea()
        {
            var rv = Kata.IsAlt("alea");
            Assert.False(rv, "is not alternating");
        }

        [Fact]
        public void Banana()
        {
            var rv = Kata.IsAlt("banana");
            Assert.True(rv, "is alternating");
        }
    }
}
