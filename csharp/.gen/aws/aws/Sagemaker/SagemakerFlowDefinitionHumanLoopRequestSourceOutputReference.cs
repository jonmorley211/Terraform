using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerFlowDefinitionHumanLoopRequestSourceOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerFlowDefinitionHumanLoopRequestSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerFlowDefinitionHumanLoopRequestSourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerFlowDefinitionHumanLoopRequestSourceOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFlowDefinitionHumanLoopRequestSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFlowDefinitionHumanLoopRequestSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsManagedHumanLoopRequestSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AwsManagedHumanLoopRequestSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "awsManagedHumanLoopRequestSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsManagedHumanLoopRequestSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopRequestSource\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopRequestSource? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopRequestSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
