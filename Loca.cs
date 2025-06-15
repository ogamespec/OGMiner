// напиши на c# программу для локализации строк. нужен класс Loca с методом GetString, который принимает параметры язык, ID строки и переменные параметры для замены таких %1 %2 %3 в локализованной строке на строковые подстановки

// Вот реализация класса Loca для локализации строк на C#. Класс позволяет получать локализованные строки по их ID, заменять плейсхолдеры (%1, %2, %3 и т.д.) на переданные значения и поддерживает разные языки.

using System;
using System.Collections.Generic;

public static class Loca
{
	// Словарь для хранения локализованных строк
	// Формат: [язык][ID_строки] = "строка с плейсхолдерами %1 %2 %3..."
	private static readonly Dictionary<string, Dictionary<string, string>> _localizations =
		new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);

	/// <summary>
	/// Инициализация локализаций (обычно загружается из файла/БД)
	/// </summary>
	static Loca()
	{
		// Пример данных (на практике загружайте из JSON/XML/БД)
		AddLanguage("en", new Dictionary<string, string>
		{
			{ "ABOUT", "OGMiner (ver %1) - OGame production calculation utility\r\n© %2, %3\r\nThe author takes no responsibility according to the Creative Commons 1.0 license" },
			{ "CLOSE", "Close" },

			{ "EXPORT_SETTINGS", "Export settings..." },
			{ "IMPORT_SETTINGS", "Import settings..." },
			{ "RESET_SETTINGS", "Reset settings" },
			{ "PROD_FACTOR", "Production Factor:" },
			{ "MAX_CRAWLERS", "Max Crawlers:" },
			{ "PROD_MSU_TOTAL", "Production (MSU):" },
			{ "BN", "Bn" },
			{ "PROD_CALC", "Production calculator" },
			{ "LF_BONUS", "Life form bonus for the class (T18)" },
			{ "ENERGY_TECH", "Energy technology" },
			{ "MAXIMIZE_CRAWLERS", "Automatically maximize the number of crawlers" },
			{ "LF_GLOBAL_BONUS", "Global life-form tech bonus" },
			{ "ENERGY", "Energy" },
			{ "DEUT", "Deuterium" },
			{ "CRYS", "Crystal" },
			{ "MET", "Metal" },
			{ "RECALC", "Recalculate" },
			{ "PLANET_POS", "Position of the planet" },
			{ "PLANET_MIN_TEMP", "Minimum planet temperature" },
			{ "ECO_SPEED", "Development speed" },
			{ "NUM_PLANETS", "Number of planets" },
			{ "ID_NAME", "Name of production/building" },
			{ "LEVEL", "Level/number" },
			{ "PICTURE", "Picture" },
			{ "PROD_SETTINGS", "Production Settings" },
			{ "CHOOSE_ALLY_CLASS", "Choose an alliance class" },
			{ "ALLY_CLASS_WARRIORS", "Warriors" },
			{ "ALLY_CLASS_TRADERS", "Traders" },
			{ "ALLY_CLASS_RESEARCHERS", "Researchers" },
			{ "ALLY_CLASS_NONE", "No alliance class selected" },
			{ "CHOOSE_PLAYER_CLASS", "Select a player's class" },
			{ "PLAYER_CLASS_COLLECTOR", "Collector" },
			{ "PLAYER_CLASS_GENERAL", "General" },
			{ "PLAYER_CLASS_DISCO", "Discoverer" },
			{ "PLAYER_CLASS_NONE", "No player class selected" },
			{ "CHOOSE_LF", "Choose a life form" },
			{ "LF_TYPE_HUMANS", "Humans" },
			{ "LF_TYPE_SHAVED_PUBIS", "Kaelesh" },
			{ "LF_TYPE_ROCK", "Rock´tal" },
			{ "LF_TYPE_MECHA", "Mechas" },
			{ "LF_TYPE_NONE", "No life form selected" },
			{ "COMMANDER_TIP", "OGame Commander\r\nGives production bonus only with full Staff" },
			{ "ADMIRAL_TIP", "Admiral\r\nGives production bonus only with full Staff" },
			{ "ENGINEER_TIP", "Engineer\r\n+10% energy production" },
			{ "GEOLOGIST_TIP", "Geologist\r\n+10% mine production, +10% crawlers for Collector" },
			{ "TECHNOCRAT_TIP", "Technocrat\r\nGives production bonus only with full Staff" },

			{ "NaturalProd", "Basic Income" },
			{ "MetalMine", "Metal Mine" },
			{ "CrystalMine", "Crystal Mine" },
			{ "DeutSynth", "Deuterium Synthesizer" },
			{ "SolarPlant", "Solar Plant" },
			{ "Fusion", "Fusion Reactor" },
			{ "SolarSat", "Solar Satellite" },
			{ "Crawler", "Crawler" },
			{ "PlasmaTech", "Plasma Technology" },
			{ "MetalBooster", "Metal Booster" },
			{ "CrystalBooster", "Crystal Booster" },
			{ "DeutBooster", "Deuterium Booster" },
			{ "EnergyBooster", "Energy Booster" },
			{ "GeologistBonus", "Geologist" },
			{ "EngineerBonus", "Engineer" },
			{ "CommandStaffBonus", "Commanding Staff" },
			{ "PlayerClassBonus", "Class" },
			{ "AllyClassBonus", "Alliance Class" },
			{ "LFBonus", "Lifeform Tech Bonus" },
			{ "Total", "Total" },
			{ "ConsEnergy", "Energy consumption" },
			{ "ProdHour", "Total per hour" },
			{ "ProdDay", "Total per day" },
			{ "ProdWeek", "Total per week" },
			{ "ProdHourAll", "Total per hour (all planets)" },
			{ "ProdDayAll", "Total per day (all planets)" },
			{ "ProdWeekAll", "Total per week (all planets)" },

			{ "Human_TechBuilding", "Research Centre" },
			{ "Human_School", "Academy of Sciences" },
			{ "Human_HighSchool", "Neuro-Calibration Centre" },
			{ "Human_ResourceBooster1", "High Energy Smelting" },
			{ "Human_LifeSupport1", "Food Silo" },
			{ "Human_ResourceBooster2", "Fusion-Powered Production" },
			{ "Human_LifeSupport2", "Skyscraper" },
			{ "Human_ResourceBooster3", "Biotech Lab" },
			{ "Human_TechTreeBooster", "Metropolis" },
			{ "Human_LifeFormProtection", "Planetary Shield" },
			{ "Rock_TechBuilding", "Rune Technologium" },
			{ "Rock_School", "Rune Forge" },
			{ "Rock_HighSchool", "Oriktorium" },
			{ "Rock_ResourceBooster1", "Magma Forge" },
			{ "Rock_EnergyManipulator", "Disruption Chamber" },
			{ "Rock_CostReductionBuildings1", "Megalith" },
			{ "Rock_ResourceBooster2", "Crystal Refinery" },
			{ "Rock_ResourceBooster3", "Deuterium Synthesissy" },
			{ "Rock_CostReductionBuildings2", "Mineral Research Centre" },
			{ "Rock_RecycleAttackerFleet", "Advanced Recycling Plant" },
			{ "Mecha_TechBuilding", "Robotics Research Centre" },
			{ "Mecha_School", "Update Network" },
			{ "Mecha_HighSchool", "Quantum Computer Centre" },
			{ "Mecha_ProductionSpeedShips", "Automatised Assembly Centre" },
			{ "Mecha_TechTreeBooster1", "High-Performance Transformer" },
			{ "Mecha_ResourceBooster", "Microchip Assembly Line" },
			{ "Mecha_LifeSupport1", "Production Assembly Hall" },
			{ "Mecha_LifeSupport2", "High-Performance Synthesiser" },
			{ "Mecha_TechTreeBooster2", "Chip Mass Production" },
			{ "Mecha_SpaceDockExtender", "Nano Repair Bots" },
			{ "Kaelish_TechBuilding", "Vortex Chamber" },
			{ "Kaelish_School", "Halls of Realisation" },
			{ "Kaelish_HighSchool", "Forum of Transcendence" },
			{ "Kaelish_LifeSupport1", "Antimatter Convector" },
			{ "Kaelish_LifeSupportAndResearch", "Cloning Laboratory" },
			{ "Kaelish_LifeSupport2", "Chrysalis Accelerator" },
			{ "Kaelish_PlanetFieldsBooster", "Bio Modifier" },
			{ "Kaelish_UnlockCondition", "Psionic Modulator" },
			{ "Kaelish_ProductionSpeedShips", "Ship Manufacturing Hall" },
			{ "Kaelish_MoonChanceIncrease", "Supra Refractor" },

		});

		AddLanguage("ru", new Dictionary<string, string>
		{
			{ "ABOUT", "OGMiner (версия %1) - утилита для расчёта выработки в игре OGame\r\n© %2, %3\r\nАвтор не несёт никакой ответственности, согласно лицензии Creative Commons 1.0\r\n" },
			{ "CLOSE", "Закрыть" },

			{ "EXPORT_SETTINGS", "Экспортировать настройки..." },
			{ "IMPORT_SETTINGS", "Импортировать настройки..." },
			{ "RESET_SETTINGS", "Сбросить настройки" },
			{ "PROD_FACTOR", "Коэффициент производства:" },
			{ "MAX_CRAWLERS", "Гусеничников макс:" },
			{ "PROD_MSU_TOTAL", "Выработка (МСУ):" },
			{ "BN", "Г" },
			{ "PROD_CALC", "Расчёт производства" },
			{ "LF_BONUS", "Бонус формы жизни для класса (Т18)" },
			{ "ENERGY_TECH", "Энергетическая технология" },
			{ "MAXIMIZE_CRAWLERS", "Автоматически максимизировать количество гусеничников" },
			{ "LF_GLOBAL_BONUS", "Глобальный техн. бонус форм жизни" },
			{ "ENERGY", "Энергия" },
			{ "DEUT", "Дейтерий" },
			{ "CRYS", "Кристалл" },
			{ "MET", "Металл" },
			{ "RECALC", "Посчитать" },
			{ "PLANET_POS", "Позиция планеты" },
			{ "PLANET_MIN_TEMP", "Минимальная температура планеты" },
			{ "ECO_SPEED", "Скорость экономики" },
			{ "NUM_PLANETS", "Количество планет" },
			{ "ID_NAME", "Название производства/постройки" },
			{ "LEVEL", "Уровень/кол-во" },
			{ "PICTURE", "Картинка" },
			{ "PROD_SETTINGS", "Производительность" },
			{ "CHOOSE_ALLY_CLASS", "Выберите класс альянса" },
			{ "ALLY_CLASS_WARRIORS", "Воины" },
			{ "ALLY_CLASS_TRADERS", "Торговцы" },
			{ "ALLY_CLASS_RESEARCHERS", "Исследователи" },
			{ "ALLY_CLASS_NONE", "Не выбрано" },
			{ "CHOOSE_PLAYER_CLASS", "Выберите класс игрока" },
			{ "PLAYER_CLASS_COLLECTOR", "Коллекционер" },
			{ "PLAYER_CLASS_GENERAL", "Генерал" },
			{ "PLAYER_CLASS_DISCO", "Исследователь" },
			{ "PLAYER_CLASS_NONE", "Не выбрано" },
			{ "CHOOSE_LF", "Выберите форму жизни" },
			{ "LF_TYPE_HUMANS", "Люди" },
			{ "LF_TYPE_SHAVED_PUBIS", "Кэлиш" },
			{ "LF_TYPE_ROCK", "Рок´тал" },
			{ "LF_TYPE_MECHA", "Мехи" },
			{ "LF_TYPE_NONE", "Не выбрано" },
			{ "COMMANDER_TIP", "Командир ОГейма\r\nДаёт бонус производства только при полном Командном составе" },
			{ "ADMIRAL_TIP", "Адмирал\r\nДаёт бонус производства только при полном Командном составе" },
			{ "ENGINEER_TIP", "Инженер\r\n+10% производство энергии" },
			{ "GEOLOGIST_TIP", "Геолог\r\n+10% доход от шахты, +10% гусеничников у Коллекционера" },
			{ "TECHNOCRAT_TIP", "Технократ\r\nДаёт бонус производства только при полном Командном составе" },

			{ "NaturalProd", "Естественное производство" },
			{ "MetalMine", "Рудник по добыче металла" },
			{ "CrystalMine", "Рудник по добыче кристалла" },
			{ "DeutSynth", "Синтезатор дейтерия" },
			{ "SolarPlant", "Солнечная электростанция" },
			{ "Fusion", "Термоядерная электростанция" },
			{ "SolarSat", "Солнечный спутник" },
			{ "Crawler", "Гусеничник" },
			{ "PlasmaTech", "Плазменная технология" },
			{ "MetalBooster", "Ускоритель металла" },
			{ "CrystalBooster", "Ускоритель кристалла" },
			{ "DeutBooster", "Ускоритель дейтерия" },
			{ "EnergyBooster", "Ускоритель энергии" },
			{ "GeologistBonus", "Геолог" },
			{ "EngineerBonus", "Инженер" },
			{ "CommandStaffBonus", "Командный состав" },
			{ "PlayerClassBonus", "Класс" },
			{ "AllyClassBonus", "Класс альянса" },
			{ "LFBonus", "Техн. бонус форм жизни" },
			{ "Total", "Итого" },
			{ "ConsEnergy", "Потребление энергии" },
			{ "ProdHour", "Выработка в час" },
			{ "ProdDay", "Выработка в сутки" },
			{ "ProdWeek", "Выработка в неделю" },
			{ "ProdHourAll", "Выработка в час (все планеты)" },
			{ "ProdDayAll", "Выработка в сутки (все планеты)" },
			{ "ProdWeekAll", "Выработка в неделю (все планеты)" },

			{ "Human_TechBuilding", "Центр Исследований" },
			{ "Human_School", "Академия наук" },
			{ "Human_HighSchool", "Центр Нервной Калибрации" },
			{ "Human_ResourceBooster1", "Высокоэнергетическое плавление" },
			{ "Human_LifeSupport1", "Хранилище пищи" },
			{ "Human_ResourceBooster2", "Производство с термоядерным источником энергии" },
			{ "Human_LifeSupport2", "Небоскреб" },
			{ "Human_ResourceBooster3", "Биотехническая лаборатория" },
			{ "Human_TechTreeBooster", "Метрополь" },
			{ "Human_LifeFormProtection", "Планетарный щит" },
			{ "Rock_TechBuilding", "Рунный Технологиум" },
			{ "Rock_School", "Рунная Кузница" },
			{ "Rock_HighSchool", "Орикториум" },
			{ "Rock_ResourceBooster1", "Кузница Магмы" },
			{ "Rock_EnergyManipulator", "Камера Разрыва" },
			{ "Rock_CostReductionBuildings1", "Мегалит" },
			{ "Rock_ResourceBooster2", "Очистка Кристаллов" },
			{ "Rock_ResourceBooster3", "Синтезатор Дейтерия (роктал)" },
			{ "Rock_CostReductionBuildings2", "Центр исследования минералов" },
			{ "Rock_RecycleAttackerFleet", "Продвинутая установка переработки ресурсов" },
			{ "Mecha_TechBuilding", "Центр Роботических Исследований" },
			{ "Mecha_School", "Сеть обновлений" },
			{ "Mecha_HighSchool", "Центр Квантового Компьютера" },
			{ "Mecha_ProductionSpeedShips", "Автоматизированный центр сборки" },
			{ "Mecha_TechTreeBooster1", "Высокопроизводительный трансформер" },
			{ "Mecha_ResourceBooster", "Конвейер микрочипов" },
			{ "Mecha_LifeSupport1", "Производственно-сборочный цех" },
			{ "Mecha_LifeSupport2", "Высокопроизводительный Синтезатор" },
			{ "Mecha_TechTreeBooster2", "Массовое производство чипов" },
			{ "Mecha_SpaceDockExtender", "Ремонтные нано-боты" },
			{ "Kaelish_TechBuilding", "Циклонная камера" },
			{ "Kaelish_School", "Зал реализации" },
			{ "Kaelish_HighSchool", "Трансцендентальный форум" },
			{ "Kaelish_LifeSupport1", "Конвектор Антиматерии" },
			{ "Kaelish_LifeSupportAndResearch", "Лаборатория клонирования" },
			{ "Kaelish_LifeSupport2", "Ускоритель хризалиды" },
			{ "Kaelish_PlanetFieldsBooster", "Биомодификатор" },
			{ "Kaelish_UnlockCondition", "Псионный модулятор" },
			{ "Kaelish_ProductionSpeedShips", "Зал производства кораблей" },
			{ "Kaelish_MoonChanceIncrease", "Рефрактор Супра" },

		});
	}

	/// <summary>
	/// Добавляет словарь локализаций для языка
	/// </summary>
	public static void AddLanguage(string language, Dictionary<string, string> strings)
	{
		_localizations[language] = strings;
	}

	/// <summary>
	/// Получает локализованную строку с заменой плейсхолдеров
	/// </summary>
	/// <param name="language">Язык (например, "en", "ru")</param>
	/// <param name="stringId">ID строки</param>
	/// <param name="args">Аргументы для замены плейсхолдеров</param>
	/// <returns>Локализованная строка или ID, если не найдена</returns>
	public static string GetString(string language, string stringId, params object[] args)
	{
		if (!_localizations.TryGetValue(language, out var languageStrings))
		{
			// Язык не найден - можно вернуть ID
			return stringId;
		}

		if (!languageStrings.TryGetValue(stringId, out var format))
		{
			// ID строки не найден
			return stringId;
		}

		// Заменяем плейсхолдеры %1, %2,... на соответствующие аргументы
		for (int i = 0; i < args.Length; i++)
		{
			format = format.Replace($"%{i + 1}", args[i]?.ToString() ?? "");
		}

		return format;
	}
}