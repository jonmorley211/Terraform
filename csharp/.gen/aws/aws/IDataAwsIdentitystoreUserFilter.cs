using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws
{
    [JsiiInterface(nativeType: typeof(IDataAwsIdentitystoreUserFilter), fullyQualifiedName: "aws.DataAwsIdentitystoreUserFilter")]
    public interface IDataAwsIdentitystoreUserFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/identitystore_user#attribute_path DataAwsIdentitystoreUser#attribute_path}.</summary>
        [JsiiProperty(name: "attributePath", typeJson: "{\"primitive\":\"string\"}")]
        string AttributePath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/identitystore_user#attribute_value DataAwsIdentitystoreUser#attribute_value}.</summary>
        [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}")]
        string AttributeValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsIdentitystoreUserFilter), fullyQualifiedName: "aws.DataAwsIdentitystoreUserFilter")]
        internal sealed class _Proxy : DeputyBase, aws.IDataAwsIdentitystoreUserFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/identitystore_user#attribute_path DataAwsIdentitystoreUser#attribute_path}.</summary>
            [JsiiProperty(name: "attributePath", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributePath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/identitystore_user#attribute_value DataAwsIdentitystoreUser#attribute_value}.</summary>
            [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributeValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
