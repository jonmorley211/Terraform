using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Securityhub
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/securityhub_standards_control aws_securityhub_standards_control}.</summary>
    [JsiiClass(nativeType: typeof(aws.Securityhub.SecurityhubStandardsControl), fullyQualifiedName: "aws.securityhub.SecurityhubStandardsControl", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.securityhub.SecurityhubStandardsControlConfig\"}}]")]
    public class SecurityhubStandardsControl : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/securityhub_standards_control aws_securityhub_standards_control} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SecurityhubStandardsControl(Constructs.Construct scope, string id, aws.Securityhub.ISecurityhubStandardsControlConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SecurityhubStandardsControl(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SecurityhubStandardsControl(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDisabledReason")]
        public virtual void ResetDisabledReason()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Securityhub.SecurityhubStandardsControl))!;

        [JsiiProperty(name: "controlId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ControlId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "controlStatusUpdatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ControlStatusUpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "relatedRequirements", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RelatedRequirements
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "remediationUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemediationUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "severityRating", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SeverityRating
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Title
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "controlStatusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ControlStatusInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disabledReasonInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DisabledReasonInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "standardsControlArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StandardsControlArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "controlStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ControlStatus
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "disabledReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisabledReason
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "standardsControlArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StandardsControlArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
