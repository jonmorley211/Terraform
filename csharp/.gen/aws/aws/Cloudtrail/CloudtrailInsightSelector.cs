using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudtrail
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudtrail.CloudtrailInsightSelector")]
    public class CloudtrailInsightSelector : aws.Cloudtrail.ICloudtrailInsightSelector
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudtrail#insight_type Cloudtrail#insight_type}.</summary>
        [JsiiProperty(name: "insightType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string InsightType
        {
            get;
            set;
        }
    }
}
