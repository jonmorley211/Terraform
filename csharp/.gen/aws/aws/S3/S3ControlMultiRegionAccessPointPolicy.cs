using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/s3control_multi_region_access_point_policy aws_s3control_multi_region_access_point_policy}.</summary>
    [JsiiClass(nativeType: typeof(aws.S3.S3ControlMultiRegionAccessPointPolicy), fullyQualifiedName: "aws.s3.S3ControlMultiRegionAccessPointPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointPolicyConfig\"}}]")]
    public class S3ControlMultiRegionAccessPointPolicy : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/s3control_multi_region_access_point_policy aws_s3control_multi_region_access_point_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public S3ControlMultiRegionAccessPointPolicy(Constructs.Construct scope, string id, aws.S3.IS3ControlMultiRegionAccessPointPolicyConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlMultiRegionAccessPointPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlMultiRegionAccessPointPolicy(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointPolicyDetails\"}}]")]
        public virtual void PutDetails(aws.S3.IS3ControlMultiRegionAccessPointPolicyDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3ControlMultiRegionAccessPointPolicyDetails)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointPolicyTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.S3.IS3ControlMultiRegionAccessPointPolicyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3ControlMultiRegionAccessPointPolicyTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.S3.S3ControlMultiRegionAccessPointPolicy))!;

        [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointPolicyDetailsOutputReference\"}")]
        public virtual aws.S3.S3ControlMultiRegionAccessPointPolicyDetailsOutputReference Details
        {
            get => GetInstanceProperty<aws.S3.S3ControlMultiRegionAccessPointPolicyDetailsOutputReference>()!;
        }

        [JsiiProperty(name: "established", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Established
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "proposed", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Proposed
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointPolicyTimeoutsOutputReference\"}")]
        public virtual aws.S3.S3ControlMultiRegionAccessPointPolicyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.S3.S3ControlMultiRegionAccessPointPolicyTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "detailsInput", typeJson: "{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointPolicyDetails\"}", isOptional: true)]
        public virtual aws.S3.IS3ControlMultiRegionAccessPointPolicyDetails? DetailsInput
        {
            get => GetInstanceProperty<aws.S3.IS3ControlMultiRegionAccessPointPolicyDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointPolicyTimeouts\"}", isOptional: true)]
        public virtual aws.S3.IS3ControlMultiRegionAccessPointPolicyTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.S3.IS3ControlMultiRegionAccessPointPolicyTimeouts?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
