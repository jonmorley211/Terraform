using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster aws_emr_cluster}.</summary>
    [JsiiClass(nativeType: typeof(aws.Emr.EmrCluster), fullyQualifiedName: "aws.emr.EmrCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.emr.EmrClusterConfig\"}}]")]
    public class EmrCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster aws_emr_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EmrCluster(Constructs.Construct scope, string id, aws.Emr.IEmrClusterConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrCluster(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutoTerminationPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emr.EmrClusterAutoTerminationPolicy\"}}]")]
        public virtual void PutAutoTerminationPolicy(aws.Emr.IEmrClusterAutoTerminationPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Emr.IEmrClusterAutoTerminationPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCoreInstanceFleet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleet\"}}]")]
        public virtual void PutCoreInstanceFleet(aws.Emr.IEmrClusterCoreInstanceFleet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Emr.IEmrClusterCoreInstanceFleet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCoreInstanceGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emr.EmrClusterCoreInstanceGroup\"}}]")]
        public virtual void PutCoreInstanceGroup(aws.Emr.IEmrClusterCoreInstanceGroup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Emr.IEmrClusterCoreInstanceGroup)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEc2Attributes", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emr.EmrClusterEc2Attributes\"}}]")]
        public virtual void PutEc2Attributes(aws.Emr.IEmrClusterEc2Attributes @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Emr.IEmrClusterEc2Attributes)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKerberosAttributes", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emr.EmrClusterKerberosAttributes\"}}]")]
        public virtual void PutKerberosAttributes(aws.Emr.IEmrClusterKerberosAttributes @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Emr.IEmrClusterKerberosAttributes)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMasterInstanceFleet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleet\"}}]")]
        public virtual void PutMasterInstanceFleet(aws.Emr.IEmrClusterMasterInstanceFleet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Emr.IEmrClusterMasterInstanceFleet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMasterInstanceGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emr.EmrClusterMasterInstanceGroup\"}}]")]
        public virtual void PutMasterInstanceGroup(aws.Emr.IEmrClusterMasterInstanceGroup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Emr.IEmrClusterMasterInstanceGroup)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalInfo")]
        public virtual void ResetAdditionalInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetApplications")]
        public virtual void ResetApplications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoscalingRole")]
        public virtual void ResetAutoscalingRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoTerminationPolicy")]
        public virtual void ResetAutoTerminationPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBootstrapAction")]
        public virtual void ResetBootstrapAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigurations")]
        public virtual void ResetConfigurations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConfigurationsJson")]
        public virtual void ResetConfigurationsJson()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCoreInstanceFleet")]
        public virtual void ResetCoreInstanceFleet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCoreInstanceGroup")]
        public virtual void ResetCoreInstanceGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomAmiId")]
        public virtual void ResetCustomAmiId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEbsRootVolumeSize")]
        public virtual void ResetEbsRootVolumeSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEc2Attributes")]
        public virtual void ResetEc2Attributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeepJobFlowAliveWhenNoSteps")]
        public virtual void ResetKeepJobFlowAliveWhenNoSteps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKerberosAttributes")]
        public virtual void ResetKerberosAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogEncryptionKmsKeyId")]
        public virtual void ResetLogEncryptionKmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogUri")]
        public virtual void ResetLogUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasterInstanceFleet")]
        public virtual void ResetMasterInstanceFleet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasterInstanceGroup")]
        public virtual void ResetMasterInstanceGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScaleDownBehavior")]
        public virtual void ResetScaleDownBehavior()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityConfiguration")]
        public virtual void ResetSecurityConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStep")]
        public virtual void ResetStep()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStepConcurrencyLevel")]
        public virtual void ResetStepConcurrencyLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTerminationProtection")]
        public virtual void ResetTerminationProtection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVisibleToAllUsers")]
        public virtual void ResetVisibleToAllUsers()
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
        = GetStaticProperty<string>(typeof(aws.Emr.EmrCluster))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoTerminationPolicy", typeJson: "{\"fqn\":\"aws.emr.EmrClusterAutoTerminationPolicyOutputReference\"}")]
        public virtual aws.Emr.EmrClusterAutoTerminationPolicyOutputReference AutoTerminationPolicy
        {
            get => GetInstanceProperty<aws.Emr.EmrClusterAutoTerminationPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "clusterState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "coreInstanceFleet", typeJson: "{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleetOutputReference\"}")]
        public virtual aws.Emr.EmrClusterCoreInstanceFleetOutputReference CoreInstanceFleet
        {
            get => GetInstanceProperty<aws.Emr.EmrClusterCoreInstanceFleetOutputReference>()!;
        }

        [JsiiProperty(name: "coreInstanceGroup", typeJson: "{\"fqn\":\"aws.emr.EmrClusterCoreInstanceGroupOutputReference\"}")]
        public virtual aws.Emr.EmrClusterCoreInstanceGroupOutputReference CoreInstanceGroup
        {
            get => GetInstanceProperty<aws.Emr.EmrClusterCoreInstanceGroupOutputReference>()!;
        }

        [JsiiProperty(name: "ec2Attributes", typeJson: "{\"fqn\":\"aws.emr.EmrClusterEc2AttributesOutputReference\"}")]
        public virtual aws.Emr.EmrClusterEc2AttributesOutputReference Ec2Attributes
        {
            get => GetInstanceProperty<aws.Emr.EmrClusterEc2AttributesOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kerberosAttributes", typeJson: "{\"fqn\":\"aws.emr.EmrClusterKerberosAttributesOutputReference\"}")]
        public virtual aws.Emr.EmrClusterKerberosAttributesOutputReference KerberosAttributes
        {
            get => GetInstanceProperty<aws.Emr.EmrClusterKerberosAttributesOutputReference>()!;
        }

        [JsiiProperty(name: "masterInstanceFleet", typeJson: "{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleetOutputReference\"}")]
        public virtual aws.Emr.EmrClusterMasterInstanceFleetOutputReference MasterInstanceFleet
        {
            get => GetInstanceProperty<aws.Emr.EmrClusterMasterInstanceFleetOutputReference>()!;
        }

        [JsiiProperty(name: "masterInstanceGroup", typeJson: "{\"fqn\":\"aws.emr.EmrClusterMasterInstanceGroupOutputReference\"}")]
        public virtual aws.Emr.EmrClusterMasterInstanceGroupOutputReference MasterInstanceGroup
        {
            get => GetInstanceProperty<aws.Emr.EmrClusterMasterInstanceGroupOutputReference>()!;
        }

        [JsiiProperty(name: "masterPublicDns", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterPublicDns
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalInfoInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdditionalInfoInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ApplicationsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscalingRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoscalingRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoTerminationPolicyInput", typeJson: "{\"fqn\":\"aws.emr.EmrClusterAutoTerminationPolicy\"}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterAutoTerminationPolicy? AutoTerminationPolicyInput
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterAutoTerminationPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootstrapActionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterBootstrapAction\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterBootstrapAction[]? BootstrapActionInput
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterBootstrapAction[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigurationsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "configurationsJsonInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConfigurationsJsonInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "coreInstanceFleetInput", typeJson: "{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleet\"}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterCoreInstanceFleet? CoreInstanceFleetInput
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterCoreInstanceFleet?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "coreInstanceGroupInput", typeJson: "{\"fqn\":\"aws.emr.EmrClusterCoreInstanceGroup\"}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterCoreInstanceGroup? CoreInstanceGroupInput
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterCoreInstanceGroup?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customAmiIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CustomAmiIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ebsRootVolumeSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? EbsRootVolumeSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ec2AttributesInput", typeJson: "{\"fqn\":\"aws.emr.EmrClusterEc2Attributes\"}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterEc2Attributes? Ec2AttributesInput
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterEc2Attributes?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keepJobFlowAliveWhenNoStepsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? KeepJobFlowAliveWhenNoStepsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kerberosAttributesInput", typeJson: "{\"fqn\":\"aws.emr.EmrClusterKerberosAttributes\"}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterKerberosAttributes? KerberosAttributesInput
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterKerberosAttributes?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logEncryptionKmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogEncryptionKmsKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterInstanceFleetInput", typeJson: "{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleet\"}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterMasterInstanceFleet? MasterInstanceFleetInput
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterMasterInstanceFleet?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterInstanceGroupInput", typeJson: "{\"fqn\":\"aws.emr.EmrClusterMasterInstanceGroup\"}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterMasterInstanceGroup? MasterInstanceGroupInput
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterMasterInstanceGroup?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "releaseLabelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReleaseLabelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scaleDownBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ScaleDownBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityConfigurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecurityConfigurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepConcurrencyLevelInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StepConcurrencyLevelInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stepInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterStep\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterStep[]? StepInput
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterStep[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsAllInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminationProtectionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TerminationProtectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "visibleToAllUsersInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? VisibleToAllUsersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "additionalInfo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdditionalInfo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "applications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Applications
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoscalingRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoscalingRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bootstrapAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterBootstrapAction\"},\"kind\":\"array\"}}")]
        public virtual aws.Emr.IEmrClusterBootstrapAction[] BootstrapAction
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterBootstrapAction[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configurations", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Configurations
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "configurationsJson", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConfigurationsJson
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "customAmiId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomAmiId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "ebsRootVolumeSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EbsRootVolumeSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keepJobFlowAliveWhenNoSteps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object KeepJobFlowAliveWhenNoSteps
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logEncryptionKmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogEncryptionKmsKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogUri
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

        [JsiiProperty(name: "releaseLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseLabel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "scaleDownBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScaleDownBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityConfiguration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "step", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterStep\"},\"kind\":\"array\"}}")]
        public virtual aws.Emr.IEmrClusterStep[] Step
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterStep[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stepConcurrencyLevel", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StepConcurrencyLevel
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object Tags
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object TagsAll
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "terminationProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object TerminationProtection
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "visibleToAllUsers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object VisibleToAllUsers
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
