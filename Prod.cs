// All the calculations of production have been placed in a separate module.

class OGameProd
{

	/// <summary>
	/// All the production calculations are here.
	/// </summary>
	public static void CalcAll(ref OGMiner.State st)
	{
		int min_temp = st.planet_temp;
		int max_temp = min_temp + 40;

		// Natural production
		st.natural_m = Math.Floor(30 * st.eco_speed * (1.0 + pos_met_bonus(st.planet_pos)));
		st.natural_k = Math.Floor(15 * st.eco_speed * (1.0 + pos_crys_bonus(st.planet_pos)));

		CalcEnergy(ref st);

		// Consumption
		st.cons_fusion = Math.Floor(10 * st.fusion * Math.Pow(1.1, st.fusion) * st.eco_speed * (st.fusion_prod / 100.0));           // deuterium consumption by the fusion

		// Base mine production
		st.base_m = Math.Floor(30 * st.metal_mine * Math.Pow(1.1, st.metal_mine) * st.eco_speed * (1.0 + pos_met_bonus(st.planet_pos)) * (st.metal_prod / 100.0) * st.factor);
		st.base_k = Math.Floor(20 * st.crystal_mine * Math.Pow(1.1, st.crystal_mine) * st.eco_speed * (1.0 + pos_crys_bonus(st.planet_pos)) * (st.crystal_prod / 100.0) * st.factor);
		st.base_d = Math.Floor(10 * st.deut_synth * Math.Pow(1.1, st.deut_synth) * (1.44 - 0.004 * max_temp) * st.eco_speed * (st.deut_prod / 100.0) * st.factor);

		// LF buildings

		if (st.lf != LifeForm.Type.NoLifeForm)
		{
			var lf_buildings = LifeForm.GetBuildings(st.lf);
			int[]? arr = null;
			LifeForm.ObjectID base_id = 0;
			switch (st.lf)
			{
				case LifeForm.Type.Human:
					base_id = LifeForm.ObjectID.Human_Base;
					arr = st.human_buildings;
					break;
				case LifeForm.Type.Rocktal:
					base_id = LifeForm.ObjectID.Rock_Base;
					arr = st.rock_buildings;
					break;
				case LifeForm.Type.Mecha:
					base_id = LifeForm.ObjectID.Mecha_Base;
					arr = st.mecha_buildings;
					break;
				case LifeForm.Type.ShavedPubis:
					base_id = LifeForm.ObjectID.Kaelish_Base;
					arr = st.pubis_buildings;
					break;
			}

			foreach (var building in lf_buildings)
			{
				int bid = (int)building - (int)base_id;

				st.lf_buildings_bonus_m[bid] = LifeForm.bonus_metal(building, arr[bid], st.base_m);
				st.lf_buildings_bonus_k[bid] = LifeForm.bonus_crys(building, arr[bid], st.base_k);
				st.lf_buildings_bonus_d[bid] = LifeForm.bonus_deut(building, arr[bid], st.base_d);
				st.lf_buildings_bonus_e[bid] = LifeForm.bonus_energy(building, arr[bid], st.base_e);
			}
		}

		// Crawlers

		double crawlers_count = (st.metal_mine + st.crystal_mine + st.deut_synth) * 8.0;
		if (st.player_class == OGMiner.PlayerClass.Collector && st.geologist)
		{
			double count_bonus = 10 * (1.0 + st.lf_class_bonus / 100.0);
			crawlers_count += crawlers_count * (count_bonus / 100);
		}
		st.crawlers_count_max = (int)Math.Floor(crawlers_count);
		crawlers_count = Math.Min(st.crawlers_count_max, st.crawlers);

		double class_factor = 1.0;
		if (st.player_class == OGMiner.PlayerClass.Collector)
		{
			double class_bonus = 50 * (1.0 + st.lf_class_bonus / 100.0);
			class_factor = 1.0 + class_bonus / 100;
		}

		st.crawlers_m = Math.Min(st.base_m * 0.0002 * crawlers_count * (st.crawlers_prod / 100.0) * class_factor, st.base_m / 2);
		st.crawlers_k = Math.Min(st.base_k * 0.0002 * crawlers_count * (st.crawlers_prod / 100.0) * class_factor, st.base_k / 2);
		st.crawlers_d = Math.Min(st.base_d * 0.0002 * crawlers_count * (st.crawlers_prod / 100.0) * class_factor, st.base_d / 2);

		// All other bonuses are calculated on the base output.

		// Plasma Bonus (+1% / +0.66% / +0.33%)
		st.plasma_m = st.base_m * st.plasma_tech * 0.01;
		st.plasma_k = st.base_k * st.plasma_tech * 0.0066;
		st.plasma_d = st.base_d * st.plasma_tech * 0.0033;

		// Bonus for boosters (items)
		st.booster_m = st.base_m * (st.metal_booster / 100.0);
		st.booster_k = st.base_k * (st.crystal_booster / 100.0);
		st.booster_d = st.base_d * (st.deut_booster / 100.0);

		// Geologist Bonus (+10%)
		if (st.geologist)
		{
			st.geologist_m = st.base_m * 0.1;
			st.geologist_k = st.base_k * 0.1;
			st.geologist_d = st.base_d * 0.1;
		}
		else
		{
			st.geologist_m = 0;
			st.geologist_k = 0;
			st.geologist_d = 0;
		}
		// Bonus when all officers are active (“Command Staff”) (+2%)
		if (st.commander && st.admiral && st.engineer && st.geologist && st.technocrate)
		{
			st.staff_m = st.base_m * 0.02;
			st.staff_k = st.base_k * 0.02;
			st.staff_d = st.base_d * 0.02;
		}
		else
		{
			st.staff_m = 0;
			st.staff_k = 0;
			st.staff_d = 0;
		}
		// Player class bonus (only Collector is useful) (+25%/+10% mod. T18)
		if (st.player_class == OGMiner.PlayerClass.Collector)
		{
			st.player_m = st.base_m * 0.25 * (1.0 + st.lf_class_bonus / 100.0);
			st.player_k = st.base_k * 0.25 * (1.0 + st.lf_class_bonus / 100.0);
			st.player_d = st.base_d * 0.25 * (1.0 + st.lf_class_bonus / 100.0);
		}
		else
		{
			st.player_m = 0;
			st.player_k = 0;
			st.player_d = 0;
		}
		// Alliance class bonus (only Traders class is useful) (+5%)
		if (st.ally_class == OGMiner.AllyClass.Traders)
		{
			st.ally_m = st.base_m * 0.05;
			st.ally_k = st.base_k * 0.05;
			st.ally_d = st.base_d * 0.05;
		}
		else
		{
			st.ally_m = 0;
			st.ally_k = 0;
			st.ally_d = 0;
		}
		// Tech bonus from the life-forms
		st.lf_prod_m = st.base_m * (st.lf_metal_bonus / 100.0);
		st.lf_prod_k = st.base_k * (st.lf_crystal_bonus / 100.0);
		st.lf_prod_d = st.base_d * (st.lf_deut_bonus / 100.0);

		// Sum
		st.total_m = st.natural_m + st.base_m + st.crawlers_m + st.plasma_m + st.booster_m + st.geologist_m + st.staff_m + st.player_m + st.ally_m + st.lf_prod_m;
		st.total_k = st.natural_k + st.base_k + st.crawlers_k + st.plasma_k + st.booster_k + st.geologist_k + st.staff_k + st.player_k + st.ally_k + st.lf_prod_k;
		st.total_d = st.base_d + st.crawlers_d + st.plasma_d + st.booster_d + st.geologist_d + st.staff_d + st.player_d + st.ally_d + st.lf_prod_d - st.cons_fusion;

		for (int i=0; i<10; i++)
		{
			st.total_m += st.lf_buildings_bonus_m[i];
			st.total_k += st.lf_buildings_bonus_k[i];
			st.total_d += st.lf_buildings_bonus_d[i];
		}
	}

	/// <summary>
	/// Position bonus for crystal production.
	/// </summary>
	static double pos_crys_bonus(int pos)
	{
		switch (pos)
		{
			case 1: return 0.4;
			case 2: return 0.3;
			case 3: return 0.2;
		}
		return 0;
	}

	/// <summary>
	/// Position bonus for metal production.
	/// </summary>
	static double pos_met_bonus(int pos)
	{
		switch (pos)
		{
			case 6: case 10: return 0.17;
			case 7: case 9: return 0.23;
			case 8: return 0.35;
		}
		return 0;
	}

	static void CalcEnergy(ref OGMiner.State st)
	{
		int min_temp = st.planet_temp;
		int max_temp = min_temp + 40;
		var average_temp = (min_temp + max_temp) / 2.0;     // average temperature of the planet

		// Energy production
		st.e_sol = Math.Floor(20 * st.solar_plant * Math.Pow(1.1, st.solar_plant) * (st.solar_prod / 100.0));
		st.e_fusion = Math.Floor(30 * st.fusion * Math.Pow(1.05 + st.energo_tech * 0.01, st.fusion) * (st.fusion_prod / 100.0));
		st.e_sat = Math.Floor((average_temp + 160) / 6.0) * st.ssat * (st.ssat_prod / 100.0);
		st.base_e = st.e_sol + st.e_fusion + st.e_sat;

		// Energy Reduction Factor (Rocktal Disruption Chamber)
		double erf = LifeForm.GetEnergyReductionFactor(ref st);

		// Energy consumption
		st.cons_met = Math.Floor(10 * st.metal_mine * Math.Pow(1.1, st.metal_mine) * (st.metal_prod / 100.0)) * erf;
		st.cons_crys = Math.Floor(10 * st.crystal_mine * Math.Pow(1.1, st.crystal_mine) * (st.crystal_prod / 100.0)) * erf;
		st.cons_deut = Math.Floor(20 * st.deut_synth * Math.Pow(1.1, st.deut_synth) * (st.deut_prod / 100.0)) * erf;

		// Consumption by LF buildings
		if (st.lf != LifeForm.Type.NoLifeForm)
		{
			var lf_buildings = LifeForm.GetBuildings(st.lf);
			int[]? arr = null;
			LifeForm.ObjectID base_id = 0;
			switch (st.lf)
			{
				case LifeForm.Type.Human:
					base_id = LifeForm.ObjectID.Human_Base;
					arr = st.human_buildings;
					break;
				case LifeForm.Type.Rocktal:
					base_id = LifeForm.ObjectID.Rock_Base;
					arr = st.rock_buildings;
					break;
				case LifeForm.Type.Mecha:
					base_id = LifeForm.ObjectID.Mecha_Base;
					arr = st.mecha_buildings;
					break;
				case LifeForm.Type.ShavedPubis:
					base_id = LifeForm.ObjectID.Kaelish_Base;
					arr = st.pubis_buildings;
					break;
			}

			foreach (var building in lf_buildings)
			{
				int bid = (int)building - (int)base_id;
				st.lf_buildings_cons[bid] = LifeForm.cons_energy(building, arr[bid]) * erf;
			}
		}

		// Crawlers

		double crawlers_count = (st.metal_mine + st.crystal_mine + st.deut_synth) * 8.0;
		if (st.player_class == OGMiner.PlayerClass.Collector && st.geologist)
		{
			double count_bonus = 10 * (1.0 + st.lf_class_bonus / 100.0);
			crawlers_count += crawlers_count * (count_bonus / 100);
		}
		st.crawlers_count_max = (int)Math.Floor(crawlers_count);
		crawlers_count = Math.Min(st.crawlers_count_max, st.crawlers);

		// 1 crawler consumes 5 energy for every 10% for 0-100% mode and 10 energy for every overloaded 10% for 110-150% mode.
		double cons_per_crawler;
		if (st.crawlers_prod > 100)
		{
			cons_per_crawler = 5 * 10 + 10 * ((st.crawlers_prod - 100) / 10);
		}
		else
		{
			cons_per_crawler = 5 * (st.crawlers_prod / 10);
		}
		st.cons_crawlers = crawlers_count * cons_per_crawler * erf;

		// All other bonuses are calculated on the base output.

		// Bonus for boosters (items)
		st.booster_e = st.base_e * (st.energy_booster / 100.0);

		// Engineer Bonus (+10%)
		if (st.engineer)
		{
			st.engineer_e = st.base_e * 0.1;
		}
		else
		{
			st.engineer_e = 0;
		}
		// Bonus when all officers are active (“Command Staff”) (+2%)
		if (st.commander && st.admiral && st.engineer && st.geologist && st.technocrate)
		{
			st.staff_e = st.base_e * 0.02;
		}
		else
		{
			st.staff_e = 0;
		}
		// Player class bonus (only Collector is useful) (+25%/+10% mod. T18)
		if (st.player_class == OGMiner.PlayerClass.Collector)
		{
			st.player_e = st.base_e * 0.1 * (1.0 + st.lf_class_bonus / 100.0);
		}
		else
		{
			st.player_e = 0;
		}
		// Alliance class bonus (only Traders class is useful) (+5%)
		if (st.ally_class == OGMiner.AllyClass.Traders)
		{
			st.ally_e = st.base_e * 0.05;
		}
		else
		{
			st.ally_e = 0;
		}
		// Tech bonus from the life-forms
		st.lf_prod_e = st.base_e * (st.lf_energy_bonus / 100.0);

		// Sum
		st.total_e = st.base_e + st.booster_e + st.engineer_e + st.staff_e + st.player_e + st.ally_e + st.lf_prod_e;
		for (int i = 0; i < 10; i++)
		{
			st.total_e += st.lf_buildings_bonus_e[i];
		}
		Console.WriteLine("Total energy produced: {0}", st.total_e);

		// Production factor

		st.econs = st.cons_met + st.cons_crys + st.cons_deut + st.cons_crawlers;
		for (int i = 0; i < 10; i++)
		{
			st.econs += st.lf_buildings_cons[i];
		}
		Console.WriteLine("Total energy consumed: {0}", st.econs);
		st.e = Math.Floor(st.total_e - st.econs);
		Console.WriteLine("Planetary energy: {0}", st.e);
		st.factor = 1.0;
		if (st.e < 0)
		{
			st.factor = Math.Max(0, 1.0 - Math.Abs(st.e / st.econs));
		}
		Console.WriteLine("Production factor: {0}", st.factor);
	}

}