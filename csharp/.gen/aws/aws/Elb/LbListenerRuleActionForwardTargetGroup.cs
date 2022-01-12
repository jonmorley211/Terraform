using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.LbListenerRuleActionForwardTargetGroup")]
    public class LbListenerRuleActionForwardTargetGroup : aws.Elb.ILbListenerRuleActionForwardTargetGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#arn LbListenerRule#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Arn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#weight LbListenerRule#weight}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? Weight
        {
            get;
            set;
        }
    }
}
