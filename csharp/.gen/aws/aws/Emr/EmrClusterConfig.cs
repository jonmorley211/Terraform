using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    #pragma warning disable CS8618

    /// <summary>AWS Elastic MapReduce.</summary>
    [JsiiByValue(fqn: "aws.emr.EmrClusterConfig")]
    public class EmrClusterConfig : aws.Emr.IEmrClusterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#name EmrCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#release_label EmrCluster#release_label}.</summary>
        [JsiiProperty(name: "releaseLabel", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ReleaseLabel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#service_role EmrCluster#service_role}.</summary>
        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ServiceRole
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#additional_info EmrCluster#additional_info}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "additionalInfo", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AdditionalInfo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#applications EmrCluster#applications}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applications", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Applications
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#autoscaling_role EmrCluster#autoscaling_role}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoscalingRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AutoscalingRole
        {
            get;
            set;
        }

        /// <summary>auto_termination_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#auto_termination_policy EmrCluster#auto_termination_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoTerminationPolicy", typeJson: "{\"fqn\":\"aws.emr.EmrClusterAutoTerminationPolicy\"}", isOptional: true, isOverride: true)]
        public aws.Emr.IEmrClusterAutoTerminationPolicy? AutoTerminationPolicy
        {
            get;
            set;
        }

        /// <summary>bootstrap_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#bootstrap_action EmrCluster#bootstrap_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bootstrapAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterBootstrapAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Emr.IEmrClusterBootstrapAction[]? BootstrapAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#configurations EmrCluster#configurations}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configurations", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Configurations
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#configurations_json EmrCluster#configurations_json}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configurationsJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ConfigurationsJson
        {
            get;
            set;
        }

        /// <summary>core_instance_fleet block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#core_instance_fleet EmrCluster#core_instance_fleet}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "coreInstanceFleet", typeJson: "{\"fqn\":\"aws.emr.EmrClusterCoreInstanceFleet\"}", isOptional: true, isOverride: true)]
        public aws.Emr.IEmrClusterCoreInstanceFleet? CoreInstanceFleet
        {
            get;
            set;
        }

        /// <summary>core_instance_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#core_instance_group EmrCluster#core_instance_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "coreInstanceGroup", typeJson: "{\"fqn\":\"aws.emr.EmrClusterCoreInstanceGroup\"}", isOptional: true, isOverride: true)]
        public aws.Emr.IEmrClusterCoreInstanceGroup? CoreInstanceGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#custom_ami_id EmrCluster#custom_ami_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customAmiId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CustomAmiId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#ebs_root_volume_size EmrCluster#ebs_root_volume_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ebsRootVolumeSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? EbsRootVolumeSize
        {
            get;
            set;
        }

        /// <summary>ec2_attributes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#ec2_attributes EmrCluster#ec2_attributes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ec2Attributes", typeJson: "{\"fqn\":\"aws.emr.EmrClusterEc2Attributes\"}", isOptional: true, isOverride: true)]
        public aws.Emr.IEmrClusterEc2Attributes? Ec2Attributes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#keep_job_flow_alive_when_no_steps EmrCluster#keep_job_flow_alive_when_no_steps}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keepJobFlowAliveWhenNoSteps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? KeepJobFlowAliveWhenNoSteps
        {
            get;
            set;
        }

        /// <summary>kerberos_attributes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#kerberos_attributes EmrCluster#kerberos_attributes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kerberosAttributes", typeJson: "{\"fqn\":\"aws.emr.EmrClusterKerberosAttributes\"}", isOptional: true, isOverride: true)]
        public aws.Emr.IEmrClusterKerberosAttributes? KerberosAttributes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#log_encryption_kms_key_id EmrCluster#log_encryption_kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logEncryptionKmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LogEncryptionKmsKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#log_uri EmrCluster#log_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LogUri
        {
            get;
            set;
        }

        /// <summary>master_instance_fleet block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#master_instance_fleet EmrCluster#master_instance_fleet}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "masterInstanceFleet", typeJson: "{\"fqn\":\"aws.emr.EmrClusterMasterInstanceFleet\"}", isOptional: true, isOverride: true)]
        public aws.Emr.IEmrClusterMasterInstanceFleet? MasterInstanceFleet
        {
            get;
            set;
        }

        /// <summary>master_instance_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#master_instance_group EmrCluster#master_instance_group}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "masterInstanceGroup", typeJson: "{\"fqn\":\"aws.emr.EmrClusterMasterInstanceGroup\"}", isOptional: true, isOverride: true)]
        public aws.Emr.IEmrClusterMasterInstanceGroup? MasterInstanceGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#scale_down_behavior EmrCluster#scale_down_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scaleDownBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ScaleDownBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#security_configuration EmrCluster#security_configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SecurityConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#step EmrCluster#step}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "step", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emr.EmrClusterStep\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Emr.IEmrClusterStep[]? Step
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#step_concurrency_level EmrCluster#step_concurrency_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stepConcurrencyLevel", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? StepConcurrencyLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#tags EmrCluster#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#tags_all EmrCluster#tags_all}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? TagsAll
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#termination_protection EmrCluster#termination_protection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "terminationProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? TerminationProtection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/emr_cluster#visible_to_all_users EmrCluster#visible_to_all_users}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "visibleToAllUsers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? VisibleToAllUsers
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
