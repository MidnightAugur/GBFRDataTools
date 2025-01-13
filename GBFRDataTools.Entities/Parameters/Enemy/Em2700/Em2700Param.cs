﻿using System.Text.Json.Serialization;

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em2700;

public class Em2700Param : EmBossBaseParam
{
    [JsonPropertyName("dpsTime_")]
    public float DpsTime { get; set; } = 30f;

    [JsonPropertyName("dpsMaxValue_")]
    public float DpsMaxValue { get; set; } = 10000f;

    [JsonPropertyName("trialTargetHPEasy_")]
    public int TrialTargetHPEasy { get; set; } = 5;

    [JsonPropertyName("trialTargetHPNormal_")]
    public int TrialTargetHPNormal { get; set; } = 25;

    [JsonPropertyName("trialTargetHPHard_")]
    public int TrialTargetHPHard { get; set; } = 45;

    [JsonPropertyName("trialTargetHPVeryHard_")]
    public int TrialTargetHPVeryHard { get; set; } = 65;

    [JsonPropertyName("trialTargetHPExtreme_")]
    public int TrialTargetHPExtreme { get; set; } = 80;

    [JsonPropertyName("trialTargetHPHell_")]
    public int TrialTargetHPHell { get; set; } = 100;

    [JsonPropertyName("trialTargetHPHighLevel_")]
    public int TrialTargetHPHighLevel { get; set; } = 125;

    public Em2700Param()
    {
        Hp = 1000;
        Atk = 10;
        Break = 10;
        Def = 1f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 0;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 0;
        HateRateBackAngle = 0;
        HateRateDamage = 0;
        HateRateManualPlayer = 0;
        HateRateHighHpPlayer = 0;
        HateRateLowHpPlayer = 0;
        HateRateTargetCountManyPlayer = 0;
        HateRateTargetCountFewPlayer = 0;
        HateRateHelpPlayer = 0;
        HateRateLastTargetPlayer = 0;
        HateRateFirstTargetPlayer = 0;
        HateUpdateTime = 10f;
        DamageToHateRate = 0.02f;
        DamageHateDecPerSec = 2f;
        CloseHateIncRate = 0f;
        CloseHateDecRate = 0f;
        FarHateIncRate = 0f;
        FarHateDecRate = 0f;
        CombatPower = 50;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 0;
        LinkAttackCameraDistRate = 0f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 5;
        UiOffsetY = 0.6f;
        BasicHitStopTimeRate = 1f;
        DamageReactionHitStopTimeRate = 1f;
        SuperArmorHitStopTimeRate = 0.5f;
        AttackerHitStopTimeRate = 0f;
        AddReactionHitstopFrameMin = -1f;
        AddReactionHitstopFrameMax = -1f;
        AddReactionWeightRateMin = -1f;
        AddReactionWeightRateMax = -1f;
        AddReactionWeightRateAI = -1f;
        AddReactionInterSec = -1f;
        IsEyeLookingAtLockOn = false;
        LookingAtPartsNo = 5;
        IsEnableSyncWeaponAnim = true;
        StageInvisibleStartDistance = 150f;
        StageInvisibleEndDistance = 200f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = true;
        IsDisableAerialDownReaction = false;
        CameraLength = 0f;
        OdHitStopTimeRate = 0f;
        BreakHitStopTimeRate = 1f;
        EmissiveInitValue = 0f;
        OdAttackRateFirstTime = 1f;
        OdDefenseRateFirstTime = 1f;
        OdAttackRateSecondTime = 1f;
        OdDefenseRateSecondTime = 1f;
        AbilityCoolSec = 10f;
        IsCutInDamageDisable = false;
        BossStunOffsetY = 0f;
    }
}