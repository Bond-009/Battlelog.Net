using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;

namespace Battlelog.BfH
{
    public class GeneralStats
    {
        [JsonPropertyName("quitPercentage")]
        public double QuitPercentage { get; set; }
        [JsonPropertyName("sc_heist")]
        public int HeistScore { get; set; }
        [JsonPropertyName("sc_hostage")]
        public int HostageScore { get; set; }
        [JsonPropertyName("sc_award")]
        public int AwardScore { get; set; }
        // TODO: cp_skill
        [JsonPropertyName("revives")]
        public int Revives { get; set; }
        // (teamdeathmatch) use sc_deathmatch for TeamDeathmatchScore
        [JsonPropertyName("kills")]
        public int Kills { get; set; }
        [JsonPropertyName("kdratio")]
        public double KDRatio { get; set; }
        [JsonPropertyName("sc_bonus")]
        public int BonusScore { get; set; }
        [JsonPropertyName("sc_hotwire")]
        public int HotwireScore { get; set; }
        [JsonPropertyName("sc_bloodmoney")]
        public int BloodMoneyScore { get; set; }
        [JsonPropertyName("accuracy")]
        public double Accuracy { get; set; }
        [JsonPropertyName("sc_bountyhunter")]
        public int BountyHunterScore { get; set; }
        // TODO: sc_unlock
        [JsonPropertyName("sc_turfwar")]
        public int ConquestScore { get; set; }
        // (sc_commander) use sc_hacker for HackerScore
        [JsonPropertyName("resupplies")]
        public int Resupplies { get; set; }
        [JsonPropertyName("repairs")]
        public int Repairs { get; set; }
        [JsonPropertyName("shotsFired")]
        public int ShotsFired { get; set; }
        [JsonPropertyName("score")]
        public int Score { get; set; }
        [JsonPropertyName("kitTimesInPercentage")]
        public KitValue<double> KitTimesInPercentage { get; set; }
        [JsonPropertyName("timePlayed")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        public TimeSpan TimePlayed { get; set; }
        [JsonPropertyName("rank")]
        public int Rank { get; set; }
        [JsonPropertyName("kitScores")]
        public KitValue<int> KitScores { get; set; }
        [JsonPropertyName("suppressionAssists")]
        public int SuppressionAssists { get; set; }
        [JsonPropertyName("sc_operator")]
        public int OperatorScore { get; set; }
        // TODO: vehicleScores
        [JsonPropertyName("numRounds")]
        public int Rounds { get; set; }
        // TODO: killStreakBonus
        // TODO: lastReset
        [JsonPropertyName("sc_deathmatch")]
        public int TeamDeathmatchScore { get; set; }
        [JsonPropertyName("shotsHit")]
        public int ShotsHit { get; set; }
        // TODO: serviceStarGameModes
        [JsonPropertyName("numLosses")]
        public int Losses { get; set; }
        [JsonPropertyName("dogtagsTaken")]
        public int DogtagsTaken { get; set; }
        // sqdm
        [JsonPropertyName("sc_vehicle")]
        public int VehicleScore { get; set; }
        // (operator) use sc_operator for OperatorScore
        [JsonPropertyName("sc_team")]
        public int TeamScore { get; set; }
        // (totalscore) use score for Score
        [JsonPropertyName("heals")]
        public int Heals { get; set; }
        [JsonPropertyName("kitTimes")]
        public KitTimes KitTimes { get; set; }
        [JsonPropertyName("sc_mechanic")]
        public int MechanicScore { get; set; }
        [JsonPropertyName("flagDefend")]
        public int FlagsDefended { get; set; }
        [JsonPropertyName("saviorKills")]
        public int SaviorKills { get; set; }
        [JsonPropertyName("nemesisStreak")]
        public int NemesisStreak { get; set; }
        [JsonPropertyName("numWins")]
        public int Wins { get; set; }
        [JsonPropertyName("killAssists")]
        public int KillAssists { get; set; }
        [JsonPropertyName("sc_enforcer")]
        public int EnforcerScore { get; set; }
        [JsonPropertyName("nemesisKills")]
        public int NemesisKills { get; set; }
        [JsonPropertyName("sc_squad")]
        public int SquadScore { get; set; }
        // (mechanic) use sc_mechanic for MechanicScore
        [JsonPropertyName("serviceStars")]
        public List<ServiceStar<Kit>> ServiceStars { get; set; }
        [JsonPropertyName("sc_hacker")]
        public int HackerScore { get; set; }
        [JsonPropertyName("deaths")]
        public int Deaths { get; set; }
        [JsonPropertyName("sc_professional")]
        public int ProfessionalScore { get; set; }
        [JsonPropertyName("sc_general")]
        public int GeneralScore { get; set; }
        // (commander) use sc_hacker for HackerScore
        // (enforcer) use sc_enforcer for EnforcerScore
        [JsonPropertyName("vehicleDamage")]
        public int VehicleDamage { get; set; }
        [JsonPropertyName("cashPerMinute")]
        public int CashPerMinute { get; set; }
        [JsonPropertyName("headshots")]
        public int Headshots { get; set; }
        [JsonPropertyName("sc_squadheist")]
        public int SquadHeistScore { get; set; }
        // sc_hit
        [JsonPropertyName("rankScore")]
        public int RankScore { get; set; }
        [JsonPropertyName("flagCaptures")]
        public int FlagCaptures { get; set; }
        [JsonPropertyName("vehiclesDestroyed")]
        public int VehiclesDestroyed { get; set; }
        [JsonPropertyName("scorePerMinute")]
        public int ScorePerMinute { get; set; } // Basically cashPerMinute but more accurate
        [JsonPropertyName("combatScore")]
        public int CombatScore { get; set; }
        [JsonPropertyName("avengerKills")]
        public int AvengerKills { get; set; }
        // (professional) use sc_professional for ProfessionalScore
    }
}
