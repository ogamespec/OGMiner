using System.Reflection;
//using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace OGMiner
{
	public partial class FormMain : Form
	{
		//[DllImport("kernel32")]
		//static extern bool AllocConsole();

		State st = new State();

		public FormMain()
		{
			InitializeComponent();
#if DEBUG
			//AllocConsole();
#endif
			SetDoubleBuffer(dataGridView1, true);
			LoadSettings();
			StateToControls();
		}

		/// <summary>
		/// Distribute global settings to controls and recreate the grid.
		/// </summary>
		void StateToControls()
		{
			SetAllyClass(st.ally_class);
			SetPlayerClass(st.player_class);
			SetLifeForm(st.lf);

			EnableOfficeer(OfficeerType.Commander, st.commander);
			EnableOfficeer(OfficeerType.Admiral, st.admiral);
			EnableOfficeer(OfficeerType.Engineer, st.engineer);
			EnableOfficeer(OfficeerType.Geologist, st.geologist);
			EnableOfficeer(OfficeerType.Technocrate, st.technocrate);

			toolStripButton3.Checked = st.commander;
			toolStripButton1.Checked = st.admiral;
			toolStripButton4.Checked = st.engineer;
			toolStripButton5.Checked = st.geologist;
			toolStripButton6.Checked = st.technocrate;

			comboBox1.SelectedIndex = st.planet_pos - 1;
			comboBox2.SelectedIndex = st.eco_speed - 1;
			textBox3.Text = st.planet_temp.ToString();
			textBox1.Text = st.num_planets.ToString();
			textBox7.Text = st.energo_tech.ToString();
			textBox8.Text = st.lf_class_bonus.ToString("0.0000");

			textBox2.Text = st.lf_metal_bonus.ToString("0.0000");
			textBox4.Text = st.lf_crystal_bonus.ToString("0.0000");
			textBox5.Text = st.lf_deut_bonus.ToString("0.0000");
			textBox6.Text = st.lf_energy_bonus.ToString("0.0000");

			checkBox1.Checked = st.maximize_crawlers;

			ClearGrid();
			RebuildGrid();
		}

		/// <summary>
		/// Pull global settings from controls into context.
		/// Alliance class, player class, selected lifeform and officers are pulled into context when the control is clicked (no need to pull them in here).
		/// </summary>
		void ControlsToState()
		{
			st.planet_pos = comboBox1.SelectedIndex + 1;
			st.eco_speed = comboBox2.SelectedIndex + 1;
			st.planet_temp = Int32.Parse(textBox3.Text);
			st.num_planets = Int32.Parse(textBox1.Text);
			st.energo_tech = Int32.Parse(textBox7.Text);
			st.lf_class_bonus = Single.Parse(textBox8.Text);

			st.lf_metal_bonus = Single.Parse(textBox2.Text);
			st.lf_crystal_bonus = Single.Parse(textBox4.Text);
			st.lf_deut_bonus = Single.Parse(textBox5.Text);
			st.lf_energy_bonus = Single.Parse(textBox6.Text);

			st.maximize_crawlers = checkBox1.Checked;
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FormAbout about = new FormAbout();
			about.ShowDialog();
		}

		void SetAllyClass(AllyClass c)
		{
			switch (c)
			{
				case AllyClass.Warriors:
					toolStripDropDownButton2.Image = воиныToolStripMenuItem.Image;
					break;
				case AllyClass.Traders:
					toolStripDropDownButton2.Image = торговцыToolStripMenuItem.Image;
					break;
				case AllyClass.Explorers:
					toolStripDropDownButton2.Image = исследователиToolStripMenuItem.Image;
					break;
				case AllyClass.NotSelected:
					toolStripDropDownButton2.Image = неВыбраноToolStripMenuItem.Image;
					break;
			}
			st.ally_class = c;
			SaveSettings();
		}

		void SetPlayerClass(PlayerClass c)
		{
			switch (c)
			{
				case PlayerClass.Collector:
					toolStripDropDownButton1.Image = toolStripMenuItem1.Image;
					break;
				case PlayerClass.General:
					toolStripDropDownButton1.Image = генералToolStripMenuItem.Image;
					break;
				case PlayerClass.ExpoDrocher:
					toolStripDropDownButton1.Image = исследовательToolStripMenuItem.Image;
					break;
				case PlayerClass.NoClass:
					toolStripDropDownButton1.Image = неВыбранToolStripMenuItem.Image;
					break;
			}
			st.player_class = c;
			SaveSettings();
		}

		void SetLifeForm(LifeForm.Type lf)
		{
			switch (lf)
			{
				case LifeForm.Type.Human:
					toolStripDropDownButton3.Image = людиToolStripMenuItem.Image;
					break;
				case LifeForm.Type.ShavedPubis:
					toolStripDropDownButton3.Image = кэлишToolStripMenuItem.Image;
					break;
				case LifeForm.Type.Rocktal:
					toolStripDropDownButton3.Image = рокталToolStripMenuItem.Image;
					break;
				case LifeForm.Type.Mecha:
					toolStripDropDownButton3.Image = мехиToolStripMenuItem.Image;
					break;
				case LifeForm.Type.NoLifeForm:
					toolStripDropDownButton3.Image = неВыбраноToolStripMenuItem1.Image;
					break;
			}
			st.lf = lf;
			SaveSettings();
		}

		void EnableOfficeer(OfficeerType type, bool enable)
		{
			switch (type)
			{
				case OfficeerType.Commander:
					if (enable)
					{
						toolStripButton3.Image = Properties.Resources.commander_on;
					}
					else
					{
						toolStripButton3.Image = Properties.Resources.commander_off;
					}
					st.commander = enable;
					break;
				case OfficeerType.Admiral:
					if (enable)
					{
						toolStripButton1.Image = Properties.Resources.admiral_on;
					}
					else
					{
						toolStripButton1.Image = Properties.Resources.admiral_off;
					}
					st.admiral = enable;
					break;
				case OfficeerType.Engineer:
					if (enable)
					{
						toolStripButton4.Image = Properties.Resources.engineer_on;
					}
					else
					{
						toolStripButton4.Image = Properties.Resources.engineer_off;
					}
					st.engineer = enable;
					break;
				case OfficeerType.Geologist:
					if (enable)
					{
						toolStripButton5.Image = Properties.Resources.geologist_on;
					}
					else
					{
						toolStripButton5.Image = Properties.Resources.geologist_off;
					}
					st.geologist = enable;
					break;
				case OfficeerType.Technocrate:
					if (enable)
					{
						toolStripButton6.Image = Properties.Resources.technocrate_on;
					}
					else
					{
						toolStripButton6.Image = Properties.Resources.technocrate_off;
					}
					st.technocrate = enable;
					break;
			}
			SaveSettings();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}




		private void воиныToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Choose a Warrior alliance class");
			SetAllyClass(AllyClass.Warriors);
			RebuildGrid();
		}

		private void торговцыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Choose a Traders alliance class");
			SetAllyClass(AllyClass.Traders);
			RebuildGrid();
		}

		private void исследователиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Choose a Researchers alliance class");
			SetAllyClass(AllyClass.Explorers);
			RebuildGrid();
		}

		private void неВыбраноToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Remove the alliance class");
			SetAllyClass(AllyClass.NotSelected);
			RebuildGrid();
		}




		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Select the class of the player Collector");
			SetPlayerClass(PlayerClass.Collector);
			RebuildGrid();
		}

		private void генералToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Select the class of the player General");
			SetPlayerClass(PlayerClass.General);
			RebuildGrid();
		}

		private void исследовательToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Select the class of the player Discoverer");
			SetPlayerClass(PlayerClass.ExpoDrocher);
			RebuildGrid();
		}

		private void неВыбранToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Remove a player's class");
			SetPlayerClass(PlayerClass.NoClass);
			RebuildGrid();
		}




		private void людиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Choose a life form Humans");
			SetLifeForm(LifeForm.Type.Human);
			RebuildGrid();
		}

		private void кэлишToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Choose a life form Kaelesh");
			SetLifeForm(LifeForm.Type.ShavedPubis);
			RebuildGrid();
		}

		private void рокталToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Choose a life form Rocktal");
			SetLifeForm(LifeForm.Type.Rocktal);
			RebuildGrid();
		}

		private void мехиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Choose a life form Mechas");
			SetLifeForm(LifeForm.Type.Mecha);
			RebuildGrid();
		}

		private void неВыбраноToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Remove the life form");
			SetLifeForm(LifeForm.Type.NoLifeForm);
			RebuildGrid();
		}




		private void toolStripButton3_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Activate Commander: {0}", toolStripButton3.Checked);
			EnableOfficeer(OfficeerType.Commander, toolStripButton3.Checked);
			RebuildGrid();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Activate Admiral: {0}", toolStripButton1.Checked);
			EnableOfficeer(OfficeerType.Admiral, toolStripButton1.Checked);
			RebuildGrid();
		}

		private void toolStripButton4_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Activate Engineer: {0}", toolStripButton4.Checked);
			EnableOfficeer(OfficeerType.Engineer, toolStripButton4.Checked);
			RebuildGrid();
		}

		private void toolStripButton5_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Activate Geologist: {0}", toolStripButton5.Checked);
			EnableOfficeer(OfficeerType.Geologist, toolStripButton5.Checked);
			RebuildGrid();
		}

		private void toolStripButton6_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Activate Technocrat: {0}", toolStripButton6.Checked);
			EnableOfficeer(OfficeerType.Technocrate, toolStripButton6.Checked);
			RebuildGrid();
		}



		void ClearGrid()
		{
			dataGridView1.Rows.Clear();
			dataGridView1.Refresh();
		}

		void AddGridRow(string entity_name, float? level, Image? image, float? m, float? k, float? d, float? e, object? boost, ObjectID? id = null)
		{
			var index = dataGridView1.Rows.Add();
			dataGridView1.Rows[index].Cells[0].Value = entity_name;
			dataGridView1.Rows[index].Cells[1].Value = level;
			dataGridView1.Rows[index].Cells[2].Value = image == null ? Properties.Resources.pixel : image;
			dataGridView1.Rows[index].Cells[3].Value = m;
			dataGridView1.Rows[index].Cells[4].Value = k;
			dataGridView1.Rows[index].Cells[5].Value = d;
			dataGridView1.Rows[index].Cells[6].Value = e;
			dataGridView1.Rows[index].Cells[7].Value = boost;

			if (level == null)
			{
				dataGridView1.Rows[index].Cells[1].ReadOnly = true;
			}

			if (boost == null)
			{
				dataGridView1.Rows[index].Cells[7].ReadOnly = true;
			}

			dataGridView1.Rows[index].Tag = id;
		}



		/// <summary>
		/// Calculate
		/// </summary>
		private void button1_Click(object sender, EventArgs e)
		{
			ControlsToState();
			GridToState();
			OGameProd.CalcAll(ref st);
			StateToGrid();
			toolStripStatusLabel2.Text = st.factor.ToString("0.00");
			toolStripStatusLabel4.Text = st.crawlers_count_max.ToString();
			SaveSettings();
		}

		/// <summary>
		/// Rebuild the table if the alliance class, player class, selected lifeform, or team composition has changed.
		/// Building levels/number of units are drawn from the internal context (actual values are taken).
		/// </summary>
		void RebuildGrid()
		{
			LifeForm.Type lf = st.lf;
			AllyClass ac = st.ally_class;
			PlayerClass pc = st.player_class;
			bool engineer = st.engineer;
			bool geologist = st.geologist;
			bool command_staff = st.commander && st.admiral && st.engineer && st.geologist && st.technocrate;

			ClearGrid();

			AddGridRow("Basic Income", null, null, null, null, null, null, null, ObjectID.NaturalProd);

			// Production buildings

			AddGridRow("Metal Mine", st.metal_mine, Properties.Resources.metal_mine, null, null, null, null, st.metal_prod.ToString() + "%", ObjectID.MetalMine);
			AddGridRow("Crystal Mine", st.crystal_mine, Properties.Resources.crystal_mine, null, null, null, null, st.crystal_prod.ToString() + "%", ObjectID.CrystalMine);
			AddGridRow("Deuterium Synthesizer", st.deut_synth, Properties.Resources.deut_synth, null, null, null, null, st.deut_prod.ToString() + "%", ObjectID.DeutSynth);
			AddGridRow("Solar Plant", st.solar_plant, Properties.Resources.solar, null, null, null, null, st.solar_prod.ToString() + "%", ObjectID.SolarPlant);
			AddGridRow("Fusion Reactor", st.fusion, Properties.Resources.fusion, null, null, null, null, st.fusion_prod.ToString() + "%", ObjectID.Fusion);

			// LF Buildings
			if (lf != LifeForm.Type.NoLifeForm)
			{
				Image? pic = null;
				int[]? arr = null;
				LifeForm.ObjectID obj_base = LifeForm.ObjectID.Human_Base;
				switch (lf)
				{
					case LifeForm.Type.Rocktal:
						arr = st.rock_buildings;
						obj_base = LifeForm.ObjectID.Rock_Base;
						pic = Properties.Resources.rock;
						break;
					case LifeForm.Type.Human:
						arr = st.human_buildings;
						obj_base = LifeForm.ObjectID.Human_Base;
						pic = Properties.Resources.human;
						break;
					case LifeForm.Type.Mecha: 
						arr = st.mecha_buildings;
						obj_base = LifeForm.ObjectID.Mecha_Base;
						pic = Properties.Resources.mecha;
						break;
					case LifeForm.Type.ShavedPubis:
						arr = st.pubis_buildings;
						obj_base = LifeForm.ObjectID.Kaelish_Base;
						pic = Properties.Resources.shaved_pubis;
						break;
				}

				var list = LifeForm.GetBuildings(lf);
				foreach (var id in list)
				{
					int level = id - obj_base;
					AddGridRow(LifeForm.GetBuildingName(id), arr != null ? arr[level] : 0, pic, null, null, null, null, null, (ObjectID)id);
				}
			}

			// Producing units
			AddGridRow("Solar Satellite", st.ssat, Properties.Resources.ssat, null, null, null, null, st.ssat_prod.ToString() + "%", ObjectID.SolarSat);
			AddGridRow("Crawler", st.crawlers, Properties.Resources.crawler, null, null, null, null, st.crawlers_prod.ToString() + "%", ObjectID.Crawler);

			// Research
			AddGridRow("Plasma Technology", st.plasma_tech, Properties.Resources.plasma, null, null, null, null, null, ObjectID.PlasmaTech);

			// Items
			AddGridRow("Metal Booster", null, null, null, null, null, null, st.metal_booster.ToString() + "%", ObjectID.MetalBooster);
			AddGridRow("Crystal Booster", null, null, null, null, null, null, st.crystal_booster.ToString() + "%", ObjectID.CrystalBooster);
			AddGridRow("Deuterium Booster", null, null, null, null, null, null, st.deut_booster.ToString() + "%", ObjectID.DeutBooster);
			AddGridRow("Energy Booster", null, null, null, null, null, null, st.energy_booster.ToString() + "%", ObjectID.EnergyBooster);

			// Officers
			AddGridRow("Geologist", null, geologist ? Properties.Resources.geologist_on : Properties.Resources.geologist_off, null, null, null, null, null, ObjectID.GeologistBonus);
			AddGridRow("Engineer", null, engineer ? Properties.Resources.engineer_on : Properties.Resources.engineer_off, null, null, null, null, null, ObjectID.EngineerBonus);
			AddGridRow("Commanding Staff", null, command_staff ? Properties.Resources.all : Properties.Resources.all_off, null, null, null, null, null, ObjectID.CommandStaffBonus);

			// Class
			switch (pc)
			{
				case PlayerClass.Collector:
					AddGridRow("Class", null, Properties.Resources.collector, null, null, null, null, null, ObjectID.PlayerClassBonus);
					break;
				case PlayerClass.General:
					AddGridRow("Class", null, Properties.Resources.general, null, null, null, null, null, ObjectID.PlayerClassBonus);
					break;
				case PlayerClass.ExpoDrocher:
					AddGridRow("Class", null, Properties.Resources.explorer, null, null, null, null, null, ObjectID.PlayerClassBonus);
					break;
				case PlayerClass.NoClass:
					AddGridRow("Class", null, Properties.Resources.not_selected, null, null, null, null, null, ObjectID.PlayerClassBonus);
					break;
			}

			// Alliance Class
			switch (ac)
			{
				case AllyClass.Traders:
					AddGridRow("Alliance Class", null, Properties.Resources.ally_traders, null, null, null, null, null, ObjectID.AllyClassBonus);
					break;
				case AllyClass.Warriors:
					AddGridRow("Alliance Class", null, Properties.Resources.ally_warriors, null, null, null, null, null, ObjectID.AllyClassBonus);
					break;
				case AllyClass.Explorers:
					AddGridRow("Alliance Class", null, Properties.Resources.ally_explorers, null, null, null, null, null, ObjectID.AllyClassBonus);
					break;
				case AllyClass.NotSelected:
					AddGridRow("Alliance Class", null, Properties.Resources.ally_not_selected, null, null, null, null, null, ObjectID.AllyClassBonus);
					break;
			}

			// Life-form tech bonus
			AddGridRow("Lifeform Tech Bonus", null, null, null, null, null, null, null, ObjectID.LFBonus);

			// Total
			AddGridRow("Total", null, null, null, null, null, null, null);

			AddGridRow("Energy consumption", null, null, null, null, null, null, null, ObjectID.ConsEnergy);
			AddGridRow("Total per hour", null, null, null, null, null, null, null, ObjectID.ProdHour);
			AddGridRow("Total per day", null, null, null, null, null, null, null, ObjectID.ProdDay);
			AddGridRow("Total per week", null, null, null, null, null, null, null, ObjectID.ProdWeek);
			AddGridRow("Total per hour (all planets)", null, null, null, null, null, null, null, ObjectID.ProdHourAll);
			AddGridRow("Total per day (all planets)", null, null, null, null, null, null, null, ObjectID.ProdDayAll);
			AddGridRow("Total per week (all planets)", null, null, null, null, null, null, null, ObjectID.ProdWeekAll);

			toolStripStatusLabel2.Text = "---";
			toolStripStatusLabel4.Text = "0";
		}

		static void SetDoubleBuffer(Control ctl, bool DoubleBuffered)
		{
			typeof(Control).InvokeMember("DoubleBuffered",
				BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
				null, ctl, new object[] { DoubleBuffered });
		}

		/// <summary>
		/// Transfer modifiable properties (mine levels, LF buildings, number of sats and crawlers, performance settings in percentages) from grid to context.
		/// </summary>
		void GridToState()
		{
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				string prc = row.Cells[7].Value != null ? ((string)row.Cells[7].Value).Replace("%", "") : "0";

				// Uniform processing is applied for LF building levels
				if (st.lf != LifeForm.Type.NoLifeForm && row.Tag != null)
				{
					var lf_buildings = LifeForm.GetBuildings(st.lf);
					int bid = 0;

					if (lf_buildings.Contains((LifeForm.ObjectID)row.Tag))
					{
						switch (st.lf)
						{
							case LifeForm.Type.Human:
								bid = (LifeForm.ObjectID)row.Tag - LifeForm.ObjectID.Human_Base;
								st.human_buildings[bid] = Convert.ToInt32(row.Cells[1].Value);
								break;
							case LifeForm.Type.Rocktal:
								bid = (LifeForm.ObjectID)row.Tag - LifeForm.ObjectID.Rock_Base;
								st.rock_buildings[bid] = Convert.ToInt32(row.Cells[1].Value);
								break;
							case LifeForm.Type.Mecha:
								bid = (LifeForm.ObjectID)row.Tag - LifeForm.ObjectID.Mecha_Base;
								st.mecha_buildings[bid] = Convert.ToInt32(row.Cells[1].Value);
								break;
							case LifeForm.Type.ShavedPubis:
								bid = (LifeForm.ObjectID)row.Tag - LifeForm.ObjectID.Kaelish_Base;
								st.pubis_buildings[bid] = Convert.ToInt32(row.Cells[1].Value);
								break;
						}
						continue;
					}
				}

				switch (row.Tag)
				{
					case ObjectID.MetalMine:
						st.metal_mine = Convert.ToInt32(row.Cells[1].Value);
						st.metal_prod = Convert.ToInt32(prc);
						break;
					case ObjectID.CrystalMine:
						st.crystal_mine = Convert.ToInt32(row.Cells[1].Value);
						st.crystal_prod = Convert.ToInt32(prc);
						break;
					case ObjectID.DeutSynth:
						st.deut_synth = Convert.ToInt32(row.Cells[1].Value);
						st.deut_prod = Convert.ToInt32(prc);
						break;
					case ObjectID.SolarPlant:
						st.solar_plant = Convert.ToInt32(row.Cells[1].Value);
						st.solar_prod = Convert.ToInt32(prc);
						break;
					case ObjectID.Fusion:
						st.fusion = Convert.ToInt32(row.Cells[1].Value);
						st.fusion_prod = Convert.ToInt32(prc);
						break;
					case ObjectID.SolarSat:
						st.ssat = Convert.ToInt32(row.Cells[1].Value);
						st.ssat_prod = Convert.ToInt32(prc);
						break;
					case ObjectID.Crawler:
						st.crawlers = Convert.ToInt32(row.Cells[1].Value);
						st.crawlers_prod = Convert.ToInt32(prc);
						break;
					case ObjectID.PlasmaTech:
						st.plasma_tech = Convert.ToInt32(row.Cells[1].Value);
						break;
					case ObjectID.MetalBooster:
						st.metal_booster = Convert.ToInt32(prc);
						break;
					case ObjectID.CrystalBooster:
						st.crystal_booster = Convert.ToInt32(prc);
						break;
					case ObjectID.DeutBooster:
						st.deut_booster = Convert.ToInt32(prc);
						break;
					case ObjectID.EnergyBooster:
						st.energy_booster = Convert.ToInt32(prc);
						break;
				}
			}
		}

		/// <summary>
		/// Transfer all calculated properties from the context to the grid.
		/// </summary>
		void StateToGrid()
		{
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				// Unified processing is applied for LF buildings
				if (st.lf != LifeForm.Type.NoLifeForm && row.Tag != null)
				{
					var lf_buildings = LifeForm.GetBuildings(st.lf);
					int bid = 0;

					if (lf_buildings.Contains((LifeForm.ObjectID)row.Tag))
					{
						switch (st.lf)
						{
							case LifeForm.Type.Human:
								bid = (LifeForm.ObjectID)row.Tag - LifeForm.ObjectID.Human_Base;
								break;
							case LifeForm.Type.Rocktal:
								bid = (LifeForm.ObjectID)row.Tag - LifeForm.ObjectID.Rock_Base;
								break;
							case LifeForm.Type.Mecha:
								bid = (LifeForm.ObjectID)row.Tag - LifeForm.ObjectID.Mecha_Base;
								break;
							case LifeForm.Type.ShavedPubis:
								bid = (LifeForm.ObjectID)row.Tag - LifeForm.ObjectID.Kaelish_Base;
								break;
						}

						double bonus_m = st.lf_buildings_bonus_m[bid];
						double bonus_k = st.lf_buildings_bonus_k[bid];
						double bonus_d = st.lf_buildings_bonus_d[bid];
						double bonus_e = st.lf_buildings_bonus_e[bid] - st.lf_buildings_cons[bid];

						row.Cells[3].Value = bonus_m != 0 ? (bonus_m.ToString("0.00")) : null;
						row.Cells[4].Value = bonus_k != 0 ? (bonus_k.ToString("0.00")) : null;
						row.Cells[5].Value = bonus_d != 0 ? (bonus_d.ToString("0.00")) : null;
						row.Cells[6].Value = bonus_e != 0 ? (bonus_e.ToString("0.00")) : null;
						continue;
					}
				}

				switch (row.Tag)
				{
					case ObjectID.NaturalProd:
						row.Cells[3].Value = st.natural_m.ToString("0.00");
						row.Cells[4].Value = st.natural_k.ToString("0.00");
						break;
					case ObjectID.MetalMine:
						row.Cells[3].Value = st.base_m.ToString("0.00");
						row.Cells[6].Value = "-" + st.cons_met.ToString("0.00");
						break;
					case ObjectID.CrystalMine:
						row.Cells[4].Value = st.base_k.ToString("0.00");
						row.Cells[6].Value = "-" + st.cons_crys.ToString("0.00");
						break;
					case ObjectID.DeutSynth:
						row.Cells[5].Value = st.base_d.ToString("0.00");
						row.Cells[6].Value = "-" + st.cons_deut.ToString("0.00");
						break;
					case ObjectID.SolarPlant:
						row.Cells[6].Value = st.e_sol.ToString("0.00");
						break;
					case ObjectID.Fusion:
						row.Cells[5].Value = "-" + st.cons_fusion.ToString("0.00");
						row.Cells[6].Value = st.e_fusion.ToString("0.00");
						break;
					case ObjectID.SolarSat:
						row.Cells[6].Value = st.e_sat.ToString("0.00");
						break;
					case ObjectID.Crawler:
						row.Cells[3].Value = st.crawlers_m != 0 ? st.crawlers_m.ToString("0.00") : null;
						row.Cells[4].Value = st.crawlers_k != 0 ? st.crawlers_k.ToString("0.00") : null;
						row.Cells[5].Value = st.crawlers_d != 0 ? st.crawlers_d.ToString("0.00") : null;
						row.Cells[6].Value = st.cons_crawlers != 0 ? "-" + st.cons_crawlers.ToString("0.00") : null;
						if (st.maximize_crawlers)
						{
							st.crawlers = st.crawlers_count_max;
							row.Cells[1].Value = st.crawlers;
						}
						break;
					case ObjectID.PlasmaTech:
						row.Cells[3].Value = st.plasma_m.ToString("0.00");
						row.Cells[4].Value = st.plasma_k.ToString("0.00");
						row.Cells[5].Value = st.plasma_d.ToString("0.00");
						break;
					case ObjectID.MetalBooster:
						row.Cells[3].Value = st.booster_m.ToString("0.00");
						break;
					case ObjectID.CrystalBooster:
						row.Cells[4].Value = st.booster_k.ToString("0.00");
						break;
					case ObjectID.DeutBooster:
						row.Cells[5].Value = st.booster_d.ToString("0.00");
						break;
					case ObjectID.EnergyBooster:
						row.Cells[6].Value = st.booster_e.ToString("0.00");
						break;

					case ObjectID.GeologistBonus:
						row.Cells[3].Value = st.geologist_m.ToString("0.00");
						row.Cells[4].Value = st.geologist_k.ToString("0.00");
						row.Cells[5].Value = st.geologist_d.ToString("0.00");
						break;
					case ObjectID.EngineerBonus:
						row.Cells[6].Value = st.engineer_e.ToString("0.00");
						break;
					case ObjectID.CommandStaffBonus:
						row.Cells[3].Value = st.staff_m.ToString("0.00");
						row.Cells[4].Value = st.staff_k.ToString("0.00");
						row.Cells[5].Value = st.staff_d.ToString("0.00");
						row.Cells[6].Value = st.staff_e.ToString("0.00");
						break;
					case ObjectID.PlayerClassBonus:
						row.Cells[3].Value = st.player_m.ToString("0.00");
						row.Cells[4].Value = st.player_k.ToString("0.00");
						row.Cells[5].Value = st.player_d.ToString("0.00");
						row.Cells[6].Value = st.player_e.ToString("0.00");
						break;
					case ObjectID.AllyClassBonus:
						row.Cells[3].Value = st.ally_m.ToString("0.00");
						row.Cells[4].Value = st.ally_k.ToString("0.00");
						row.Cells[5].Value = st.ally_d.ToString("0.00");
						row.Cells[6].Value = st.ally_e.ToString("0.00");
						break;
					case ObjectID.LFBonus:
						row.Cells[3].Value = st.lf_prod_m.ToString("0.00");
						row.Cells[4].Value = st.lf_prod_k.ToString("0.00");
						row.Cells[5].Value = st.lf_prod_d.ToString("0.00");
						row.Cells[6].Value = st.lf_prod_e.ToString("0.00");
						break;

					case ObjectID.ConsEnergy:
						row.Cells[6].Value = st.econs.ToString("0.00");
						break;
					case ObjectID.ProdHour:
						row.Cells[3].Value = st.total_m.ToString("0.00");
						row.Cells[4].Value = st.total_k.ToString("0.00");
						row.Cells[5].Value = st.total_d.ToString("0.00");
						row.Cells[6].Value = st.total_e.ToString("0.00");
						break;
					case ObjectID.ProdDay:
						row.Cells[3].Value = (st.total_m * 24).ToString("0.00");
						row.Cells[4].Value = (st.total_k * 24).ToString("0.00");
						row.Cells[5].Value = (st.total_d * 24).ToString("0.00");
						break;
					case ObjectID.ProdWeek:
						row.Cells[3].Value = (st.total_m * 24 * 7).ToString("0.00");
						row.Cells[4].Value = (st.total_k * 24 * 7).ToString("0.00");
						row.Cells[5].Value = (st.total_d * 24 * 7).ToString("0.00");
						break;
					case ObjectID.ProdHourAll:
						row.Cells[3].Value = (st.total_m * st.num_planets).ToString("0.00");
						row.Cells[4].Value = (st.total_k * st.num_planets).ToString("0.00");
						row.Cells[5].Value = (st.total_d * st.num_planets).ToString("0.00");
						break;
					case ObjectID.ProdDayAll:
						row.Cells[3].Value = (st.total_m * 24 * st.num_planets).ToString("0.00");
						row.Cells[4].Value = (st.total_k * 24 * st.num_planets).ToString("0.00");
						row.Cells[5].Value = (st.total_d * 24 * st.num_planets).ToString("0.00");
						break;
					case ObjectID.ProdWeekAll:
						row.Cells[3].Value = (st.total_m * 24 * 7 * st.num_planets).ToString("0.00");
						row.Cells[4].Value = (st.total_k * 24 * 7 * st.num_planets).ToString("0.00");
						row.Cells[5].Value = (st.total_d * 24 * 7 * st.num_planets).ToString("0.00");
						break;
				}
			}
		}



		private void экспортироватьНастройкиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				File.WriteAllText(saveFileDialog1.FileName, SerializeSettings(), System.Text.Encoding.UTF8);
				Console.WriteLine("The settings are saved to a file {0}", saveFileDialog1.FileName);
			}
		}

		private void импортироватьНастройкиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string text = File.ReadAllText (openFileDialog1.FileName, System.Text.Encoding.UTF8);
				st = DeserializeSettings(text);
				StateToControls();
				Console.WriteLine("Settings loaded from a file {0}", openFileDialog1.FileName);
			}
		}

		private void сброситьНастройкиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ResetSettings();
			StateToControls();
			Console.WriteLine("The settings are reset to their original state.");
		}

		string SerializeSettings ()
		{
			XmlSerializer ser = new XmlSerializer(typeof(State));
			using (StringWriter textWriter = new StringWriter())
			{
				ser.Serialize(textWriter, st);
				string text = textWriter.ToString();
				return text;
			}
		}

		State DeserializeSettings(string text)
		{
			State settings = new();
			var ser = new XmlSerializer(typeof(State));

			using (TextReader reader = new StringReader(text))
			{
				var res = ser.Deserialize(reader);
				if (res != null)
				{
					settings = (State)res;
				}
			}

			// For compatibility (when LF buildigns were not yet available)
			if (settings.rock_buildings == null)
				settings.rock_buildings = new int[10];
			if (settings.mecha_buildings == null)
				settings.mecha_buildings = new int[10];
			if (settings.human_buildings == null)
				settings.human_buildings = new int[10];
			if (settings.pubis_buildings == null)
				settings.pubis_buildings = new int[10];

			return settings;
		}

		void LoadSettings()
		{
			string text = Properties.Settings.Default.settings;
			if (text == "")
			{
				st = new();
				return;
			}
			st = DeserializeSettings(text);
		}

		void SaveSettings()
		{
			Properties.Settings.Default.settings = SerializeSettings();
			Properties.Settings.Default.Save();
		}

		void ResetSettings()
		{
			st = new();
			SaveSettings();
		}
	}



	/// <summary>
	/// Officer type (for simplicity, Commander also counts as an officer)
	/// </summary>
	public enum OfficeerType
	{
		Commander,
		Admiral,
		Engineer,
		Geologist,
		Technocrate,
	}

	/// <summary>
	/// Alliance Class
	/// </summary>
	public enum AllyClass
	{
		Warriors,
		Traders,
		Explorers,
		NotSelected,
	}

	/// <summary>
	/// Player Class
	/// </summary>
	public enum PlayerClass
	{
		Collector,
		General,
		ExpoDrocher,
		NoClass,
	}

	/// <summary>
	/// Type of game object (ID may not match the one in the game)
	/// </summary>
	public enum ObjectID
	{
		NaturalProd = 2000,         // Basic Income

		MetalMine = 1,
		CrystalMine = 2,
		DeutSynth = 3,
		SolarPlant = 4,
		Fusion = 12,
		SolarSat = 212,
		Crawler = 300,
		PlasmaTech = 400,

		MetalBooster = 1000,
		CrystalBooster = 1001,
		DeutBooster = 1002,
		EnergyBooster = 1003,

		// See LifeForm.cs for the ID for the LF

		GeologistBonus = 50000,
		EngineerBonus = 50001,
		CommandStaffBonus = 50002,
		PlayerClassBonus = 50003,
		AllyClassBonus = 50004,
		LFBonus = 50005,

		ConsEnergy = 69999,   // Energy consumption (total)
		ProdHour = 70000,   // Production per hour
		ProdDay = 70001,        // Production per day
		ProdWeek = 70002,       // Production per week
		ProdHourAll = 70003,        // Production per hour (all planets)
		ProdDayAll = 70004,         // Production per day (all planets)
		ProdWeekAll = 70005,        // Production per week (all planets)
	}

	/// <summary>
	/// Account/universe state limited to our subject area (production calculation)
	/// </summary>
	[XmlRoot]
	public struct State
	{
		public State() { }

		[XmlElement]
		public int eco_speed = 1;       // development speed
		[XmlElement]
		public int planet_pos = 8;      // position
		[XmlElement]
		public int planet_temp = -30;       // Minimum temperature of the planet
		[XmlElement]
		public int num_planets = 1;         // Number of planets in the Empire

		[XmlElement]
		public bool maximize_crawlers = true;

		[XmlElement]
		public AllyClass ally_class = AllyClass.NotSelected;
		[XmlElement]
		public PlayerClass player_class = PlayerClass.NoClass;
		[XmlElement]
		public LifeForm.Type lf = LifeForm.Type.NoLifeForm;

		[XmlElement]
		public bool commander = false;
		[XmlElement]
		public bool admiral = false;
		[XmlElement]
		public bool engineer = false;
		[XmlElement]
		public bool geologist = false;
		[XmlElement]
		public bool technocrate = false;

		[XmlElement]
		public int metal_mine = 0;
		[XmlElement]
		public int crystal_mine = 0;
		[XmlElement]
		public int deut_synth = 0;
		[XmlElement]
		public int solar_plant = 0;
		[XmlElement]
		public int fusion = 0;

		[XmlElement]
		public int[] rock_buildings = new int[10];
		[XmlElement]
		public int[] human_buildings = new int[10];
		[XmlElement]
		public int[] mecha_buildings = new int[10];
		[XmlElement]
		public int[] pubis_buildings = new int[10];

		[XmlElement]
		public int ssat = 0;
		[XmlElement]
		public int crawlers = 0;

		[XmlElement]
		public int metal_prod = 100;
		[XmlElement]
		public int crystal_prod = 100;
		[XmlElement]
		public int deut_prod = 100;
		[XmlElement]
		public int solar_prod = 100;
		[XmlElement]
		public int fusion_prod = 100;
		[XmlElement]
		public int ssat_prod = 100;
		[XmlElement]
		public int crawlers_prod = 100;

		[XmlElement]
		public int metal_booster = 0;
		[XmlElement]
		public int crystal_booster = 0;
		[XmlElement]
		public int deut_booster = 0;
		[XmlElement]
		public int energy_booster = 0;

		[XmlElement]
		public int plasma_tech = 0;
		[XmlElement]
		public int energo_tech = 0;

		[XmlElement]
		public float lf_metal_bonus = 0.0f;
		[XmlElement]
		public float lf_crystal_bonus = 0.0f;
		[XmlElement]
		public float lf_deut_bonus = 0.0f;
		[XmlElement]
		public float lf_energy_bonus = 0.0f;
		[XmlElement]
		public float lf_class_bonus = 0.0f;

		// Dynamic properties that are generated during the calculation process (do not need to be saved).

		[XmlIgnore] public double natural_m;
		[XmlIgnore] public double natural_k;

		[XmlIgnore] public double base_m;
		[XmlIgnore] public double base_k;
		[XmlIgnore] public double base_d;

		[XmlIgnore] public double cons_met;
		[XmlIgnore] public double cons_crys;
		[XmlIgnore] public double cons_deut;
		[XmlIgnore] public double cons_fusion;
		[XmlIgnore] public double cons_crawlers;
		[XmlIgnore] public double econs;            // total energy consumption

		[XmlIgnore] public double e_sol;
		[XmlIgnore] public double e_fusion;
		[XmlIgnore] public double e_sat;
		[XmlIgnore] public double base_e;             // Basic energy output (solar + fusion + sats)

		[XmlIgnore] public double e;            // planet energy
		[XmlIgnore] public double factor;       // Production factor

		[XmlIgnore] public double crawlers_m;
		[XmlIgnore] public double crawlers_k;
		[XmlIgnore] public double crawlers_d;
		[XmlIgnore] public int crawlers_count_max;              // max active crawlers

		[XmlIgnore] public double plasma_m;
		[XmlIgnore] public double plasma_k;
		[XmlIgnore] public double plasma_d;

		[XmlIgnore] public double booster_m;
		[XmlIgnore] public double booster_k;
		[XmlIgnore] public double booster_d;
		[XmlIgnore] public double booster_e;

		[XmlIgnore] public double geologist_m;
		[XmlIgnore] public double geologist_k;
		[XmlIgnore] public double geologist_d;
		[XmlIgnore] public double engineer_e;
		[XmlIgnore] public double staff_m;
		[XmlIgnore] public double staff_k;
		[XmlIgnore] public double staff_d;
		[XmlIgnore] public double staff_e;
		[XmlIgnore] public double player_m;
		[XmlIgnore] public double player_k;
		[XmlIgnore] public double player_d;
		[XmlIgnore] public double player_e;
		[XmlIgnore] public double ally_m;
		[XmlIgnore] public double ally_k;
		[XmlIgnore] public double ally_d;
		[XmlIgnore] public double ally_e;
		[XmlIgnore] public double lf_prod_m;
		[XmlIgnore] public double lf_prod_k;
		[XmlIgnore] public double lf_prod_d;
		[XmlIgnore] public double lf_prod_e;

		[XmlIgnore] public double[] lf_buildings_bonus_m = new double[10];
		[XmlIgnore] public double[] lf_buildings_bonus_k = new double[10];
		[XmlIgnore] public double[] lf_buildings_bonus_d = new double[10];
		[XmlIgnore] public double[] lf_buildings_bonus_e = new double[10];
		[XmlIgnore] public double[] lf_buildings_cons = new double[10];

		[XmlIgnore] public double total_m;
		[XmlIgnore] public double total_k;
		[XmlIgnore] public double total_d;
		[XmlIgnore] public double total_e;
	}
}
