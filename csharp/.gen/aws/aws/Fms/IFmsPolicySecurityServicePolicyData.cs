using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fms
{
    [JsiiInterface(nativeType: typeof(IFmsPolicySecurityServicePolicyData), fullyQualifiedName: "aws.fms.FmsPolicySecurityServicePolicyData")]
    public interface IFmsPolicySecurityServicePolicyData
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fms_policy#type FmsPolicy#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fms_policy#managed_service_data FmsPolicy#managed_service_data}.</summary>
        [JsiiProperty(name: "managedServiceData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedServiceData
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFmsPolicySecurityServicePolicyData), fullyQualifiedName: "aws.fms.FmsPolicySecurityServicePolicyData")]
        internal sealed class _Proxy : DeputyBase, aws.Fms.IFmsPolicySecurityServicePolicyData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fms_policy#type FmsPolicy#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fms_policy#managed_service_data FmsPolicy#managed_service_data}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "managedServiceData", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedServiceData
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
