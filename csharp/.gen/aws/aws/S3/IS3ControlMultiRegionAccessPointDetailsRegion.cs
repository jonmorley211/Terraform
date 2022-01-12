using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3ControlMultiRegionAccessPointDetailsRegion), fullyQualifiedName: "aws.s3.S3ControlMultiRegionAccessPointDetailsRegion")]
    public interface IS3ControlMultiRegionAccessPointDetailsRegion
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_multi_region_access_point#bucket S3ControlMultiRegionAccessPoint#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3ControlMultiRegionAccessPointDetailsRegion), fullyQualifiedName: "aws.s3.S3ControlMultiRegionAccessPointDetailsRegion")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3ControlMultiRegionAccessPointDetailsRegion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_multi_region_access_point#bucket S3ControlMultiRegionAccessPoint#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
