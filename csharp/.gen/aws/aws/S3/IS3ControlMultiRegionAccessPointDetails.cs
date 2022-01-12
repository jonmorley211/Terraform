using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3ControlMultiRegionAccessPointDetails), fullyQualifiedName: "aws.s3.S3ControlMultiRegionAccessPointDetails")]
    public interface IS3ControlMultiRegionAccessPointDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_multi_region_access_point#name S3ControlMultiRegionAccessPoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>region block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_multi_region_access_point#region S3ControlMultiRegionAccessPoint#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointDetailsRegion\"},\"kind\":\"array\"}}")]
        aws.S3.IS3ControlMultiRegionAccessPointDetailsRegion[] Region
        {
            get;
        }

        /// <summary>public_access_block block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_multi_region_access_point#public_access_block S3ControlMultiRegionAccessPoint#public_access_block}
        /// </remarks>
        [JsiiProperty(name: "publicAccessBlock", typeJson: "{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointDetailsPublicAccessBlock\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3ControlMultiRegionAccessPointDetailsPublicAccessBlock? PublicAccessBlock
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3ControlMultiRegionAccessPointDetails), fullyQualifiedName: "aws.s3.S3ControlMultiRegionAccessPointDetails")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3ControlMultiRegionAccessPointDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_multi_region_access_point#name S3ControlMultiRegionAccessPoint#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>region block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_multi_region_access_point#region S3ControlMultiRegionAccessPoint#region}
            /// </remarks>
            [JsiiProperty(name: "region", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointDetailsRegion\"},\"kind\":\"array\"}}")]
            public aws.S3.IS3ControlMultiRegionAccessPointDetailsRegion[] Region
            {
                get => GetInstanceProperty<aws.S3.IS3ControlMultiRegionAccessPointDetailsRegion[]>()!;
            }

            /// <summary>public_access_block block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_multi_region_access_point#public_access_block S3ControlMultiRegionAccessPoint#public_access_block}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicAccessBlock", typeJson: "{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointDetailsPublicAccessBlock\"}", isOptional: true)]
            public aws.S3.IS3ControlMultiRegionAccessPointDetailsPublicAccessBlock? PublicAccessBlock
            {
                get => GetInstanceProperty<aws.S3.IS3ControlMultiRegionAccessPointDetailsPublicAccessBlock?>();
            }
        }
    }
}
