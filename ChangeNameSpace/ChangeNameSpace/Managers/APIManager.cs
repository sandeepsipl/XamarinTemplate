using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ChangeNameSpace
{
	sealed class APIManager
	{
		private static APIManager _instance = null;
		string url = "http://gillcleerenpluralsight.blob.core.windows.net/files/hotdogs.json";

		private APIManager() { }

		static internal APIManager Instance()
		{
			if (_instance == null)
			{
				_instance = new APIManager();
			}

			return _instance;
		}

		private static List<mainObjectGroup> ObjGroups = new List<mainObjectGroup>();

		public void FetchAllObjs()
		{
			Task.Run(() => this.LoadDataAsync(url)).Wait();
		}

		private async Task LoadDataAsync(string uri)
		{
			if (ObjGroups != null)
			{
				string responseJsonString = null;

				using (var httpClient = new HttpClient())
				{
					try
					{
						Task<HttpResponseMessage> getResponse = httpClient.GetAsync(uri);

						HttpResponseMessage response = await getResponse;

						responseJsonString = await response.Content.ReadAsStringAsync();
						ObjGroups = JsonConvert.DeserializeObject<List<mainObjectGroup>>(responseJsonString);
					}
					catch (Exception ex)
					{
						string message = ex.Message;
					}
				}
			}
		}

		public List<mainObject> GetAllObjs()
		{
			IEnumerable<mainObject> objs =
				from objGroup in ObjGroups
				from obj in objGroup.mainObjects

				select obj;
			return objs.ToList<mainObject>();
		}

		public mainObject GetObjById(int ObjId)
		{
			IEnumerable<mainObject> objs =
				from objGroup in ObjGroups
				from obj in objGroup.mainObjects
				where obj.mainObjectId == ObjId
				select obj;
			return objs.FirstOrDefault();
		}

		public List<mainObjectGroup> GetGroupedObjs()
		{
			return ObjGroups;
		}

		public List<mainObject> GetObjsForGroup(int ObjGroupId)
		{
			var group = ObjGroups.Where(h => h.mainObjectGroupId == ObjGroupId).FirstOrDefault();

			if (group != null)
			{
				return group.mainObjects;
			}
			return null;
		}

		public List<mainObject> GetFavoriteObjs()
		{
			IEnumerable<mainObject> Objs =
				from objGroup in ObjGroups
				from obj in objGroup.mainObjects
				where obj.IsFavorite
				select obj;
			return Objs.ToList<mainObject>();
		}
	}
}

