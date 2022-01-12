using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Gamelift
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.gamelift.GameliftGameSessionQueuePlayerLatencyPolicy")]
    public class GameliftGameSessionQueuePlayerLatencyPolicy : aws.Gamelift.IGameliftGameSessionQueuePlayerLatencyPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_game_session_queue#maximum_individual_player_latency_milliseconds GameliftGameSessionQueue#maximum_individual_player_latency_milliseconds}.</summary>
        [JsiiProperty(name: "maximumIndividualPlayerLatencyMilliseconds", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MaximumIndividualPlayerLatencyMilliseconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_game_session_queue#policy_duration_seconds GameliftGameSessionQueue#policy_duration_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyDurationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? PolicyDurationSeconds
        {
            get;
            set;
        }
    }
}
