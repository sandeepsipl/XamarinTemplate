using System;

namespace ChangeNameSpace
{
	sealed class DatabaseManager
	{
		private static DatabaseManager _instance = null;

		private DatabaseManager() { }

		static internal DatabaseManager Instance()
		{
			if (_instance == null)
			{
				_instance = new DatabaseManager();
			}

			return _instance;
		}

	}
}

