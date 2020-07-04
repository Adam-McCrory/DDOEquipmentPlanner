using System;

namespace EquipmentDomain
{
    [Flags]
	public enum OffhandCategory
	{
		Buckler = 1,
		Small = 2,
		Large = 4,
		Tower = 8,
		Orb = 16,
		RuneArm = 32
	}
}
