using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudformation
{
    [JsiiInterface(nativeType: typeof(ICloudformationStackSetInstanceDeploymentTargets), fullyQualifiedName: "aws.cloudformation.CloudformationStackSetInstanceDeploymentTargets")]
    public interface ICloudformationStackSetInstanceDeploymentTargets
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack_set_instance#organizational_unit_ids CloudformationStackSetInstance#organizational_unit_ids}.</summary>
        [JsiiProperty(name: "organizationalUnitIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OrganizationalUnitIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudformationStackSetInstanceDeploymentTargets), fullyQualifiedName: "aws.cloudformation.CloudformationStackSetInstanceDeploymentTargets")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudformation.ICloudformationStackSetInstanceDeploymentTargets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudformation_stack_set_instance#organizational_unit_ids CloudformationStackSetInstance#organizational_unit_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "organizationalUnitIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OrganizationalUnitIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
