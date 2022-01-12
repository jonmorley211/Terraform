using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdafunction.LambdaFunctionEventInvokeConfigDestinationConfigOnFailure")]
    public class LambdaFunctionEventInvokeConfigDestinationConfigOnFailure : aws.Lambdafunction.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_function_event_invoke_config#destination LambdaFunctionEventInvokeConfig#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Destination
        {
            get;
            set;
        }
    }
}
