using System;
using Xunit;
using IIG.PasswordHashingUtils;

namespace XUnitTestProject2 {
    public class UnitTest1 {

        [Fact]
        public void TestGetHash() {

            Assert.NotNull(PasswordHasher.GetHash("1111"));
            Assert.Equal(PasswordHasher.GetHash("1111"), PasswordHasher.GetHash("1111"));
            Assert.NotEqual(PasswordHasher.GetHash("1111"), PasswordHasher.GetHash("1111", "ww"));
            Assert.NotEqual(PasswordHasher.GetHash("1111"), PasswordHasher.GetHash("1111",null,123));

        }

        [Fact]
        public void TestInit() {
           

            String a = PasswordHasher.GetHash("1111");
            PasswordHasher.Init("wsd", 5);
            Assert.NotEqual( a, PasswordHasher.GetHash("1111"));

            PasswordHasher.Init("wsd", 0);
            Assert.Equal(PasswordHasher.GetHash("1111"), PasswordHasher.GetHash("1111"));

            PasswordHasher.Init(null, 6);
            Assert.Equal(PasswordHasher.GetHash("1111"), PasswordHasher.GetHash("1111"));

            a = PasswordHasher.GetHash("1111");
            PasswordHasher.Init(null, 6);
            Assert.Equal(a, PasswordHasher.GetHash("1111"));



        }


        [Fact]
        public void TestInit2()
        {
            PasswordHasher.Init("wsd", 0);
            Assert.Equal(PasswordHasher.GetHash("1111"), PasswordHasher.GetHash("1111"));
            PasswordHasher.Init("wsd", 4294967295);
            Assert.Equal(PasswordHasher.GetHash("1111"), PasswordHasher.GetHash("1111"));
        }

        }
}

