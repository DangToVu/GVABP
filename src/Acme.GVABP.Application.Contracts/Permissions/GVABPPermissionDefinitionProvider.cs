using Acme.GVABP.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.GVABP.Permissions;

public class GVABPPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(GVABPPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(GVABPPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<GVABPResource>(name);
    }
}
