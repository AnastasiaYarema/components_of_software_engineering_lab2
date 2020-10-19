using System;
using Xunit;

namespace Lab2
{
    public class UnitTest1
    {
        [Fact]
        public void ConstructorNormalRun()
        {
            bool expected = false;

            IIG.BinaryFlag.MultipleBinaryFlag mbf = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
            bool actual = mbf.GetFlag();

            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ConstructorNormalRunWithTrue()
        {
            bool expected = true;

            IIG.BinaryFlag.MultipleBinaryFlag mbf = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            bool actual = mbf.GetFlag();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConstructorMaxLength()
        {
            bool expected = false;

            IIG.BinaryFlag.MultipleBinaryFlag mbf = new IIG.BinaryFlag.MultipleBinaryFlag(17179868703, false);
            bool actual = mbf.GetFlag();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetFlagReturnsTrue()
        {
            bool expected = true;

            IIG.BinaryFlag.MultipleBinaryFlag mbf = new IIG.BinaryFlag.MultipleBinaryFlag(100, false);
            for(ulong i = 0; i < 100; i++)
            {
                mbf.SetFlag(i);
            }
            bool actual = mbf.GetFlag();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetFlagExceeedsLength()
        {
            bool expected = true;

            IIG.BinaryFlag.MultipleBinaryFlag mbf = new IIG.BinaryFlag.MultipleBinaryFlag(100, false);
            mbf.SetFlag(999999);
            bool actual = mbf.GetFlag();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ResetFlagReturnsFalse()
        {
            bool expected = false;

            IIG.BinaryFlag.MultipleBinaryFlag mbf = new IIG.BinaryFlag.MultipleBinaryFlag(100, false);
            for (ulong i = 0; i < 100; i++)
            {
                mbf.ResetFlag(i);
            }
            bool actual = mbf.GetFlag();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ResetFlagExceedsLength()
        {
            bool expected = true;

            IIG.BinaryFlag.MultipleBinaryFlag mbf = new IIG.BinaryFlag.MultipleBinaryFlag(3, false);
            mbf.ResetFlag(999999);
            bool actual = mbf.GetFlag();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConstructorExceedMaxLength()
        {
            bool expected = false;
            IIG.BinaryFlag.MultipleBinaryFlag mbf = new IIG.BinaryFlag.MultipleBinaryFlag(9999999999999999999, false);
            bool actual = mbf.GetFlag();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ConstructorMinLengthRun()
        {
            bool expected = false;

            IIG.BinaryFlag.MultipleBinaryFlag mbf = new IIG.BinaryFlag.MultipleBinaryFlag(1, false);
            bool actual = mbf.GetFlag();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetFlagExceedsLength()
        {
            bool expected = false;
            
            IIG.BinaryFlag.MultipleBinaryFlag mbf = new IIG.BinaryFlag.MultipleBinaryFlag(99, false);
            for (ulong i = 10; i < 999; i++)
            {
                mbf.SetFlag(i);
            }

            bool actual = mbf.GetFlag();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SetFlag1000ReturnsTrue()
        {
            bool expected = true;

            IIG.BinaryFlag.MultipleBinaryFlag mbf = new IIG.BinaryFlag.MultipleBinaryFlag(1000, false);
            for (ulong i = 0; i < 1000; i++)
            {
                mbf.SetFlag(i);
            }

            bool actual = mbf.GetFlag();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ResetFlagNotAllReturnsFalse()
        {
            bool expected = false;
            
            IIG.BinaryFlag.MultipleBinaryFlag mbf = new IIG.BinaryFlag.MultipleBinaryFlag(99, true);
            for (ulong i = 0; i < 9; i++)
            {
                mbf.ResetFlag(i);
            }

            bool actual = mbf.GetFlag();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetFlagReturnsFalse()
        {
            bool expected = false;

            IIG.BinaryFlag.MultipleBinaryFlag mbf = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
            mbf.SetFlag(1);

            bool actual = mbf.GetFlag();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetFlagRerunsFalseFromStart()
        {
            bool expected = false;

            IIG.BinaryFlag.MultipleBinaryFlag mbf = new IIG.BinaryFlag.MultipleBinaryFlag(1000, false);
            for (ulong i = 1; i < 1000; i++)
            {
                mbf.SetFlag(i);
            }

            bool actual = mbf.GetFlag();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetFlagWithOnlyOneSetFlagReturnFalse()
        {
            bool expected = false;

            IIG.BinaryFlag.MultipleBinaryFlag mbf = new IIG.BinaryFlag.MultipleBinaryFlag(1000, false);
            mbf.SetFlag(300);

            bool actual = mbf.GetFlag();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OneResetFlagReturnToAllFlagsFalse()
        {
            bool expected = false;

            IIG.BinaryFlag.MultipleBinaryFlag mbf = new IIG.BinaryFlag.MultipleBinaryFlag(1000, true);
            mbf.ResetFlag(999);

            bool actual = mbf.GetFlag();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckOnlyOneSetFlagOnWholeLength()
        {
            bool expected = false;

            IIG.BinaryFlag.MultipleBinaryFlag mbf = new IIG.BinaryFlag.MultipleBinaryFlag(1000, false);
            mbf.SetFlag(0);

            bool actual = mbf.GetFlag();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckForEqualityAlmostSame()
        {
            bool expected = false;

            IIG.BinaryFlag.MultipleBinaryFlag mbf1 = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
            IIG.BinaryFlag.MultipleBinaryFlag mbf2 = new IIG.BinaryFlag.MultipleBinaryFlag(2, false);
            mbf1.SetFlag(1);

            bool actual = mbf1.Equals(mbf2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckForEqualityAlmostSameBigger()
        {
            bool expected = false;

            IIG.BinaryFlag.MultipleBinaryFlag mbf1 = new IIG.BinaryFlag.MultipleBinaryFlag(100000, false);
            IIG.BinaryFlag.MultipleBinaryFlag mbf2 = new IIG.BinaryFlag.MultipleBinaryFlag(100000, false);
            mbf1.SetFlag(14567);

            bool actual = mbf1.Equals(mbf2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckSameWithEqualsReturnsTrue()
        {
            bool expected = true;

            IIG.BinaryFlag.MultipleBinaryFlag mbf1 = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            IIG.BinaryFlag.MultipleBinaryFlag mbf2 = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);

            bool actual = mbf1.Equals(mbf2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckSameWithEqualsOnSameReturnsTrue()
        {
            bool expected = true;

            IIG.BinaryFlag.MultipleBinaryFlag mbf1 = new IIG.BinaryFlag.MultipleBinaryFlag(5, false);
            IIG.BinaryFlag.MultipleBinaryFlag mbf2 = new IIG.BinaryFlag.MultipleBinaryFlag(5, false);

            bool actual = mbf1.Equals(mbf2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EqualsOnEqualObjectReturnsTrue()
        {
            bool expected = true;

            IIG.BinaryFlag.MultipleBinaryFlag mbf1 = new IIG.BinaryFlag.MultipleBinaryFlag(1000000, true);
            IIG.BinaryFlag.MultipleBinaryFlag mbf2 = new IIG.BinaryFlag.MultipleBinaryFlag(1000000, true);

            bool actual = mbf1.Equals(mbf2);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void EqualsOnSameRefReturnsTrue()
        {
            bool expected = true;

            IIG.BinaryFlag.MultipleBinaryFlag mbf1 = new IIG.BinaryFlag.MultipleBinaryFlag(2, true);
            IIG.BinaryFlag.MultipleBinaryFlag mbf2 = mbf1;

            bool actual = mbf1.Equals(mbf2);

            Assert.Equal(expected, actual);
        }
    }
}
