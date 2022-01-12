using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    #pragma warning disable CS8618

    /// <summary>AWS Route 53.</summary>
    [JsiiByValue(fqn: "aws.route53.Route53RecoverycontrolconfigRoutingControlConfig")]
    public class Route53RecoverycontrolconfigRoutingControlConfig : aws.Route53.IRoute53RecoverycontrolconfigRoutingControlConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53recoverycontrolconfig_routing_control#cluster_arn Route53RecoverycontrolconfigRoutingControl#cluster_arn}.</summary>
        [JsiiProperty(name: "clusterArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ClusterArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53recoverycontrolconfig_routing_control#name Route53RecoverycontrolconfigRoutingControl#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53recoverycontrolconfig_routing_control#control_panel_arn Route53RecoverycontrolconfigRoutingControl#control_panel_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "controlPanelArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ControlPanelArn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
