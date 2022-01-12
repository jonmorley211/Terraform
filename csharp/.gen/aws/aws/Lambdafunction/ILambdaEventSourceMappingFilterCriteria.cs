using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiInterface(nativeType: typeof(ILambdaEventSourceMappingFilterCriteria), fullyQualifiedName: "aws.lambdafunction.LambdaEventSourceMappingFilterCriteria")]
    public interface ILambdaEventSourceMappingFilterCriteria
    {
        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#filter LambdaEventSourceMapping#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingFilterCriteriaFilter\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lambdafunction.ILambdaEventSourceMappingFilterCriteriaFilter[]? Filter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaEventSourceMappingFilterCriteria), fullyQualifiedName: "aws.lambdafunction.LambdaEventSourceMappingFilterCriteria")]
        internal sealed class _Proxy : DeputyBase, aws.Lambdafunction.ILambdaEventSourceMappingFilterCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#filter LambdaEventSourceMapping#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lambdafunction.LambdaEventSourceMappingFilterCriteriaFilter\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Lambdafunction.ILambdaEventSourceMappingFilterCriteriaFilter[]? Filter
            {
                get => GetInstanceProperty<aws.Lambdafunction.ILambdaEventSourceMappingFilterCriteriaFilter[]?>();
            }
        }
    }
}
