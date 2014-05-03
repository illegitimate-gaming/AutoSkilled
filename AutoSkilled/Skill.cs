using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeta.Internals.Actors;

namespace AutoSkilled {
    public abstract class Skill {
        public SNOPower Power { get; set; }
        public int RuneId { get; set; }

        private Dictionary<string, SNOPower> SkillDict;
        private Dictionary<string, int> RuneDict;

        public Skill() {
            SkillDict = new Dictionary<string, SNOPower>();
            RuneDict = new Dictionary<string, int>();
            RuneDict.Add("None", -1);

            // Barbarian Primary
            SkillDict.Add("Bash", SNOPower.Barbarian_Bash);
            RuneDict.Add("Clobber", 2);
            RuneDict.Add("Onslaught", 0);
            RuneDict.Add("Punish", 1);
            RuneDict.Add("Instigation", 3);
            RuneDict.Add("Pulverize", 4);

            SkillDict.Add("Cleave", SNOPower.Barbarian_Cleave);
            RuneDict.Add("Rupture", 4);
            RuneDict.Add("ReapingSwing", 3);
            RuneDict.Add("ScatteringBlast", 2);
            RuneDict.Add("BroadSweep", 0);
            RuneDict.Add("GatheringStorm", 1);

            SkillDict.Add("Frenzy", SNOPower.Barbarian_Frenzy);
            RuneDict.Add("Sidearm", 1);
            RuneDict.Add("Triumph", 4);
            RuneDict.Add("Vanguard", 2);
            RuneDict.Add("Smite", 3);
            RuneDict.Add("Maniac", 0);

            // Barbarian - Secondary
            SkillDict.Add("HammerOfTheAncients", SNOPower.Barbarian_HammerOfTheAncients);
            RuneDict.Add("RollingThunder", 1);
            RuneDict.Add("Smash", 0);
            RuneDict.Add("TheDevilsAnvil", 2);
            RuneDict.Add("Thunderstrike", 4);
            RuneDict.Add("Birthright", 3);

            SkillDict.Add("Rend", SNOPower.Barbarian_Rend);
            RuneDict.Add("Ravage", 1);
            RuneDict.Add("BloodLust", 3);
            RuneDict.Add("Lacerate", 0);
            RuneDict.Add("Mutilate", 2);
            RuneDict.Add("Bloodbath", 4);

            SkillDict.Add("SeismicSlam", SNOPower.Barbarian_SeismicSlam);
            RuneDict.Add("Stagger", 2);
            RuneDict.Add("ShatteredGround", 0);
            RuneDict.Add("Rumble", 1);
            RuneDict.Add("StrengthFromEarth", 3);
            RuneDict.Add("CrackingRift", 4);

            SkillDict.Add("Whirlwind", SNOPower.Barbarian_Whirlwind);
            RuneDict.Add("DustDevils", 1);
            RuneDict.Add("Hurricane", 2);
            RuneDict.Add("BloodFunnel", 4);
            RuneDict.Add("WindShear", 3);
            RuneDict.Add("VolcanicEruption", 0);

            // Barbarian - Defensive
            SkillDict.Add("GroundStomp", SNOPower.Barbarian_GroundStomp);
            RuneDict.Add("DeafeningCrash", 4);
            RuneDict.Add("WrenchingSmash", 1);
            RuneDict.Add("TremblingStomp", 0);
            RuneDict.Add("FootOfTheMountain", 3);
            RuneDict.Add("Avalanche", 2);

            SkillDict.Add("Leap", SNOPower.Barbarian_Leap);
            RuneDict.Add("IronImpact", 3);
            RuneDict.Add("Launch", 2);
            RuneDict.Add("TopplingImpact", 1);
            RuneDict.Add("CallOfArreat", 0);
            RuneDict.Add("BeathFromAbove", 4);

            SkillDict.Add("Sprint", SNOPower.Barbarian_Sprint);
            RuneDict.Add("Rush", 1);
            RuneDict.Add("RunLikeTheWind", 2);
            RuneDict.Add("Marathon", 0);
            RuneDict.Add("Gangway", 4);
            RuneDict.Add("ForcedMarch", 3);

            SkillDict.Add("IgnorePain", SNOPower.Barbarian_IgnorePain);
            RuneDict.Add("Bravado", 3);
            RuneDict.Add("IronHide", 1);
            RuneDict.Add("IgnoranceIsBliss", 4);
            RuneDict.Add("MobRule", 2);
            RuneDict.Add("ContemptForWeakness", 0);

            // Barbarian - Might
            SkillDict.Add("AncientSpear", SNOPower.Barbarian_AncientSpear);
            RuneDict.Add("GrapplingHooks", 1);
            RuneDict.Add("Skirmish", 3);
            RuneDict.Add("DreadSpear", 2);
            RuneDict.Add("Harpoon", 0);
            RuneDict.Add("RageFlip", 4);

            SkillDict.Add("Revenge", SNOPower.Barbarian_Revenge);
            RuneDict.Add("VengeanceIsMine", 3);
            RuneDict.Add("BestServedCold", 4);
            RuneDict.Add("Retribution", 0);
            RuneDict.Add("Grudge", 2);
            RuneDict.Add("Provocation", 1);

            SkillDict.Add("FuriousCharge", SNOPower.Barbarian_FuriousCharge);
            RuneDict.Add("BatteringRam", 0);
            RuneDict.Add("MercilessAssault", 4);
            RuneDict.Add("Stamina", 3);
            RuneDict.Add("BullRush", 2);
            RuneDict.Add("Dreadnought", 1);

            SkillDict.Add("Overpower", SNOPower.Barbarian_Overpower);
            RuneDict.Add("StormOfSteel", 1);
            RuneDict.Add("KillingSpree", 0);
            RuneDict.Add("CrushingAdvance", 4);
            RuneDict.Add("Momentum", 3);
            RuneDict.Add("Revel", 2);

            // Barbarian - Tactics
            SkillDict.Add("WeaponThrow", SNOPower.Barbarian_WeaponThrow);
            RuneDict.Add("MightyThrow", 0);
            RuneDict.Add("Ricochet", 1);
            RuneDict.Add("ThrowingHammer", 2);
            RuneDict.Add("Stupefy", 4);
            RuneDict.Add("DreadBomb", 3);

            SkillDict.Add("ThreateningShout", SNOPower.Barbarian_ThreateningShout);
            RuneDict.Add("Intimidate", 1);
            RuneDict.Add("Falter", 3);
            RuneDict.Add("GrimHarvest", 2);
            RuneDict.Add("Demoralize", 0);
            RuneDict.Add("Terrify", 4);

            SkillDict.Add("BattleRage", SNOPower.Barbarian_BattleRage);
            RuneDict.Add("MaraudersRage", 0);
            RuneDict.Add("Ferocity", 1);
            RuneDict.Add("SwordsToPloughshares", 2);
            RuneDict.Add("IntoTheFray", 3);
            RuneDict.Add("Bloodshed", 4);

            SkillDict.Add("WarCry", SNOPower.Barbarian_WarCry);
            RuneDict.Add("HardenedWrath", 0);
            RuneDict.Add("Charge", 3);
            RuneDict.Add("Invigorate", 4);
            RuneDict.Add("VeteransWarning", 1);
            RuneDict.Add("Impunity", 2);

            // Barbarian - Rage
            SkillDict.Add("Earthquake", SNOPower.Barbarian_Earthquake);
            RuneDict.Add("GiantsStride", 1);
            RuneDict.Add("ChillingEarth", 2);
            RuneDict.Add("TheMountainsCall", 3);
            RuneDict.Add("Aftershocks", 0);
            RuneDict.Add("PathOfFire", 4);

            SkillDict.Add("CallOfTheAncients", SNOPower.Barbarian_CallOfTheAncients);
            RuneDict.Add("TheCouncilRises", 1);
            RuneDict.Add("DutyToTheClan", 3);
            RuneDict.Add("KorlicsMight", 0);
            RuneDict.Add("MadawcsMadness", 2);
            RuneDict.Add("TalicsAnger", 4);

            SkillDict.Add("WrathOfTheBerserker", SNOPower.Barbarian_WrathOfTheBerserker);
            RuneDict.Add("ArreatsWail", 1);
            RuneDict.Add("Insanity", 0);
            RuneDict.Add("Slaughter", 4);
            RuneDict.Add("StridingGiant", 2);
            RuneDict.Add("ThriveOnChaos", 3);

            // Barbarian - Passives
            SkillDict.Add("PoundOfFlesh", SNOPower.Barbarian_Passive_PoundOfFlesh);
            SkillDict.Add("Ruthless", SNOPower.Barbarian_Passive_Ruthless);
            SkillDict.Add("NervesOfSteel", SNOPower.Barbarian_Passive_NervesOfSteel);
            SkillDict.Add("WeaponsMaster", SNOPower.Barbarian_Passive_WeaponsMaster);
            SkillDict.Add("InspiringPresence", SNOPower.Barbarian_Passive_InspiringPresence);
            SkillDict.Add("BerserkerRage", SNOPower.Barbarian_Passive_BerserkerRage);
            SkillDict.Add("Bloodthirst", SNOPower.Barbarian_Passive_Bloodthirst);
            SkillDict.Add("Animosity", SNOPower.Barbarian_Passive_Animosity);
            SkillDict.Add("Superstition", SNOPower.Barbarian_Passive_Superstition);
            SkillDict.Add("ToughAsNails", SNOPower.Barbarian_Passive_ToughAsNails);
            SkillDict.Add("NoEscape", SNOPower.Barbarian_Passive_NoEscape);
            SkillDict.Add("Relentless", SNOPower.Barbarian_Passive_Relentless);
            SkillDict.Add("Brawler", SNOPower.Barbarian_Passive_Brawler);
            SkillDict.Add("Juggernaut", SNOPower.Barbarian_Passive_Juggernaut);
            SkillDict.Add("Unforgiving", SNOPower.Barbarian_Passive_Unforgiving);
            SkillDict.Add("BoonOfBulKathos", SNOPower.Barbarian_Passive_BoonOfBulKathos);

            // Monk - Primary
            SkillDict.Add("FistsOfThunder", SNOPower.Monk_FistsofThunder);
            RuneDict.Add("Thunderclap", 0);
            RuneDict.Add("LightningFlash", 4);
            RuneDict.Add("StaticCharge", 2);
            RuneDict.Add("Quickening", 3);
            RuneDict.Add("BoundingLight", 1);

            SkillDict.Add("DeadlyReach", SNOPower.Monk_DeadlyReach);
            RuneDict.Add("PiercingTrident", 1);
            RuneDict.Add("KeenEye", 4);
            RuneDict.Add("ScatteredBlows", 2);
            RuneDict.Add("StrikeFromBeyond", 3);
            RuneDict.Add("Foresight", 0);

            SkillDict.Add("CripplingWave", SNOPower.Monk_CripplingWave);
            RuneDict.Add("Mangle", 0);
            RuneDict.Add("Concussion", 2);
            RuneDict.Add("RisingTide", 3);
            RuneDict.Add("Tsunami", 1);
            RuneDict.Add("BreakingWave", 4);

            SkillDict.Add("WayOfTheHundredFists", SNOPower.Monk_WayOfTheHundredFists);
            RuneDict.Add("HandsOfLightning", 1);
            RuneDict.Add("BlazingFists", 2);
            RuneDict.Add("FistsOfFury", 0);
            RuneDict.Add("SpiritedSalvo", 3);
            RuneDict.Add("WindforceFlurry", 4);

            // Monk - Secondary
            SkillDict.Add("LashingTailKick", SNOPower.Monk_LashingTailKick);
            RuneDict.Add("VultureClawKick", 0);
            RuneDict.Add("SweepingArmada", 3);
            RuneDict.Add("SpinningFlameKick", 1);
            RuneDict.Add("ScorpionSting", 4);
            RuneDict.Add("HandOfYtar", 2);

            SkillDict.Add("TempestRush", SNOPower.Monk_TempestRush);
            RuneDict.Add("NorthernBreeze", 3);
            RuneDict.Add("Tailwind", 1);
            RuneDict.Add("Flurry", 4);
            RuneDict.Add("Slipstream", 2);
            RuneDict.Add("Bluster", 0);

            SkillDict.Add("WaveOfLight", SNOPower.Monk_WaveOfLight);
            RuneDict.Add("WallOfLight", 0);
            RuneDict.Add("ExplosiveLight", 1);
            RuneDict.Add("EmpoweredWave", 3);
            RuneDict.Add("BlindingLight", 4);
            RuneDict.Add("PillarOfTheAncients", 2);

            // Monk - Defensive
            SkillDict.Add("BlindingFlash", SNOPower.Monk_BlindingFlash);
            RuneDict.Add("SelfReflection", 3);
            RuneDict.Add("BlindedAndConfused", 2);
            RuneDict.Add("BlindingEcho", 1);
            RuneDict.Add("SearingLight", 4);
            RuneDict.Add("FaithInTheLight", 0);

            SkillDict.Add("BreathOfHeaven", SNOPower.Monk_BreathOfHeaven);
            RuneDict.Add("CircleOfScorn", 0);
            RuneDict.Add("CircleOfLife", 1);
            RuneDict.Add("BlazingWrath", 2);
            RuneDict.Add("InfusedWithLight", 3);
            RuneDict.Add("PenitentFlame", 4);

            SkillDict.Add("Serenity", SNOPower.Monk_Serenity);
            RuneDict.Add("PeacefulRepose", 0);
            RuneDict.Add("ReapWhatIsSown", 4);
            RuneDict.Add("Tranquility", 3);
            RuneDict.Add("Ascension", 2);
            RuneDict.Add("InstantKarma", 1);

            SkillDict.Add("InnerSanctuary", SNOPower.Monk_InnerSanctuary);
            RuneDict.Add("SafeHaven", 3);
            RuneDict.Add("SanctifiedGround", 4);
            RuneDict.Add("Consecration", 1);
            RuneDict.Add("CircleOfProtection", 2);
            RuneDict.Add("ForbiddenPalace", 0);

            // Monk - Techniques
            SkillDict.Add("DashingStrike", SNOPower.Monk_DashingStrike);
            RuneDict.Add("WayOfTheFallingStar", 1);
            RuneDict.Add("FlyingSideKick", 4);
            RuneDict.Add("Quicksilver", 3);
            RuneDict.Add("SoaringSkull", 0);
            RuneDict.Add("BlindingSpeed", 2);

            SkillDict.Add("ExplodingPalm", SNOPower.Monk_ExplodingPalm);
            RuneDict.Add("TheFleshIsWeak", 2);
            RuneDict.Add("StrongSpirit", 3);
            RuneDict.Add("CreepingDemise", 1);
            RuneDict.Add("ImpendingDoom", 0);
            RuneDict.Add("EssenceBurn", 4);

            SkillDict.Add("SweepingWind", SNOPower.Monk_SweepingWind);
            RuneDict.Add("MasterOfWind", 4);
            RuneDict.Add("BladeStorm", 0);
            RuneDict.Add("FireStorm", 1);
            RuneDict.Add("InnerStorm", 3);
            RuneDict.Add("Cyclone", 2);

            // Monk - Focus
            SkillDict.Add("CycloneStrike", SNOPower.Monk_CycloneStrike);
            RuneDict.Add("EyeOfTheStorm", 3);
            RuneDict.Add("Implosion", 1);
            RuneDict.Add("Sunburst", 0);
            RuneDict.Add("WallOfWind", 4);
            RuneDict.Add("SoothingBreeze", 2);

            SkillDict.Add("SevenSidedStrike", SNOPower.Monk_SevenSidedStrike);
            RuneDict.Add("SuddenAssault", 0);
            RuneDict.Add("SeveralSidedStrike", 1);
            RuneDict.Add("Pandemonium", 2);
            RuneDict.Add("SustainedAttack", 3);
            RuneDict.Add("FulinatingOnslaught", 4);

            SkillDict.Add("MysticAlly", SNOPower.Monk_MysticAlly);
            RuneDict.Add("WaterAlly", 1);
            RuneDict.Add("FireAlly", 0);
            RuneDict.Add("AirAlly", 3);
            RuneDict.Add("EternalAlly", 4);
            RuneDict.Add("EarthAlly", 2);

            // Monk - Mantras
            SkillDict.Add("MantraOfEvasion", SNOPower.Monk_MantraOfEvasion);
            RuneDict.Add("HardTarget", 2);
            RuneDict.Add("DivineProtection", 4);
            RuneDict.Add("WindThroughTheReeds", 3);
            RuneDict.Add("Perserverance", 1);
            RuneDict.Add("Backlash", 0);

            SkillDict.Add("MantraOfRetribution", SNOPower.Monk_MantraOfRetribution);
            RuneDict.Add("Retaliation", 0);
            RuneDict.Add("Transgression", 1);
            RuneDict.Add("Indignation", 2);
            RuneDict.Add("AgainstAllOdds", 3);
            RuneDict.Add("CollateralDamage", 4);

            SkillDict.Add("MantraOfHealing", SNOPower.Monk_MantraOfHealing);
            RuneDict.Add("Sustenance", 0);
            RuneDict.Add("CircularBreathing", 3);
            RuneDict.Add("BoonOfInspiration", 1);
            RuneDict.Add("HeavenlyBody", 2);
            RuneDict.Add("TimeOfNeed", 4);

            SkillDict.Add("MantraOfConviction", SNOPower.Monk_MantraOfConviction);
            RuneDict.Add("Overawe", 0);
            RuneDict.Add("Intimidation", 4);
            RuneDict.Add("Dishearten", 2);
            RuneDict.Add("Reclamation", 3);
            RuneDict.Add("Submission", 1);

            // Monk - Passives
            SkillDict.Add("Resolve", SNOPower.Monk_Passive_Resolve);
            SkillDict.Add("FleetFooted", SNOPower.Monk_Passive_FleetFooted);
            SkillDict.Add("ExaltedSoul", SNOPower.Monk_Passive_ExaltedSoul);
            SkillDict.Add("Transcendence", SNOPower.Monk_Passive_Transcendence);
            SkillDict.Add("ChantOfResonance", SNOPower.Monk_Passive_ChantOfResonance);
            SkillDict.Add("SeizeTheInitiative", SNOPower.Monk_Passive_SeizeTheInitiative);
            SkillDict.Add("TheGuardiansPath", SNOPower.Monk_Passive_TheGuardiansPath);
            SkillDict.Add("SixthSense", SNOPower.Monk_Passive_SixthSense);
            SkillDict.Add("Pacifism", SNOPower.Monk_Passive_Pacifism);
            SkillDict.Add("BeaconOfYtar", SNOPower.Monk_Passive_BeaconOfYtar);
            SkillDict.Add("GuidingLight", SNOPower.Monk_Passive_GuidingLight);
            SkillDict.Add("OneWithEverything", SNOPower.Monk_Passive_OneWithEverything);
            SkillDict.Add("CombinationStrike", SNOPower.Monk_Passive_CombinationStrike);
            SkillDict.Add("NearDeathExperience", SNOPower.Monk_Passive_NearDeathExperience);

            // Demon Hunter - Primary
            SkillDict.Add("HungeringArrow", SNOPower.DemonHunter_HungeringArrow);
            RuneDict.Add("PuncturingArrow", 3);
            RuneDict.Add("CinderArrow", 0);
            RuneDict.Add("ShatterShot", 1);
            RuneDict.Add("DevouringArrow", 2);
            RuneDict.Add("SprayOfTeeth", 4);

            SkillDict.Add("EntanglingShot", SNOPower.DemonHunter_EntanglingShot);
            RuneDict.Add("ChainGang", 1);
            RuneDict.Add("ShockCollar", 2);
            RuneDict.Add("HeavyBurden", 0);
            RuneDict.Add("JusticeIsServed", 3);
            RuneDict.Add("BountyHunter", 4);

            SkillDict.Add("BolaShot", SNOPower.DemonHunter_BolaShot);
            RuneDict.Add("VolatileExplosives", 0);
            RuneDict.Add("ThunderBall", 2);
            RuneDict.Add("AcidStrike", 1);
            RuneDict.Add("BitterPill", 3);
            RuneDict.Add("ImminentDoom", 4);

            SkillDict.Add("Grenades", SNOPower.DemonHunter_Grenades);
            RuneDict.Add("Tinkerer", 3);
            RuneDict.Add("ClusterGrenades", 1);
            RuneDict.Add("FireBomb", 2);
            RuneDict.Add("StunGrenades", 4);
            RuneDict.Add("GasGrenades", 0);

            // Demon Hunter - Secondary
            SkillDict.Add("Impale", SNOPower.DemonHunter_Impale);
            RuneDict.Add("Impact", 1);
            RuneDict.Add("ChemicalBurn", 2);
            RuneDict.Add("Overpenetration", 0);
            RuneDict.Add("Awareness", 3);
            RuneDict.Add("GrievousWounds", 4);

            SkillDict.Add("RapidFire", SNOPower.DemonHunter_RapidFire);
            RuneDict.Add("WitheringFire", 3);
            RuneDict.Add("WebShot", 4);
            RuneDict.Add("FireSupport", 2);
            RuneDict.Add("HighVelocity", 1);
            RuneDict.Add("Bombardment", 0);

            SkillDict.Add("Chakram", SNOPower.DemonHunter_Chakram);
            RuneDict.Add("TwinChakrams", 0);
            RuneDict.Add("Serpentine", 2);
            RuneDict.Add("RazorDisk", 3);
            RuneDict.Add("Boomerang", 1);
            RuneDict.Add("ShurikenCloud", 4);

            SkillDict.Add("ElementalArrow", SNOPower.DemonHunter_ElementalArrow);
            RuneDict.Add("BallLightning", 1);
            RuneDict.Add("FrostArrow", 0);
            RuneDict.Add("ScreamingSkull", 2);
            RuneDict.Add("LightningBolts", 4);
            RuneDict.Add("NetherTentacles", 3);

            // Demon Hunter - Defensive
            SkillDict.Add("Caltrops", SNOPower.DemonHunter_Caltrops);
            RuneDict.Add("HookedSpines", 1);
            RuneDict.Add("TorturousGround", 2);
            RuneDict.Add("JaggedSpikes", 0);
            RuneDict.Add("CarvedStakes", 3);
            RuneDict.Add("BaitTheTrap", 4);

            SkillDict.Add("SmokeScreen", SNOPower.DemonHunter_SmokeScreen);
            RuneDict.Add("Displacement", 4);
            RuneDict.Add("LingeringFog", 1);
            RuneDict.Add("BreatheDeep", 2);
            RuneDict.Add("SpecialRecipe", 3);
            RuneDict.Add("ChokingGas", 0);

            SkillDict.Add("ShadowPower", SNOPower.DemonHunter_ShadowPower);
            RuneDict.Add("NightBane", 0);
            RuneDict.Add("BloodMoon", 4);
            RuneDict.Add("WellOfDarkness", 3);
            RuneDict.Add("Gloom", 2);
            RuneDict.Add("ShadowGuide", 1);

            // Demon Hunter - Hunting
            SkillDict.Add("Vault", SNOPower.DemonHunter_Vault);
            RuneDict.Add("ActionShot", 2);
            RuneDict.Add("RattlingRoll", 4);
            RuneDict.Add("Tumble", 3);
            RuneDict.Add("Acrobatics", 1);
            RuneDict.Add("TrailOfCinders", 0);

            SkillDict.Add("Preparation", SNOPower.DemonHunter_Preparation);
            RuneDict.Add("Invigoration", 1);
            RuneDict.Add("Punishment", 0);
            RuneDict.Add("BattleScars", 3);
            RuneDict.Add("FocusedMind", 2);
            RuneDict.Add("BackupPlan", 4);

            SkillDict.Add("Companion", SNOPower.DemonHunter_Companion);
            RuneDict.Add("SpiderCompanion", 0);
            RuneDict.Add("BatCompanion", 3);
            RuneDict.Add("BoarCompanion", 1);
            RuneDict.Add("FerretCompanion", 4);
            RuneDict.Add("WolfCompanion", 2);

            SkillDict.Add("MarkedForDeath", SNOPower.DemonHunter_MarkedForDeath);
            RuneDict.Add("Contagion", 1);
            RuneDict.Add("ValleyOfDeath", 2);
            RuneDict.Add("GrimReaper", 0);
            RuneDict.Add("MortalEnemy", 3);
            RuneDict.Add("DeathToll", 4);

            // Demon Hunter - Devices
            SkillDict.Add("EvasiveFire", SNOPower.DemonHunter_EvasiveFire);
            RuneDict.Add("Hardened", 0);
            RuneDict.Add("PartingGift", 2);
            RuneDict.Add("CoveringFire", 1);
            RuneDict.Add("Displace", 4);
            RuneDict.Add("Surge", 3);

            SkillDict.Add("FanOfKnives", SNOPower.DemonHunter_FanOfKnives);
            RuneDict.Add("CripplingRazors", 3);
            RuneDict.Add("Retaliate", 4);
            RuneDict.Add("HailOfKnives", 0);
            RuneDict.Add("FanOfDaggers", 2);
            RuneDict.Add("AssassinsKnives", 1);

            SkillDict.Add("SpikeTrap", SNOPower.DemonHunter_SpikeTrap);
            RuneDict.Add("EchoingBlast", 1);
            RuneDict.Add("StickyTrap", 2);
            RuneDict.Add("LongFuse", 0);
            RuneDict.Add("LightningRod", 4);
            RuneDict.Add("Scatter", 3);

            SkillDict.Add("Sentry", SNOPower.DemonHunter_Sentry);
            RuneDict.Add("SpitfireTurret", 2);
            RuneDict.Add("VigilantWatcher", 1);
            RuneDict.Add("ChainOfTorment", 0);
            RuneDict.Add("AidStation", 3);
            RuneDict.Add("GuardianTurret", 4);

            // Demon Hunter - Archery
            SkillDict.Add("Strafe", SNOPower.DemonHunter_Strafe);
            RuneDict.Add("Emberstrafe", 1);
            RuneDict.Add("DriftingShadow", 3);
            RuneDict.Add("StingingSteel", 4);
            RuneDict.Add("RocketStorm", 2);
            RuneDict.Add("Demolition", 0);

            SkillDict.Add("Multishot", SNOPower.DemonHunter_Multishot);
            RuneDict.Add("FireAtWill", 3);
            RuneDict.Add("BurstFire", 1);
            RuneDict.Add("SuppressionFire", 4);
            RuneDict.Add("FullBroadside", 0);
            RuneDict.Add("Arsenal", 2);

            SkillDict.Add("ClusterArrow", SNOPower.DemonHunter_ClusterArrow);
            RuneDict.Add("DazzlingArrow", 4);
            RuneDict.Add("ShootingStars", 1);
            RuneDict.Add("Maelstrom", 3);
            RuneDict.Add("ClusterBombs", 2);
            RuneDict.Add("LoadedForBear", 0);

            SkillDict.Add("RainOfVengeance", SNOPower.DemonHunter_RainOfVengeance);
            RuneDict.Add("DarkCloud", 1);
            RuneDict.Add("BeastlyBombs", 0);
            RuneDict.Add("Stampede", 4);
            RuneDict.Add("Anathema", 2);
            RuneDict.Add("FlyingStrike", 3);

            // Demon Hunter - Passives
            SkillDict.Add("ThrillOfTheHunt", SNOPower.DemonHunter_Passive_ThrillOfTheHunt);
            SkillDict.Add("TacticalAdvantage", SNOPower.DemonHunter_Passive_TacticalAdvantage);
            SkillDict.Add("Vengeance", SNOPower.DemonHunter_Passive_Vengeance);
            SkillDict.Add("SteadyAim", SNOPower.DemonHunter_Passive_SteadyAim);
            SkillDict.Add("CullTheWeak", SNOPower.DemonHunter_Passive_CullTheWeak);
            SkillDict.Add("NightStalker", SNOPower.DemonHunter_Passive_NightStalker);
            SkillDict.Add("Brooding", SNOPower.DemonHunter_Passive_Brooding);
            SkillDict.Add("HotPursuit", SNOPower.DemonHunter_Passive_HotPursuit);
            SkillDict.Add("Archery", SNOPower.DemonHunter_Passive_Archery);
            SkillDict.Add("NumbingTraps", SNOPower.DemonHunter_Passive_NumbingTraps);
            SkillDict.Add("Perfectionist", SNOPower.DemonHunter_Passive_Perfectionist);
            SkillDict.Add("CustomEngineering", SNOPower.DemonHunter_Passive_CustomEngineering);
            SkillDict.Add("Grenadier", SNOPower.DemonHunter_Passive_Grenadier);
            SkillDict.Add("Sharpshooter", SNOPower.DemonHunter_Passive_Sharpshooter);
            SkillDict.Add("Ballistics", SNOPower.DemonHunter_Passive_Ballistics);

            // Witch Doctor - Primary
            SkillDict.Add("PoisonDart", SNOPower.Witchdoctor_PoisonDart);
            RuneDict.Add("Splinters", 1);
            RuneDict.Add("NumbingDart", 2);
            RuneDict.Add("SpinedDart", 3);
            RuneDict.Add("FlamingDart", 0);
            RuneDict.Add("SnakeToTheFace", 4);

            SkillDict.Add("CorpseSpiders", SNOPower.Witchdoctor_CorpseSpider);
            RuneDict.Add("LeapingSpiders", 2);
            RuneDict.Add("SpiderQueen", 1);
            RuneDict.Add("Widowmakers", 3);
            RuneDict.Add("MedusaSpiders", 4);
            RuneDict.Add("BlazingSpiders", 0);

            SkillDict.Add("PlagueOfToads", SNOPower.Witchdoctor_PlagueOfToads);
            RuneDict.Add("ExplosiveToads", 0);
            RuneDict.Add("ToadOfHugeness", 2);
            RuneDict.Add("RainOfToads", 1);
            RuneDict.Add("AddlingToads", 4);
            RuneDict.Add("ToadAffinity", 3);

            SkillDict.Add("Firebomb", SNOPower.Witchdoctor_Firebomb);
            RuneDict.Add("FlashFire", 4);
            RuneDict.Add("RollTheBones", 1);
            RuneDict.Add("FirePit", 2);
            RuneDict.Add("Pyrogeist", 3);
            RuneDict.Add("GhostBomb", 0);

            // Witch Doctor - Secondary
            SkillDict.Add("GraspOfTheDead", SNOPower.Witchdoctor_GraspOfTheDead);
            RuneDict.Add("UnbreakableGrasp", 2);
            RuneDict.Add("GropingEels", 0);
            RuneDict.Add("DeathIsLife", 4);
            RuneDict.Add("DesperateGrasp", 3);
            RuneDict.Add("RainOfCorpses", 1);

            SkillDict.Add("Firebats", SNOPower.Witchdoctor_Firebats);
            RuneDict.Add("DireBats", 0);
            RuneDict.Add("VampireBats", 3);
            RuneDict.Add("PlagueBats", 2);
            RuneDict.Add("HungryBats", 1);
            RuneDict.Add("CloudOfBats", 4);

            SkillDict.Add("Haunt", SNOPower.Witchdoctor_Haunt);
            RuneDict.Add("ConsumingSpirit", 0);
            RuneDict.Add("ResentfulSpirit", 4);
            RuneDict.Add("LingeringSpirit", 1);
            RuneDict.Add("GraspingSpirit", 2);
            RuneDict.Add("DrainingSpirit", 3);

            SkillDict.Add("LocustSwarm", SNOPower.Witchdoctor_Locust_Swarm);
            RuneDict.Add("Pestilence", 1);
            RuneDict.Add("DevouringSwarm", 3);
            RuneDict.Add("CloudOfInsects", 2);
            RuneDict.Add("DiseasedSwarm", 4);
            RuneDict.Add("SearingLocusts", 0);

            // Witch Doctor - Defensive
            SkillDict.Add("SummonZombieDogs", SNOPower.Witchdoctor_SummonZombieDog);
            RuneDict.Add("RabidDogs", 2);
            RuneDict.Add("FinalGift", 3);
            RuneDict.Add("LifeLink", 1);
            RuneDict.Add("BurningDogs", 0);
            RuneDict.Add("LeechingBeasts", 4);

            SkillDict.Add("Horrify", SNOPower.Witchdoctor_Horrify);
            RuneDict.Add("Phobia", 2);
            RuneDict.Add("Stalker", 4);
            RuneDict.Add("FaceOfDeath", 1);
            RuneDict.Add("FrighteningAspect", 0);
            RuneDict.Add("RuthlessTerror", 3);

            SkillDict.Add("SpiritWalk", SNOPower.Witchdoctor_SpiritWalk);
            RuneDict.Add("Jaunt", 1);
            RuneDict.Add("HonoredGuest", 3);
            RuneDict.Add("UmbralShock", 2);
            RuneDict.Add("Severance", 0);
            RuneDict.Add("HealingJourney", 4);

            SkillDict.Add("Hex", SNOPower.Witchdoctor_Hex);
            RuneDict.Add("HedgeMagic", 3);
            RuneDict.Add("Jinx", 4);
            RuneDict.Add("AngryChicken", 1);
            RuneDict.Add("PainfulTransformation", 0);
            RuneDict.Add("UnstableForm", 2);

            // Witch Doctor - Terror
            SkillDict.Add("SoulHarvest", SNOPower.Witchdoctor_SoulHarvest);
            RuneDict.Add("SwallowYourSoul", 3);
            RuneDict.Add("Siphon", 0);
            RuneDict.Add("Languish", 2);
            RuneDict.Add("SoulToWaste", 1);
            RuneDict.Add("VengefulSpirit", 4);

            SkillDict.Add("Sacrifice", SNOPower.Witchdoctor_Sacrifice);
            RuneDict.Add("BlackBlood", 2);
            RuneDict.Add("NextOfKin", 4);
            RuneDict.Add("Pride", 3);
            RuneDict.Add("ForTheMaster", 1);
            RuneDict.Add("ProvokeThePack", 0);

            SkillDict.Add("MassConfusion", SNOPower.Witchdoctor_MassConfusion);
            RuneDict.Add("UnstableRealm", 3);
            RuneDict.Add("Devolution", 4);
            RuneDict.Add("MassHysteria", 1);
            RuneDict.Add("Paranoia", 0);
            RuneDict.Add("MassHallucination", 2);

            // Witch Doctor - Decay
            SkillDict.Add("ZombieCharger", SNOPower.Witchdoctor_ZombieCharger);
            RuneDict.Add("LeperousZombie", 2);
            RuneDict.Add("Undeath", 3);
            RuneDict.Add("WaveOfZombies", 1);
            RuneDict.Add("ExplosiveBeast", 4);
            RuneDict.Add("ZombieBears", 0);

            SkillDict.Add("SpiritBarage", SNOPower.Witchdoctor_SpiritBarrage);
            RuneDict.Add("TheSpiritIsWilling", 3);
            RuneDict.Add("WellOfSouls", 1);
            RuneDict.Add("Phantasm", 2);
            RuneDict.Add("Phlebotomize", 0);
            RuneDict.Add("Manitou", 4);

            SkillDict.Add("AcidCloud", SNOPower.Witchdoctor_AcidCloud);
            RuneDict.Add("AcidRain", 1);
            RuneDict.Add("LobBlobBomb", 2);
            RuneDict.Add("SlowBurn", 3);
            RuneDict.Add("KissOfDeath", 4);
            RuneDict.Add("CorpseBomb", 0);

            SkillDict.Add("WallOfZombies", SNOPower.Witchdoctor_WallOfZombies);
            RuneDict.Add("Barricade", 1);
            RuneDict.Add("UnrelentingGrip", 3);
            RuneDict.Add("Creepers", 0);
            RuneDict.Add("PileOn", 4);
            RuneDict.Add("DeadRush", 2);

            // Witch Doctor - Voodoo
            SkillDict.Add("Gargantuan", SNOPower.Witchdoctor_Gargantuan);
            RuneDict.Add("Humongoid", 1);
            RuneDict.Add("RestlessGiant", 0);
            RuneDict.Add("WrathfulProtector", 3);
            RuneDict.Add("BigStinker", 2);
            RuneDict.Add("Bruiser", 4);

            SkillDict.Add("BigBadVoodoo", SNOPower.Witchdoctor_BigBadVoodoo);
            RuneDict.Add("JungleDrums", 1);
            RuneDict.Add("RainDance", 3);
            RuneDict.Add("SlamDance", 0);
            RuneDict.Add("GhostTrance", 2);
            RuneDict.Add("BoogieMan", 4);

            SkillDict.Add("FetishArmy", SNOPower.Witchdoctor_FetishArmy);
            RuneDict.Add("FetishAmbush", 0);
            RuneDict.Add("DevotedFollowing", 3);
            RuneDict.Add("LegionOfDaggers", 1);
            RuneDict.Add("TikiTorchers", 2);
            RuneDict.Add("HeadHunters", 4);

            // Witch Doctor - Passives
            SkillDict.Add("JungleFortitude", SNOPower.Witchdoctor_Passive_JungleFortitude);
            SkillDict.Add("CircleOfLife", SNOPower.Witchdoctor_Passive_CircleOfLife);
            SkillDict.Add("SpiritualAttunement", SNOPower.Witchdoctor_Passive_SpiritualAttunement);
            SkillDict.Add("GruesomeFeast", SNOPower.Witchdoctor_Passive_GruesomeFeast);
            SkillDict.Add("BloodRitual", SNOPower.Witchdoctor_Passive_BloodRitual);
            SkillDict.Add("BadMedicine", SNOPower.Witchdoctor_Passive_BadMedicine);
            SkillDict.Add("ZombieHandler", SNOPower.Witchdoctor_Passive_ZombieHandler);
            SkillDict.Add("PierceTheVeil", SNOPower.Witchdoctor_Passive_PierceTheVeil);
            SkillDict.Add("SpiritVessel", SNOPower.Witchdoctor_Passive_SpiritVessel);
            SkillDict.Add("FetishSycophants", SNOPower.Witchdoctor_Passive_FetishSycophants);
            SkillDict.Add("RushOfEssence", SNOPower.Witchdoctor_Passive_RushOfEssence);
            SkillDict.Add("VisionQuest", SNOPower.Witchdoctor_Passive_VisionQuest);
            SkillDict.Add("FierceLoyalty", SNOPower.Witchdoctor_Passive_FierceLoyalty);
            SkillDict.Add("GraveInjustice", SNOPower.Witchdoctor_Passive_GraveInjustice);
            SkillDict.Add("TribalRites", SNOPower.Witchdoctor_Passive_TribalRites);

            // Wizard - Primary
            SkillDict.Add("MagicMissile", SNOPower.Wizard_MagicMissile);
            RuneDict.Add("ChargedBlast", 0);
            RuneDict.Add("Split", 1);
            RuneDict.Add("PenetratingBlast", 2);
            RuneDict.Add("Attunement", 3);
            RuneDict.Add("Seeker", 4);

            SkillDict.Add("ShockPulse", SNOPower.Wizard_ShockPulse);
            RuneDict.Add("ExplosiveBolts", 4);
            RuneDict.Add("FireBolts", 0);
            RuneDict.Add("PiercingOrb", 2);
            RuneDict.Add("LightningAffinity", 3);
            RuneDict.Add("LivingLightning", 1);

            SkillDict.Add("SpectralBlade", SNOPower.Wizard_SpectralBlade);
            RuneDict.Add("DeepCuts", 0);
            RuneDict.Add("ImpactfulBlades", 2);
            RuneDict.Add("SiphoningBlade", 3);
            RuneDict.Add("HealingBlades", 4);
            RuneDict.Add("ThrownBlade", 1);

            SkillDict.Add("Electrocute", SNOPower.Wizard_Electrocute);
            RuneDict.Add("ChainLightning", 1);
            RuneDict.Add("ForkedLightning", 4);
            RuneDict.Add("LightningBlast", 0);
            RuneDict.Add("SurgeOfPower", 3);
            RuneDict.Add("ArcLightning", 2);

            // Wizard - Secondary
            SkillDict.Add("RayOfFrost", SNOPower.Wizard_RayOfFrost);
            RuneDict.Add("Numb", 2);
            RuneDict.Add("SnowBlast", 0);
            RuneDict.Add("ColdBlood", 3);
            RuneDict.Add("SleetStorm", 1);
            RuneDict.Add("BlackIce", 4);

            SkillDict.Add("ArcaneOrb", SNOPower.Wizard_ArcaneOrb);
            RuneDict.Add("Obliteration", 0);
            RuneDict.Add("ArcaneOrbit", 2);
            RuneDict.Add("ArcaneNova", 1);
            RuneDict.Add("TapTheSource", 3);
            RuneDict.Add("CelestialOrb", 4);

            SkillDict.Add("ArcaneTorrent", SNOPower.Wizard_ArcaneTorrent);
            RuneDict.Add("Diruption", 0);
            RuneDict.Add("DeathBlossom", 4);
            RuneDict.Add("ArcaneMines", 2);
            RuneDict.Add("PowerStone", 3);
            RuneDict.Add("Cascade", 1);

            SkillDict.Add("Disintegrate", SNOPower.Wizard_Disintegrate);
            RuneDict.Add("Convergence", 1);
            RuneDict.Add("ChaosNexus", 3);
            RuneDict.Add("Volatility", 4);
            RuneDict.Add("Entropy", 2);
            RuneDict.Add("Intensify", 0);

            // Wizard - Defensive
            SkillDict.Add("FrostNova", SNOPower.Wizard_FrostNova);
            RuneDict.Add("Shatter", 1);
            RuneDict.Add("ColdSnap", 3);
            RuneDict.Add("FrozenMist", 2);
            RuneDict.Add("DeepFreeze", 4);
            RuneDict.Add("BoneChill", 0);

            SkillDict.Add("DiamondSkin", SNOPower.Wizard_DiamondSkin);
            RuneDict.Add("CrystalShell", 2);
            RuneDict.Add("Prism", 3);
            RuneDict.Add("MirrorSkin", 0);
            RuneDict.Add("EnduringSkin", 1);
            RuneDict.Add("DiamondShards", 4);

            SkillDict.Add("SlowTime", SNOPower.Wizard_SlowTime);
            RuneDict.Add("Miasma", 1);
            RuneDict.Add("TimeWarp", 0);
            RuneDict.Add("TimeShell", 2);
            RuneDict.Add("Perpetuity", 3);
            RuneDict.Add("StretchTime", 4);

            SkillDict.Add("Teleport", SNOPower.Wizard_Teleport);
            RuneDict.Add("SafePassage", 2);
            RuneDict.Add("Wormhole", 4);
            RuneDict.Add("Reversal", 3);
            RuneDict.Add("Fracture", 1);
            RuneDict.Add("Calamity", 0);

            // Wizard - Force
            SkillDict.Add("WaveOfForce", SNOPower.Wizard_WaveOfForce);
            RuneDict.Add("ImpactfulWave", 4);
            RuneDict.Add("ForceAffinity", 3);
            RuneDict.Add("ForcefulWave", 0);
            RuneDict.Add("TeleportingWave", 2);
            RuneDict.Add("ExplodingWave", 1);

            SkillDict.Add("EnergyTwister", SNOPower.Wizard_EnergyTwister);
            RuneDict.Add("MistralBreeze", 3);
            RuneDict.Add("GaleForce", 0);
            RuneDict.Add("RagingStorm", 1);
            RuneDict.Add("WickedWind", 4);
            RuneDict.Add("StromChaser", 2);

            SkillDict.Add("Hydra", SNOPower.Wizard_Hydra);
            RuneDict.Add("ArcaneHydra", 4);
            RuneDict.Add("LightningHydra", 1);
            RuneDict.Add("VenomHydra", 2);
            RuneDict.Add("FrostHydra", 0);
            RuneDict.Add("MammothHydra", 3);

            SkillDict.Add("Meteor", SNOPower.Wizard_Meteor);
            RuneDict.Add("MoltenImpact", 0);
            RuneDict.Add("StarPact", 3);
            RuneDict.Add("MeteorShower", 1);
            RuneDict.Add("Comet", 2);
            RuneDict.Add("Liquefy", 4);

            SkillDict.Add("Blizzard", SNOPower.Wizard_Blizzard);
            RuneDict.Add("GraspingChill", 2);
            RuneDict.Add("FrozenSolid", 4);
            RuneDict.Add("Snowbound", 3);
            RuneDict.Add("StarkWinter", 1);
            RuneDict.Add("UnrelentingStorm", 0);

            // Wizard - Conjuration
            SkillDict.Add("IceArmor", SNOPower.Wizard_IceArmor);
            RuneDict.Add("ChillingAura", 1);
            RuneDict.Add("Crystallize", 3);
            RuneDict.Add("JaggedIce", 0);
            RuneDict.Add("IceReflect", 4);
            RuneDict.Add("FrozenStorm", 2);

            SkillDict.Add("StormArmor", SNOPower.Wizard_StormArmor);
            RuneDict.Add("ReactiveArmor", 2);
            RuneDict.Add("PowerOfTheStorm", 3);
            RuneDict.Add("ThunderStorm", 0);
            RuneDict.Add("Scramble", 1);
            RuneDict.Add("ShockingAspect", 4);

            SkillDict.Add("MagicWeapon", SNOPower.Wizard_MagicWeapon);
            RuneDict.Add("Electrify", 1);
            RuneDict.Add("ForceWeapon", 2);
            RuneDict.Add("Conduit", 3);
            RuneDict.Add("Venom", 0);
            RuneDict.Add("BloodMagic", 4);

            SkillDict.Add("Familiar", SNOPower.Wizard_Familiar);
            RuneDict.Add("Sparkflint", 0);
            RuneDict.Add("Vigoron", 2);
            RuneDict.Add("AncientGuardian", 4);
            RuneDict.Add("Arcanot", 3);
            RuneDict.Add("Cannoneer", 1);

            SkillDict.Add("EnergyArmor", SNOPower.Wizard_EnergyArmor);
            RuneDict.Add("Absorption", 3);
            RuneDict.Add("PinpointBarrier", 4);
            RuneDict.Add("EnergyTap", 1);
            RuneDict.Add("ForceArmor", 2);
            RuneDict.Add("PrismaticArmor", 0);

            // Wizard - Mastery
            SkillDict.Add("ExplosiveBlast", SNOPower.Wizard_ExplosiveBlast);
            RuneDict.Add("Unleashed", 3);
            RuneDict.Add("TimeBomb", 2);
            RuneDict.Add("ShortFuse", 0);
            RuneDict.Add("Obliterate", 1);
            RuneDict.Add("ChainReaction", 4);

            SkillDict.Add("MirrorImage", SNOPower.Wizard_MirrorImage);
            RuneDict.Add("Simulacrum", 2);
            RuneDict.Add("Duplicates", 1);
            RuneDict.Add("MockingDemise", 4);
            RuneDict.Add("ExtensionOfWill", 3);
            RuneDict.Add("MirrorMimics", 0);

            SkillDict.Add("Archon", SNOPower.Wizard_Archon);
            RuneDict.Add("ArcaneDestruction", 4);
            RuneDict.Add("Teleport", 2);
            RuneDict.Add("PurePower", 3);
            RuneDict.Add("SlowTime", 1);
            RuneDict.Add("ImprovedArchon", 0);

            // Wizard - Passives
            SkillDict.Add("PowerHungry", SNOPower.Wizard_Passive_PowerHungry);
            SkillDict.Add("Blur", SNOPower.Wizard_Passive_Blur);
            SkillDict.Add("Evocation", SNOPower.Wizard_Passive_Evocation);
            SkillDict.Add("GlassCannon", SNOPower.Wizard_Passive_GlassCannon);
            SkillDict.Add("Prodigy", SNOPower.Wizard_Passive_Prodigy);
            SkillDict.Add("AstralPresence", SNOPower.Wizard_Passive_AstralPresence);
            SkillDict.Add("Illusionist", SNOPower.Wizard_Passive_Illusionist);
            SkillDict.Add("ColdBlooded", SNOPower.Wizard_Passive_ColdBlooded);
            SkillDict.Add("Conflagration", SNOPower.Wizard_Passive_Conflagration);
            SkillDict.Add("Paralysis", SNOPower.Wizard_Passive_Paralysis);
            SkillDict.Add("GalvanizingWard", SNOPower.Wizard_Passive_GalvanizingWard);
            SkillDict.Add("TemporalFlux", SNOPower.Wizard_Passive_TemporalFlux);
            SkillDict.Add("CriticalMass", SNOPower.Wizard_Passive_CriticalMass);
            SkillDict.Add("ArcaneDynamo", SNOPower.Wizard_Passive_ArcaneDynamo);
            SkillDict.Add("UnstableAnomaly", SNOPower.Wizard_Passive_UnstableAnomaly);
        }

        public abstract bool Activate();

        public abstract void SetSlotByString(string SlotString);

        public void SetSnoPowerByString(string SkillString) {
            this.Power = SkillDict[SkillString];
        }

        public void SetRuneIdByString(string RuneString) {
            this.RuneId = RuneDict[RuneString];
        }
    }
}

/*  Rune numbering setup
Code                                    Name                     Class       Rune 0                  Rune 1                  Rune 2                  Rune 3                  Rune 4                  
wizard_electrocute                      Electrocute              Wizard      Lightning Blast         Chain Lightning         Arc Lightning           Surge of Power          Forked Lightning        
wizard_slowtime                         Slow Time                Wizard      Time Warp               Miasma                  Time Shell              Perpetuity              Stretch Time            
witchdoctor_gargantuan                  Gargantuan               WitchDoctor Restless Giant          Humongoid               Big Stinker             Wrathful Protector      Bruiser                 
witchdoctor_hex                         Hex                      WitchDoctor Painful Transformation  Angry Chicken           Unstable Form           Hedge Magic             Jinx                    
wizard_arcaneorb                        Arcane Orb               Wizard      Obliteration            Arcane Nova             Arcane Orbit            Tap the Source          Celestial Orb           
wizard_blizzard                         Blizzard                 Wizard      Unrelenting Storm       Stark Winter            Grasping Chill          Snowbound               Frozen Solid            
wizard_frostnova                        Frost Nova               Wizard      Bone Chill              Shatter                 Frozen Mist             Cold Snap               Deep Freeze             
wizard_hydra                            Hydra                    Wizard      Frost Hydra             Lightning Hydra         Venom Hydra             Mammoth Hydra           Arcane Hydra            
wizard_magicmissile                     Magic Missile            Wizard      Charged Blast           Split                   Penetrating Blast       Attunement              Seeker                  
wizard_shockpulse                       Shock Pulse              Wizard      Fire Bolts              Living Lightning        Piercing Orb            Lightning Affinity      Explosive Bolts         
wizard_waveofforce                      Wave of Force            Wizard      Forceful Wave           Exploding Wave          Teleporting Wave        Force Affinity          Impactful Wave          
witchdoctor_firebomb                    Firebomb                 WitchDoctor Ghost Bomb              Roll the Bones          Fire Pit                Pyrogeist               Flash Fire              
witchdoctor_massconfusion               Mass Confusion           WitchDoctor Paranoia                Mass Hysteria           Mass Hallucination      Unstable Realm          Devolution              
witchdoctor_soulharvest                 Soul Harvest             WitchDoctor Siphon                  Soul to Waste           Languish                Swallow Your Soul       Vengeful Spirit         
witchdoctor_horrify                     Horrify                  WitchDoctor Frightening Aspect      Face of Death           Phobia                  Ruthless Terror         Stalker                 
monk_breathofheaven                     Breath of Heaven         Monk        Circle of Scorn         Circle of Life          Blazing Wrath           Infused with Light      Penitent Flame          
witchdoctor_graspofthedead              Grasp of the Dead        WitchDoctor Groping Eels            Rain of Corpses         Unbreakable Grasp       Desperate Grasp         Death Is Life           
wizard_meteor                           Meteor                   Wizard      Molten Impact           Meteor Shower           Comet                   Star Pact               Liquefy                 
monk_mantraofretribution                Mantra of Retribution    Monk        Retaliation             Transgression           Indignation             Against All Odds        Collateral Damage       
monk_mantraofhealing                    Mantra of Healing        Monk        Sustenance              Boon of Inspiration     Heavenly Body           Circular Breathing      Time of Need            
witchdoctor_corpsespider                Corpse Spiders           WitchDoctor Blazing Spiders         Spider Queen            Leaping Spiders         Widowmakers             Medusa Spiders          
witchdoctor_locust_swarm                Locust Swarm             WitchDoctor Searing Locusts         Pestilence              Cloud of Insects        Devouring Swarm         Diseased Swarm          
barbarian_ancientspear                  Ancient Spear            Barbarian   Harpoon                 Grappling Hooks         Dread Spear             Skirmish                Rage Flip               
witchdoctor_acidcloud                   Acid Cloud               WitchDoctor Corpse Bomb             Acid Rain               Lob Blob Bomb           Slow Burn               Kiss of Death           
barbarian_rend                          Rend                     Barbarian   Lacerate                Ravage                  Mutilate                Blood Lust              Bloodbath               
wizard_spectralblade                    Spectral Blade           Wizard      Deep Cuts               Thrown Blade            Impactful Blades        Siphoning Blade         Healing Blades          
witchdoctor_fetisharmy                  Fetish Army              WitchDoctor Fetish Ambush           Legion of Daggers       Tiki Torchers           Devoted Following       Head Hunters            
wizard_icearmor                         Ice Armor                Wizard      Jagged Ice              Chilling Aura           Frozen Storm            Crystallize             Ice Reflect             
witchdoctor_zombiecharger               Zombie Charger           WitchDoctor Zombie Bears            Wave of Zombies         Leperous Zombie         Undeath                 Explosive Beast         
wizard_stormarmor                       Storm Armor              Wizard      Thunder Storm           Scramble                Reactive Armor          Power of the Storm      Shocking Aspect         
demonhunter_spiketrap                   Spike Trap               DemonHunter Long Fuse               Echoing Blast           Sticky Trap             Scatter                 Lightning Rod           
wizard_diamondskin                      Diamond Skin             Wizard      Mirror Skin             Enduring Skin           Crystal Shell           Prism                   Diamond Shards          
demonhunter_entanglingshot              Entangling Shot          DemonHunter Heavy Burden            Chain Gang              Shock Collar            Justice is Served       Bounty Hunter           
wizard_magicweapon                      Magic Weapon             Wizard      Venom                   Electrify               Force Weapon            Conduit                 Blood Magic             
wizard_energytwister                    Energy Twister           Wizard      Gale Force              Raging Storm            Storm Chaser            Mistral Breeze          Wicked Wind             
demonhunter_fanofknives                 Fan of Knives            DemonHunter Hail of Knives          Assassin's Knives       Fan of Daggers          Crippling Razors        Retaliate               
demonhunter_bolashot                    Bola Shot                DemonHunter Volatile Explosives     Acid Strike             Thunder Ball            Bitter Pill             Imminent Doom           
demonhunter_multishot                   Multishot                DemonHunter Full Broadside          Burst Fire              Arsenal                 Fire at Will            Suppression Fire        
barbarian_frenzy                        Frenzy                   Barbarian   Maniac                  Sidearm                 Vanguard                Smite                   Triumph                 
barbarian_sprint                        Sprint                   Barbarian   Marathon                Rush                    Run Like the Wind       Forced March            Gangway                 
barbarian_battlerage                    Battle Rage              Barbarian   Marauder's Rage         Ferocity                Swords to Ploughshares  Into the Fray           Bloodshed               
barbarian_threateningshout              Threatening Shout        Barbarian   Demoralize              Intimidate              Grim Harvest            Falter                  Terrify                 
barbarian_bash                          Bash                     Barbarian   Onslaught               Punish                  Clobber                 Instigation             Pulverize               
barbarian_groundstomp                   Ground Stomp             Barbarian   Trembling Stomp         Wrenching Smash         Avalanche               Foot of the Mountain    Deafening Crash         
barbarian_ignorepain                    Ignore Pain              Barbarian   Contempt for Weakness   Iron Hide               Mob Rule                Bravado                 Ignorance is Bliss      
barbarian_wrathoftheberserker           Wrath of the Berserker   Barbarian   Insanity                Arreat's Wail           Striding Giant          Thrive on Chaos         Slaughter               
barbarian_hammeroftheancients           Hammer of the Ancients   Barbarian   Smash                   Rolling Thunder         The Devil's Anvil       Birthright              Thunderstrike           
barbarian_calloftheancients             Call of the Ancients     Barbarian   Korlic's Might          The Council Rises       Madawc's Madness        Duty to the Clan        Talic's Anger           
barbarian_cleave                        Cleave                   Barbarian   Broad Sweep             Gathering Storm         Scattering Blast        Reaping Swing           Rupture                 
barbarian_warcry                        War Cry                  Barbarian   Hardened Wrath          Veteran's Warning       Impunity                Charge!                 Invigorate              
witchdoctor_haunt                       Haunt                    WitchDoctor Consuming Spirit        Lingering Spirit        Grasping Spirit         Draining Spirit         Resentful Spirit        
demonhunter_grenades                    Grenades                 DemonHunter Gas Grenades            Cluster Grenades        Fire Bomb               Tinkerer                Stun Grenades           
barbarian_seismicslam                   Seismic Slam             Barbarian   Shattered Ground        Rumble                  Stagger                 Strength from Earth     Cracking Rift           
wizard_energyarmor                      Energy Armor             Wizard      Prismatic Armor         Energy Tap              Force Armor             Absorption              Pinpoint Barrier        
wizard_explosiveblast                   Explosive Blast          Wizard      Short Fuse              Obliterate              Time Bomb               Unleashed               Chain Reaction          
wizard_disintegrate                     Disintegrate             Wizard      Intensify               Convergence             Entropy                 Chaos Nexus             Volatility              
wizard_rayoffrost                       Ray of Frost             Wizard      Snow Blast              Sleet Storm             Numb                    Cold Blood              Black Ice               
barbarian_leap                          Leap                     Barbarian   Call of Arreat          Toppling Impact         Launch                  Iron Impact             Death from Above        
barbarian_weaponthrow                   Weapon Throw             Barbarian   Mighty Throw            Ricochet                Throwing Hammer         Dread Bomb              Stupefy                 
monk_mantraofconviction                 Mantra of Conviction     Monk        Overawe                 Submission              Dishearten              Reclamation             Intimidation            
monk_fistsofthunder                     Fists of Thunder         Monk        Thunderclap             Bounding Light          Static Charge           Quickening              Lightning Flash         
monk_deadlyreach                        Deadly Reach             Monk        Foresight               Piercing Trident        Scattered Blows         Strike from Beyond      Keen Eye                
monk_waveoflight                        Wave of Light            Monk        Wall of Light           Explosive Light         Pillar of the Ancients  Empowered Wave          Blinding Light          
monk_sweepingwind                       Sweeping Wind            Monk        Blade Storm             Fire Storm              Cyclone                 Inner Storm             Master of Wind          
monk_dashingstrike                      Dashing Strike           Monk        Soaring Skull           Way of the Falling Star Blinding Speed          Quicksilver             Flying Side Kick        
monk_serenity                           Serenity                 Monk        Peaceful Repose         Instant Karma           Ascension               Tranquility             Reap What Is Sown       
barbarian_whirlwind                     Whirlwind                Barbarian   Volcanic Eruption       Dust Devils             Hurricane               Wind Shear              Blood Funnel            
monk_cripplingwave                      Crippling Wave           Monk        Mangle                  Tsunami                 Concussion              Rising Tide             Breaking Wave           
monk_sevensidedstrike                   Seven-Sided Strike       Monk        Sudden Assault          Several-Sided Strike    Pandemonium             Sustained Attack        Fulminating Onslaught   
monk_wayofthehundredfists               Way of the Hundred Fists Monk        Fists of Fury           Hands of Lightning      Blazing Fists           Spirited Salvo          Windforce Flurry        
monk_innersanctuary                     Inner Sanctuary          Monk        Forbidden Palace        Consecration            Circle of Protection    Safe Haven              Sanctified Ground       
monk_explodingpalm                      Exploding Palm           Monk        Impending Doom          Creeping Demise         The Flesh is Weak       Strong Spirit           Essence Burn            
barbarian_furiouscharge                 Furious Charge           Barbarian   Battering Ram           Dreadnought             Bull Rush               Stamina                 Merciless Assault       
wizard_mirrorimage                      Mirror Image             Wizard      Mirror Mimics           Duplicates              Simulacrum              Extension of Will       Mocking Demise          
barbarian_earthquake                    Earthquake               Barbarian   Aftershocks             Giant's Stride          Chilling Earth          The Mountain's Call     Path of Fire            
wizard_familiar                         Familiar                 Wizard      Sparkflint              Cannoneer               Vigoron                 Arcanot                 Ancient Guardian        
witchdoctor_sacrifice                   Sacrifice                WitchDoctor Provoke the Pack        For the Master          Black Blood             Pride                   Next of Kin             
witchdoctor_summonzombiedog             Summon Zombie Dogs       WitchDoctor Burning Dogs            Life Link               Rabid Dogs              Final Gift              Leeching Beasts         
witchdoctor_poisondart                  Poison Dart              WitchDoctor Flaming Dart            Splinters               Numbing Dart            Spined Dart             Snake to the Face       
witchdoctor_firebats                    Firebats                 WitchDoctor Dire Bats               Hungry Bats             Plague Bats             Vampire Bats            Cloud of Bats           
witchdoctor_spiritwalk                  Spirit Walk              WitchDoctor Severance               Jaunt                   Umbral Shock            Honored Guest           Healing Journey         
witchdoctor_plagueoftoads               Plague of Toads          WitchDoctor Explosive Toads         Rain of Toads           Toad of Hugeness        Toad Affinity           Addling Toads           
witchdoctor_spiritbarrage               Spirit Barrage           WitchDoctor Phlebotomize            Well of Souls           Phantasm                The Spirit Is Willing   Manitou                 
barbarian_revenge                       Revenge                  Barbarian   Retribution             Provocation             Grudge                  Vengeance Is Mine       Best Served Cold        
demonhunter_vault                       Vault                    DemonHunter Trail of Cinders        Acrobatics              Action Shot             Tumble                  Rattling Roll           
monk_lashingtailkick                    Lashing Tail Kick        Monk        Vulture Claw Kick       Spinning Flame Kick     Hand of Ytar            Sweeping Armada         Scorpion Sting          
witchdoctor_bigbadvoodoo                Big Bad Voodoo           WitchDoctor Slam Dance              Jungle Drums            Ghost Trance            Rain Dance              Boogie Man              
monk_tempestrush                        Tempest Rush             Monk        Bluster                 Tailwind                Slipstream              Northern Breeze         Flurry                  
monk_mystically                         Mystic Ally              Monk        Fire Ally               Water Ally              Earth Ally              Air Ally                Eternal Ally            
demonhunter_preparation                 Preparation              DemonHunter Punishment              Invigoration            Focused Mind            Battle Scars            Backup Plan             
demonhunter_chakram                     Chakram                  DemonHunter Twin Chakrams           Boomerang               Serpentine              Razor Disk              Shuriken Cloud          
demonhunter_clusterarrow                Cluster Arrow            DemonHunter Loaded for Bear         Shooting Stars          Cluster Bombs           Maelstrom               Dazzling Arrow          
demonhunter_hungeringarrow              Hungering Arrow          DemonHunter Cinder Arrow            Shatter Shot            Devouring Arrow         Puncturing Arrow        Spray of Teeth          
demonhunter_caltrops                    Caltrops                 DemonHunter Jagged Spikes           Hooked Spines           Torturous Ground        Carved Stakes           Bait the Trap           
demonhunter_sentry                      Sentry                   DemonHunter Chain of Torment        Vigilant Watcher        Spitfire Turret         Aid Station             Guardian Turret         
demonhunter_smokescreen                 Smoke Screen             DemonHunter Choking Gas             Lingering Fog           Breathe Deep            Special Recipe          Displacement            
demonhunter_markedfordeath              Marked for Death         DemonHunter Grim Reaper             Contagion               Valley of Death         Mortal Enemy            Death Toll              
demonhunter_shadowpower                 Shadow Power             DemonHunter Night Bane              Shadow Glide            Gloom                   Well of Darkness        Blood Moon              
demonhunter_rainofvengeance             Rain of Vengeance        DemonHunter Beastly Bombs           Dark Cloud              Anathema                Flying Strike           Stampede                
demonhunter_rapidfire                   Rapid Fire               DemonHunter Bombardment             High Velocity           Fire Support            Withering Fire          Web Shot                
demonhunter_elementalarrow              Elemental Arrow          DemonHunter Frost Arrow             Ball Lightning          Screaming Skull         Nether Tentacles        Lightning Bolts         
demonhunter_impale                      Impale                   DemonHunter Overpenetration         Impact                  Chemical Burn           Awareness               Grievous Wounds         
demonhunter_companion                   Companion                DemonHunter Spider Companion        Boar Companion          Wolf Companion          Bat Companion           Ferret Companion        
demonhunter_strafe                      Strafe                   DemonHunter Demolition              Emberstrafe             Rocket Storm            Drifting Shadow         Stinging Steel          
demonhunter_evasivefire                 Evasive Fire             DemonHunter Hardened                Covering Fire           Parting Gift            Surge                   Displace                
wizard_arcanetorrent                    Arcane Torrent           Wizard      Disruption              Cascade                 Arcane Mines            Power Stone             Death Blossom           
witchdoctor_wallofzombies               Wall of Zombies          WitchDoctor Creepers                Barricade               Dead Rush               Unrelenting Grip        Pile On                 
wizard_archon                           Archon                   Wizard      Improved Archon         Slow Time               Teleport                Pure Power              Arcane Destruction      
wizard_archon_arcanestrike              Arcane Strike            Wizard                                                                                                                              
wizard_archon_disintegrationwave        Disintegration Wave      Wizard                                                                                                                              
wizard_archon_slowtime                  Slow Time                Wizard                                                                                                                              
monk_blindingflash                      Blinding Flash           Monk        Faith in the Light      Blinding Echo           Blinded and Confused    Self Reflection         Searing Light           
demonhunter_passive_vengeance           Vengeance                DemonHunter                                                                                                                         
demonhunter_passive_sharpshooter        Sharpshooter             DemonHunter                                                                                                                         
demonhunter_passive_culltheweak         Cull the Weak            DemonHunter                                                                                                                         
demonhunter_passive_perfectionist       Perfectionist            DemonHunter                                                                                                                         
demonhunter_passive_ballistics          Ballistics               DemonHunter                                                                                                                         
demonhunter_passive_hotpursuit          Hot Pursuit              DemonHunter                                                                                                                         
monk_passive_chantofresonance           Chant of Resonance       Monk                                                                                                                                
monk_passive_neardeathexperience        Near Death Experience    Monk                                                                                                                                
monk_passive_guidinglight               Guiding Light            Monk                                                                                                                                
barbarian_overpower                     Overpower                Barbarian   Killing Spree           Storm of Steel          Revel                   Momentum                Crushing Advance        
demonhunter_passive_steadyaim           Steady Aim               DemonHunter                                                                                                                         
wizard_archon_arcaneblast               Arcane Blast             Wizard                                                                                                                              
wizard_archon_teleport                  Teleport                 Wizard                                                                                                                              
wizard_teleport                         Teleport                 Wizard      Calamity                Fracture                Safe Passage            Reversal                Wormhole                
monk_mantraofevasion                    Mantra of Evasion        Monk        Backlash                Perseverance            Hard Target             Wind through the Reeds  Divine Protection       
barbarian_passive_boonofbulkathos       Boon of Bul-Kathos       Barbarian                                                                                                                           
barbarian_passive_noescape              No Escape                Barbarian                                                                                                                           
barbarian_passive_brawler               Brawler                  Barbarian                                                                                                                           
barbarian_passive_ruthless              Ruthless                 Barbarian                                                                                                                           
barbarian_passive_berserkerrage         Berserker Rage           Barbarian                                                                                                                           
barbarian_passive_poundofflesh          Pound of Flesh           Barbarian                                                                                                                           
barbarian_passive_bloodthirst           Bloodthirst              Barbarian                                                                                                                           
barbarian_passive_animosity             Animosity                Barbarian                                                                                                                           
barbarian_passive_unforgiving           Unforgiving              Barbarian                                                                                                                           
barbarian_passive_relentless            Relentless               Barbarian                                                                                                                           
barbarian_passive_superstition          Superstition             Barbarian                                                                                                                           
barbarian_passive_inspiringpresence     Inspiring Presence       Barbarian                                                                                                                           
barbarian_passive_juggernaut            Juggernaut               Barbarian                                                                                                                           
barbarian_passive_toughasnails          Tough as Nails           Barbarian                                                                                                                           
barbarian_passive_weaponsmaster         Weapons Master           Barbarian                                                                                                                           
wizard_passive_blur                     Blur                     Wizard                                                                                                                              
wizard_passive_glasscannon              Glass Cannon             Wizard                                                                                                                              
wizard_passive_astralpresence           Astral Presence          Wizard                                                                                                                              
wizard_passive_evocation                Evocation                Wizard                                                                                                                              
wizard_passive_unstableanomaly          Unstable Anomaly         Wizard                                                                                                                              
wizard_passive_temporalflux             Temporal Flux            Wizard                                                                                                                              
wizard_passive_powerhungry              Power Hungry             Wizard                                                                                                                              
wizard_passive_prodigy                  Prodigy                  Wizard                                                                                                                              
wizard_passive_galvanizingward          Galvanizing Ward         Wizard                                                                                                                              
wizard_passive_illusionist              Illusionist              Wizard                                                                                                                              
witchdoctor_passive_zombiehandler       Zombie Handler           WitchDoctor                                                                                                                         
witchdoctor_passive_rushofessence       Rush of Essence          WitchDoctor                                                                                                                         
witchdoctor_passive_bloodritual         Blood Ritual             WitchDoctor                                                                                                                         
witchdoctor_passive_spiritualattunement Spiritual Attunement     WitchDoctor                                                                                                                         
witchdoctor_passive_circleoflife        Circle of Life           WitchDoctor                                                                                                                         
witchdoctor_passive_gruesomefeast       Gruesome Feast           WitchDoctor                                                                                                                         
witchdoctor_passive_tribalrites         Tribal Rites             WitchDoctor                                                                                                                         
demonhunter_passive_customengineering   Custom Engineering       DemonHunter                                                                                                                         
witchdoctor_passive_piercetheveil       Pierce the Veil          WitchDoctor                                                                                                                         
witchdoctor_passive_fierceloyalty       Fierce Loyalty           WitchDoctor                                                                                                                         
demonhunter_passive_grenadier           Grenadier                DemonHunter                                                                                                                         
wizard_passive_arcanedynamo             Arcane Dynamo            Wizard                                                                                                                              
monk_passive_exaltedsoul                Exalted Soul             Monk                                                                                                                                
monk_passive_fleetfooted                Fleet Footed             Monk                                                                                                                                
witchdoctor_passive_visionquest         Vision Quest             WitchDoctor                                                                                                                         
monk_passive_beaconofytar               Beacon of Ytar           Monk                                                                                                                                
monk_passive_transcendence              Transcendence            Monk                                                                                                                                
monk_passive_sixthsense                 Sixth Sense              Monk                                                                                                                                
monk_passive_seizetheinitiative         Seize the Initiative     Monk                                                                                                                                
monk_passive_onewitheverything          One With Everything      Monk                                                                                                                                
demonhunter_passive_archery             Archery                  DemonHunter                                                                                                                         
monk_passive_theguardianspath           The Guardian's Path      Monk                                                                                                                                
monk_passive_pacifism                   Pacifism                 Monk                                                                                                                                
demonhunter_passive_brooding            Brooding                 DemonHunter                                                                                                                         
demonhunter_passive_thrillofthehunt     Thrill of the Hunt       DemonHunter                                                                                                                         
monk_passive_resolve                    Resolve                  Monk                                                                                                                                
barbarian_passive_nervesofsteel         Nerves Of Steel          Barbarian                                                                                                                           
witchdoctor_passive_badmedicine         Bad Medicine             WitchDoctor                                                                                                                         
witchdoctor_passive_junglefortitude     Jungle Fortitude         WitchDoctor                                                                                                                         
wizard_passive_conflagration            Conflagration            Wizard                                                                                                                              
wizard_passive_criticalmass             Critical Mass            Wizard                                                                                                                              
witchdoctor_passive_graveinjustice      Grave Injustice          WitchDoctor                                                                                                                         
demonhunter_passive_nightstalker        Night Stalker            DemonHunter                                                                                                                         
demonhunter_passive_tacticaladvantage   Tactical Advantage       DemonHunter                                                                                                                         
demonhunter_passive_numbingtraps        Numbing Traps            DemonHunter                                                                                                                         
monk_passive_combinationstrike          Combination Strike       Monk                                                                                                                                
witchdoctor_passive_spiritvessel        Spirit Vessel            WitchDoctor                                                                                                                         
witchdoctor_passive_fetishsycophants    Fetish Sycophants        WitchDoctor                                                                                                                         
monk_cyclonestrike                      Cyclone Strike           Monk        Sunburst                Implosion               Soothing Breeze         Eye of the Storm        Wall of Wind            
wizard_passive_coldblooded              Cold Blooded             Wizard                                                                                                                              
wizard_passive_paralysis                Paralysis                Wizard */
