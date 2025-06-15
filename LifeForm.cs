// Everything about life forms is in here.

public class LifeForm
{
	/// <summary>
	/// Life form type
	/// </summary>
	public enum Type
	{
		NoLifeForm = 0,
		Human = 1,
		Rocktal = 2,
		Mecha = 3,
		ShavedPubis = 4,
	}

	/// <summary>
	/// LF object identifiers.
	/// </summary>
	public enum ObjectID
	{
		// Human

		Human_Base = 11103,
		Human_TechBuilding = 11103,
		Human_School = 11104,
		Human_HighSchool = 11105, 
		Human_ResourceBooster1 = 11106,

		Human_LifeSupport1 = 11107,
		Human_ResourceBooster2 = 11108,
		Human_LifeSupport2 = 11109,
		Human_ResourceBooster3 = 11110,
		Human_TechTreeBooster = 11111,
		Human_LifeFormProtection = 11112,

		// Rock
		
		Rock_Base = 12103,
		Rock_TechBuilding = 12103,
		Rock_School = 12104,
		Rock_HighSchool = 12105,
		Rock_ResourceBooster1 = 12106,

		Rock_EnergyManipulator = 12107,
		Rock_CostReductionBuildings1 = 12108,
		Rock_ResourceBooster2 = 12109,
		Rock_ResourceBooster3 = 12110,
		Rock_CostReductionBuildings2 = 12111,
		Rock_RecycleAttackerFleet = 12112,

		// Mecha

		Mecha_Base = 13103,
		Mecha_TechBuilding = 13103,
		Mecha_School = 13104,
		Mecha_HighSchool = 13105,
		Mecha_ProductionSpeedShips = 13106,

		Mecha_TechTreeBooster1 = 13107,
		Mecha_ResourceBooster = 13108,
		Mecha_LifeSupport1 = 13109,
		Mecha_LifeSupport2 = 13110,
		Mecha_TechTreeBooster2 = 13111,
		Mecha_SpaceDockExtender = 13112,

		// Kaelish

		Kaelish_Base = 14103,
		Kaelish_TechBuilding = 14103,
		Kaelish_School = 14104,
		Kaelish_HighSchool = 14105,
		Kaelish_LifeSupport1 = 14106,

		Kaelish_LifeSupportAndResearch = 14107,
		Kaelish_LifeSupport2 = 14108,
		Kaelish_PlanetFieldsBooster = 14109,
		Kaelish_UnlockCondition = 14110,
		Kaelish_ProductionSpeedShips = 14111,
		Kaelish_MoonChanceIncrease = 14112,
	}


	static public string GetBuildingName (ObjectID id)
	{
		switch (id)
		{
			case ObjectID.Human_TechBuilding: return "Research Centre";
			case ObjectID.Human_School: return "Academy of Sciences";
			case ObjectID.Human_HighSchool: return "Neuro-Calibration Centre";
			case ObjectID.Human_ResourceBooster1: return "High Energy Smelting";
			case ObjectID.Human_LifeSupport1: return "Food Silo";
			case ObjectID.Human_ResourceBooster2: return "Fusion-Powered Production";
			case ObjectID.Human_LifeSupport2: return "Skyscraper";
			case ObjectID.Human_ResourceBooster3: return "Biotech Lab";
			case ObjectID.Human_TechTreeBooster: return "Metropolis";
			case ObjectID.Human_LifeFormProtection: return "Planetary Shield";

			case ObjectID.Rock_TechBuilding: return "Rune Technologium";
			case ObjectID.Rock_School: return "Rune Forge";
			case ObjectID.Rock_HighSchool: return "Oriktorium";
			case ObjectID.Rock_ResourceBooster1: return "Magma Forge";
			case ObjectID.Rock_EnergyManipulator: return "Disruption Chamber";
			case ObjectID.Rock_CostReductionBuildings1: return "Megalith";
			case ObjectID.Rock_ResourceBooster2: return "Crystal Refinery";
			case ObjectID.Rock_ResourceBooster3: return "Deuterium Synthesissy";
			case ObjectID.Rock_CostReductionBuildings2: return "Mineral Research Centre";
			case ObjectID.Rock_RecycleAttackerFleet: return "Advanced Recycling Plant";

			case ObjectID.Mecha_TechBuilding: return "Robotics Research Centre";
			case ObjectID.Mecha_School: return "Update Network";
			case ObjectID.Mecha_HighSchool: return "Quantum Computer Centre";
			case ObjectID.Mecha_ProductionSpeedShips: return "Automatised Assembly Centre";
			case ObjectID.Mecha_TechTreeBooster1: return "High-Performance Transformer";
			case ObjectID.Mecha_ResourceBooster: return "Microchip Assembly Line";
			case ObjectID.Mecha_LifeSupport1: return "Production Assembly Hall";
			case ObjectID.Mecha_LifeSupport2: return "High-Performance Synthesiser";
			case ObjectID.Mecha_TechTreeBooster2: return "Chip Mass Production";
			case ObjectID.Mecha_SpaceDockExtender: return "Nano Repair Bots";

			case ObjectID.Kaelish_TechBuilding: return "Vortex Chamber";
			case ObjectID.Kaelish_School: return "Halls of Realisation";
			case ObjectID.Kaelish_HighSchool: return "Forum of Transcendence";
			case ObjectID.Kaelish_LifeSupport1: return "Antimatter Convector";
			case ObjectID.Kaelish_LifeSupportAndResearch: return "Cloning Laboratory";
			case ObjectID.Kaelish_LifeSupport2: return "Chrysalis Accelerator";
			case ObjectID.Kaelish_PlanetFieldsBooster: return "Bio Modifier";
			case ObjectID.Kaelish_UnlockCondition: return "Psionic Modulator";
			case ObjectID.Kaelish_ProductionSpeedShips: return "Ship Manufacturing Hall";
			case ObjectID.Kaelish_MoonChanceIncrease: return "Supra Refractor";
		}
		return "Unknown";
	}

	static public List<ObjectID> GetBuildings (Type type)
	{
		List<ObjectID> list = new List<ObjectID>();

		switch (type)
		{
			case LifeForm.Type.Rocktal:
				list.Add(ObjectID.Rock_TechBuilding);
				list.Add(ObjectID.Rock_School);
				list.Add(ObjectID.Rock_HighSchool);
				list.Add(ObjectID.Rock_ResourceBooster1);
				list.Add(ObjectID.Rock_EnergyManipulator);
				list.Add(ObjectID.Rock_CostReductionBuildings1);
				list.Add(ObjectID.Rock_ResourceBooster2);
				list.Add(ObjectID.Rock_ResourceBooster3);
				list.Add(ObjectID.Rock_CostReductionBuildings2);
				list.Add(ObjectID.Rock_RecycleAttackerFleet);
				break;
			case LifeForm.Type.ShavedPubis:
				list.Add(ObjectID.Kaelish_TechBuilding);
				list.Add(ObjectID.Kaelish_School);
				list.Add(ObjectID.Kaelish_HighSchool);
				list.Add(ObjectID.Kaelish_LifeSupport1);
				list.Add(ObjectID.Kaelish_LifeSupportAndResearch);
				list.Add(ObjectID.Kaelish_LifeSupport2);
				list.Add(ObjectID.Kaelish_PlanetFieldsBooster);
				list.Add(ObjectID.Kaelish_UnlockCondition);
				list.Add(ObjectID.Kaelish_ProductionSpeedShips);
				list.Add(ObjectID.Kaelish_MoonChanceIncrease);
				break;
			case LifeForm.Type.Human:
				list.Add(ObjectID.Human_TechBuilding);
				list.Add(ObjectID.Human_School);
				list.Add(ObjectID.Human_HighSchool);
				list.Add(ObjectID.Human_ResourceBooster1);
				list.Add(ObjectID.Human_LifeSupport1);
				list.Add(ObjectID.Human_ResourceBooster2);
				list.Add(ObjectID.Human_LifeSupport2);
				list.Add(ObjectID.Human_ResourceBooster3);
				list.Add(ObjectID.Human_TechTreeBooster);
				list.Add(ObjectID.Human_LifeFormProtection);
				break;
			case LifeForm.Type.Mecha:
				list.Add(ObjectID.Mecha_TechBuilding);
				list.Add(ObjectID.Mecha_School);
				list.Add(ObjectID.Mecha_HighSchool);
				list.Add(ObjectID.Mecha_ProductionSpeedShips);
				list.Add(ObjectID.Mecha_TechTreeBooster1);
				list.Add(ObjectID.Mecha_ResourceBooster);
				list.Add(ObjectID.Mecha_LifeSupport1);
				list.Add(ObjectID.Mecha_LifeSupport2);
				list.Add(ObjectID.Mecha_TechTreeBooster2);
				list.Add(ObjectID.Mecha_SpaceDockExtender);
				break;
		}

		return list;
	}

	static public double bonus_metal (ObjectID id, int level, double base_prod)
	{
		double pr = 0;

		switch (id)
		{
			case ObjectID.Human_ResourceBooster1: pr = 1.5 * level; break;
			case ObjectID.Rock_ResourceBooster1: pr = 2.0 * level; break;
		}

		return base_prod * (pr / 100.0);
	}

	static public double bonus_crys(ObjectID id, int level, double base_prod)
	{
		double pr = 0;

		switch (id)
		{
			case ObjectID.Human_ResourceBooster2: pr = 1.5 * level; break;
			case ObjectID.Rock_ResourceBooster2: pr = 2.0 * level; break;
		}

		return base_prod * (pr / 100.0);
	}

	static public double bonus_deut(ObjectID id, int level, double base_prod)
	{
		double pr = 0;

		switch (id)
		{
			case ObjectID.Human_ResourceBooster2: pr = 1.0 * level; break;
			case ObjectID.Rock_ResourceBooster3: pr = 2.0 * level; break;
			case ObjectID.Mecha_LifeSupport2: pr = 2.0 * level; break;
		}

		return base_prod * (pr / 100.0);
	}

	static public double bonus_energy(ObjectID id, int level, double base_prod)
	{
		double pr = 0;

		switch (id)
		{
			case ObjectID.Rock_EnergyManipulator: pr = 1.5 * level; break;
			case ObjectID.Mecha_TechTreeBooster1: pr = 1.0 * level; break;
		}

		return base_prod * (pr / 100.0);
	}

	static public double cons_energy(ObjectID id, int level)
	{
		double b = 0;
		double e = 0;

		switch (id)
		{
			case ObjectID.Human_TechBuilding: b = 10; e = 1.08; break;
			case ObjectID.Human_School: b = 15; e = 1.25; break;
			case ObjectID.Human_HighSchool: b = 30; e = 1.25; break;
			case ObjectID.Human_ResourceBooster1: b = 40; e = 1.10; break;
			case ObjectID.Human_LifeSupport1: break; 
			case ObjectID.Human_ResourceBooster2: b = 80; e = 1.10; break;
			case ObjectID.Human_LifeSupport2: b = 50; e = 1.02; break;
			case ObjectID.Human_ResourceBooster3: b = 60; e = 1.03; break;
			case ObjectID.Human_TechTreeBooster: b = 90; e = 1.05; break;
			case ObjectID.Human_LifeFormProtection: b = 100; e = 1.02; break;

			case ObjectID.Rock_TechBuilding: b = 15; e = 1.10; break;
			case ObjectID.Rock_School: b = 20; e = 1.35; break;
			case ObjectID.Rock_HighSchool: b = 60; e = 1.30; break;
			case ObjectID.Rock_ResourceBooster1: b = 40; e = 1.10; break;
			case ObjectID.Rock_EnergyManipulator: break;
			case ObjectID.Rock_CostReductionBuildings1: b = 80; e = 1.30; break;
			case ObjectID.Rock_ResourceBooster2: b = 90; e = 1.10; break;
			case ObjectID.Rock_ResourceBooster3: b = 90; e = 1.10; break;
			case ObjectID.Rock_CostReductionBuildings2: b = 120; e = 1.30; break;
			case ObjectID.Rock_RecycleAttackerFleet: b = 100; e = 1.10; break;

			case ObjectID.Mecha_TechBuilding: b = 13; e = 1.08; break;
			case ObjectID.Mecha_School: b = 10; e = 1.20; break;
			case ObjectID.Mecha_HighSchool: b = 40; e = 1.20; break;
			case ObjectID.Mecha_ProductionSpeedShips: break;
			case ObjectID.Mecha_TechTreeBooster1: b = 40; e = 1.05; break;
			case ObjectID.Mecha_ResourceBooster: b = 40; e = 1.01; break;
			case ObjectID.Mecha_LifeSupport1: b = 80; e = 1.04; break;
			case ObjectID.Mecha_LifeSupport2: b = 60; e = 1.10; break;
			case ObjectID.Mecha_TechTreeBooster2: b = 70; e = 1.05; break;
			case ObjectID.Mecha_SpaceDockExtender: b = 100; e = 1.05; break;

			case ObjectID.Kaelish_TechBuilding: b = 10; e = 1.08; break;
			case ObjectID.Kaelish_School: b = 15; e = 1.30; break;
			case ObjectID.Kaelish_HighSchool: b = 30; e = 1.30; break;
			case ObjectID.Kaelish_LifeSupport1: break;
			case ObjectID.Kaelish_LifeSupportAndResearch: break;
			case ObjectID.Kaelish_LifeSupport2: b = 30; e = 1.03; break;
			case ObjectID.Kaelish_PlanetFieldsBooster: b = 40; e = 1.02; break;
			case ObjectID.Kaelish_UnlockCondition: b = 140; e = 1.05; break;
			case ObjectID.Kaelish_ProductionSpeedShips: b = 90; e = 1.04; break;
			case ObjectID.Kaelish_MoonChanceIncrease: b = 100; e = 1.05; break;
		}

		return Math.Floor(b * level * Math.Pow(e, level));
	}

	/// <summary>
	/// Get a factor for reducing energy consumption.
	/// </summary>
	static public double GetEnergyReductionFactor (ref OGMiner.State state)
	{
		// Reduced energy consumption is provided by only one building, the Rock`tal Disruption Chamber (-0.5% per level)
		if (state.lf == Type.Rocktal && state.rock_buildings[4] != 0)
		{
			return Math.Max(0.6, 1.0 - 0.005 * state.rock_buildings[4]);		// 40% cap
		}
		return 1.0;
	}
}