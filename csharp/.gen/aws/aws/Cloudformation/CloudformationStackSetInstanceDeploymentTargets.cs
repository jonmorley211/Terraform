using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudformation
{
    [JsiiByValue(fqn: "aws.cloudformation.CloudformationStackSetInstanceDeploymentTargets")]
    public class CloudformationStackSetInstanceDeploymentTargets : aws.Cloudformation.ICloudformationStackSetInstanceDeploymentTargets
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack_set_instance#organizational_unit_ids CloudformationStackSetInstance#organizational_unit_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "organizationalUnitIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? OrganizationalUnitIds
        {
            get;
            set;
        }
    }
}
