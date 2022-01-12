using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDataAwsIdentitystoreGroupFilter), fullyQualifiedName: "aws.DataAwsIdentitystoreGroupFilter")]
    public interface IDataAwsIdentitystoreGroupFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/identitystore_group#attribute_path DataAwsIdentitystoreGroup#attribute_path}.</summary>
        [JsiiProperty(name: "attributePath", typeJson: "{\"primitive\":\"string\"}")]
        string AttributePath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/identitystore_group#attribute_value DataAwsIdentitystoreGroup#attribute_value}.</summary>
        [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}")]
        string AttributeValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsIdentitystoreGroupFilter), fullyQualifiedName: "aws.DataAwsIdentitystoreGroupFilter")]
        internal sealed class _Proxy : DeputyBase, aws.IDataAwsIdentitystoreGroupFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/identitystore_group#attribute_path DataAwsIdentitystoreGroup#attribute_path}.</summary>
            [JsiiProperty(name: "attributePath", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributePath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/identitystore_group#attribute_value DataAwsIdentitystoreGroup#attribute_value}.</summary>
            [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributeValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
