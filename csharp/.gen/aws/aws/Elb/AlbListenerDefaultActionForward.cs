using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.AlbListenerDefaultActionForward")]
    public class AlbListenerDefaultActionForward : aws.Elb.IAlbListenerDefaultActionForward
    {
        /// <summary>target_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#target_group AlbListener#target_group}
        /// </remarks>
        [JsiiProperty(name: "targetGroup", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.AlbListenerDefaultActionForwardTargetGroup\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Elb.IAlbListenerDefaultActionForwardTargetGroup[] TargetGroup
        {
            get;
            set;
        }

        /// <summary>stickiness block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#stickiness AlbListener#stickiness}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stickiness", typeJson: "{\"fqn\":\"aws.elb.AlbListenerDefaultActionForwardStickiness\"}", isOptional: true, isOverride: true)]
        public aws.Elb.IAlbListenerDefaultActionForwardStickiness? Stickiness
        {
            get;
            set;
        }
    }
}
