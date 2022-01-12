using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Guardduty
{
    [JsiiClass(nativeType: typeof(aws.Guardduty.GuarddutyDetectorDatasourcesOutputReference), fullyQualifiedName: "aws.guardduty.GuarddutyDetectorDatasourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class GuarddutyDetectorDatasourcesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public GuarddutyDetectorDatasourcesOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GuarddutyDetectorDatasourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GuarddutyDetectorDatasourcesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3Logs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.guardduty.GuarddutyDetectorDatasourcesS3Logs\"}}]")]
        public virtual void PutS3Logs(aws.Guardduty.IGuarddutyDetectorDatasourcesS3Logs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Guardduty.IGuarddutyDetectorDatasourcesS3Logs)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetS3Logs")]
        public virtual void ResetS3Logs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.guardduty.GuarddutyDetectorDatasourcesS3LogsOutputReference\"}")]
        public virtual aws.Guardduty.GuarddutyDetectorDatasourcesS3LogsOutputReference S3Logs
        {
            get => GetInstanceProperty<aws.Guardduty.GuarddutyDetectorDatasourcesS3LogsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3LogsInput", typeJson: "{\"fqn\":\"aws.guardduty.GuarddutyDetectorDatasourcesS3Logs\"}", isOptional: true)]
        public virtual aws.Guardduty.IGuarddutyDetectorDatasourcesS3Logs? S3LogsInput
        {
            get => GetInstanceProperty<aws.Guardduty.IGuarddutyDetectorDatasourcesS3Logs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.guardduty.GuarddutyDetectorDatasources\"}", isOptional: true)]
        public virtual aws.Guardduty.IGuarddutyDetectorDatasources? InternalValue
        {
            get => GetInstanceProperty<aws.Guardduty.IGuarddutyDetectorDatasources?>();
            set => SetInstanceProperty(value);
        }
    }
}
