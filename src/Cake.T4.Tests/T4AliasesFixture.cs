/*
 * MIT License
 *
 * Copyright (c) 2020 Kim J. Nordmo
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

namespace Cake.T4.Tests
{
	using System.Collections.Generic;
	using System.Linq;
	using Cake.Core;
	using Cake.Core.IO;
	using Cake.Testing;
	using Cake.Testing.Fixtures;
	using Moq;

	public class T4AliasesFixture : T4RunnerFixture
	{
		internal ICakeContext _context;

		public T4AliasesFixture()
		{
			var argumentsMoq = new Mock<ICakeArguments>();
			var registryMoq = new Mock<IRegistry>();
			var dataService = new Mock<ICakeDataService>();
			_context = new CakeContext(
				FileSystem,
				Environment,
				Globber,
				new FakeLog(),
				argumentsMoq.Object,
				ProcessRunner,
				registryMoq.Object,
				Tools,
				dataService.Object,
				Configuration);
		}

		protected override void RunTool()
		{
			if (Settings == null)
			{
				T4Aliases.T4(_context);
			}
			else
			{
				T4Aliases.T4(_context, Settings);
			}
		}
	}
}
