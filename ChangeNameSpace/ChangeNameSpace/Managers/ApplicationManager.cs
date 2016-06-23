using System;
using System.Linq;
using System.Collections.Generic;

namespace ChangeNameSpace
{
	sealed class ApplicationManager
	{
		private static ApplicationManager _instance = null;

		private ApplicationManager() { }

		static internal ApplicationManager Instance()
		{
			if (_instance == null)
			{
				_instance = new ApplicationManager();
			}

			return _instance;
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

		private static List<mainObjectGroup> ObjGroups = new List<mainObjectGroup>() {
			new mainObjectGroup () {
				mainObjectGroupId = 1, Title = "Meat lovers", ImagePath = "", mainObjects = new List<mainObject> () {
					new mainObject () {
						mainObjectId = 1,
						Name = "Regular Hot Dog",
						ShortDescription = "The best there is on this planet.",
						Description = "Manchego smelly cheese danish fontina.",
						ImagePath = "hotdog1",
						Available = true,
						PrepTime = 10,
						Ingredients = new List<string> () {
							"Regular bun", "Sausage", "Ketchup"
						},
						Price = 8,
						IsFavorite = true
					},
					new mainObject () {
						mainObjectId = 2,
						Name = "haute Dog",
						ShortDescription = "The classy one.",
						Description = "Bacon ipsum dolor amet turduken.",
						ImagePath = "hotdog2",
						Available = true,
						PrepTime = 15,
						Ingredients = new List<string> () {
							"Baked bun", "Gourmet sausage", "Ketchup"
						},
						Price = 10,
						IsFavorite = false
					},
					new mainObject () {
						mainObjectId = 3,
						Name = "Extra Long",
						ShortDescription = "For when a regular one isn't enough.",
						Description = "Capicola short loin shoulder strip steak ribeye pork.",
						ImagePath = "hotdog3",
						Available = true,
						PrepTime = 10,
						Ingredients = new List<string> () {
							"Extra Large bun", "Extra long sausage", "Ketchup"
						},
						Price = 8,
						IsFavorite = true
					}
				}
			},
			new mainObjectGroup () {
				mainObjectGroupId = 2, Title = "Veggie lovers", ImagePath = "", mainObjects = new List<mainObject> () {
					new mainObject () {
						mainObjectId = 4,
						Name = "Veggie Hot Dog",
						ShortDescription = "American for non-meat lovers.",
						Description = "Veggies es bonus vobis, proinde vos.",
						ImagePath = "hotdog4",
						Available = true,
						PrepTime = 10,
						Ingredients = new List<string> () {
							"Regular bun", "Sausage", "Ketchup"
						},
						Price = 8,
						IsFavorite = true
					},
					new mainObject () {
						mainObjectId = 5,
						Name = "haute Dog 5",
						ShortDescription = "The classy one.",
						Description = "Bacon ipsum dolor amet turduken.",
						ImagePath = "hotdog5",
						Available = true,
						PrepTime = 15,
						Ingredients = new List<string> () {
							"Baked bun", "Gourmet sausage", "Ketchup"
						},
						Price = 10,
						IsFavorite = false
					},
					new mainObject () {
						mainObjectId = 6,
						Name = "Extra Long 6",
						ShortDescription = "For when a regular one isn't enough.",
						Description = "Capicola short loin shoulder strip steak ribeye pork.",
						ImagePath = "hotdog6",
						Available = true,
						PrepTime = 10,
						Ingredients = new List<string> () {
							"Extra Large bun", "Extra long sausage", "Ketchup"
						},
						Price = 8,
						IsFavorite = true
					}
				}
			}
		};
	}
}

