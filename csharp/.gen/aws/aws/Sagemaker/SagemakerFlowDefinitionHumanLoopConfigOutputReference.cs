using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerFlowDefinitionHumanLoopConfigOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerFlowDefinitionHumanLoopConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerFlowDefinitionHumanLoopConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerFlowDefinitionHumanLoopConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFlowDefinitionHumanLoopConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFlowDefinitionHumanLoopConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPublicWorkforceTaskPrice", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice\"}}]")]
        public virtual void PutPublicWorkforceTaskPrice(aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPublicWorkforceTaskPrice")]
        public virtual void ResetPublicWorkforceTaskPrice()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskAvailabilityLifetimeInSeconds")]
        public virtual void ResetTaskAvailabilityLifetimeInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskKeywords")]
        public virtual void ResetTaskKeywords()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTaskTimeLimitInSeconds")]
        public virtual void ResetTaskTimeLimitInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "publicWorkforceTaskPrice", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceOutputReference PublicWorkforceTaskPrice
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPriceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "humanTaskUiArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HumanTaskUiArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicWorkforceTaskPriceInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice? PublicWorkforceTaskPriceInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfigPublicWorkforceTaskPrice?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskAvailabilityLifetimeInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TaskAvailabilityLifetimeInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TaskCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskDescriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskDescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskKeywordsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TaskKeywordsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskTimeLimitInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TaskTimeLimitInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "taskTitleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskTitleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "workteamArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WorkteamArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "humanTaskUiArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HumanTaskUiArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskAvailabilityLifetimeInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TaskAvailabilityLifetimeInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TaskCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskDescription
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskKeywords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TaskKeywords
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskTimeLimitInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TaskTimeLimitInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "taskTitle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskTitle
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "workteamArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkteamArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
