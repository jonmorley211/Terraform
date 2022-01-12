using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lambdafunction
{
    [JsiiInterface(nativeType: typeof(ILambdaEventSourceMappingSelfManagedEventSource), fullyQualifiedName: "aws.lambdafunction.LambdaEventSourceMappingSelfManagedEventSource")]
    public interface ILambdaEventSourceMappingSelfManagedEventSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#endpoints LambdaEventSourceMapping#endpoints}.</summary>
        [JsiiProperty(name: "endpoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        object Endpoints
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaEventSourceMappingSelfManagedEventSource), fullyQualifiedName: "aws.lambdafunction.LambdaEventSourceMappingSelfManagedEventSource")]
        internal sealed class _Proxy : DeputyBase, aws.Lambdafunction.ILambdaEventSourceMappingSelfManagedEventSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lambda_event_source_mapping#endpoints LambdaEventSourceMapping#endpoints}.</summary>
            [JsiiProperty(name: "endpoints", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
            public object Endpoints
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
