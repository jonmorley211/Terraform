using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appautoscaling
{
    [JsiiInterface(nativeType: typeof(IAppautoscalingScheduledActionScalableTargetAction), fullyQualifiedName: "aws.appautoscaling.AppautoscalingScheduledActionScalableTargetAction")]
    public interface IAppautoscalingScheduledActionScalableTargetAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#max_capacity AppautoscalingScheduledAction#max_capacity}.</summary>
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxCapacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#min_capacity AppautoscalingScheduledAction#min_capacity}.</summary>
        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinCapacity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppautoscalingScheduledActionScalableTargetAction), fullyQualifiedName: "aws.appautoscaling.AppautoscalingScheduledActionScalableTargetAction")]
        internal sealed class _Proxy : DeputyBase, aws.Appautoscaling.IAppautoscalingScheduledActionScalableTargetAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#max_capacity AppautoscalingScheduledAction#max_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxCapacity
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appautoscaling_scheduled_action#min_capacity AppautoscalingScheduledAction#min_capacity}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinCapacity
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
