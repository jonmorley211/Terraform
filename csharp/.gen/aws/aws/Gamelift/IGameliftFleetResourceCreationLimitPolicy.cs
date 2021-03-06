using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Gamelift
{
    [JsiiInterface(nativeType: typeof(IGameliftFleetResourceCreationLimitPolicy), fullyQualifiedName: "aws.gamelift.GameliftFleetResourceCreationLimitPolicy")]
    public interface IGameliftFleetResourceCreationLimitPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#new_game_sessions_per_creator GameliftFleet#new_game_sessions_per_creator}.</summary>
        [JsiiProperty(name: "newGameSessionsPerCreator", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NewGameSessionsPerCreator
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#policy_period_in_minutes GameliftFleet#policy_period_in_minutes}.</summary>
        [JsiiProperty(name: "policyPeriodInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PolicyPeriodInMinutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGameliftFleetResourceCreationLimitPolicy), fullyQualifiedName: "aws.gamelift.GameliftFleetResourceCreationLimitPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Gamelift.IGameliftFleetResourceCreationLimitPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#new_game_sessions_per_creator GameliftFleet#new_game_sessions_per_creator}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "newGameSessionsPerCreator", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NewGameSessionsPerCreator
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/gamelift_fleet#policy_period_in_minutes GameliftFleet#policy_period_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policyPeriodInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PolicyPeriodInMinutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
