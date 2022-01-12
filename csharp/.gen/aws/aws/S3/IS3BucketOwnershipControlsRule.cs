using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketOwnershipControlsRule), fullyQualifiedName: "aws.s3.S3BucketOwnershipControlsRule")]
    public interface IS3BucketOwnershipControlsRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_ownership_controls#object_ownership S3BucketOwnershipControls#object_ownership}.</summary>
        [JsiiProperty(name: "objectOwnership", typeJson: "{\"primitive\":\"string\"}")]
        string ObjectOwnership
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketOwnershipControlsRule), fullyQualifiedName: "aws.s3.S3BucketOwnershipControlsRule")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketOwnershipControlsRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_ownership_controls#object_ownership S3BucketOwnershipControls#object_ownership}.</summary>
            [JsiiProperty(name: "objectOwnership", typeJson: "{\"primitive\":\"string\"}")]
            public string ObjectOwnership
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
