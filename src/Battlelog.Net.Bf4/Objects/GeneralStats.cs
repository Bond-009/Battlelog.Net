using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;

namespace Battlelog.Bf4
{
    public class GeneralStats
    {
        [JsonPropertyName("quitPercentage")]
        public double QuitPercentage { get; set; }
        [JsonPropertyName("skill")]
        public int Skill { get; set; }
        [JsonPropertyName("assaultRifleAccuracy")]
        public double AssaultRifleAccuracy { get; set; }
        [JsonPropertyName("kills_assault")]
        public int AssaultKills { get; set; }
        [JsonPropertyName("sc_award")]
        public int AwardScore { get; set; }
        [JsonPropertyName("revives")]
        public int Revives { get; set; }
        [JsonPropertyName("gameModesScore")]
        public GameModesScore GameModesScore { get; set; }
        [JsonPropertyName("teamdeathmatch")]
        public int TeamDeathmatchScore { get; set; }
        [JsonPropertyName("kills")]
        public int Kills { get; set; }
        [JsonPropertyName("kdRatio")]
        public double KDRatio { get; set; }
        [JsonPropertyName("sc_bonus")]
        public int BonusScore { get; set; }
        [JsonPropertyName("assaultRifleKills")]
        public int AssaultRifleKills { get; set; }
        [JsonPropertyName("accuracy")]
        public double Accuracy { get; set; }
        [JsonPropertyName("sc_unlock")]
        public int UnlockScore { get; set; }
        // (conquestlarge) use conquest for ConquestScore
        public double LMGAccuracy { get; set; }
        [JsonPropertyName("resupplies")]
        public int Resupplies { get; set; }
        // (conquest_ladder) use conquest for ConquestScore
        [JsonPropertyName("repairs")]
        public int Repairs { get; set; }
        [JsonPropertyName("shotsFired")]
        public int ShotsFired { get; set; }
        public int LMGKills { get; set; }
        [JsonPropertyName("score")]
        public int Score { get; set; }
        [JsonPropertyName("kitTimesInPercentage")]
        public KitValue<double> KitTimesInPercentage { get; set; }
        [JsonPropertyName("timePlayed")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        public TimeSpan TimePlayed { get; set; }
        [JsonPropertyName("rank")]
        public int Rank { get; set; }
        [JsonPropertyName("kills_engineer")]
        public int EngineerKills { get; set; }
        [JsonPropertyName("kitScores")]
        public KitValue<int> KitScores { get; set; }
        [JsonPropertyName("suppressionAssists")]
        public int SuppressionAssists { get; set; }
        [JsonPropertyName("assaultRifleHeadshots")]
        public int AssaultRifleHeadshots { get; set; }
        [JsonPropertyName("killsPerMinute")]
        public double KillsPerMinute { get; set; }
        [JsonPropertyName("sniperRifleKills")]
        public int SniperRifleKills { get; set; }
        [JsonPropertyName("chainlink")]
        public int ChainlinkScore { get; set; }
        // TODO: vehicleScores
        [JsonPropertyName("numRounds")]
        public int Rounds { get; set; }
        [JsonPropertyName("killStreakBonus")]
        public int KillStreakBonus { get; set; }
        [JsonPropertyName("shotsHit")]
        public int ShotsHit { get; set; }
        [JsonPropertyName("ServiceStarsGameModes")]
        public List<ServiceStar> ServiceStarsGameModes { get; set; }
        [JsonPropertyName("numLosses")]
        public int Losses { get; set; }
        // (sqdm) use teamdeathmatch for TeamDeathmatchScore
        [JsonPropertyName("engineer")]
        public int EngineerScore { get; set; }
        [JsonPropertyName("serviceStarsProgress")]
        public KitValue<double> ServiceStarsProgress { get; set; }
        [JsonPropertyName("conquest")]
        public int ConquestScore { get; set; }
        // (totalscore) use score for Score
        [JsonPropertyName("dogtagsTaken")]
        public int DogtagsTaken { get; set; }
        [JsonPropertyName("sc_vehicle")]
        public int VehicleScore { get; set; }
        [JsonPropertyName("sc_team")]
        public int TeamScore { get; set; }
        // (totalScore) use score for Score
        [JsonPropertyName("heals")]
        public int Heals { get; set; }
        [JsonPropertyName("obliteration")]
        public int ObliterationScore { get; set; }
        [JsonPropertyName("kitTimes")]
        public KitTimes KitTimes { get; set; }
        [JsonPropertyName("longestHeadshot")]
        public double LongestHeadshot { get; set; }
        [JsonPropertyName("support")]
        public int SupportScore { get; set; }
        [JsonPropertyName("mcomDefendKills")]
        public int McomDefendKills { get; set; }
        [JsonPropertyName("kills_support")]
        public int SupportKills { get; set; }
        [JsonPropertyName("flagDefend")]
        public int flagDefend { get; set; }
        public int LMGHeadshots { get; set; }
        [JsonPropertyName("domination")]
        public int DominationScore { get; set; }
        [JsonPropertyName("saviorKills")]
        public int SaviorKills { get; set; }
        [JsonPropertyName("nemesisStreak")]
        public int NemesisStreak { get; set; }
        [JsonPropertyName("numWins")]
        public int Wins { get; set; }
        [JsonPropertyName("killAssists")]
        public int KillAssists { get; set; }
        [JsonPropertyName("rush")]
        public int RushScore { get; set; }
        [JsonPropertyName("sniperRifleAccuracy")]
        public double SniperRifleAccuracy { get; set; }
        // TODO: antiGroundSoldier
        [JsonPropertyName("recon")]
        public int ReconScore { get; set; }
        [JsonPropertyName("nemesisKills")]
        public int NemesisKills { get; set; }
        [JsonPropertyName("sc_squad")]
        public int SquadScore { get; set; }
        [JsonPropertyName("vehicleDamage")]
        public int VehicleDamage { get; set; }
        [JsonPropertyName("serviceStars")]
        public KitValue<int> ServiceStars { get; set; }
        [JsonPropertyName("deaths")]
        public int Deaths { get; set; }
        [JsonPropertyName("sc_general")]
        public int GeneralScore { get; set; }
        [JsonPropertyName("sniperRifleHeadshots")]
        public int SniperRifleHeadshots { get; set; }
        [JsonPropertyName("commander")]
        public int CommanderScore { get; set; }
        // (carrierassaultlarge) use carrierassault for CarrierAssaultScore
        [JsonPropertyName("headshots")]
        public int Headshots { get; set; }
        [JsonPropertyName("airsuperiority")]
        public int AirSuperiorityScore { get; set; }
        // (sqobliteration) use obliteration for ObliterationScore
        [JsonPropertyName("gunmaster")]
        public int GunMasterScore { get; set; }
        [JsonPropertyName("kills_recon")]
        public int ReconKills { get; set; }
        [JsonPropertyName("rankScore")]
        public int RankScore { get; set; }
        [JsonPropertyName("flagCaptures")]
        public int FlagCaptures { get; set; }
        [JsonPropertyName("vehiclesDestroyed")]
        public int VehiclesDestroyed { get; set; }
        [JsonPropertyName("scorePerMinute")]
        public int ScorePerMinute { get; set; }
        [JsonPropertyName("assault")]
        public int AssaultScore { get; set; }
        [JsonPropertyName("combatScore")]
        public int CombatScore { get; set; }
        [JsonPropertyName("avengerKills")]
        public int AvengerKills { get; set; }
        // TODO: antiAirSoldier
    }
}
