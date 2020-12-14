
using System;
using System.Text.Json.Serialization;

namespace Battlelog.Bf3
{
    public class OverviewStats
    {
        [JsonPropertyName("serviceStarsProgress")]
        public KitValue<double> ServiceStarsProgress { get; set; }

        [JsonPropertyName("vehiclesDestroyed")]
        public int VehiclesDestroyed { get; set; }

        [JsonPropertyName("rank")]
        public int Rank { get; set; }

        [JsonPropertyName("sc_vehicle")]
        public int VehicleScore { get; set; }

        [JsonPropertyName("sc_team")]
        public int TeamScore { get; set; }

        [JsonPropertyName("nemesisKills")]
        public int NemesisKills { get; set; }

        [JsonPropertyName("heals")]
        public int Heals { get; set; }

        [JsonPropertyName("longestHeadshot")]
        public double LongestHeadshot { get; set; }

        [JsonPropertyName("elo")]
        public double Elo { get; set; }

        [JsonPropertyName("sc_unlock")]
        public int UnlockScore { get; set; }

        [JsonPropertyName("mcomDefendKills")]
        public int McomDefendKills { get; set; }

        [JsonPropertyName("wlRatio")]
        public double WLRatio { get; set; }

        [JsonPropertyName("sc_award")]
        public double AwardScore { get; set; }

        [JsonPropertyName("vehiclesDestroyedAssists")]
        public int VehiclesDestroyedAssists { get; set; }

        [JsonPropertyName("revives")]
        public int Revives { get; set; }

        [JsonPropertyName("kills")]
        public int Kills { get; set; }

        [JsonPropertyName("sc_bonus")]
        public int BonusScore { get; set; }

        [JsonPropertyName("flagDefend")]
        public int FlagsDefended { get; set; }

        [JsonPropertyName("numWins")]
        public int Wins { get; set; }

        [JsonPropertyName("sc_objective")]
        public int ObjectiveScore { get; set; }

        // TODO: vehicleScores
        [JsonPropertyName("quitPercentage")]
        public double QuitPercentage { get; set; }

        [JsonPropertyName("sc_squad")]
        public int SquadScore { get; set; }

        [JsonPropertyName("flagCaptures")]
        public int FlagCaptures { get; set; }

        [JsonPropertyName("serviceStars")]
        public KitValue<double> ServiceStars { get; set; }

        [JsonPropertyName("dogtagsTaken")]
        public int DogtagsTaken { get; set; }

        [JsonPropertyName("deaths")]
        public int Deaths { get; set; }

        [JsonPropertyName("killAssists")]
        public int KillAssists { get; set; }

        [JsonPropertyName("resupplies")]
        public int Resupplies { get; set; }

        // (totalscore) use score fot Score
        [JsonPropertyName("repairs")]
        public int Repairs { get; set; }

        [JsonPropertyName("shotsFired")]
        public int ShotsFired { get; set; }

        [JsonPropertyName("avengerKills")]
        public int AvengerKills { get; set; }

        [JsonPropertyName("totalscore")]
        public int Score { get; set; }

        [JsonPropertyName("kitTimes")]
        public KitValue<TimeSpan> KitTimes { get; set; }

        [JsonPropertyName("kitTimesInPercentage")]
        public KitValue<double> KitTimesInPercentage { get; set; }

        // (rankScore) use score for Score
        [JsonPropertyName("accuracy")]
        public double Accuracy { get; set; }

        [JsonPropertyName("timePlayed")]
        public TimeSpan TimePlayed { get; set; }

        [JsonPropertyName("kitScores")]
        public KitValue<int> KitScores { get; set; }

        [JsonPropertyName("suppressionAssists")]
        public int SuppressionAssists { get; set; }

        [JsonPropertyName("scorePerMinute")]
        public int ScorePerMinute { get; set; }

        [JsonPropertyName("combatScore")]
        public int CombatScore { get; set; }

        [JsonPropertyName("numRounds")]
        public int Rounds { get; set; }

        [JsonPropertyName("shotsHit")]
        public int ShotsHit { get; set; }

        [JsonPropertyName("numLosses")]
        public int Losses { get; set; }

        [JsonPropertyName("sc_general")]
        public int GeneralScore { get; set; }

        [JsonPropertyName("saviorKills")]
        public int SaviorKills { get; set; }
    }
}
