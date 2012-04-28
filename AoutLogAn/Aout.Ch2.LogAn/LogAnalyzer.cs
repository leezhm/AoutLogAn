// 
// LogAnalyzer.cs
//  
// Author:
//       Leezhm <leezhm@126.com>
//             
// Copyright (c) 2012 leezhm@126.com
// 
// Created:
//       Leezhm <12-4-28 上1:51>
// 
// Modified:
//       Leezhm <12-4-28 上1:51>
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

namespace AoutLogAn
{
	public class LogAnalyzer
	{
		public LogAnalyzer ()
		{
		}
		
		/// <summary>
		/// Determines whether this instance is valid log file name the specified fileName.
		/// </summary>
		/// <returns>
		/// <c>true</c> if this instance is valid log file name the specified fileName; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='fileName'>
		/// If set to <c>true</c> file name.
		/// </param>
		public bool IsValidLogFileName (string fileName)
		{
			if (String.IsNullOrEmpty (fileName)) {
				throw new ArgumentException("No FileName Provided ...");
			}
			
			if (!fileName.EndsWith (".slf")) {
				return false;
			}
			
			return true;
		}
		
		/// <summary>
		/// Determines whether this instance is exist log file the specified filePath.
		/// </summary>
		/// <returns>
		/// <c>true</c> if this instance is exist log file the specified filePath; otherwise, <c>false</c>.
		/// </returns>
		/// <param name='filePath'>
		/// If set to <c>true</c> file path.
		/// </param>
		public bool IsExistLogFilePath (string filePath)
		{
			if (String.IsNullOrEmpty (filePath)) {
				throw new ArgumentException ("No FilePath Provided ...");
			}
			
			if (!System.IO.File.Exists (filePath)) {
				return false;
			}
		
			return true;
		}
	}
}

