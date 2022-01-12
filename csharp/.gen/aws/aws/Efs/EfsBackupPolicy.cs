using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/efs_backup_policy aws_efs_backup_policy}.</summary>
    [JsiiClass(nativeType: typeof(aws.Efs.EfsBackupPolicy), fullyQualifiedName: "aws.efs.EfsBackupPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.efs.EfsBackupPolicyConfig\"}}]")]
    public class EfsBackupPolicy : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/efs_backup_policy aws_efs_backup_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public EfsBackupPolicy(Constructs.Construct scope, string id, aws.Efs.IEfsBackupPolicyConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EfsBackupPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EfsBackupPolicy(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBackupPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.efs.EfsBackupPolicyBackupPolicy\"}}]")]
        public virtual void PutBackupPolicy(aws.Efs.IEfsBackupPolicyBackupPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Efs.IEfsBackupPolicyBackupPolicy)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Efs.EfsBackupPolicy))!;

        [JsiiProperty(name: "backupPolicy", typeJson: "{\"fqn\":\"aws.efs.EfsBackupPolicyBackupPolicyOutputReference\"}")]
        public virtual aws.Efs.EfsBackupPolicyBackupPolicyOutputReference BackupPolicy
        {
            get => GetInstanceProperty<aws.Efs.EfsBackupPolicyBackupPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupPolicyInput", typeJson: "{\"fqn\":\"aws.efs.EfsBackupPolicyBackupPolicy\"}", isOptional: true)]
        public virtual aws.Efs.IEfsBackupPolicyBackupPolicy? BackupPolicyInput
        {
            get => GetInstanceProperty<aws.Efs.IEfsBackupPolicyBackupPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FileSystemIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
