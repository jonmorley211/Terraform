using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.LbListenerDefaultActionForwardStickiness")]
    public class LbListenerDefaultActionForwardStickiness : aws.Elb.ILbListenerDefaultActionForwardStickiness
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#duration LbListener#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Duration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener#enabled LbListener#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? Enabled
        {
            get;
            set;
        }
    }
}
