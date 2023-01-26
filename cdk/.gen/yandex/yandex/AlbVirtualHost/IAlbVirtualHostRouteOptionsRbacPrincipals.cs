using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiInterface(nativeType: typeof(IAlbVirtualHostRouteOptionsRbacPrincipals), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteOptionsRbacPrincipals")]
    public interface IAlbVirtualHostRouteOptionsRbacPrincipals
    {
        /// <summary>and_principals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#and_principals AlbVirtualHost#and_principals}
        /// </remarks>
        [JsiiProperty(name: "andPrincipals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteOptionsRbacPrincipalsAndPrincipals\"},\"kind\":\"array\"}}]}}")]
        object AndPrincipals
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbVirtualHostRouteOptionsRbacPrincipals), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteOptionsRbacPrincipals")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbVirtualHost.IAlbVirtualHostRouteOptionsRbacPrincipals
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>and_principals block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#and_principals AlbVirtualHost#and_principals}
            /// </remarks>
            [JsiiProperty(name: "andPrincipals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteOptionsRbacPrincipalsAndPrincipals\"},\"kind\":\"array\"}}]}}")]
            public object AndPrincipals
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
