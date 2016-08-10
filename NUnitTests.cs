using System;
using System.Threading;
using NUnit.Framework;

namespace NUnitTests
{
	[TestFixture]
	public class InconclusiveTestFixture
	{
		public void Test()
		{
		}
	}

	[TestFixture]
	public class NotRunnableTestFixture
	{
		internal NotRunnableTestFixture()
		{

		}

		[Test]
		public void Test1()
		{
			
		}
	}

	[TestFixture]
	public class NUnitTests
	{
		[TestFixture]
		public class DerivedFixture
		{
			[SetUp]
			public void Setup()
			{

			}
			[Test]
			public void Test()
			{
			}
		}

		[Test]
		public void FailedTest()
		{
			Assert.AreEqual(1, 0);
		}


		[Test]
		public void ErrorTest()
		{
			throw new Exception("ERROR!!! interrupted");
			Assert.AreEqual(1, 0);
		}

		[Test]
		[Ignore("Test is unstable")]
		public void Ignored()
		{
			Assert.AreEqual(1, 0);
		}

		[Test]
		public void CancelledTest()
		{
			// need to run nunit with /timeout=10
			Thread.Sleep(11);
			Assert.AreEqual(1, 1);
		}

		[Test]
		[Platform("Linux")]
		public void Skipped()
		{
			Assert.That(1, Is.EqualTo(1));
		}

		[Test]
		public void SuccessfullTest()
		{
			Assert.AreEqual(1, 1);
		}

		[Test]
		public void InconclussiveTest()
		{
			Assert.Inconclusive("Inconclusive Test");
		}

		[TestCase(1, 1)]
		[TestCase(2, 3)]
		public void ParameterizedTest(int a, int b)
		{
			Assert.AreEqual(a, b);
		}

		static object[] DivideCases =
		{
			new object[] { 12, 3, 4 },
			new object[] { 12, 2, 6 },
			new object[] { 12, 4, 3 }
		};

		[Test, TestCaseSource("DivideCases")]
		public void TestWithTestSource(int n, int d, int q)
		{
			Assert.AreEqual(q, n / d);
		}

		[Test]
		public void InvalidTestCase(int n, int d, int q)
		{
			Assert.AreEqual(q, n / d);
		}
	}
}
