// 0x141A394F0
SIG_SCAN(sigCObjHintRingCtor, "\x40\x55\x56\x57\x41\x54\x41\x55\x41\x56\x41\x57\x48\x8D\xAC\x24\x00\x00\x00\x00\x48\x81\xEC\x00\x00\x00\x00\x48\xC7\x45\x00\x00\x00\x00\x00\x48\x89\x9C\x24\x00\x00\x00\x00\x4C\x8B\xEA\x48\x8B\xD9\x4C\x8D\xB9\x00\x00\x00\x00\xC7\x45\x00\x00\x00\x00\x00\x41\x0F\x10\x57\x00\xF2\x41\x0F\x10\x47\x00\xF2\x0F\x11\x45\x00\x66\x0F\x6F\xCA\x66\x0F\x73\xD9\x00\x66\x0F\x7E\xC8\x48\x63\xC8\x48\x03\xCB\x4C\x8D\x45\xD8\x48\x8D\x55\x40\x66\x48\x0F\x7E\xD0\xFF\xD0\xE8\x00\x00\x00\x00\x8D\x48\xFF\x83\xF9\x02\x77\x27\x80\xBB\x00\x00\x00\x00\x00\x74\x1E\xFF\xC8\x89\x83\x00\x00\x00\x00\x83\xBC\x83\x00\x00\x00\x00\x00\x75\x0C\xC6\x83\x00\x00\x00\x00\x00\xE9\x00\x00\x00\x00\x48\x8D\x15\x00\x00\x00\x00\x49\x8B\xCD\xE8\x00\x00\x00\x00\x4C\x8B\xF0\x45\x33\xE4\x41\x8D\x74\x24\x00\x48\x85\xC0\x0F\x84\x00\x00\x00\x00\x4C\x89\xA5\x00\x00\x00\x00\x4C\x39\x60\x18\x74\x21\x48\x8D\x8D\x00\x00\x00\x00\xE8\x00\x00\x00\x00\x49\x8B\x4E\x18\x48\x89\x8D\x00\x00\x00\x00\x48\x85\xC9\x74\x05\xE8\x00\x00\x00\x00\x45\x33\xC0\x48\x8D\x95\x00\x00\x00\x00\x48\x8D\x4D\xE8\xE8\x00\x00\x00\x00\x90\x4C\x8D\xA3\x00\x00\x00\x00\x48\x8B\x08\x49\x89\x0C\x24\x48\x8D\x50\x08\x49\x8D\x4C\x24\x00\xE8\x00\x00\x00\x00\x90\x48\x8B\x7D\xF0\x48\x85\xFF\x74\x2B\x8B\xC6\xF0\x0F\xC1\x47\x00\x83\xF8\x01\x75\x1F\x48\x8B\x07\x48\x8B\xCF\xFF\x50\x08\x8B\xC6\xF0\x0F\xC1\x47\x00\x83\xF8\x01\x75\x0A\x48\x8B\x07\x48\x8B\xCF\xFF\x50\x10\x90", "xxxxxxxxxxxxxxxx????xxx????xxx?????xxxx????xxxxxxxxx????xx?????xxxx?xxxxx?xxxx?xxxxxxxx?xxxxxxxxxxxxxxxxxxxxxxxxxx????xxxxxxxxxx?????xxxxxx????xxx?????xxxx?????x????xxx????xxxx????xxxxxxxxxx?xxxxx????xxx????xxxxxxxxx????x????xxxxxxx????xxxxxx????xxxxxx????xxxxx????xxxx????xxxxxxxxxxxxxxx?x????xxxxxxxxxxxxxxxx?xxxxxxxxxxxxxxxxxxxx?xxxxxxxxxxxxxxx");
HOOK(void, __fastcall, CObjHintRingCtor, sigCObjHintRingCtor(), void* a1, void* a2)
{
	return;
}

// 0x141A71380
SIG_SCAN(sigCEventNavigationCollisionCtor, "\x48\x89\x5C\x24\x00\x57\x48\x83\xEC\x20\x48\x8B\xFA\x48\x8B\xD9\x33\xD2\xE8\x00\x00\x00\x00\x48\x8B\xCB\x83\xF8\x01\x75\x17\xE8\x00\x00\x00\x00\x48\x8B\xCB\x48\x8B\x5C\x24\x00\x48\x83\xC4\x20\x5F\xE9\x00\x00\x00\x00\x48\x8B\xD7\x48\x8B\x5C\x24\x00\x48\x83\xC4\x20\x5F\xE9\x00\x00\x00\x00", "xxxx?xxxxxxxxxxxxxx????xxxxxxxxx????xxxxxxx?xxxxxx????xxxxxxx?xxxxxx????");
HOOK(void, __fastcall, CEventNavigationCollisionCtor, sigCEventNavigationCollisionCtor(), void* a1, void* a2)
{
	return;
}

// 0x141A95710
SIG_SCAN(sigCEventNavigationCollisionPlaneCtor, "\x48\x89\x5C\x24\x00\x57\x48\x83\xEC\x20\x48\x8B\xFA\x48\x8B\xD9\x33\xD2\xE8\x00\x00\x00\x00\x48\x8B\xCB\x83\xF8\x01\x75\x17\xE8\x00\x00\x00\x00\x48\x8B\xCB\x48\x8B\x5C\x24\x00\x48\x83\xC4\x20\x5F\xE9\x00\x00\x00\x00\x48\x8B\xD7\x48\x8B\x5C\x24\x00\x48\x83\xC4\x20\x5F\xE9\x00\x00\x00\x00", "xxxx?xxxxxxxxxxxxxx????xxxxxxxxx????xxxxxxx?xxxxxx????xxxxxxx?xxxxxx????");
HOOK(void, __fastcall, CEventNavigationCollisionPlaneCtor, sigCEventNavigationCollisionPlaneCtor(), void* a1, void* a2)
{
	return;
}

void Navigator::Init()
{
	if (Configuration::forceDisableNavi)
	{
		INSTALL_HOOK(CObjHintRingCtor);
		INSTALL_HOOK(CEventNavigationCollisionCtor);
		INSTALL_HOOK(CEventNavigationCollisionPlaneCtor);
	}
}