using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Securityhub
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight aws_securityhub_insight}.</summary>
    [JsiiClass(nativeType: typeof(aws.Securityhub.SecurityhubInsight), fullyQualifiedName: "aws.securityhub.SecurityhubInsight", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.securityhub.SecurityhubInsightConfig\"}}]")]
    public class SecurityhubInsight : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight aws_securityhub_insight} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public SecurityhubInsight(Constructs.Construct scope, string id, aws.Securityhub.ISecurityhubInsightConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SecurityhubInsight(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SecurityhubInsight(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFilters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.securityhub.SecurityhubInsightFilters\"}}]")]
        public virtual void PutFilters(aws.Securityhub.ISecurityhubInsightFilters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Securityhub.ISecurityhubInsightFilters)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Securityhub.SecurityhubInsight))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "filters", typeJson: "{\"fqn\":\"aws.securityhub.SecurityhubInsightFiltersOutputReference\"}")]
        public virtual aws.Securityhub.SecurityhubInsightFiltersOutputReference Filters
        {
            get => GetInstanceProperty<aws.Securityhub.SecurityhubInsightFiltersOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filtersInput", typeJson: "{\"fqn\":\"aws.securityhub.SecurityhubInsightFilters\"}", isOptional: true)]
        public virtual aws.Securityhub.ISecurityhubInsightFilters? FiltersInput
        {
            get => GetInstanceProperty<aws.Securityhub.ISecurityhubInsightFilters?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "groupByAttributeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GroupByAttributeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "groupByAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupByAttribute
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
