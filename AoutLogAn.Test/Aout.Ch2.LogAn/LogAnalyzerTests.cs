// 
// LogAnalyzerTests.cs
//  
// Author:
//       Leezhm <leezhm@126.com>
//             
// Copyright (c) 2012 leezhm@126.com
// 
// Created:
//       Leezhm <12-4-28 上1:54>
// 
// Modified:
//       Leezhm <12-4-28 上1:54>
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
// 
// 
// 
using System;
using NUnit.Framework;

namespace AoutLogAn.Test
{
	[TestFixture]
	public class LogAnalyzerTests
	{
		/// <summary>
		/// Declare a member of variant
		/// </summary>
		private LogAnalyzer mAnalyzer = null;
		[SetUp]
		public void Setup ()
		{
			mAnalyzer = new LogAnalyzer ();
		}
		
		[TearDown]
		public void TearDown ()
		{
			mAnalyzer = null;
		}
		
		[Test]
		public void IsValidLogFileName_ValidFileLowercase_ReturnTrue()
		{
			// act
			bool result = mAnalyzer.IsValidLogFileName("whatever.slf");
			
			// assert
			Assert.IsTrue (result, "File should be valid ... ");
		}
		
		[Test]
		public void IsExistLogFilePath_ValidFilePath_ReturnTrue ()
		{
			// act
			bool result = mAnalyzer.IsExistLogFilePath ("whatever.slf");
			
			// assert
			Assert.IsTrue (result, "File should be exist ... ");
		}
		
		[Test]
		[ExpectedException(typeof(ArgumentException), ExpectedMessage="No FileName Provided ...")]
		public void IsValidLogFileName_EmptyFileName_ThrowException ()
		{
			mAnalyzer.IsValidLogFileName (string.Empty);
		}
		
		[Test]
		[ExpectedException(typeof(ArgumentException), ExpectedMessage="No FilePath Provided ...")]
		public void IsExistLogFilePath_EmptyFilePath_ThrowException ()
		{
			mAnalyzer.IsExistLogFilePath (string.Empty);
		}
		
		[Test]
		[Ignore("Ignore current test function ...")]
		public void IgnoreTestingFunction ()
		{
		}
		
		[Test]
		[Category("For Learning")]
		public void ForLearning ()
		{
			
		}
	}
}

