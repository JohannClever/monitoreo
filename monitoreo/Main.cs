using System;
using System.IO;
using System.Threading;

namespace monitoreo
{
	class MainClass
	{
		static bool _continue = true;
		public static void Main (string[] args)
		{
			FileSystemWatcher watcher = new FileSystemWatcher();
			watcher.Path = @"C:\Users\D2\Desktop\origen\";
			watcher.Filter = "*.txt";
			watcher.IncludeSubdirectories = false;
			watcher.Created += new FileSystemEventHandler(OnCreated);
			watcher.EnableRaisingEvents = true;
	
			while (_continue)		
			{
				Console.WriteLine("Monitoreando... ");
				Thread.Sleep(1000);	
			}
			
			
			
			Console.ReadKey(true);
		}

		static void OnCreated(object sender, FileSystemEventArgs e)		
		{
			Console.WriteLine("Se ha creado un fichero '{0}'", e.Name);
            Console.WriteLine("Continue");
			_continue = false;	
		}
	}
}




	

	
