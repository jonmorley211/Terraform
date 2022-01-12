using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet aws_emr_instance_fleet}.</summary>
    [JsiiClass(nativeType: typeof(aws.Emr.EmrInstanceFleet), fullyQualifiedName: "aws.emr.EmrInstanceFleet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.emr.EmrInstanceFleetConfig\"}}]")]
    public class EmrInstanceFleet : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/emr_instance_fleet aws_emr_instance_fleet} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EmrInstanceFleet(Constructs.Construct scope, string id, aws.Emr.IEmrInstanceFleetConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrInstanceFleet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrInstanceFleet(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLaunchSpecifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emr.EmrInstanceFleetLaunchSpecifications\"}}]")]
        public virtual void PutLaunchSpecifications(aws.Emr.IEmrInstanceFleetLaunchSpecifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Emr.IEmrInstanceFleetLaunchSpecifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetInstanceTypeConfigs")]
        public virtual void ResetInstanceTypeConfigs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLaunchSpecifications")]
        public virtual void ResetLaunchSpecifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetOnDemandCapacity")]
        public virtual void ResetTargetOnDemandCapacity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetSpotCapacity")]
        public virtual void ResetTargetSpotCapacity()
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
        = GetStaticProperty<string>(typeof(aws.Emr.EmrInstanceFleet))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "launchSpecifications", typeJson: "{\"fqn\":\"aws.emr.EmrInstanceFleetLaunchSpecificationsOutputReference\"}")]
        public virtual aws.Emr.EmrInstanceFleetLaunchSpecificationsOutputReference LaunchSpecifications
        {
            get => GetInstanceProperty<aws.Emr.EmrInstanceFleetLaunchSpecificationsOutputReference>()!;
        }

        [JsiiProperty(name: "provisionedOnDemandCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProvisionedOnDemandCapacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "provisionedSpotCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ProvisionedSpotCapacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTypeConfigsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrInstanceFleetInstanceTypeConfigs\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Emr.IEmrInstanceFleetInstanceTypeConfigs[]? InstanceTypeConfigsInput
        {
            get => GetInstanceProperty<aws.Emr.IEmrInstanceFleetInstanceTypeConfigs[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "launchSpecificationsInput", typeJson: "{\"fqn\":\"aws.emr.EmrInstanceFleetLaunchSpecifications\"}", isOptional: true)]
        public virtual aws.Emr.IEmrInstanceFleetLaunchSpecifications? LaunchSpecificationsInput
        {
            get => GetInstanceProperty<aws.Emr.IEmrInstanceFleetLaunchSpecifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetOnDemandCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetOnDemandCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetSpotCapacityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetSpotCapacityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceTypeConfigs", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrInstanceFleetInstanceTypeConfigs\"},\"kind\":\"array\"}}")]
        public virtual aws.Emr.IEmrInstanceFleetInstanceTypeConfigs[] InstanceTypeConfigs
        {
            get => GetInstanceProperty<aws.Emr.IEmrInstanceFleetInstanceTypeConfigs[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetOnDemandCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetOnDemandCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetSpotCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetSpotCapacity
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
