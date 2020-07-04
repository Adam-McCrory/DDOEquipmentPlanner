using EquipmentDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDOEquipmentPlannerUI
{
 
	public class EquipmentLoadout
	{
		public int MinimumLevel = 1;
		public int MaximumLevel = 30;

		public int CurrentBuildResult;

		public bool FiltersResultsMismatch;

		public string AppVersion;

		//public Dictionary<EquipmentSlotType, List<BuildFilter>> Filters = new Dictionary<EquipmentSlotType, List<BuildFilter>>()
		//{
		//	{ EquipmentSlotType.None, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Back, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Body, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Eye, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Feet, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Finger, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Hand, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Head, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Neck, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Offhand, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Trinket, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Waist, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Weapon, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Wrist, new List<BuildFilter>() }
		//};
		// so we can remember the lock state of the slots
		public List<EquipmentSlotType> LockedSlots = new List<EquipmentSlotType>();
		//public List<BuildItem> LockedSlotItems = new List<BuildItem>();
		//public List<GearSetEvaluation> BuildResults = new List<GearSetEvaluation>();

		public void SetLockStatus(EquipmentSlotType est, bool locked)
		{
			if (locked && !LockedSlots.Contains(est)) LockedSlots.Add(est);
			else if (!locked && LockedSlots.Contains(est)) LockedSlots.Remove(est);
		}

		public void Clear()
		{
			MinimumLevel = 1;
			MaximumLevel = 30;
			CurrentBuildResult = -1;
			FiltersResultsMismatch = false;

			//foreach (var kv in Filters)
			//	kv.Value.Clear();

			LockedSlots.Clear();
			//BuildResults.Clear();

			//AppVersion = PlannerWindow.VERSION;
		}

		public bool ValidateFilters(bool test)
		{
			//var filters = test ? TestFilters : Filters;

			//foreach (var fg in filters)
			//	foreach (var f in fg.Value)
			//	{
			//		if (f.Include) return true;
			//	}

			return false;
		}

		#region Build process support
		public Dictionary<EquipmentSlotType, List<DDOItem>> DiscoveredItems, FilterTestItems;
		//public Dictionary<EquipmentSlotType, List<BuildFilter>> TestFilters = new Dictionary<EquipmentSlotType, List<BuildFilter>>()
		//{
		//	{ EquipmentSlotType.None, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Back, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Body, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Eye, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Feet, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Finger, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Hand, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Head, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Neck, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Offhand, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Trinket, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Waist, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Weapon, new List<BuildFilter>() },
		//	{ EquipmentSlotType.Wrist, new List<BuildFilter>() }
		//};

		public void SetupLockedSlots(Dictionary<EquipmentSlotType, EquipmentSlotControl> EquipmentSlots)
		{
			LockedSlots.Clear();
			//LockedSlotItems.Clear();
			foreach (var kv in EquipmentSlots)
				if (kv.Value.IsLocked)
				{
					LockedSlots.Add(kv.Key);
					//if (kv.Value.Item != null) LockedSlotItems.Add(kv.Value.Item);
				}
		}

		public void SetupFilterTest(Dictionary<EquipmentSlotType, EquipmentSlotControl> EquipmentSlots)
		{
			//foreach (var kvp in TestFilters)
			//	kvp.Value.Clear();

			FilterTestItems = new Dictionary<EquipmentSlotType, List<DDOItem>>();
			SetupLockedSlots(EquipmentSlots);
		}

		public void SetupBuildProcess(Dictionary<EquipmentSlotType, EquipmentSlotControl> EquipmentSlots)
		{
			//BuildResults.Clear();
			DiscoveredItems = new Dictionary<EquipmentSlotType, List<DDOItem>>();
			FilterTestItems = null;
			SetupLockedSlots(EquipmentSlots);
		}

		//bool GearSetHasRedundantRings(GearSet gs)
		//{
		//	List<BuildItem> rings = gs.Items.Where(i => i.Slot == EquipmentSlotType.Finger1 || i.Slot == EquipmentSlotType.Finger2).ToList();
		//	if (rings.Count < 2) return false;
		//	if (rings[0].Item != rings[1].Item) return false;
		//	if (rings[0].OptionProperties.Count != rings[1].OptionProperties.Count) return false;
		//	bool diff = false;
		//	for (int p = 0; p < rings[0].OptionProperties.Count; p++)
		//	{
		//		if (!rings[1].OptionProperties.Contains(rings[0].OptionProperties[p]))
		//		{
		//			diff = true;
		//			break;
		//		}
		//	}

		//	return !diff;
		//}

		//public void AddBuildGearSet(GearSet gs)
		//{
		//	foreach (var ls in LockedSlotItems) gs.AddItem(ls);

		//	//TODO: perform multiple artifact check here as well

		//	if (!GearSetHasRedundantRings(gs)) BuildResults.Add(new GearSetEvaluation(gs, new List<EquipmentSlotType>(LockedSlots)));
		//}
		#endregion

		//public XmlDocument ToXml(bool filters, bool results)
		//{
		//	XmlDocument doc = new XmlDocument();
		//	XmlElement xe = doc.CreateElement("Build");
		//	XmlAttribute xa = doc.CreateAttribute("version");
		//	xa.InnerText = AppVersion;
		//	xe.Attributes.Append(xa);
		//	doc.AppendChild(xe);
		//	xe = doc.CreateElement("MinimumLevel");
		//	xe.InnerText = MinimumLevel.ToString();
		//	doc.DocumentElement.AppendChild(xe);
		//	xe = doc.CreateElement("MaximumLevel");
		//	xe.InnerText = MaximumLevel.ToString();
		//	doc.DocumentElement.AppendChild(xe);

		//	if (filters)
		//	{
		//		xe = doc.CreateElement("Filters");
		//		doc.DocumentElement.AppendChild(xe);
		//		foreach (var kv in Filters)
		//		{
		//			if (kv.Value.Count == 0) continue;
		//			foreach (var f in kv.Value)
		//			{
		//				XmlElement xf = f.ToXml(doc);
		//				xe.AppendChild(xf);
		//			}
		//		}
		//	}

		//	if (results)
		//	{
		//		xe = doc.CreateElement("BuildResults");
		//		doc.DocumentElement.AppendChild(xe);
		//		foreach (var gse in BuildResults)
		//		{
		//			XmlElement xg = gse.ToXml(doc);
		//			xe.AppendChild(xg);
		//		}
		//	}

		//	return doc;
		//}

		//public static GearSetBuild FromXml(XmlDocument doc, bool filters, bool results)
		//{
		//	GearSetBuild build = new GearSetBuild();

		//	try
		//	{
		//		build.AppVersion = doc.DocumentElement.GetAttribute("version");
		//		build.MinimumLevel = int.Parse(doc.GetElementsByTagName("MinimumLevel")[0].InnerText);
		//		build.MaximumLevel = int.Parse(doc.GetElementsByTagName("MaximumLevel")[0].InnerText);

		//		if (filters)
		//		{
		//			XmlElement xe = doc.GetElementsByTagName("Filters")[0] as XmlElement;
		//			if (xe != null)
		//				foreach (XmlElement xf in xe.ChildNodes)
		//				{
		//					BuildFilter bf = BuildFilter.FromXml(xf);
		//					build.Filters[bf.Slot].Add(bf);
		//				}
		//		}

		//		if (results)
		//		{
		//			XmlElement xe = doc.GetElementsByTagName("BuildResults")[0] as XmlElement;
		//			if (xe != null)
		//				foreach (XmlElement xb in xe.ChildNodes)
		//				{
		//					GearSetEvaluation gse = GearSetEvaluation.FromXml(xb);
		//					build.BuildResults.Add(gse);
		//				}
		//		}

		//		return build;
		//	}
		//	catch
		//	{
		//		return null;
		//	}
		//}
	}

}
