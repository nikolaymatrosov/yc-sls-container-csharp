using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiInterface(nativeType: typeof(IAlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeader), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeader")]
    public interface IAlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#name AlbVirtualHost#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#value AlbVirtualHost#value}
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeader), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeader")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#name AlbVirtualHost#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>value block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#value AlbVirtualHost#value}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue\"}", isOptional: true)]
            public yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue? Value
            {
                get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue?>();
            }
        }
    }
}
