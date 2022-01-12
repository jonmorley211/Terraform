using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSourceParametersS3), fullyQualifiedName: "aws.quicksight.QuicksightDataSourceParametersS3")]
    public interface IQuicksightDataSourceParametersS3
    {
        /// <summary>manifest_file_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#manifest_file_location QuicksightDataSource#manifest_file_location}
        /// </remarks>
        [JsiiProperty(name: "manifestFileLocation", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersS3ManifestFileLocation\"}")]
        aws.Quicksight.IQuicksightDataSourceParametersS3ManifestFileLocation ManifestFileLocation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSourceParametersS3), fullyQualifiedName: "aws.quicksight.QuicksightDataSourceParametersS3")]
        internal sealed class _Proxy : DeputyBase, aws.Quicksight.IQuicksightDataSourceParametersS3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>manifest_file_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#manifest_file_location QuicksightDataSource#manifest_file_location}
            /// </remarks>
            [JsiiProperty(name: "manifestFileLocation", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersS3ManifestFileLocation\"}")]
            public aws.Quicksight.IQuicksightDataSourceParametersS3ManifestFileLocation ManifestFileLocation
            {
                get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersS3ManifestFileLocation>()!;
            }
        }
    }
}
