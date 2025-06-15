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
		});

		AddLanguage("ru", new Dictionary<string, string>
		{
			{ "ABOUT", "OGMiner (версия %1) - утилита для расчёта выработки в игре OGame\r\n© %2, %3\r\nАвтор не несёт никакой ответственности, согласно лицензии Creative Commons 1.0\r\n" },
			{ "CLOSE", "Закрыть" },
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
	/// <returns>Локализованная строка или null, если не найдена</returns>
	public static string GetString(string language, string stringId, params object[] args)
	{
		if (!_localizations.TryGetValue(language, out var languageStrings))
		{
			// Язык не найден - можно вернуть строку на языке по умолчанию или null
			return null;
		}

		if (!languageStrings.TryGetValue(stringId, out var format))
		{
			// ID строки не найден
			return null;
		}

		// Заменяем плейсхолдеры %1, %2,... на соответствующие аргументы
		for (int i = 0; i < args.Length; i++)
		{
			format = format.Replace($"%{i + 1}", args[i]?.ToString() ?? "");
		}

		return format;
	}
}