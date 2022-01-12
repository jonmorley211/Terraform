using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fms
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fms.FmsPolicySecurityServicePolicyData")]
    public class FmsPolicySecurityServicePolicyData : aws.Fms.IFmsPolicySecurityServicePolicyData
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fms_policy#type FmsPolicy#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fms_policy#managed_service_data FmsPolicy#managed_service_data}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "managedServiceData", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ManagedServiceData
        {
            get;
            set;
        }
    }
}
