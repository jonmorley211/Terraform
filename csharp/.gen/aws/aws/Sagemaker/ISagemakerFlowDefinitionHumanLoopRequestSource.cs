using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerFlowDefinitionHumanLoopRequestSource), fullyQualifiedName: "aws.sagemaker.SagemakerFlowDefinitionHumanLoopRequestSource")]
    public interface ISagemakerFlowDefinitionHumanLoopRequestSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#aws_managed_human_loop_request_source SagemakerFlowDefinition#aws_managed_human_loop_request_source}.</summary>
        [JsiiProperty(name: "awsManagedHumanLoopRequestSource", typeJson: "{\"primitive\":\"string\"}")]
        string AwsManagedHumanLoopRequestSource
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerFlowDefinitionHumanLoopRequestSource), fullyQualifiedName: "aws.sagemaker.SagemakerFlowDefinitionHumanLoopRequestSource")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopRequestSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#aws_managed_human_loop_request_source SagemakerFlowDefinition#aws_managed_human_loop_request_source}.</summary>
            [JsiiProperty(name: "awsManagedHumanLoopRequestSource", typeJson: "{\"primitive\":\"string\"}")]
            public string AwsManagedHumanLoopRequestSource
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
