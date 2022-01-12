using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice), fullyQualifiedName: "aws.sagemaker.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice")]
    public interface ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice
    {
        /// <summary>amount_in_usd block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#amount_in_usd SagemakerFlowDefinition#amount_in_usd}
        /// </remarks>
        [JsiiProperty(name: "amountInUsd", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceAmountInUsd\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceAmountInUsd? AmountInUsd
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice), fullyQualifiedName: "aws.sagemaker.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>amount_in_usd block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_flow_definition#amount_in_usd SagemakerFlowDefinition#amount_in_usd}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "amountInUsd", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceAmountInUsd\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceAmountInUsd? AmountInUsd
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceAmountInUsd?>();
            }
        }
    }
}
