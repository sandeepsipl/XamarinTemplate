using System;
using System.Collections.Generic;

namespace ChangeNameSpace
{
	public class mainObjectGroup
	{
		public mainObjectGroup ()
		{
		}

		public int mainObjectGroupId {
			get;
			set;
		}

		public string Title {
			get;
			set;
		}

		public string ImagePath {
			get;
			set;
		}

		public List<mainObject> mainObjects{
			get;
			set;
		}

	}
}

