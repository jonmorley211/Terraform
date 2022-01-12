using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Rds
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/db_proxy_default_target_group aws_db_proxy_default_target_group}.</summary>
    [JsiiClass(nativeType: typeof(aws.Rds.DbProxyDefaultTargetGroup), fullyQualifiedName: "aws.rds.DbProxyDefaultTargetGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.rds.DbProxyDefaultTargetGroupConfig\"}}]")]
    public class DbProxyDefaultTargetGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/db_proxy_default_target_group aws_db_proxy_default_target_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DbProxyDefaultTargetGroup(Constructs.Construct scope, string id, aws.Rds.IDbProxyDefaultTargetGroupConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DbProxyDefaultTargetGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DbProxyDefaultTargetGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnectionPoolConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.rds.DbProxyDefaultTargetGroupConnectionPoolConfig\"}}]")]
        public virtual void PutConnectionPoolConfig(aws.Rds.IDbProxyDefaultTargetGroupConnectionPoolConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Rds.IDbProxyDefaultTargetGroupConnectionPoolConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.rds.DbProxyDefaultTargetGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Rds.IDbProxyDefaultTargetGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Rds.IDbProxyDefaultTargetGroupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConnectionPoolConfig")]
        public virtual void ResetConnectionPoolConfig()
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
        = GetStaticProperty<string>(typeof(aws.Rds.DbProxyDefaultTargetGroup))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionPoolConfig", typeJson: "{\"fqn\":\"aws.rds.DbProxyDefaultTargetGroupConnectionPoolConfigOutputReference\"}")]
        public virtual aws.Rds.DbProxyDefaultTargetGroupConnectionPoolConfigOutputReference ConnectionPoolConfig
        {
            get => GetInstanceProperty<aws.Rds.DbProxyDefaultTargetGroupConnectionPoolConfigOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.rds.DbProxyDefaultTargetGroupTimeoutsOutputReference\"}")]
        public virtual aws.Rds.DbProxyDefaultTargetGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Rds.DbProxyDefaultTargetGroupTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionPoolConfigInput", typeJson: "{\"fqn\":\"aws.rds.DbProxyDefaultTargetGroupConnectionPoolConfig\"}", isOptional: true)]
        public virtual aws.Rds.IDbProxyDefaultTargetGroupConnectionPoolConfig? ConnectionPoolConfigInput
        {
            get => GetInstanceProperty<aws.Rds.IDbProxyDefaultTargetGroupConnectionPoolConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dbProxyNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DbProxyNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.rds.DbProxyDefaultTargetGroupTimeouts\"}", isOptional: true)]
        public virtual aws.Rds.IDbProxyDefaultTargetGroupTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Rds.IDbProxyDefaultTargetGroupTimeouts?>();
        }

        [JsiiProperty(name: "dbProxyName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DbProxyName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
