using System;
using Xunit;
using IIG.PasswordHashingUtils;

namespace XUnitTestProject2 {
   
    
    public class HashFuncTests {
        const string passsword  = "111111111wwwww1";
        const string salt = "awar32rn129mfnsadd";

        [Fact]
        public void TestInit_AdlerMod32_0(){
           PasswordHasher.Init(salt, 0);
            Assert.Equal(PasswordHasher.GetHash(passsword), PasswordHasher.GetHash(passsword));

        }
        
        [Fact]
        public void TestInit_AdlerMod32_1() {
            PasswordHasher.Init(salt, 1);
            Assert.NotNull(PasswordHasher.GetHash(passsword));

        }

        [Fact]
        public void TestInit_AdlerMod32_4294967295() {
            PasswordHasher.Init(salt, 4294967295);
            Assert.NotNull(PasswordHasher.GetHash(passsword));

        }

        [Fact]
        public void TestInit_AdlerMod32_4294967294()  {
            PasswordHasher.Init(salt, 4294967294);
            Assert.NotNull(PasswordHasher.GetHash(passsword));

        }

        [Fact]
        public void TestInit_AdlerMod32_22()  {
            PasswordHasher.Init(salt, 22);
            Assert.NotNull(PasswordHasher.GetHash(passsword));

        }


        [Fact]
        public void TestGetHash_AdlerMod32_0()
        {

            Assert.Equal(PasswordHasher.GetHash( passsword, null, 0), PasswordHasher.GetHash(passsword, null, 0));

        }

        [Fact]
        public void TestGetHash_AdlerMod32_1()
        {

            Assert.Equal(PasswordHasher.GetHash(passsword, null, 1), PasswordHasher.GetHash(passsword, null, 1));

        }

        [Fact]
        public void TestGetHash_AdlerMod32_4294967294()
        {
            Assert.Equal(PasswordHasher.GetHash(passsword, null, 4294967294), PasswordHasher.GetHash(passsword, null, 4294967294));

        }

        [Fact]
        public void TestGetHash_AdlerMod32_4294967295()
        {

            Assert.Equal(PasswordHasher.GetHash(passsword, null, 4294967295), PasswordHasher.GetHash(passsword, null, 4294967295));

        }

        [Fact]
        public void TestGetHash_AdlerMod32_22()
        {

            Assert.Equal(PasswordHasher.GetHash(passsword, null, 22), PasswordHasher.GetHash(passsword, null, 22));

        }

        [Fact]
        public void TestGetHash_passwordEmpty()
        {

            Assert.Equal(PasswordHasher.GetHash("", null, 22), PasswordHasher.GetHash("", null, 22));

        }

        [Fact]
        public void TestGetHash_passwordNull()
        {
            Assert.Equal(PasswordHasher.GetHash(null, null, 22), PasswordHasher.GetHash(null, null, 22));

        }

        [Fact]
        public void TestInit_IfSalt_IsNull()
        {
            String a = PasswordHasher.GetHash(passsword);
            PasswordHasher.Init(null, 0);
            Assert.Equal(PasswordHasher.GetHash(passsword), a);

        }

        [Fact]
        public void TestInit_IfSalt_IsEmpty()
        {
            String a = PasswordHasher.GetHash(passsword);
            PasswordHasher.Init("", 0);
            Assert.Equal(PasswordHasher.GetHash(passsword), a);
            
        }

        [Fact]
        public void TestInit_IfAdlerMod32_0AndMoreThan0_NotEqual()
        {
            PasswordHasher.Init(salt, 0);
            String a = PasswordHasher.GetHash(passsword);
            PasswordHasher.Init(salt, 22);
            Assert.NotEqual(PasswordHasher.GetHash(passsword),a);

        }


    }
}

