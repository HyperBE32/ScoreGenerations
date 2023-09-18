bool HudSonicStage::isVisible = true;
bool HudSonicStage::isMission = false;
float superSonicDeltaTimer = 0;
float slamBonusDeltaTimer = 0;

HOOK(void, __fastcall, CHudSonicStageUpdate, 0x1098A50, void* thisDeclaration, void* edx, float* pUpdateInfo)
{
	// Process the Casino Night score message.
	if (!HudSonicStage::IsCasino() && !HudSonicStage::IsStageForbidden())
		HudSonicStage::ProcessMsgSetPinballHud(thisDeclaration);

	// Update the Super Sonic timer and reward score.
	HudSonicStage::UpdateSuperSonicTimer(pUpdateInfo);

	// Update the multipliers.
	HudSonicStage::UpdateMultipliers(pUpdateInfo);

	originalCHudSonicStageUpdate(thisDeclaration, edx, pUpdateInfo);
}

HOOK(bool, __fastcall, ScriptImplInitialise, 0x1105120, int thisDeclaration)
{
	return HudSonicStage::isMission = originalScriptImplInitialise(thisDeclaration);
}

bool HudSonicStage::IsCasino()
{
	if (Configuration::overrideForbiddenCasino)
		return false;

	if (StringHelper::Compare(BlueBlurCommon::GetStageCharID(), "cnz100"))
		return true;

	return false;
}

bool HudSonicStage::IsStageForbidden()
{
	// Forbid missions, Casino Night and stages lacking rank tables from using the score counter.
	if
	(
		isMission  ||
		IsCasino() ||
		TableListener::rankTables.find(std::string(BlueBlurCommon::GetStageCharID())) == TableListener::rankTables.end()
	)
	{
		return true;
	}

	// Check if the current stage ID matches any in the list.
	for (std::vector<std::string>::const_iterator i = Configuration::forbiddenStages.begin(); i != Configuration::forbiddenStages.end(); ++i)
	{
		// Stage ID matches - HUD must be special.
		if (StringHelper::Compare(BlueBlurCommon::GetStageCharID(), i->c_str()))
			return true;
	}

	return false;
}

void HudSonicStage::ProcessMsgSetPinballHud(void* thisDeclaration)
{
	FUNCTION_PTR(void, __thiscall, MsgSetPinballHud, 0x1095D40, void* thisDeclaration, const HudSonicStage::MsgSetPinballHud& msgSetPinballHud);

	// Set up message for Casino Night score.
	HudSonicStage::MsgSetPinballHud msgSetPinballHud;
	msgSetPinballHud.flags = 1;
	msgSetPinballHud.score = ScoreListener::score;

	MsgSetPinballHud(thisDeclaration, msgSetPinballHud);
}

void HudSonicStage::UpdateSuperSonicTimer(float* pUpdateInfo)
{
	// Update the timer using delta time.
	superSonicDeltaTimer += *pUpdateInfo;

	if (superSonicDeltaTimer > TableListener::timerTable.superSonicTimer)
	{
		// Reset the timer.
		superSonicDeltaTimer = 0;

		// Reward score every two seconds if the player is Super Sonic.
		if (BlueBlurCommon::IsSuper())
			ScoreListener::Reward(ScoreListener::ScoreType::Super);
	}
}

void HudSonicStage::UpdateMultipliers(float* pUpdateInfo)
{
	// Update the timer using delta time.
	slamBonusDeltaTimer += *pUpdateInfo;

	if (CONTEXT->m_Grounded)
	{
		// Reset bonuses if the player is grounded.
		MultiplierListener::ResetHomingChainBonus();
		MultiplierListener::ResetTrickBonus();

		if (slamBonusDeltaTimer > TableListener::timerTable.slamTimer)
		{
			// Reset the timer.
			slamBonusDeltaTimer = 0;

			// Reset the slam bonus if the timer runs out.
			MultiplierListener::ResetSlamBonus();
		}
	}

	// Reset the slam bonus if the player isn't grounded.
	else
		MultiplierListener::ResetSlamBonus();
}

void HudSonicStage::Install()
{
	// Install hook to update the score counter.
	INSTALL_HOOK(CHudSonicStageUpdate);

	// Install hook to check for missions.
	INSTALL_HOOK(ScriptImplInitialise);
}