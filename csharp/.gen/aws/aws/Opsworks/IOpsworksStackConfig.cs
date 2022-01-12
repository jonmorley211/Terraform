using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Opsworks
{
    /// <summary>AWS OpsWorks.</summary>
    [JsiiInterface(nativeType: typeof(IOpsworksStackConfig), fullyQualifiedName: "aws.opsworks.OpsworksStackConfig")]
    public interface IOpsworksStackConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#default_instance_profile_arn OpsworksStack#default_instance_profile_arn}.</summary>
        [JsiiProperty(name: "defaultInstanceProfileArn", typeJson: "{\"primitive\":\"string\"}")]
        string DefaultInstanceProfileArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#name OpsworksStack#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#region OpsworksStack#region}.</summary>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        string Region
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#service_role_arn OpsworksStack#service_role_arn}.</summary>
        [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceRoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#agent_version OpsworksStack#agent_version}.</summary>
        [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AgentVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#berkshelf_version OpsworksStack#berkshelf_version}.</summary>
        [JsiiProperty(name: "berkshelfVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BerkshelfVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#color OpsworksStack#color}.</summary>
        [JsiiProperty(name: "color", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Color
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#configuration_manager_name OpsworksStack#configuration_manager_name}.</summary>
        [JsiiProperty(name: "configurationManagerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfigurationManagerName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#configuration_manager_version OpsworksStack#configuration_manager_version}.</summary>
        [JsiiProperty(name: "configurationManagerVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConfigurationManagerVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_cookbooks_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#custom_cookbooks_source OpsworksStack#custom_cookbooks_source}
        /// </remarks>
        [JsiiProperty(name: "customCookbooksSource", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksStackCustomCookbooksSource\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Opsworks.IOpsworksStackCustomCookbooksSource[]? CustomCookbooksSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#custom_json OpsworksStack#custom_json}.</summary>
        [JsiiProperty(name: "customJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomJson
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#default_availability_zone OpsworksStack#default_availability_zone}.</summary>
        [JsiiProperty(name: "defaultAvailabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultAvailabilityZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#default_os OpsworksStack#default_os}.</summary>
        [JsiiProperty(name: "defaultOs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultOs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#default_root_device_type OpsworksStack#default_root_device_type}.</summary>
        [JsiiProperty(name: "defaultRootDeviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultRootDeviceType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#default_ssh_key_name OpsworksStack#default_ssh_key_name}.</summary>
        [JsiiProperty(name: "defaultSshKeyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultSshKeyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#default_subnet_id OpsworksStack#default_subnet_id}.</summary>
        [JsiiProperty(name: "defaultSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultSubnetId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#hostname_theme OpsworksStack#hostname_theme}.</summary>
        [JsiiProperty(name: "hostnameTheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostnameTheme
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#manage_berkshelf OpsworksStack#manage_berkshelf}.</summary>
        [JsiiProperty(name: "manageBerkshelf", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ManageBerkshelf
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#tags OpsworksStack#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#tags_all OpsworksStack#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#use_custom_cookbooks OpsworksStack#use_custom_cookbooks}.</summary>
        [JsiiProperty(name: "useCustomCookbooks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseCustomCookbooks
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#use_opsworks_security_groups OpsworksStack#use_opsworks_security_groups}.</summary>
        [JsiiProperty(name: "useOpsworksSecurityGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UseOpsworksSecurityGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#vpc_id OpsworksStack#vpc_id}.</summary>
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VpcId
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS OpsWorks.</summary>
        [JsiiTypeProxy(nativeType: typeof(IOpsworksStackConfig), fullyQualifiedName: "aws.opsworks.OpsworksStackConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Opsworks.IOpsworksStackConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#default_instance_profile_arn OpsworksStack#default_instance_profile_arn}.</summary>
            [JsiiProperty(name: "defaultInstanceProfileArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DefaultInstanceProfileArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#name OpsworksStack#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#region OpsworksStack#region}.</summary>
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
            public string Region
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#service_role_arn OpsworksStack#service_role_arn}.</summary>
            [JsiiProperty(name: "serviceRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#agent_version OpsworksStack#agent_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "agentVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AgentVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#berkshelf_version OpsworksStack#berkshelf_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "berkshelfVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BerkshelfVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#color OpsworksStack#color}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "color", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Color
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#configuration_manager_name OpsworksStack#configuration_manager_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configurationManagerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfigurationManagerName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#configuration_manager_version OpsworksStack#configuration_manager_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configurationManagerVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConfigurationManagerVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>custom_cookbooks_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#custom_cookbooks_source OpsworksStack#custom_cookbooks_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customCookbooksSource", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.opsworks.OpsworksStackCustomCookbooksSource\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Opsworks.IOpsworksStackCustomCookbooksSource[]? CustomCookbooksSource
            {
                get => GetInstanceProperty<aws.Opsworks.IOpsworksStackCustomCookbooksSource[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#custom_json OpsworksStack#custom_json}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customJson", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomJson
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#default_availability_zone OpsworksStack#default_availability_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultAvailabilityZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultAvailabilityZone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#default_os OpsworksStack#default_os}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultOs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultOs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#default_root_device_type OpsworksStack#default_root_device_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultRootDeviceType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultRootDeviceType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#default_ssh_key_name OpsworksStack#default_ssh_key_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultSshKeyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultSshKeyName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#default_subnet_id OpsworksStack#default_subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultSubnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultSubnetId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#hostname_theme OpsworksStack#hostname_theme}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostnameTheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostnameTheme
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#manage_berkshelf OpsworksStack#manage_berkshelf}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "manageBerkshelf", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ManageBerkshelf
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#tags OpsworksStack#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? Tags
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#tags_all OpsworksStack#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
            public object? TagsAll
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#use_custom_cookbooks OpsworksStack#use_custom_cookbooks}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "useCustomCookbooks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseCustomCookbooks
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#use_opsworks_security_groups OpsworksStack#use_opsworks_security_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "useOpsworksSecurityGroups", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UseOpsworksSecurityGroups
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/opsworks_stack#vpc_id OpsworksStack#vpc_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VpcId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
