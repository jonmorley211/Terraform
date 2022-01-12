using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fms
{
    [JsiiByValue(fqn: "aws.fms.FmsPolicyIncludeMap")]
    public class FmsPolicyIncludeMap : aws.Fms.IFmsPolicyIncludeMap
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fms_policy#account FmsPolicy#account}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "account", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Account
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fms_policy#orgunit FmsPolicy#orgunit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "orgunit", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Orgunit
        {
            get;
            set;
        }
    }
}
