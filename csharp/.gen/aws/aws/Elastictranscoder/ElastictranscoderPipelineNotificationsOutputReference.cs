using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elastictranscoder
{
    [JsiiClass(nativeType: typeof(aws.Elastictranscoder.ElastictranscoderPipelineNotificationsOutputReference), fullyQualifiedName: "aws.elastictranscoder.ElastictranscoderPipelineNotificationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ElastictranscoderPipelineNotificationsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public ElastictranscoderPipelineNotificationsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPipelineNotificationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElastictranscoderPipelineNotificationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCompleted")]
        public virtual void ResetCompleted()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetError")]
        public virtual void ResetError()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProgressing")]
        public virtual void ResetProgressing()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWarning")]
        public virtual void ResetWarning()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "completedInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompletedInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ErrorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "progressingInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProgressingInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "warningInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WarningInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "completed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Completed
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "error", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Error
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "progressing", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Progressing
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "warning", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Warning
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elastictranscoder.ElastictranscoderPipelineNotifications\"}", isOptional: true)]
        public virtual aws.Elastictranscoder.IElastictranscoderPipelineNotifications? InternalValue
        {
            get => GetInstanceProperty<aws.Elastictranscoder.IElastictranscoderPipelineNotifications?>();
            set => SetInstanceProperty(value);
        }
    }
}
