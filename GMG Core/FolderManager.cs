using System.IO;

namespace GMG_Core
{
	public class FolderManager
	{
		public class Folder
		{
			public Folder(string path)
			{
				this.Path = path;
			}

			public Folder(string path, bool create)
			{
				this.Path = path;
				if (create)
				{
					this.CreateFolder();
				}
			}

			public string Path { get; }

			public override string ToString()
			{
				return this.Path;
			}

			public bool Exists { get { return Directory.Exists(this.Path); } }

			public string CreateFolder()
			{
				if (!this.Exists)
				{
					Directory.CreateDirectory(this.Path);
				}

				return this.Path;
			}
		}

		public void CreateFolders(Folder[] folders)
		{
			foreach (Folder folder in folders)
			{
				folder.CreateFolder();
			}
		}
	}
}
