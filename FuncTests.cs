using System;
using Xunit;
using IIG.PasswordHashingUtils;

namespace XUnitTestProject2 {
    //�������� �������� ���������� � ��� �� ������� � ��������� �������� ���������� ���� ���������.
    //�������� ������� � ������ �� ����� ������� ���������� ������� �� ��� ����� ���������
    // ���� ��������� � ��������������;
    //
    
    public class HashFuncTests
    {
        // ������ � �������� �������� ���������� 
        //  � ������ �������� ��� �� ������� � ��������� �������� ���������� ���� ���������

        // ��������� �������� ����  � 0 ��  4294967295
        // ������ ������� ��������  0 1  �   4294967294  4294967295   � ����� �� �������� 22
 

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



        //�������� ������� � ������ �� ����� ������� ���������� ������� �� ��� ����� ���������
        // ���� ��������� � ��������������;
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

