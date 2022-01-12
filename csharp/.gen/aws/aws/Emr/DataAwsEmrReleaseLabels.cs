using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/emr_release_labels aws_emr_release_labels}.</summary>
    [JsiiClass(nativeType: typeof(aws.Emr.DataAwsEmrReleaseLabels), fullyQualifiedName: "aws.emr.DataAwsEmrReleaseLabels", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.emr.DataAwsEmrReleaseLabelsConfig\"}}]")]
    public class DataAwsEmrReleaseLabels : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/emr_release_labels aws_emr_release_labels} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsEmrReleaseLabels(Constructs.Construct scope, string id, aws.Emr.IDataAwsEmrReleaseLabelsConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEmrReleaseLabels(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEmrReleaseLabels(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFilters", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emr.DataAwsEmrReleaseLabelsFilters\"}}]")]
        public virtual void PutFilters(aws.Emr.IDataAwsEmrReleaseLabelsFilters @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Emr.IDataAwsEmrReleaseLabelsFilters)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilters")]
        public virtual void ResetFilters()
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
        = GetStaticProperty<string>(typeof(aws.Emr.DataAwsEmrReleaseLabels))!;

        [JsiiProperty(name: "filters", typeJson: "{\"fqn\":\"aws.emr.DataAwsEmrReleaseLabelsFiltersOutputReference\"}")]
        public virtual aws.Emr.DataAwsEmrReleaseLabelsFiltersOutputReference Filters
        {
            get => GetInstanceProperty<aws.Emr.DataAwsEmrReleaseLabelsFiltersOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "releaseLabels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ReleaseLabels
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filtersInput", typeJson: "{\"fqn\":\"aws.emr.DataAwsEmrReleaseLabelsFilters\"}", isOptional: true)]
        public virtual aws.Emr.IDataAwsEmrReleaseLabelsFilters? FiltersInput
        {
            get => GetInstanceProperty<aws.Emr.IDataAwsEmrReleaseLabelsFilters?>();
        }
    }
}
