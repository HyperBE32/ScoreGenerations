﻿#pragma once

#define WIN32_LEAN_AND_MEAN

// Detours
#include <Windows.h>
#include <detours.h>

// Standard library
#include <cstdint>
#include <cstdio>
#include <unordered_map>

// Dependencies
#include <Helpers.h>
#include <Signature.h>
#include <StringHelper.h>

// Internal headers
#include "BattleRushParameter.h"