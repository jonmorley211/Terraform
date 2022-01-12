using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksight.QuicksightDataSourceParametersS3")]
    public class QuicksightDataSourceParametersS3 : aws.Quicksight.IQuicksightDataSourceParametersS3
    {
        /// <summary>manifest_file_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#manifest_file_location QuicksightDataSource#manifest_file_location}
        /// </remarks>
        [JsiiProperty(name: "manifestFileLocation", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersS3ManifestFileLocation\"}", isOverride: true)]
        public aws.Quicksight.IQuicksightDataSourceParametersS3ManifestFileLocation ManifestFileLocation
        {
            get;
            set;
        }
    }
}
