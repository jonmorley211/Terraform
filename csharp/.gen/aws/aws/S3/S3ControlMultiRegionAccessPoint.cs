using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/s3control_multi_region_access_point aws_s3control_multi_region_access_point}.</summary>
    [JsiiClass(nativeType: typeof(aws.S3.S3ControlMultiRegionAccessPoint), fullyQualifiedName: "aws.s3.S3ControlMultiRegionAccessPoint", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointConfig\"}}]")]
    public class S3ControlMultiRegionAccessPoint : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/s3control_multi_region_access_point aws_s3control_multi_region_access_point} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public S3ControlMultiRegionAccessPoint(Constructs.Construct scope, string id, aws.S3.IS3ControlMultiRegionAccessPointConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlMultiRegionAccessPoint(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlMultiRegionAccessPoint(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointDetails\"}}]")]
        public virtual void PutDetails(aws.S3.IS3ControlMultiRegionAccessPointDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3ControlMultiRegionAccessPointDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.S3.IS3ControlMultiRegionAccessPointTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3ControlMultiRegionAccessPointTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountId")]
        public virtual void ResetAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.S3.S3ControlMultiRegionAccessPoint))!;

        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Alias
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointDetailsOutputReference\"}")]
        public virtual aws.S3.S3ControlMultiRegionAccessPointDetailsOutputReference Details
        {
            get => GetInstanceProperty<aws.S3.S3ControlMultiRegionAccessPointDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointTimeoutsOutputReference\"}")]
        public virtual aws.S3.S3ControlMultiRegionAccessPointTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.S3.S3ControlMultiRegionAccessPointTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "detailsInput", typeJson: "{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointDetails\"}", isOptional: true)]
        public virtual aws.S3.IS3ControlMultiRegionAccessPointDetails? DetailsInput
        {
            get => GetInstanceProperty<aws.S3.IS3ControlMultiRegionAccessPointDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointTimeouts\"}", isOptional: true)]
        public virtual aws.S3.IS3ControlMultiRegionAccessPointTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.S3.IS3ControlMultiRegionAccessPointTimeouts?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
