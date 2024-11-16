using WhiteLabel.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace WhiteLabel.Permissions;

public class WhiteLabelPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(WhiteLabelPermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(WhiteLabelPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<WhiteLabelResource>(name);
    }
}
