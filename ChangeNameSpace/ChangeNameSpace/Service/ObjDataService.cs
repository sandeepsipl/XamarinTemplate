using System;
using System.Collections.Generic;

namespace ChangeNameSpace
{
	public class ObjDataService
	{
		private static ApplicationManager applicationManager = ApplicationManager.Instance();

		public ObjDataService ()
		{
		}

		public List<mainObject> GetAllObjs()
		{
			return applicationManager.GetAllObjs ();
		}

		public List<mainObjectGroup> GetGroupedObjs()
		{
			return applicationManager.GetGroupedObjs ();
		}

		public List<mainObject> GetObjsForGroup(int groupId)
		{
			return applicationManager.GetObjsForGroup (groupId);
		}

		public mainObject GetObjById(int objId)
		{
			return applicationManager.GetObjById (objId);
		}

		public List<mainObject> GetFavoriteObjs()
		{
			return applicationManager.GetFavoriteObjs ();
		}
	}
}

