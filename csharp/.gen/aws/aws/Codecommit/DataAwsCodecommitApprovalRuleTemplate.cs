using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Codecommit
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/codecommit_approval_rule_template aws_codecommit_approval_rule_template}.</summary>
    [JsiiClass(nativeType: typeof(aws.Codecommit.DataAwsCodecommitApprovalRuleTemplate), fullyQualifiedName: "aws.codecommit.DataAwsCodecommitApprovalRuleTemplate", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.codecommit.DataAwsCodecommitApprovalRuleTemplateConfig\"}}]")]
    public class DataAwsCodecommitApprovalRuleTemplate : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/codecommit_approval_rule_template aws_codecommit_approval_rule_template} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsCodecommitApprovalRuleTemplate(Constructs.Construct scope, string id, aws.Codecommit.IDataAwsCodecommitApprovalRuleTemplateConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCodecommitApprovalRuleTemplate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCodecommitApprovalRuleTemplate(DeputyProps props): base(props)
        {
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
        = GetStaticProperty<string>(typeof(aws.Codecommit.DataAwsCodecommitApprovalRuleTemplate))!;

        [JsiiProperty(name: "approvalRuleTemplateId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApprovalRuleTemplateId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Content
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "creationDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationDate
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

        [JsiiProperty(name: "lastModifiedDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModifiedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastModifiedUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModifiedUser
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ruleContentSha256", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuleContentSha256
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
