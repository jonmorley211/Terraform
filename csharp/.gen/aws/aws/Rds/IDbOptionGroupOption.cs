using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    [JsiiInterface(nativeType: typeof(IDbOptionGroupOption), fullyQualifiedName: "aws.rds.DbOptionGroupOption")]
    public interface IDbOptionGroupOption
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#option_name DbOptionGroup#option_name}.</summary>
        [JsiiProperty(name: "optionName", typeJson: "{\"primitive\":\"string\"}")]
        string OptionName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#db_security_group_memberships DbOptionGroup#db_security_group_memberships}.</summary>
        [JsiiProperty(name: "dbSecurityGroupMemberships", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DbSecurityGroupMemberships
        {
            get
            {
                return null;
            }
        }

        /// <summary>option_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#option_settings DbOptionGroup#option_settings}
        /// </remarks>
        [JsiiProperty(name: "optionSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rds.DbOptionGroupOptionOptionSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Rds.IDbOptionGroupOptionOptionSettings[]? OptionSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#port DbOptionGroup#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#version DbOptionGroup#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#vpc_security_group_memberships DbOptionGroup#vpc_security_group_memberships}.</summary>
        [JsiiProperty(name: "vpcSecurityGroupMemberships", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? VpcSecurityGroupMemberships
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDbOptionGroupOption), fullyQualifiedName: "aws.rds.DbOptionGroupOption")]
        internal sealed class _Proxy : DeputyBase, aws.Rds.IDbOptionGroupOption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#option_name DbOptionGroup#option_name}.</summary>
            [JsiiProperty(name: "optionName", typeJson: "{\"primitive\":\"string\"}")]
            public string OptionName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#db_security_group_memberships DbOptionGroup#db_security_group_memberships}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbSecurityGroupMemberships", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DbSecurityGroupMemberships
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>option_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#option_settings DbOptionGroup#option_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "optionSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.rds.DbOptionGroupOptionOptionSettings\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Rds.IDbOptionGroupOptionOptionSettings[]? OptionSettings
            {
                get => GetInstanceProperty<aws.Rds.IDbOptionGroupOptionOptionSettings[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#port DbOptionGroup#port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#version DbOptionGroup#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/db_option_group#vpc_security_group_memberships DbOptionGroup#vpc_security_group_memberships}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "vpcSecurityGroupMemberships", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? VpcSecurityGroupMemberships
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
