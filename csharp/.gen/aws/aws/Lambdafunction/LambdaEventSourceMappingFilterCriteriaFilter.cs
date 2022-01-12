using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiByValue(fqn: "aws.lambdafunction.LambdaEventSourceMappingFilterCriteriaFilter")]
    public class LambdaEventSourceMappingFilterCriteriaFilter : aws.Lambdafunction.ILambdaEventSourceMappingFilterCriteriaFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#pattern LambdaEventSourceMapping#pattern}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pattern", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Pattern
        {
            get;
            set;
        }
    }
}
