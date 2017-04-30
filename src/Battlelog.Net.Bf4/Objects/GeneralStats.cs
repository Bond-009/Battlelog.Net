using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Battlelog.Bf4
{
    public class GeneralStats
    {
        [JsonProperty("quitPercentage")]
        [JsonRequired]
        public double QuitPercentage { get; set; }
        [JsonProperty("skill")]
        [JsonRequired]
        public int Skill { get; set; }
        [JsonProperty("assaultRifleAccuracy")]
        [JsonRequired]
        public double AssaultRifleAccuracy { get; set; }
        [JsonProperty("kills_assault")]
        [JsonRequired]
        public int AssaultKills { get; set; }
        [JsonProperty("sc_award")]
        [JsonRequired]
        public int AwardScore { get; set; }
        [JsonProperty("revives")]
        [JsonRequired]
        public int Revives { get; set; }
        [JsonProperty("gameModesScore")]
        [JsonRequired]
        public GameModesScore GameModesScore { get; set; }
        [JsonProperty("teamdeathmatch")]
        [JsonRequired]
        public int TeamDeathmatchScore { get; set; }
        [JsonProperty("kills")]
        [JsonRequired]
        public int Kills { get; set; }
        [JsonProperty("kdRatio")]
        [JsonRequired]
        public double KDRatio { get; set; }
        [JsonProperty("sc_bonus")]
        [JsonRequired]
        public int BonusScore { get; set; }
        [JsonProperty("assaultRifleKills")]
        [JsonRequired]
        public int AssaultRifleKills { get; set; }
        [JsonProperty("accuracy")]
        [JsonRequired]
        public double Accuracy { get; set; }
        [JsonProperty("sc_unlock")]
        [JsonRequired]
        public int UnlockScore { get; set; }
        // (conquestlarge) use conquest for ConquestScore
        [JsonRequired]
        public double LMGAccuracy { get; set; }
        [JsonProperty("resupplies")]
        [JsonRequired]
        public int Resupplies { get; set; }
        // (conquest_ladder) use conquest for ConquestScore
        [JsonProperty("repairs")]
        [JsonRequired]
        public int Repairs { get; set; }
        [JsonProperty("shotsFired")]
        [JsonRequired]
        public int ShotsFired { get; set; }
        [JsonRequired]
        public int LMGKills { get; set; }
        [JsonProperty("score")]
        [JsonRequired]
        public int Score { get; set; }
        [JsonProperty("kitTimesInPercentage")]
        [JsonRequired]
        public KitTimesInPercentage KitTimesInPercentage { get; set; }
        [JsonProperty("timePlayed")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        [JsonRequired]
        public TimeSpan TimePlayed { get; set; }
        [JsonProperty("rank")]
        [JsonRequired]
        public int Rank { get; set; }
        [JsonProperty("kills_engineer")]
        [JsonRequired]
        public int EngineerKills { get; set; }
        [JsonProperty("kitScores")]
        [JsonRequired]
        public KitScores KitScores { get; set; }
        [JsonProperty("suppressionAssists")]
        [JsonRequired]
        public int SuppressionAssists { get; set; }
        [JsonProperty("assaultRifleHeadshots")]
        [JsonRequired]
        public int AssaultRifleHeadshots { get; set; }
        [JsonProperty("killsPerMinute")]
        [JsonRequired]
        public double KillsPerMinute { get; set; }
        [JsonProperty("sniperRifleKills")]
        [JsonRequired]
        public int SniperRifleKills { get; set; }
        [JsonProperty("chainlink")]
        [JsonRequired]
        public int ChainlinkScore { get; set; }
        // TODO: vehicleScores
        [JsonProperty("numRounds")]
        [JsonRequired]
        public int Rounds { get; set; }
        [JsonProperty("killStreakBonus")]
        [JsonRequired]
        public int KillStreakBonus { get; set; }
        [JsonProperty("shotsHit")]
        [JsonRequired]
        public int ShotsHit { get; set; }
        // TODO: serviceStarGameModes
        [JsonProperty("numLosses")]
        [JsonRequired]
        public int Losses { get; set; }
        // (sqdm) use teamdeathmatch for TeamDeathmatchScore
        [JsonProperty("engineer")]
        [JsonRequired]
        public int EngineerScore { get; set; }
        // TODO: serviceStarsProgress
        [JsonProperty("conquest")]
        [JsonRequired]
        public int ConquestScore { get; set; }
        // (totalscore) use score for Score
        [JsonProperty("dogtagsTaken")]
        [JsonRequired]
        public int DogtagsTaken { get; set; }
        [JsonProperty("sc_vehicle")]
        [JsonRequired]
        public int VehicleScore { get; set; }
        [JsonProperty("sc_team")]
        [JsonRequired]
        public int TeamScore { get; set; }
        // (totalScore) use score for Score
        [JsonProperty("heals")]
        [JsonRequired]
        public int Heals { get; set; }
        [JsonProperty("obliteration")]
        [JsonRequired]
        public int ObliterationScore { get; set; }
        [JsonProperty("kitTimes")]
        [JsonRequired]
        public KitTimes KitTimes { get; set; }
        [JsonProperty("longestHeadshot")]
        [JsonRequired]
        public double LongestHeadshot { get; set; }
        [JsonProperty("support")]
        [JsonRequired]
        public int SupportScore { get; set; }
        [JsonProperty("mcomDefendKills")]
        [JsonRequired]
        public int McomDefendKills { get; set; }
        [JsonProperty("kills_support")]
        [JsonRequired]
        public int SupportKills { get; set; }
        [JsonProperty("flagDefend")]
        [JsonRequired]
        public int flagDefend { get; set; }
        [JsonRequired]
        public int LMGHeadshots { get; set; }
        [JsonProperty("domination")]
        [JsonRequired]
        public int DominationScore { get; set; }
        [JsonProperty("saviorKills")]
        [JsonRequired]
        public int SaviorKills { get; set; }
        [JsonProperty("nemesisStreak")]
        [JsonRequired]
        public int NemesisStreak { get; set; }
        [JsonProperty("numWins")]
        [JsonRequired]
        public int Wins { get; set; }
        [JsonProperty("killAssists")]
        [JsonRequired]
        public int KillAssists { get; set; }
        [JsonProperty("rush")]
        [JsonRequired]
        public int RushScore { get; set; }
        [JsonProperty("sniperRifleAccuracy")]
        [JsonRequired]
        public double SniperRifleAccuracy { get; set; }
        // TODO: antiGroundSoldier
        [JsonProperty("recon")]
        [JsonRequired]
        public int ReconScore { get; set; }
        [JsonProperty("nemesisKills")]
        [JsonRequired]
        public int NemesisKills { get; set; }
        [JsonProperty("sc_squad")]
        [JsonRequired]
        public int SquadScore { get; set; }
        [JsonProperty("vehicleDamage")]
        [JsonRequired]
        public int VehicleDamage { get; set; }
        [JsonProperty("serviceStars")]
        [JsonRequired]
        public ServiceStars ServiceStars { get; set; }
        [JsonProperty("deaths")]
        [JsonRequired]
        public int Deaths { get; set; }
        [JsonProperty("sc_general")]
        [JsonRequired]
        public int GeneralScore { get; set; }
        [JsonProperty("sniperRifleHeadshots")]
        [JsonRequired]
        public int SniperRifleHeadshots { get; set; }
        [JsonProperty("commander")]
        [JsonRequired]
        public int CommanderScore { get; set; }
        // (carrierassaultlarge) use carrierassault for CarrierAssaultScore
        [JsonProperty("headshots")]
        [JsonRequired]
        public int Headshots { get; set; }
        [JsonProperty("airsuperiority")]
        [JsonRequired]
        public int AirSuperiorityScore { get; set; }
        // (sqobliteration) use obliteration for ObliterationScore
        [JsonProperty("gunmaster")]
        [JsonRequired]
        public int GunMasterScore { get; set; }
        [JsonProperty("kills_recon")]
        [JsonRequired]
        public int ReconKills { get; set; }
        [JsonProperty("rankScore")]
        [JsonRequired]
        public int RankScore { get; set; }
        [JsonProperty("flagCaptures")]
        [JsonRequired]
        public int FlagCaptures { get; set; }
        [JsonProperty("vehiclesDestroyed")]
        [JsonRequired]
        public int VehiclesDestroyed { get; set; }
        [JsonProperty("scorePerMinute")]
        [JsonRequired]
        public int ScorePerMinute { get; set; }
        [JsonProperty("assault")]
        [JsonRequired]
        public int AssaultScore { get; set; }
        [JsonProperty("combatScore")]
        [JsonRequired]
        public int CombatScore { get; set; }
        [JsonProperty("avengerKills")]
        [JsonRequired]
        public int AvengerKills { get; set; }
        // TODO: antiAirSoldier
    }
}
