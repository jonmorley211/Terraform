using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ssm
{
    [JsiiClass(nativeType: typeof(aws.Ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersOutputReference), fullyQualifiedName: "aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDocumentVersion")]
        public virtual void ResetDocumentVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameter")]
        public virtual void ResetParameter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "documentVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DocumentVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parameterInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersParameter\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersParameter[]? ParameterInput
        {
            get => GetInstanceProperty<aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersParameter[]?>();
        }

        [JsiiProperty(name: "documentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DocumentVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parameter", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersParameter\"},\"kind\":\"array\"}}")]
        public virtual aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersParameter[] Parameter
        {
            get => GetInstanceProperty<aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParametersParameter[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ssm.SsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters\"}", isOptional: true)]
        public virtual aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters? InternalValue
        {
            get => GetInstanceProperty<aws.Ssm.ISsmMaintenanceWindowTaskTaskInvocationParametersAutomationParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
