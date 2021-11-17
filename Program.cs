using System;
using System.Windows.Forms;

#if true
// new, more troubling repro

try {
	FolderBrowserDialog fbd = new();
	Console.WriteLine("showing FBD...");
	fbd.ShowDialog();
	Console.WriteLine(fbd.FileName);
} catch (Exception e) {
	Console.WriteLine($"caught {e}");
}

#else
// initial repro

try {
	OpenFileDialog ofd = new();
	Console.WriteLine("showing OFD...");
	ofd.ShowDialog();
	Console.WriteLine(ofd.FileName);
} catch (Exception e) {
	Console.WriteLine($"caught {e}");
}

#endif
