using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Battlelog.Bf3
{
    public class OverviewStats
    {
        [JsonProperty("serviceStarsProgress")]
        [JsonRequired]
        public KitValue<double> ServiceStarsProgress { get; set; }
        [JsonProperty("vehiclesDestroyed")]
        [JsonRequired]
        public int VehiclesDestroyed { get; set; }
        [JsonProperty("rank")]
        [JsonRequired]
        public int Rank { get; set; }
        [JsonProperty("sc_vehicle")]
        [JsonRequired]
        public int VehicleScore { get; set; }
        [JsonProperty("sc_team")]
        [JsonRequired]
        public int TeamScore { get; set; }
        [JsonProperty("nemesisKills")]
        [JsonRequired]
        public int NemesisKills { get; set; }
        [JsonProperty("heals")]
        [JsonRequired]
        public int Heals { get; set; }
        [JsonProperty("longestHeadshot")]
        [JsonRequired]
        public double LongestHeadshot { get; set; }
        [JsonProperty("elo")]
        [JsonRequired]
        public double Elo { get; set; }
        [JsonProperty("sc_unlock")]
        [JsonRequired]
        public int UnlockScore { get; set; }
        [JsonProperty("mcomDefendKills")]
        [JsonRequired]
        public int McomDefendKills { get; set; }
        [JsonProperty("wlRatio")]
        [JsonRequired]
        public double WLRatio { get; set; }
        [JsonProperty("sc_award")]
        [JsonRequired]
        public double AwardScore { get; set; }
        [JsonProperty("vehiclesDestroyedAssists")]
        [JsonRequired]
        public int VehiclesDestroyedAssists { get; set; }
        [JsonProperty("revives")]
        [JsonRequired]
        public int Revives { get; set; }
        [JsonProperty("kills")]
        [JsonRequired]
        public int Kills { get; set; }
        [JsonProperty("sc_bonus")]
        [JsonRequired]
        public int BonusScore { get; set; }
        [JsonProperty("flagDefend")]
        [JsonRequired]
        public int FlagsDefended { get; set; }
        [JsonProperty("numWins")]
        [JsonRequired]
        public int Wins { get; set; }
        [JsonProperty("sc_objective")]
        [JsonRequired]
        public int ObjectiveScore { get; set; }
        // TODO: vehicleScores
        [JsonProperty("quitPercentage")]
        [JsonRequired]
        public double QuitPercentage { get; set; }
        [JsonProperty("sc_squad")]
        [JsonRequired]
        public int SquadScore { get; set; }
        [JsonProperty("flagCaptures")]
        [JsonRequired]
        public int FlagCaptures { get; set; }
        [JsonProperty("serviceStars")]
        [JsonRequired]
        public KitValue<double> ServiceStars { get; set; }
        [JsonProperty("dogtagsTaken")]
        [JsonRequired]
        public int DogtagsTaken { get; set; }
        [JsonProperty("deaths")]
        [JsonRequired]
        public int Deaths { get; set; }
        [JsonProperty("killAssists")]
        [JsonRequired]
        public int KillAssists { get; set; }
        [JsonProperty("resupplies")]
        [JsonRequired]
        public int Resupplies { get; set; }
        // (totalscore) use score fot Score
        [JsonProperty("repairs")]
        [JsonRequired]
        public int Repairs { get; set; }
        [JsonProperty("shotsFired")]
        [JsonRequired]
        public int ShotsFired { get; set; }
        [JsonProperty("avengerKills")]
        [JsonRequired]
        public int AvengerKills { get; set; }
        [JsonProperty("totalscore")]
        [JsonRequired]
        public int Score { get; set; }
        [JsonProperty("kitTimes")]
        [JsonRequired]
        public KitTimes KitTimes { get; set; }
        [JsonProperty("kitTimesInPercentage")]
        [JsonRequired]
        public KitValue<double> KitTimesInPercentage { get; set; }
        // (rankScore) use score for Score
        [JsonProperty("accuracy")]
        [JsonRequired]
        public double Accuracy { get; set; }
        [JsonProperty("timePlayed")]
        [JsonConverter(typeof(UnixTimeSpanConverter))]
        [JsonRequired]
        public TimeSpan TimePlayed { get; set; }
        [JsonProperty("kitScores")]
        [JsonRequired]
        public KitValue<int> KitScores { get; set; }
        [JsonProperty("suppressionAssists")]
        [JsonRequired]
        public int SuppressionAssists { get; set; }
        [JsonProperty("scorePerMinute")]
        [JsonRequired]
        public int ScorePerMinute { get; set; }
        [JsonProperty("combatScore")]
        [JsonRequired]
        public int CombatScore { get; set; }
        [JsonProperty("numRounds")]
        [JsonRequired]
        public int Rounds { get; set; }
        [JsonProperty("shotsHit")]
        [JsonRequired]
        public int ShotsHit { get; set; }
        [JsonProperty("numLosses")]
        [JsonRequired]
        public int Losses { get; set; }
        [JsonProperty("sc_general")]
        [JsonRequired]
        public int GeneralScore { get; set; }
        [JsonProperty("saviorKills")]
        [JsonRequired]
        public int SaviorKills { get; set; }
    }
}
