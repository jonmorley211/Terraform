using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Waf
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/waf_size_constraint_set aws_waf_size_constraint_set}.</summary>
    [JsiiClass(nativeType: typeof(aws.Waf.WafSizeConstraintSet), fullyQualifiedName: "aws.waf.WafSizeConstraintSet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.waf.WafSizeConstraintSetConfig\"}}]")]
    public class WafSizeConstraintSet : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/waf_size_constraint_set aws_waf_size_constraint_set} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public WafSizeConstraintSet(Constructs.Construct scope, string id, aws.Waf.IWafSizeConstraintSetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafSizeConstraintSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafSizeConstraintSet(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSizeConstraints")]
        public virtual void ResetSizeConstraints()
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
        = GetStaticProperty<string>(typeof(aws.Waf.WafSizeConstraintSet))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizeConstraintsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.waf.WafSizeConstraintSetSizeConstraints\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Waf.IWafSizeConstraintSetSizeConstraints[]? SizeConstraintsInput
        {
            get => GetInstanceProperty<aws.Waf.IWafSizeConstraintSetSizeConstraints[]?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sizeConstraints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.waf.WafSizeConstraintSetSizeConstraints\"},\"kind\":\"array\"}}")]
        public virtual aws.Waf.IWafSizeConstraintSetSizeConstraints[] SizeConstraints
        {
            get => GetInstanceProperty<aws.Waf.IWafSizeConstraintSetSizeConstraints[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
