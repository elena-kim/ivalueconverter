using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IValueConverterSample.ViewModels
{
	public class MainViewModel
	{
		public List<FileInfo> Files { get; set; }

		public MainViewModel()
		{
			InitFileList();
		}

		private void InitFileList()
		{
			Files = Directory.GetFiles(Environment.CurrentDirectory).Select(x => new FileInfo(x)).ToList();
		}
	}
}
