using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apprunner
{
    [JsiiInterface(nativeType: typeof(IApprunnerServiceEncryptionConfiguration), fullyQualifiedName: "aws.apprunner.ApprunnerServiceEncryptionConfiguration")]
    public interface IApprunnerServiceEncryptionConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#kms_key ApprunnerService#kms_key}.</summary>
        [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}")]
        string KmsKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApprunnerServiceEncryptionConfiguration), fullyQualifiedName: "aws.apprunner.ApprunnerServiceEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Apprunner.IApprunnerServiceEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/apprunner_service#kms_key ApprunnerService#kms_key}.</summary>
            [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}")]
            public string KmsKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
