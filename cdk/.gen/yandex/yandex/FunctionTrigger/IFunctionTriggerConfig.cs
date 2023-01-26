using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.FunctionTrigger
{
    [JsiiInterface(nativeType: typeof(IFunctionTriggerConfig), fullyQualifiedName: "yandex.functionTrigger.FunctionTriggerConfig")]
    public interface IFunctionTriggerConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>function block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#function FunctionTrigger#function}
        /// </remarks>
        [JsiiProperty(name: "function", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerFunction\"}")]
        yandex.FunctionTrigger.IFunctionTriggerFunction Function
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#name FunctionTrigger#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#description FunctionTrigger#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>dlq block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#dlq FunctionTrigger#dlq}
        /// </remarks>
        [JsiiProperty(name: "dlq", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerDlq\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.FunctionTrigger.IFunctionTriggerDlq? Dlq
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#folder_id FunctionTrigger#folder_id}.</summary>
        [JsiiProperty(name: "folderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FolderId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#id FunctionTrigger#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>iot block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#iot FunctionTrigger#iot}
        /// </remarks>
        [JsiiProperty(name: "iot", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerIot\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.FunctionTrigger.IFunctionTriggerIot? Iot
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#labels FunctionTrigger#labels}.</summary>
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Labels
        {
            get
            {
                return null;
            }
        }

        /// <summary>logging block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#logging FunctionTrigger#logging}
        /// </remarks>
        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerLogging\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.FunctionTrigger.IFunctionTriggerLogging? Logging
        {
            get
            {
                return null;
            }
        }

        /// <summary>log_group block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#log_group FunctionTrigger#log_group}
        /// </remarks>
        [JsiiProperty(name: "logGroup", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerLogGroup\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.FunctionTrigger.IFunctionTriggerLogGroup? LogGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>message_queue block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#message_queue FunctionTrigger#message_queue}
        /// </remarks>
        [JsiiProperty(name: "messageQueue", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerMessageQueue\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.FunctionTrigger.IFunctionTriggerMessageQueue? MessageQueue
        {
            get
            {
                return null;
            }
        }

        /// <summary>object_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#object_storage FunctionTrigger#object_storage}
        /// </remarks>
        [JsiiProperty(name: "objectStorage", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerObjectStorage\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.FunctionTrigger.IFunctionTriggerObjectStorage? ObjectStorage
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#timeouts FunctionTrigger#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.FunctionTrigger.IFunctionTriggerTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>timer block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#timer FunctionTrigger#timer}
        /// </remarks>
        [JsiiProperty(name: "timer", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerTimer\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.FunctionTrigger.IFunctionTriggerTimer? Timer
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionTriggerConfig), fullyQualifiedName: "yandex.functionTrigger.FunctionTriggerConfig")]
        internal sealed class _Proxy : DeputyBase, yandex.FunctionTrigger.IFunctionTriggerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>function block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#function FunctionTrigger#function}
            /// </remarks>
            [JsiiProperty(name: "function", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerFunction\"}")]
            public yandex.FunctionTrigger.IFunctionTriggerFunction Function
            {
                get => GetInstanceProperty<yandex.FunctionTrigger.IFunctionTriggerFunction>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#name FunctionTrigger#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#description FunctionTrigger#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>dlq block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#dlq FunctionTrigger#dlq}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dlq", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerDlq\"}", isOptional: true)]
            public yandex.FunctionTrigger.IFunctionTriggerDlq? Dlq
            {
                get => GetInstanceProperty<yandex.FunctionTrigger.IFunctionTriggerDlq?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#folder_id FunctionTrigger#folder_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "folderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FolderId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#id FunctionTrigger#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>iot block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#iot FunctionTrigger#iot}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iot", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerIot\"}", isOptional: true)]
            public yandex.FunctionTrigger.IFunctionTriggerIot? Iot
            {
                get => GetInstanceProperty<yandex.FunctionTrigger.IFunctionTriggerIot?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#labels FunctionTrigger#labels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Labels
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>logging block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#logging FunctionTrigger#logging}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerLogging\"}", isOptional: true)]
            public yandex.FunctionTrigger.IFunctionTriggerLogging? Logging
            {
                get => GetInstanceProperty<yandex.FunctionTrigger.IFunctionTriggerLogging?>();
            }

            /// <summary>log_group block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#log_group FunctionTrigger#log_group}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logGroup", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerLogGroup\"}", isOptional: true)]
            public yandex.FunctionTrigger.IFunctionTriggerLogGroup? LogGroup
            {
                get => GetInstanceProperty<yandex.FunctionTrigger.IFunctionTriggerLogGroup?>();
            }

            /// <summary>message_queue block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#message_queue FunctionTrigger#message_queue}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "messageQueue", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerMessageQueue\"}", isOptional: true)]
            public yandex.FunctionTrigger.IFunctionTriggerMessageQueue? MessageQueue
            {
                get => GetInstanceProperty<yandex.FunctionTrigger.IFunctionTriggerMessageQueue?>();
            }

            /// <summary>object_storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#object_storage FunctionTrigger#object_storage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "objectStorage", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerObjectStorage\"}", isOptional: true)]
            public yandex.FunctionTrigger.IFunctionTriggerObjectStorage? ObjectStorage
            {
                get => GetInstanceProperty<yandex.FunctionTrigger.IFunctionTriggerObjectStorage?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#timeouts FunctionTrigger#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerTimeouts\"}", isOptional: true)]
            public yandex.FunctionTrigger.IFunctionTriggerTimeouts? Timeouts
            {
                get => GetInstanceProperty<yandex.FunctionTrigger.IFunctionTriggerTimeouts?>();
            }

            /// <summary>timer block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#timer FunctionTrigger#timer}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timer", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerTimer\"}", isOptional: true)]
            public yandex.FunctionTrigger.IFunctionTriggerTimer? Timer
            {
                get => GetInstanceProperty<yandex.FunctionTrigger.IFunctionTriggerTimer?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
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
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
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

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
