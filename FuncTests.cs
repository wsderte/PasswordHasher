using System;
using Xunit;
using IIG.PasswordHashingUtils;

namespace XUnitTestProject2 {
    //покрытие значений параметров — все ли типовые и граничные значения параметров были проверены.
    //покрытие условий — каждая ли точка решения вычисления истинно ли или ложно выражение
    // была выполнена и протестирована;
    //
    
    public class HashFuncTests
    {
        // начнем с покрытия значений параметров 
        //  а именно проверив все ли типовые и граничные значения параметров были проверены

        // граничные значения ИНИТ  с 0 по  4294967295
        // потому возьмем значения  0 1  и   4294967294  4294967295   а также по середине 22
 

        [Fact]
        public void TestInit_0(){
           PasswordHasher.Init("", 0);
            Assert.NotNull(PasswordHasher.GetHash(""));

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
        public void TestInit_mark()
        {
            PasswordHasher.Init("32awdawd###", 22);
            Assert.NotNull(PasswordHasher.GetHash(""));

        }



        //покрытие условий — каждая ли точка решения вычисления истинно ли или ложно выражение
        // была выполнена и протестирована;
        [Fact]
        public void TestInit_IsNull()
        {
            PasswordHasher.Init(null, 22);
            Assert.NotNull(PasswordHasher.GetHash(""));


        }

        [Fact]
        public void TestInit_IsEmpty()
        {
            PasswordHasher.Init("", 22);
            Assert.NotNull(PasswordHasher.GetHash(""));


        }

        [Fact]
        public void TestInit_adlerMod32MoreThan0()
        {
            PasswordHasher.Init("ww", 0);
            String a = PasswordHasher.GetHash("www");
            PasswordHasher.Init("ww", 22);
            Assert.NotEqual(a, PasswordHasher.GetHash("www"));

        }

        [Fact]
        public void TestInit_adlerMod32MoreThan0ButOneSymbolIsGetting()
        {
            PasswordHasher.Init("ww", 0);
            String a = PasswordHasher.GetHash("w");
            PasswordHasher.Init("ww", 22);
            Assert.NotEqual(a, PasswordHasher.GetHash("w"));


        }





    }
}

