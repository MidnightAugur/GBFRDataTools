﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em0500_Crocodile;

public class Em0500Param : EmCrocodileBaseParam
{
    public Em0500Param()
    {
        Hp = 250000;
        Atk = 1000;
        Break = 8;
        Def = 0f;
        Endurance = 1;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 0;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 15;
        HateRateFarPlayerPerSec = 25;
        HateRateFrontAngle = 0;
        HateRateBackAngle = 5;
        HateRateDamage = 55;
        HateRateManualPlayer = 0;
        HateRateHighHpPlayer = 0;
        HateRateLowHpPlayer = 0;
        HateRateTargetCountManyPlayer = 0;
        HateRateTargetCountFewPlayer = 0;
        HateRateHelpPlayer = 0;
        HateRateLastTargetPlayer = 0;
        HateRateFirstTargetPlayer = 5;
        HateUpdateTime = 5f;
        DamageToHateRate = 0.02f;
        DamageHateDecPerSec = 2f;
        CloseHateIncRate = 0f;
        CloseHateDecRate = 0f;
        FarHateIncRate = 0f;
        FarHateDecRate = 0f;
        CombatPower = 65;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 2;
        LinkAttackCameraDistRate = 0.75f;
        AnimInterDefaultSec = 0.1f;
        DamageAnimInterDefaultSec = 0.1f;
        UiPartsNo = 5;
        UiOffsetY = 0.6f;
        BasicHitStopTimeRate = 0f;
        DamageReactionHitStopTimeRate = 0f;
        SuperArmorHitStopTimeRate = 0f;
        AttackerHitStopTimeRate = 0f;
        AddReactionHitstopFrameMin = -1f;
        AddReactionHitstopFrameMax = -1f;
        AddReactionWeightRateMin = -1f;
        AddReactionWeightRateMax = -1f;
        AddReactionWeightRateAI = -1f;
        AddReactionInterSec = -1f;
        IsEyeLookingAtLockOn = false;
        LookingAtPartsNo = 5;
        IsEnableSyncWeaponAnim = false;
        StageInvisibleStartDistance = 100f;
        StageInvisibleEndDistance = 125f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = false;
        IsDisableAerialDownReaction = true;
        CameraLength = 0f;
        OdHitStopTimeRate = 0f;
        BreakHitStopTimeRate = 1f;
        EmissiveInitValue = 0f;
        OdAttackRateFirstTime = 1.1f;
        OdDefenseRateFirstTime = 0.9f;
        OdAttackRateSecondTime = 1.2f;
        OdDefenseRateSecondTime = 0.7f;
        AbilityCoolSec = 10f;
        IsCutInDamageDisable = false;
        BossStunOffsetY = 0f;
        PartsBreakHp = new Vector3(1500f, 1200f, 1200f);
        HighVoltageRushAtkRate = new Vector2(2.5f, 2.5f);
        HighVoltagePushUpAtkRate = new Vector2(3f, 3f);
        RollingFinalRushAtkRate = new Vector2(3.5f, 3.5f);
        AddMotionRate = 1f;
        StrongAnimInterpSec = 0.4166667f;
        OverDriveAnimRateAILv3_4 = new Vector2(1.05f, 1.1f);
        OverDriveHpRateAILv3_4 = new Vector4(0.25f, 0.15f, 0.25f, 0.15f);
        OverDriveHpRateTutorial = new Vector4(0.3f, 0.35f, 0.3f, 0.35f);
        CoolTimeMeleeCombo = new Vector2(1f, 1f);
        CoolTimeMeleeComboOD = new Vector2(60f, 60f);
        CoolTimeMeleeComboTutorial = new Vector2(4f, 0f);
        CoolTimeBite = new Vector2(30f, 30f);
        CoolTimeShot = new Vector2(25f, 25f);
        CoolTimeVacuumBite = new Vector2(22f, 22f);
        CoolTimeRushPushUp = new Vector2(18f, 0f);
        CoolTimeRushPushUpTutorial = new Vector2(12f, 0f);
        CoolTimeWatching = new Vector2(60f, 0f);
        CoolTimeJumpRush = new Vector2(45f, 45f);
        EntanglePlNum = 3;
        SlamCheckCount = 5;
        HighVoltageRushCount = 1;
        SpreadShotAngle = 30f;
        GayserRadialDivRot = 30f;
        GayserAddLength = 18f;
        GayserInitLength = new Vector2(18f, 25f);
        GayserNoSetLengthEm0500 = 5f;
        GayserNoSetLengthGayser = 15f;
        GayserNoSetLengthInitPos = 6f;
        GayserRandPos = 4f;
        GayserLineMax = 5;
        GayserInitDelayTime = new Vector2(0f, 1f);
        GayserInitDelayDistance = new Vector2(0f, 100f);
        GayserRockHp = 1;
        GayserRockBreak = 30;
        RockCrushNum = 12;
        RockCrushRange = new Vector2(15f, 35f);
        RockCrushPosRand = 0.5f;
        RockCrushDisengageRange = 5f;
        RockCrushTime = new Vector2(1.6f, 2.1f);
        RollingAnimBlendAnglePerRate = 1.5f;
        RollingAnimBlendAddRate = 0.05f;
        RollingEffectRate = 0.5f;
        TutorialStunGauge = 640f;
        TutorialHpLimit = new Vector4(0.9f, 0.8f, 0.7f, 0.4f);
        TutorialNoMoveAction = 0.45f;
    }
}
