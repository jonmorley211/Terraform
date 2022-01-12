using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Guardduty
{
    [JsiiClass(nativeType: typeof(aws.Guardduty.GuarddutyOrganizationConfigurationDatasourcesOutputReference), fullyQualifiedName: "aws.guardduty.GuarddutyOrganizationConfigurationDatasourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class GuarddutyOrganizationConfigurationDatasourcesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public GuarddutyOrganizationConfigurationDatasourcesOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GuarddutyOrganizationConfigurationDatasourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GuarddutyOrganizationConfigurationDatasourcesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3Logs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.guardduty.GuarddutyOrganizationConfigurationDatasourcesS3Logs\"}}]")]
        public virtual void PutS3Logs(aws.Guardduty.IGuarddutyOrganizationConfigurationDatasourcesS3Logs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Guardduty.IGuarddutyOrganizationConfigurationDatasourcesS3Logs)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetS3Logs")]
        public virtual void ResetS3Logs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.guardduty.GuarddutyOrganizationConfigurationDatasourcesS3LogsOutputReference\"}")]
        public virtual aws.Guardduty.GuarddutyOrganizationConfigurationDatasourcesS3LogsOutputReference S3Logs
        {
            get => GetInstanceProperty<aws.Guardduty.GuarddutyOrganizationConfigurationDatasourcesS3LogsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3LogsInput", typeJson: "{\"fqn\":\"aws.guardduty.GuarddutyOrganizationConfigurationDatasourcesS3Logs\"}", isOptional: true)]
        public virtual aws.Guardduty.IGuarddutyOrganizationConfigurationDatasourcesS3Logs? S3LogsInput
        {
            get => GetInstanceProperty<aws.Guardduty.IGuarddutyOrganizationConfigurationDatasourcesS3Logs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.guardduty.GuarddutyOrganizationConfigurationDatasources\"}", isOptional: true)]
        public virtual aws.Guardduty.IGuarddutyOrganizationConfigurationDatasources? InternalValue
        {
            get => GetInstanceProperty<aws.Guardduty.IGuarddutyOrganizationConfigurationDatasources?>();
            set => SetInstanceProperty(value);
        }
    }
}
