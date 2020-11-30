using System;
using Xunit;
using IIG.PasswordHashingUtils;

namespace XUnitTestProject2 {
   
    
    public class HashFuncTests {

        [Fact]
        public void TestInit_0(){
           PasswordHasher.Init("", 0);
            Assert.Equal(PasswordHasher.GetHash(""), PasswordHasher.GetHash(""));

        }
        
        [Fact]
        public void TestInit_1() {
            PasswordHasher.Init("", 1);
            Assert.NotNull(PasswordHasher.GetHash(""));

        }

        [Fact]
        public void TestInit_4294967295() {
            PasswordHasher.Init("", 4294967295);
            Assert.NotNull(PasswordHasher.GetHash(""));

        }

        [Fact]
        public void TestInit_4294967294()  {
            PasswordHasher.Init("", 4294967294);
            Assert.NotNull(PasswordHasher.GetHash(""));

        }

        [Fact]
        public void TestInit_22()  {
            PasswordHasher.Init("", 22);
            Assert.NotNull(PasswordHasher.GetHash(""));

        }


        [Fact]
        public void TestGet_0()
        {
            PasswordHasher.Init("", 22);

            Assert.Equal(PasswordHasher.GetHash("1111", null, 0), PasswordHasher.GetHash("1111", null, 0));

        }

        [Fact]
        public void TestGet_1()
        {
            PasswordHasher.Init("", 22);

            Assert.Equal(PasswordHasher.GetHash("1111", null, 1), PasswordHasher.GetHash("1111", null, 1));

        }

        [Fact]
        public void TestGet_4294967294()
        {
            PasswordHasher.Init("", 22);
            Assert.Equal(PasswordHasher.GetHash("1111", null, 4294967294), PasswordHasher.GetHash("1111", null, 4294967294));

        }


        [Fact]
        public void TestGet_4294967295()
        {
            PasswordHasher.Init("", 22);

            Assert.Equal(PasswordHasher.GetHash("1111", null, 4294967295), PasswordHasher.GetHash("1111", null, 4294967295));

        }

        [Fact]
        public void TestGet_22()
        {
            PasswordHasher.Init("", 22);

            Assert.Equal(PasswordHasher.GetHash("1111", null, 22), PasswordHasher.GetHash("1111", null, 22));

        }

        [Fact]
        public void TestGet_passwordEmpty()
        {
            PasswordHasher.Init("", 22);

            Assert.Equal(PasswordHasher.GetHash("", null, 22), PasswordHasher.GetHash("", null, 22));

        }

        [Fact]
        public void TestGet_passwordNull()
        {
            PasswordHasher.Init("", 22);

            Assert.Equal(PasswordHasher.GetHash(null, null, 22), PasswordHasher.GetHash(null, null, 22));

        }



        [Fact]
        public void TestInit_IsNull()
        {
            PasswordHasher.Init(null, 22);
            String a = PasswordHasher.GetHash("11111111111");
            PasswordHasher.Init("wwwwwwwwwwwww", 22);
            Assert.NotEqual(PasswordHasher.GetHash("11111111111"), a);


        }

        [Fact]
        public void TestInit_IsEmpty()
        {
            PasswordHasher.Init("", 22);
            String a = PasswordHasher.GetHash("11111111111");
            PasswordHasher.Init("wwwwwwwwwwwww", 22);
            Assert.NotEqual(PasswordHasher.GetHash("11111111111"), a);
            

        }

        [Fact]
        public void TestInit_ValueAdlerMod32MoreThan0ANd22()
        {
            PasswordHasher.Init("wwwwww", 0);
            String a = PasswordHasher.GetHash("wwwwwwww");
            PasswordHasher.Init("wwwwww", 22);
            Assert.NotEqual(PasswordHasher.GetHash("wwwwwwww"),a);

        }



    }
}

