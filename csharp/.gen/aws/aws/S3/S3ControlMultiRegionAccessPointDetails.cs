using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3ControlMultiRegionAccessPointDetails")]
    public class S3ControlMultiRegionAccessPointDetails : aws.S3.IS3ControlMultiRegionAccessPointDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_multi_region_access_point#name S3ControlMultiRegionAccessPoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>region block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_multi_region_access_point#region S3ControlMultiRegionAccessPoint#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointDetailsRegion\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.S3.IS3ControlMultiRegionAccessPointDetailsRegion[] Region
        {
            get;
            set;
        }

        /// <summary>public_access_block block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_multi_region_access_point#public_access_block S3ControlMultiRegionAccessPoint#public_access_block}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "publicAccessBlock", typeJson: "{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointDetailsPublicAccessBlock\"}", isOptional: true, isOverride: true)]
        public aws.S3.IS3ControlMultiRegionAccessPointDetailsPublicAccessBlock? PublicAccessBlock
        {
            get;
            set;
        }
    }
}
