using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiByValue(fqn: "aws.lambdafunction.LambdaEventSourceMappingFilterCriteria")]
    public class LambdaEventSourceMappingFilterCriteria : aws.Lambdafunction.ILambdaEventSourceMappingFilterCriteria
    {
        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#filter LambdaEventSourceMapping#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingFilterCriteriaFilter\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Lambdafunction.ILambdaEventSourceMappingFilterCriteriaFilter[]? Filter
        {
            get;
            set;
        }
    }
}
