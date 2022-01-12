using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Efs
{
    [JsiiInterface(nativeType: typeof(IEfsBackupPolicyBackupPolicy), fullyQualifiedName: "aws.efs.EfsBackupPolicyBackupPolicy")]
    public interface IEfsBackupPolicyBackupPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_backup_policy#status EfsBackupPolicy#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IEfsBackupPolicyBackupPolicy), fullyQualifiedName: "aws.efs.EfsBackupPolicyBackupPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Efs.IEfsBackupPolicyBackupPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/efs_backup_policy#status EfsBackupPolicy#status}.</summary>
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
