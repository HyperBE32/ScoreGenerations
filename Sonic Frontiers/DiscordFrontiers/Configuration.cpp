void Configuration::Read()
{
	INIReader reader(INI_FILE);

	// General
	Language = INI_READ_STRING("General", Language);
}

void Configuration::ReadMods(ModInfo* in_pModInfo)
{
	for (auto pMod : *in_pModInfo->ModList)
	{
		if (!strcmp(pMod->Name, "Discord Frontiers"))
			continue;

		auto path = StringHelper::GetSubstringBeforeLastChar(pMod->Path, '\\');

		auto iniPath = path + "\\DiscordFrontiers.ini";
		auto jsonPath = path + "\\DiscordFrontiers.json";
		auto jsonPathLocalised = path + std::format("\\DiscordFrontiers.{}.json", Configuration::Language);

		if (IOHelper::FileExists(iniPath))
		{
			printf("[Discord Frontiers] Loading configuration from \"%s\"\n", iniPath.c_str());

			auto ini = BasicIniReader::Read(iniPath);

			if (ini.count("Images"))
			{
				// Load custom image URLs.
				for (auto key : ini["Images"])
				{
					if (Discord::ImageURLs.count(key.first))
					{
						Discord::ImageURLs[key.first] = key.second;
						continue;
					}

					Discord::ImageURLs.insert({ key.first, key.second });
				}
			}
		}

		if (IOHelper::FileExists(jsonPath))
		{
			printf("[Discord Frontiers] Loading localisation from \"%s\"\n", jsonPath.c_str());

			LanguageHelper::Merge(jsonPath);
		}

		if (IOHelper::FileExists(jsonPathLocalised))
		{
			printf("[Discord Frontiers] Loading localisation from \"%s\"\n", jsonPathLocalised.c_str());

			LanguageHelper::Merge(jsonPathLocalised);
		}
	}
}