using System;
using System.Windows.Forms;

try {
	OpenFileDialog ofd = new();
	Console.WriteLine("showing OFD...");
	ofd.ShowDialog();
	Console.WriteLine(ofd.FileName);
} catch (Exception e) {
	Console.WriteLine($"caught {e}");
}
