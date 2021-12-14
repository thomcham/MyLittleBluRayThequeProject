using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO.Abstractions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLittleBluRayThequeProject.Helpers
{
    public class ApplicationHelper : IApplicationHelper
    {
        public const string VERSIONTABLENAME = "VersionInfo";
		public const string FILEDBNAME = "BluRayProject";
		public const string FILEGROUPNAME = "FileBluRayProject";
		public const string ASPNETCORE_ENVIRONMENT_VARIABLE_NAME = "ASPNETCORE_ENVIRONMENT";
		public const string LOGLEVEL_VARIABLE_NAME = "logLevel";
		public const int MAX_CONCURRENT_MESSAGE = 64;

		private const string ESEO = "Eseo";

		readonly IFileSystem fileSystem;

		public ApplicationHelper(IFileSystem fileSystem)
		{
			this.fileSystem = fileSystem;
			Type type = GetType();
		}

		#region méthodes

		public void EnsureDirectoriesExist(List<string> directories)
		{
			directories.ForEach(directoryPath =>
			{
				if (!string.IsNullOrEmpty(directoryPath) && !fileSystem.Directory.Exists(directoryPath))
				{
					fileSystem.Directory.CreateDirectory(directoryPath);
				}
			});
		}

		#endregion

		#region static

		public static string ProgramDataFolder => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), ESEO, "BluRayProject");



		// TODO : faire mieux
		public static string GetConnectionString() {

			string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BluRayProject;Data Source=(local)";
			SqlConnectionStringBuilder connectionStringBuilder = GetConnectionStringBuilder(connectionString);

         return connectionStringBuilder.ToString();
		}


		public static string GetFileGroupName(string databaseName) => $"{FILEGROUPNAME}_{databaseName}";

		public static string GetEnvironmentVariable() => Environment.GetEnvironmentVariable(ASPNETCORE_ENVIRONMENT_VARIABLE_NAME);

		private static SqlConnectionStringBuilder GetConnectionStringBuilder(string connectionString)
		{
			SqlConnectionStringBuilder result = new SqlConnectionStringBuilder(connectionString);
			result.ConnectRetryCount = 5;

			return result;
		}

		#endregion
	}
}
