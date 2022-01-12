using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.DataAwsIdentitystoreUserFilter")]
    public class DataAwsIdentitystoreUserFilter : aws.IDataAwsIdentitystoreUserFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/identitystore_user#attribute_path DataAwsIdentitystoreUser#attribute_path}.</summary>
        [JsiiProperty(name: "attributePath", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AttributePath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/identitystore_user#attribute_value DataAwsIdentitystoreUser#attribute_value}.</summary>
        [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AttributeValue
        {
            get;
            set;
        }
    }
}
