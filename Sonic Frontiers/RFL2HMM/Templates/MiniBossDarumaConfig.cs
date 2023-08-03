using System.Numerics;
using System.Runtime.InteropServices;

public class MiniBossDarumaConfigClass
{
    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct MiniBossCommonConfig
    {
        [FieldOffset(0)]  public float scoutDistance;
        [FieldOffset(4)]  public float scoutDistanceOutside;
        [FieldOffset(8)]  public float zoomDistance;
        [FieldOffset(16)] public Vector3 zoomOffset;
        [FieldOffset(32)] public Vector3 zoomAngle;
        [FieldOffset(48)] public float zoomFov;
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct MiniBossDarumaShotParam
    {
        [FieldOffset(0)]  public int count;
        [FieldOffset(4)]  public float intervalTime;
        [FieldOffset(8)]  public float pitchMin;
        [FieldOffset(12)] public float pitchMax;
        [FieldOffset(16)] public float pitchOffsetMin;
        [FieldOffset(20)] public float pitchOffsetMax;
        [FieldOffset(24)] public float yawOffsetRange;
        [FieldOffset(28)] public bool sweepFire;
        [FieldOffset(29)] public bool predict;
        [FieldOffset(32)] public float radius;
        [FieldOffset(36)] public float speed;
        [FieldOffset(40)] public float lifeTime;
        [FieldOffset(44)] public float waitTime;
    }

    public enum ScatterType : sbyte
    {
        RANDOM = 0,
        HOMING = 1,
        SPIRAL = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public struct MiniBossDarumaSpecialShotParamBase
    {
        [FieldOffset(0)]  public int count;
        [FieldOffset(4)]  public float intervalTime;
        [FieldOffset(8)]  public float shootPitchMin;
        [FieldOffset(12)] public float shootPitchMax;
        [FieldOffset(16)] public float initialSpeedMin;
        [FieldOffset(20)] public float initialSpeedMax;
        [FieldOffset(24)] public float maxAngle;
        [FieldOffset(28)] public float moveRadius;
        [FieldOffset(32)] public float maxMoveSpeed;
        [FieldOffset(36)] public float accel;
        [FieldOffset(40)] public float waitTime;
        [FieldOffset(44)] public float featherLifeTime;
        [FieldOffset(48)] public ScatterType m_scatterTypeTable__arr0;
        [FieldOffset(49)] public ScatterType m_scatterTypeTable__arr1;
        [FieldOffset(50)] public ScatterType m_scatterTypeTable__arr2;
        [FieldOffset(51)] public ScatterType m_scatterTypeTable__arr3;
        [FieldOffset(52)] public ScatterType m_scatterTypeTable__arr4;
        [FieldOffset(53)] public ScatterType m_scatterTypeTable__arr5;
    }

    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public struct MiniBossDarumaBombParam
    {
        [FieldOffset(0)]  public MiniBossDarumaSpecialShotParamBase miniBossDarumaSpecialShotParamBase;
        [FieldOffset(56)] public float explosionRadius;
        [FieldOffset(60)] public float explosionEffectScale;
        [FieldOffset(64)] public float explosionTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public struct MiniBossDarumaFlamePillarParam
    {
        [FieldOffset(0)]  public MiniBossDarumaSpecialShotParamBase miniBossDarumaSpecialShotParamBase;
        [FieldOffset(56)] public float burnLifeTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct MiniBossDarumaWaveBombParam
    {
        [FieldOffset(0)]  public MiniBossDarumaSpecialShotParamBase miniBossDarumaSpecialShotParamBase;
        [FieldOffset(56)] public float burnLifeTime;
        [FieldOffset(60)] public float cycleTime;
        [FieldOffset(64)] public float cycleDistance;
        [FieldOffset(68)] public float homingLimitAngle;
        [FieldOffset(72)] public float maxTurnAngle;
        [FieldOffset(76)] public uint cycleCount;
    }

    [StructLayout(LayoutKind.Explicit, Size = 120)]
    public struct MiniBossDarumaStompingParam
    {
        [FieldOffset(0)]   public float range;
        [FieldOffset(4)]   public float riseDistance;
        [FieldOffset(8)]   public float riseTime;
        [FieldOffset(12)]  public float chaseSpeed;
        [FieldOffset(16)]  public float chaseTime;
        [FieldOffset(20)]  public float speed;
        [FieldOffset(24)]  public float rotationSpeed;
        [FieldOffset(28)]  public float timingGap;
        [FieldOffset(32)]  public float spinTime;
        [FieldOffset(36)]  public float ringRiseTime;
        [FieldOffset(40)]  public float waitTime;
        [FieldOffset(44)]  public float staggerTime;
        [FieldOffset(48)]  public float staggerDistance;
        [FieldOffset(52)]  public float groundImpactRadius;
        [FieldOffset(56)]  public float waveRadius;
        [FieldOffset(60)]  public float waveAppearRadius;
        [FieldOffset(64)]  public float waveKeepRadius;
        [FieldOffset(68)]  public float waveDisappearRadius;
        [FieldOffset(72)]  public float waveHeightMin;
        [FieldOffset(76)]  public float waveHeightMax;
        [FieldOffset(80)]  public float waveLifeTime;
        [FieldOffset(84)]  public float waveVelocityX;
        [FieldOffset(88)]  public float waveVelocityY;
        [FieldOffset(92)]  public float laserRadius;
        [FieldOffset(96)]  public float laserLength;
        [FieldOffset(100)] public float laserTime;
        [FieldOffset(104)] public float laserRotationInitialSpeed;
        [FieldOffset(108)] public float laserRotationAccel;
        [FieldOffset(112)] public float laserRotationMaxSpeed;
        [FieldOffset(116)] public float laserAccelDelayTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public struct MiniBossDarumaCyloopReactionParam
    {
        [FieldOffset(0)]  public Vector3 targetOffSet;
        [FieldOffset(16)] public float azimuth;
        [FieldOffset(20)] public float elevation;
        [FieldOffset(24)] public float distance;
        [FieldOffset(28)] public float zRoll;
        [FieldOffset(32)] public float fovy;
        [FieldOffset(48)] public Vector3 cameraMoveDir;
        [FieldOffset(64)] public float cameraMoveSpeed;
        [FieldOffset(68)] public float interpolateTime;
        [FieldOffset(72)] public float bodyBreakWaitTime;
        [FieldOffset(76)] public float changeStateWaitTime;
    }

    [StructLayout(LayoutKind.Explicit, Size = 64)]
    public struct MiniBossDarumaDebrisBodySmallParam
    {
        [FieldOffset(0)]  public float lifeTime;
        [FieldOffset(4)]  public float forceScale;
        [FieldOffset(8)]  public float forceMin;
        [FieldOffset(12)] public float forceMax;
        [FieldOffset(16)] public float forceCyloopExplode;
        [FieldOffset(20)] public float gravity;
        [FieldOffset(24)] public float weight;
        [FieldOffset(28)] public float friction;
        [FieldOffset(32)] public sbyte maxPieceNum;
        [FieldOffset(48)] public Vector3 centerOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 144)]
    public struct MiniBossDarumaDebrisParam
    {
        [FieldOffset(0)]  public float damageVelocityScale;
        [FieldOffset(4)]  public float minSpeed;
        [FieldOffset(8)]  public float maxSpeed;
        [FieldOffset(16)] public MiniBossDarumaDebrisBodySmallParam body;
        [FieldOffset(80)] public MiniBossDarumaDebrisBodySmallParam cyloop;
    }

    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public struct MiniBossDarumaCameraShakeParam
    {
        [FieldOffset(0)]  public float time;
        [FieldOffset(4)]  public float magnitude;
        [FieldOffset(8)]  public int freq;
        [FieldOffset(12)] public float attnRatio;
        [FieldOffset(16)] public float shakeRange;
    }

    [StructLayout(LayoutKind.Explicit, Size = 2912)]
    public struct MiniBossDarumaCommonParam
    {
        [FieldOffset(0)]    public MiniBossCommonConfig commonConfig;
        [FieldOffset(64)]   public float headHeight;
        [FieldOffset(68)]   public int bodyMaxHealthPoint;
        [FieldOffset(72)]   public float bodyRadius;
        [FieldOffset(76)]   public float bodyHeight;
        [FieldOffset(80)]   public float baseHeight;
        [FieldOffset(84)]   public float partSpace;
        [FieldOffset(88)]   public float ringRadius;
        [FieldOffset(92)]   public float ringHeight;
        [FieldOffset(96)]   public float ringRotationSpeed;
        [FieldOffset(100)]  public float gravity;
        [FieldOffset(104)]  public float stunTime;
        [FieldOffset(108)]  public float maxSpeed;
        [FieldOffset(112)]  public float stompingTransitRange;
        [FieldOffset(116)]  public int questKodamaMaxNum__arr0;
        [FieldOffset(120)] public int questKodamaMaxNum__arr1;
        [FieldOffset(124)] public int questKodamaMaxNum__arr2;
        [FieldOffset(128)]  public MiniBossDarumaShotParam shot;
        [FieldOffset(176)]  public MiniBossDarumaShotParam shot3way;
        [FieldOffset(224)]  public MiniBossDarumaShotParam shot5way;
        [FieldOffset(272)]  public MiniBossDarumaBombParam bomb;
        [FieldOffset(340)]  public MiniBossDarumaFlamePillarParam flamePillar;
        [FieldOffset(400)]  public MiniBossDarumaWaveBombParam waveBomb;
        [FieldOffset(480)]  public MiniBossDarumaStompingParam stomping;
        [FieldOffset(600)]  public MiniBossDarumaStompingParam stompingThorn;
        [FieldOffset(720)]  public MiniBossDarumaStompingParam stompingQuest__arr0;
        [FieldOffset(840)] public MiniBossDarumaStompingParam stompingQuest__arr1;
        [FieldOffset(960)] public MiniBossDarumaStompingParam stompingQuest__arr2;
        [FieldOffset(1080)] public MiniBossDarumaStompingParam stompingQuestHigh__arr0;
        [FieldOffset(1200)] public MiniBossDarumaStompingParam stompingQuestHigh__arr1;
        [FieldOffset(1320)] public MiniBossDarumaStompingParam stompingQuestHigh__arr2;
        [FieldOffset(1440)] public MiniBossDarumaStompingParam stompingQuest2__arr0;
        [FieldOffset(1560)] public MiniBossDarumaStompingParam stompingQuest2__arr1;
        [FieldOffset(1680)] public MiniBossDarumaStompingParam stompingQuest2__arr2;
        [FieldOffset(1800)] public MiniBossDarumaStompingParam stompingQuest2High__arr0;
        [FieldOffset(1920)] public MiniBossDarumaStompingParam stompingQuest2High__arr1;
        [FieldOffset(2040)] public MiniBossDarumaStompingParam stompingQuest2High__arr2;
        [FieldOffset(2160)] public MiniBossDarumaCyloopReactionParam cyloopReaction;
        [FieldOffset(2240)] public MiniBossDarumaShotParam shotBerserk;
        [FieldOffset(2288)] public MiniBossDarumaShotParam shotBerserk3way;
        [FieldOffset(2336)] public MiniBossDarumaShotParam shotBerserk5way;
        [FieldOffset(2384)] public MiniBossDarumaStompingParam hop;
        [FieldOffset(2504)] public MiniBossDarumaStompingParam stompingBerserk;
        [FieldOffset(2624)] public MiniBossDarumaFlamePillarParam flamePillarBerserk;
        [FieldOffset(2688)] public MiniBossDarumaDebrisParam debris;
        [FieldOffset(2832)] public MiniBossDarumaCameraShakeParam cameraShakeStomping;
        [FieldOffset(2852)] public MiniBossDarumaCameraShakeParam cameraShakeStompingQuest;
        [FieldOffset(2872)] public MiniBossDarumaCameraShakeParam cameraShakeStompingQuest2;
        [FieldOffset(2892)] public MiniBossDarumaCameraShakeParam cameraShakeDrop;
    }

    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public struct MiniBossLevelCommonConfig
    {
        [FieldOffset(0)]  public int maxHealthPoint;
        [FieldOffset(4)]  public float maxStunPoint__arr0;
        [FieldOffset(8)] public float maxStunPoint__arr1;
        [FieldOffset(12)] public float maxStunPoint__arr2;
        [FieldOffset(16)] public float stunDecreaseStartTime;
        [FieldOffset(20)] public float stunDecreaseSpeed;
        [FieldOffset(24)] public float maxStaggerPoint__arr0;
        [FieldOffset(28)] public float maxStaggerPoint__arr1;
        [FieldOffset(32)] public float maxStaggerPoint__arr2;
        [FieldOffset(36)] public float staggerDecreaseStartTime;
        [FieldOffset(40)] public float staggerDecreaseSpeed;
        [FieldOffset(44)] public float attackRate;
        [FieldOffset(48)] public ushort expItemNum;
        [FieldOffset(50)] public ushort exp;
    }

    [StructLayout(LayoutKind.Explicit, Size = 56)]
    public struct MiniBossDarumaLevelParam
    {
        [FieldOffset(0)] public int level;
        [FieldOffset(4)] public MiniBossLevelCommonConfig commonConfig;
    }

    public enum StompingType : sbyte
    {
        WEEK = 0,
        WAVE = 1
    }

    public enum BulletType : sbyte
    {
        NORMAL = 0,
        THREE_WAY = 1,
        FIVE_WAY = 2
    }

    public enum SpecialBulletType : sbyte
    {
        BOMB = 0,
        PILLAR = 1,
        WAVE_BOMB = 2
    }

    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public struct MiniBossDarumaLevelBand
    {
        [FieldOffset(0)]  public uint level;
        [FieldOffset(4)]  public StompingType stompingType;
        [FieldOffset(5)]  public sbyte laserCount;
        [FieldOffset(6)]  public bool isBarrier;
        [FieldOffset(7)]  public StompingType stompingTypeThorn;
        [FieldOffset(8)]  public sbyte laserCountThorn;
        [FieldOffset(9)]  public bool isBarrierThorn;
        [FieldOffset(10)] public BulletType bulletType;
        [FieldOffset(11)] public SpecialBulletType specialBulletType;
        [FieldOffset(12)] public sbyte stompingMaxBreakBodyCount;
        [FieldOffset(13)] public bool isThorn;
        [FieldOffset(16)] public Vector3 headRigidColliderExtents;
        [FieldOffset(32)] public Vector3 headRigidCollHeightOffset;
    }

    [StructLayout(LayoutKind.Explicit, Size = 3552)]
    public struct MiniBossDarumaConfig
    {
        [FieldOffset(0)]    public MiniBossDarumaCommonParam commonParam;
        [FieldOffset(2912)] public MiniBossDarumaLevelParam levelParams__arr0;
        [FieldOffset(2968)] public MiniBossDarumaLevelParam levelParams__arr1;
        [FieldOffset(3024)] public MiniBossDarumaLevelParam levelParams__arr2;
        [FieldOffset(3080)] public MiniBossDarumaLevelParam levelParams__arr3;
        [FieldOffset(3136)] public MiniBossDarumaLevelParam levelParams__arr4;
        [FieldOffset(3200)] public MiniBossDarumaLevelBand levelBands__arr0;
        [FieldOffset(3248)] public MiniBossDarumaLevelBand levelBands__arr1;
        [FieldOffset(3296)] public MiniBossDarumaLevelBand levelBands__arr2;
        [FieldOffset(3344)] public MiniBossDarumaLevelBand levelBands__arr3;
        [FieldOffset(3392)] public MiniBossDarumaLevelBand levelBands__arr4;
        [FieldOffset(3440)] public MiniBossDarumaLevelParam levelParamQuest;
        [FieldOffset(3504)] public MiniBossDarumaLevelBand levelBandQuest;
    }

}