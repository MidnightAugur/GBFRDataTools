﻿using System.Numerics;

namespace GBFRDataTools.Entities.Parameters.Enemy.Em7300;

public class Em7310Param : Em7300Param
{
    public Em7310Param()
    {
        Hp = 315000;
        Atk = 1100;
        Break = 10;
        Def = 0f;
        Endurance = 0;
        Exp = 0;
        HitSEMaxBreak = 4f;
        HitSEMinBreak = 0f;
        HateRateClosePlayer = 25;
        HateRateFarPlayer = 0;
        HateRateClosePlayerPerSec = 0;
        HateRateFarPlayerPerSec = 0;
        HateRateFrontAngle = 25;
        HateRateBackAngle = 0;
        HateRateDamage = 50;
        HateRateManualPlayer = 0;
        HateRateHighHpPlayer = 0;
        HateRateLowHpPlayer = 0;
        HateRateTargetCountManyPlayer = 0;
        HateRateTargetCountFewPlayer = 0;
        HateRateHelpPlayer = 0;
        HateRateLastTargetPlayer = 0;
        HateRateFirstTargetPlayer = 0;
        HateUpdateTime = 5f;
        DamageToHateRate = 0.2f;
        DamageHateDecPerSec = 2f;
        CloseHateIncRate = 0f;
        CloseHateDecRate = 0f;
        FarHateIncRate = 0f;
        FarHateDecRate = 0f;
        CombatPower = 100;
        ItemRewordMoneyVal = 0;
        ItemRewordJumpRate = 0.5f;
        Battle2SearchLength = 40f;
        Search2battleLength = 10f;
        EnemySize = 2;
        LinkAttackCameraDistRate = 1f;
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
        IsEnableSyncWeaponAnim = false;
        StageInvisibleStartDistance = 150f;
        StageInvisibleEndDistance = 200f;
        IsChangeNormalDamageAttackReaction = true;
        IsUseNormalDamageAttackReactionDefault = true;
        IsCallExplodeBodyPresageDefaultVfx = true;
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
        PowerDamageCutRate = 0.4f;
        PowerDamageUpBuffRate = 0.2f;
        Timeline0 = 80;
        Timeline1 = 60;
        Timeline2 = 65;
        Timeline3 = 40;
        Timeline4 = 25;
        Timeline5 = 25;
        Timeline6 = 30;
        Timeline7 = 5;
        OverDrive1stRate = new Vector4(1f, 1f, 1f, 1.05f);
        OverDrive2ndRate = new Vector4(1f, 1f, 1.05f, 1.05f);
        OverDrive3rdRate = new Vector4(1f, 1.05f, 1.05f, 1.05f);
        IceBlockSizeScale = 2f;
        IceBlockSizeHeight = 4f;
        IceBlockSizeRadius = 2f;
        IceBlockRadius = new Vector2(17.5f, 35f);
        IceBlockBeginAngle = new Vector2(45f, 22.5f);
        IceBlockAngle = new Vector2(90f, 45f);
        SpArtsIceBlockRadius = new Vector2(12.5f, 25f);
        SpArtsIceBlockBeginAngle = new Vector2(60f, 105f);
        SpArtsIceBlockAngle = new Vector2(120f, 120f);
        IceBlockAppearDelayTime = new Vector2(0f, 0.5f);
        IceBlockBreakDownTime = 0.25f;
        IceBlockTerminateWaitTime = 0.5f;
        IceBlockTerminateAlphaTime = 1.5f;
        ManastepFrontLRAngle = 45f;
        CoolTimeFangAttack = new Vector4(20f, 10f, 0f, 0f);
        CoolTimeHugeIceBlock = new Vector4(90f, 180f, 240f, 300f);
        CoolTimeDoubleSlash = new Vector2(20f, 5f);
        CoolTimeTurnTail = new Vector2(30f, 20f);
        CoolTimeSomersaultTail = new Vector2(40f, 30f);
        CoolTimeMoonsaultHorn = new Vector2(25f, 0f);
        CoolTimeIceAndLaser = new Vector2(50f, 15f);
        CoolTimeSpeedCounter = new Vector2(30f, 30f);
        CoolTimeCleaveLaser = new Vector2(60f, 60f);
        CoolTimeTurnShovel = new Vector2(20f, 20f);
        CoolTimeIceDrop = new Vector2(35f, 35f);
        CoolTimeNarrowDust = new Vector2(50f, 50f);
        CoolTimePowerCounter = new Vector2(30f, 30f);
        CoolTimeDiamondDust = new Vector2(60f, 60f);
        TurnTailSmokeOffset1 = new Vector3(0f, 0f, -13f);
        TurnTailSmokeOffset2 = new Vector3(9f, 0f, -9f);
        TurnTailSmokeOffset3 = new Vector3(13f, 0f, 0f);
        TurnTailSmokeRotY = new Vector3(90f, 45f, 0f);
        IciclesDanceStartAngle = 110f;
        IciclesDanceRangeAngle = 280f;
        IciclesDanceOffset = new Vector4(0f, 1.5f, 6.5f, 1f);
        ScoopingPosOffset = new Vector4(0f, 0f, 5f, 1f);
        ScoopingPosRand = 2f;
        ScoopingRotOffset = new Vector2(-18f, 10f);
        ScoopingRotRandX = 2f;
        ScoopingRotRandY = new Vector4(15f, 15f, 15f, 15f);
        IceDropPosOffset = new Vector4(0f, 0f, 3f, 1f);
        IceDropAngleRotX = -60f;
        IceDropSplashHeight = 30f;
        IceDropSplashDistMin = 3f;
        IceDropSplashDistMax = new Vector4(21f, 21f, 25f, 25f);
        IceDropSplashAddDist = 8f;
        IceDropSplashWaitTimeMax = 0.5f;
        IceDropSplashPlNonOverlapDist = 5f;
        GroundWaveAttackRate = 0.9f;
        GroundWaveHeight = 1f;
        GroundWaveRadius = new Vector2(5f, 30f);
        GroundWaveTime = new Vector2(3.5f, 1.45f);
        DiamondDustEndRadius = 50f;
        DiamondDustWidht = 5f;
        DiamondDustScaleTime = 0.8f;
        OdPowerArtsIcePosOffset = new Vector4(0f, 0f, 10f, 1f);
        OdPowerArtsFrontDist = 6f;
        OdPowerArtsMinDist = 2f;
        OdPowerArtsFragFallDist = 10f;
        OdPowerArtsFragFallAngle = 45f;
        BlizzardAreaRadius = 32.5f;
        BlizzardAreaSpeed = 0f;
        BlizzardAreaSpeedScale = 0.5f;
        StageCenterPos = new Vector4(123f, 219f, 228.5f, 1f);
        StageCornerDist = 32f;
        TypeChangeCameraBone = -1;
        TypeChangeCameraTime = 4f;
        TypeChangeCameraRotSpeed = 5f;
        FangHpPercent = new Vector4(0.5f, 0.5f, 0.75f, 0.75f);
        FangShowHpGaugeDistance = 15f;
        FangIdleMotionRate = 2f;
        FangDeadHitStop = 5;
        FangInnerOffset = new Vector4(3f, 8f, 2f, 1f);
        FangOuterOffset = new Vector4(8f, 2f, -2f, 1f);
        FangStockInnerOffset = new Vector4(0.5f, 9f, 0f, 1f);
        FangStockOuterOffset = new Vector4(1.5f, 9.2f, 0f, 1f);
        FangLaserPosLength = new Vector4(8f, 10f, 9f, 1f);
        FangLaserAngle = new Vector4(15f, 0f, -10f, 1f);
        FangLaserAddY = new Vector4(3f, 5f, 1f, 1f);
        FangLaserShotOffset = new Vector4(4f, 0f, -4f, 1f);
        FangLaserMultipleAddPosLength = 0f;
        FangLaserMultipleAddAngle = -20f;
        FangLaserMultipleAddAddY = 0f;
        FangChargeLaserHeight = 8f;
        FangIdle_SpeedMax = 20f;
        FangIdle_SpeedMin = 1f;
        FangIdle_SpeedAdd = 1f;
        FangIdle_SpeedSub = 0.65f;
        FangIdle_BorderDist = 5f;
        FangIdle_StopDist = 0.5f;
        MainStoryDemoHpLimitPer = 80f;
    }
}