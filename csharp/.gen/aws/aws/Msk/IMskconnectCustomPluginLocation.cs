using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiInterface(nativeType: typeof(IMskconnectCustomPluginLocation), fullyQualifiedName: "aws.msk.MskconnectCustomPluginLocation")]
    public interface IMskconnectCustomPluginLocation
    {
        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mskconnect_custom_plugin#s3 MskconnectCustomPlugin#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.msk.MskconnectCustomPluginLocationS3\"}")]
        aws.Msk.IMskconnectCustomPluginLocationS3 S3
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskconnectCustomPluginLocation), fullyQualifiedName: "aws.msk.MskconnectCustomPluginLocation")]
        internal sealed class _Proxy : DeputyBase, aws.Msk.IMskconnectCustomPluginLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/mskconnect_custom_plugin#s3 MskconnectCustomPlugin#s3}
            /// </remarks>
            [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.msk.MskconnectCustomPluginLocationS3\"}")]
            public aws.Msk.IMskconnectCustomPluginLocationS3 S3
            {
                get => GetInstanceProperty<aws.Msk.IMskconnectCustomPluginLocationS3>()!;
            }
        }
    }
}
