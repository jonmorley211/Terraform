using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    [JsiiByValue(fqn: "aws.quicksight.QuicksightDataSourceParametersAthena")]
    public class QuicksightDataSourceParametersAthena : aws.Quicksight.IQuicksightDataSourceParametersAthena
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/quicksight_data_source#work_group QuicksightDataSource#work_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "workGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? WorkGroup
        {
            get;
            set;
        }
    }
}
