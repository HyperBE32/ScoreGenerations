﻿#pragma once

#define WIN32_LEAN_AND_MEAN

// Detours
#include <Windows.h>
#include <detours.h>

// BlueBlur must be included before STL
#include "..\Dependencies\BlueBlurCommon.h"

// Standard library
#include <algorithm>
#include <array>
#include <cstdint>
#include <cstdio>
#include <fstream>
#include <iostream>
#include <regex>
#include <set>
#include <sstream>
#include <stdint.h>
#include <string>
#include <tuple>
#include <unordered_map>
#include <vector>
#include <xmmintrin.h>

// Dependencies
#include <Helpers.h>
#include <StringHelper.h>
#include <INIReader.h>
#include <IOHelper.h>
#include <lua.hpp>
#include "Configuration.h"
#include <ModIntegrity.h>
#include "StateHooks.h"
#include <MemoryPreserver.h>

// Internal headers
#include "ArchiveTreePatcher.h"
#include "HudSonicStage.h"
#include "Loader.h"
#include "LuaCallback.h"
#include "MultiplierListener.h"
#include "Patches.h"
#include "ResultListener.h"
#include "ScoreHooks.h"
#include "ScoreListener.h"
#include "lib\Statistics.h"
#include "StatisticsListener.h"
#include "lib\Tables.h"
#include "TableListener.h"