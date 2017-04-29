using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Battlelog.BfH
{
    public class GeneralStats
    {
        [JsonProperty("quitPercentage")]
        [JsonRequired]
        public double QuitPercentage { get; set; }
        [JsonProperty("sc_heist")]
        [JsonRequired]
        public int HeistScore { get; set; }
        [JsonProperty("sc_hostage")]
        [JsonRequired]
        public int HostageScore { get; set; }
        [JsonProperty("sc_award")]
        [JsonRequired]
        public int AwardScore { get; set; }
        // TODO: cp_skill
        [JsonProperty("revives")]
        [JsonRequired]
        public int Revives { get; set; }
        // (teamdeathmatch) use sc_deathmatch for TeamDeathmatchScore
        [JsonProperty("kills")]
        [JsonRequired]
        public int Kills { get; set; }
        [JsonProperty("kdratio")]
        [JsonRequired]
        public double KDRatio { get; set; }
        [JsonProperty("sc_bonus")]
        [JsonRequired]
        public int BonusScore { get; set; }
        [JsonProperty("sc_hotwire")]
        [JsonRequired]
        public int HotwireScore { get; set; }
        [JsonProperty("sc_bloodmoney")]
        [JsonRequired]
        public int BloodMoneyScore { get; set; }
        [JsonProperty("accuracy")]
        [JsonRequired]
        public double Accuracy { get; set; }
        [JsonProperty("sc_bountyhunter")]
        [JsonRequired]
        public int BountyHunterScore { get; set; }
        // TODO: sc_unlock
        [JsonProperty("sc_turfwar")]
        [JsonRequired]
        public int ConquestScore { get; set; }
        // (sc_commander) use sc_hacker for HackerScore
        [JsonProperty("resupplies")]
        [JsonRequired]
        public int Resupplies { get; set; }
        [JsonProperty("repairs")]
        [JsonRequired]
        public int Repairs { get; set; }
        [JsonProperty("shotsFired")]
        [JsonRequired]
        public int ShotsFired { get; set; }
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
        [JsonProperty("kitScores")]
        [JsonRequired]
        public KitScores KitScores { get; set; }
        [JsonProperty("suppressionAssists")]
        [JsonRequired]
        public int SuppressionAssists { get; set; }
        [JsonProperty("sc_operator")]
        [JsonRequired]
        public int OperatorScore { get; set; }
        // TODO: vehicleScores
        [JsonProperty("numRounds")]
        [JsonRequired]
        public int Rounds { get; set; }
        // TODO: killStreakBonus
        // TODO: lastReset
        [JsonProperty("sc_deathmatch")]
        [JsonRequired]
        public int TeamDeathmatchScore { get; set; }
        [JsonProperty("shotsHit")]
        [JsonRequired]
        public int ShotsHit { get; set; }
        // TODO: serviceStarGameModes
        [JsonProperty("numLosses")]
        [JsonRequired]
        public int Losses { get; set; }
        [JsonProperty("dogtagsTaken")]
        [JsonRequired]
        public int DogtagsTaken { get; set; }
        // sqdm
        [JsonProperty("sc_vehicle")]
        [JsonRequired]
        public int VehicleScore { get; set; }
        // (operator) use sc_operator for OperatorScore
        [JsonProperty("sc_team")]
        [JsonRequired]
        public int TeamScore { get; set; }
        // (totalscore) use score for Score
        [JsonProperty("heals")]
        [JsonRequired]
        public int Heals { get; set; }
        [JsonProperty("kitTimes")]
        [JsonRequired]
        public KitTimes KitTimes { get; set; }
        [JsonProperty("sc_mechanic")]
        [JsonRequired]
        public int MechanicScore { get; set; }
        [JsonProperty("flagDefend")]
        [JsonRequired]
        public int FlagsDefended { get; set; }
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
        [JsonProperty("sc_enforcer")]
        [JsonRequired]
        public int EnforcerScore { get; set; }
        [JsonProperty("nemesisKills")]
        [JsonRequired]
        public int NemesisKills { get; set; }
        [JsonProperty("sc_squad")]
        [JsonRequired]
        public int SquadScore { get; set; }
        // (mechanic) use sc_mechanic for MechanicScore
        [JsonProperty("serviceStars")]
        [JsonRequired]
        public List<ServiceStar<Kit>> ServiceStars { get; set; }
        [JsonProperty("sc_hacker")]
        [JsonRequired]
        public int HackerScore { get; set; }
        [JsonProperty("deaths")]
        [JsonRequired]
        public int Deaths { get; set; }
        [JsonProperty("sc_professional")]
        [JsonRequired]
        public int ProfessionalScore { get; set; }
        [JsonProperty("sc_general")]
        [JsonRequired]
        public int GeneralScore { get; set; }
        // (commander) use sc_hacker for HackerScore
        // (enforcer) use sc_enforcer for EnforcerScore
        [JsonProperty("vehicleDamage")]
        [JsonRequired]
        public int VehicleDamage { get; set; }
        [JsonProperty("cashPerMinute")]
        [JsonRequired]
        public int CashPerMinute { get; set; }
        [JsonProperty("headshots")]
        [JsonRequired]
        public int Headshots { get; set; }
        [JsonProperty("sc_squadheist")]
        [JsonRequired]
        public int SquadHeistScore { get; set; }
        // sc_hit
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
        public int ScorePerMinute { get; set; } // Basically cashPerMinute but more accurate
        [JsonProperty("combatScore")]
        [JsonRequired]
        public int CombatScore { get; set; }
        [JsonProperty("avengerKills")]
        [JsonRequired]
        public int AvengerKills { get; set; }
        // (professional) use sc_professional for ProfessionalScore
    }
}
