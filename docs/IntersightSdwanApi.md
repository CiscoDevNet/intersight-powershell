# Intersight.Intersight/Api.IntersightSdwanApi

All URIs are relative to *https://intersight.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**New-IntersightSdwanProfile**](IntersightSdwanApi.md#New-IntersightSdwanProfile) | **POST** /api/v1/sdwan/Profiles | Create a &#39;sdwan.Profile&#39; resource.
[**New-IntersightSdwanRouterNode**](IntersightSdwanApi.md#New-IntersightSdwanRouterNode) | **POST** /api/v1/sdwan/RouterNodes | Create a &#39;sdwan.RouterNode&#39; resource.
[**New-IntersightSdwanRouterPolicy**](IntersightSdwanApi.md#New-IntersightSdwanRouterPolicy) | **POST** /api/v1/sdwan/RouterPolicies | Create a &#39;sdwan.RouterPolicy&#39; resource.
[**New-IntersightSdwanVmanageAccountPolicy**](IntersightSdwanApi.md#New-IntersightSdwanVmanageAccountPolicy) | **POST** /api/v1/sdwan/VmanageAccountPolicies | Create a &#39;sdwan.VmanageAccountPolicy&#39; resource.
[**Remove-IntersightSdwanProfile**](IntersightSdwanApi.md#Remove-IntersightSdwanProfile) | **DELETE** /api/v1/sdwan/Profiles/{Moid} | Delete a &#39;sdwan.Profile&#39; resource.
[**Remove-IntersightSdwanRouterNode**](IntersightSdwanApi.md#Remove-IntersightSdwanRouterNode) | **DELETE** /api/v1/sdwan/RouterNodes/{Moid} | Delete a &#39;sdwan.RouterNode&#39; resource.
[**Remove-IntersightSdwanRouterPolicy**](IntersightSdwanApi.md#Remove-IntersightSdwanRouterPolicy) | **DELETE** /api/v1/sdwan/RouterPolicies/{Moid} | Delete a &#39;sdwan.RouterPolicy&#39; resource.
[**Remove-IntersightSdwanVmanageAccountPolicy**](IntersightSdwanApi.md#Remove-IntersightSdwanVmanageAccountPolicy) | **DELETE** /api/v1/sdwan/VmanageAccountPolicies/{Moid} | Delete a &#39;sdwan.VmanageAccountPolicy&#39; resource.
[**Get-IntersightSdwanProfileByMoid**](IntersightSdwanApi.md#Get-IntersightSdwanProfileByMoid) | **GET** /api/v1/sdwan/Profiles/{Moid} | Read a &#39;sdwan.Profile&#39; resource.
[**Get-IntersightSdwanProfileList**](IntersightSdwanApi.md#Get-IntersightSdwanProfileList) | **GET** /api/v1/sdwan/Profiles | Read a &#39;sdwan.Profile&#39; resource.
[**Get-IntersightSdwanRouterNodeByMoid**](IntersightSdwanApi.md#Get-IntersightSdwanRouterNodeByMoid) | **GET** /api/v1/sdwan/RouterNodes/{Moid} | Read a &#39;sdwan.RouterNode&#39; resource.
[**Get-IntersightSdwanRouterNodeList**](IntersightSdwanApi.md#Get-IntersightSdwanRouterNodeList) | **GET** /api/v1/sdwan/RouterNodes | Read a &#39;sdwan.RouterNode&#39; resource.
[**Get-IntersightSdwanRouterPolicyByMoid**](IntersightSdwanApi.md#Get-IntersightSdwanRouterPolicyByMoid) | **GET** /api/v1/sdwan/RouterPolicies/{Moid} | Read a &#39;sdwan.RouterPolicy&#39; resource.
[**Get-IntersightSdwanRouterPolicyList**](IntersightSdwanApi.md#Get-IntersightSdwanRouterPolicyList) | **GET** /api/v1/sdwan/RouterPolicies | Read a &#39;sdwan.RouterPolicy&#39; resource.
[**Get-IntersightSdwanVmanageAccountPolicyByMoid**](IntersightSdwanApi.md#Get-IntersightSdwanVmanageAccountPolicyByMoid) | **GET** /api/v1/sdwan/VmanageAccountPolicies/{Moid} | Read a &#39;sdwan.VmanageAccountPolicy&#39; resource.
[**Get-IntersightSdwanVmanageAccountPolicyList**](IntersightSdwanApi.md#Get-IntersightSdwanVmanageAccountPolicyList) | **GET** /api/v1/sdwan/VmanageAccountPolicies | Read a &#39;sdwan.VmanageAccountPolicy&#39; resource.
[**Set-IntersightSdwanProfile**](IntersightSdwanApi.md#Set-IntersightSdwanProfile) | **PATCH** /api/v1/sdwan/Profiles/{Moid} | Update a &#39;sdwan.Profile&#39; resource.
[**Set-IntersightSdwanRouterNode**](IntersightSdwanApi.md#Set-IntersightSdwanRouterNode) | **PATCH** /api/v1/sdwan/RouterNodes/{Moid} | Update a &#39;sdwan.RouterNode&#39; resource.
[**Set-IntersightSdwanRouterPolicy**](IntersightSdwanApi.md#Set-IntersightSdwanRouterPolicy) | **PATCH** /api/v1/sdwan/RouterPolicies/{Moid} | Update a &#39;sdwan.RouterPolicy&#39; resource.
[**Set-IntersightSdwanVmanageAccountPolicy**](IntersightSdwanApi.md#Set-IntersightSdwanVmanageAccountPolicy) | **PATCH** /api/v1/sdwan/VmanageAccountPolicies/{Moid} | Update a &#39;sdwan.VmanageAccountPolicy&#39; resource.
[**Update-IntersightSdwanProfile**](IntersightSdwanApi.md#Update-IntersightSdwanProfile) | **POST** /api/v1/sdwan/Profiles/{Moid} | Update a &#39;sdwan.Profile&#39; resource.
[**Update-IntersightSdwanRouterNode**](IntersightSdwanApi.md#Update-IntersightSdwanRouterNode) | **POST** /api/v1/sdwan/RouterNodes/{Moid} | Update a &#39;sdwan.RouterNode&#39; resource.
[**Update-IntersightSdwanRouterPolicy**](IntersightSdwanApi.md#Update-IntersightSdwanRouterPolicy) | **POST** /api/v1/sdwan/RouterPolicies/{Moid} | Update a &#39;sdwan.RouterPolicy&#39; resource.
[**Update-IntersightSdwanVmanageAccountPolicy**](IntersightSdwanApi.md#Update-IntersightSdwanVmanageAccountPolicy) | **POST** /api/v1/sdwan/VmanageAccountPolicies/{Moid} | Update a &#39;sdwan.VmanageAccountPolicy&#39; resource.


<a name="New-IntersightSdwanProfile"></a>
# **New-IntersightSdwanProfile**
> SdwanProfile New-IntersightSdwanProfile<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SdwanProfile] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IfMatch] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IfNoneMatch] <String><br>

Create a 'sdwan.Profile' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$SdwanProfile = (Initialize-sdwan.Profile-ClassId "ClassId_example" -ObjectType "ObjectType_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Moid "Moid_example" -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @((Initialize-mo.Tag-Key "Key_example" -Value "Value_example")) -VersionContext (Initialize-mo.VersionContext-ClassId "ClassId_example" -ObjectType "ObjectType_example" -InterestedMos @((Initialize-mo.MoRef-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example")) -RefMo (Initialize-mo.MoRef-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example") -Timestamp Get-Date -Version "Version_example" -VersionType "VersionType_example") -Ancestors @((Initialize-mo.BaseMo.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @((Initialize-mo.Tag-Key "Key_example" -Value "Value_example")) -VersionContext (Initialize-mo.VersionContext-ClassId "ClassId_example" -ObjectType "ObjectType_example" -InterestedMos @() -RefMo  -Timestamp Get-Date -Version "Version_example" -VersionType "VersionType_example") -Ancestors @((Initialize-mo.BaseMo.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO")) -Parent  -PermissionResources @() -DisplayNames "TODO")) -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -Type "Type_example" -SrcTemplate (Initialize-policy.AbstractProfile.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -Type "Type_example" -SrcTemplate (Initialize-policy.AbstractProfile.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -Type "Type_example" -SrcTemplate )) -Action "Action_example" -ConfigContext (Initialize-policy.ConfigContext-ClassId "ClassId_example" -ObjectType "ObjectType_example" -ConfigState "ConfigState_example" -ControlAction "ControlAction_example" -ErrorState "ErrorState_example" -OperState "OperState_example") -Organization (Initialize-organization.Organization.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -Account (Initialize-iam.Account.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Name "Name_example" -Status "Status_example" -AppRegistrations @((Initialize-iam.AppRegistration.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -ClientId "ClientId_example" -ClientName "ClientName_example" -ClientSecret "ClientSecret_example" -ClientType "ClientType_example" -Description "Description_example" -GrantTypes @("GrantTypes_example") -RedirectUris @("RedirectUris_example") -RenewClientSecret $false -ResponseTypes @("ResponseTypes_example") -RevocationTimestamp Get-Date -Revoke $false -Account (Initialize-iam.Account.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Name "Name_example" -Status "Status_example" -AppRegistrations @((Initialize-iam.AppRegistration.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -ClientId "ClientId_example" -ClientName "ClientName_example" -ClientSecret "ClientSecret_example" -ClientType "ClientType_example" -Description "Description_example" -GrantTypes @("GrantTypes_example") -RedirectUris @("RedirectUris_example") -RenewClientSecret $false -ResponseTypes @("ResponseTypes_example") -RevocationTimestamp Get-Date -Revoke $false -Account  -OauthTokens @((Initialize-iam.OAuthToken.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -AccessExpirationTime Get-Date -ClientId "ClientId_example" -ClientIpAddress "ClientIpAddress_example" -ClientName "ClientName_example" -ExpirationTime Get-Date -LastLoginClient "LastLoginClient_example" -LastLoginTime Get-Date -TokenId "TokenId_example" -UserMeta (Initialize-iam.ClientMeta-ClassId "ClassId_example" -ObjectType "ObjectType_example" -DeviceModel "DeviceModel_example" -UserAgent "UserAgent_example") -AppRegistration  -Permission (Initialize-iam.Permission.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -Account  -EndPointRoles @((Initialize-iam.EndPointRole.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Name "Name_example" -RoleType "RoleType_example" -Type "Type_example" -Account  -EndPointPrivileges @((Initialize-iam.EndPointPrivilege.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -Type "Type_example" -System (Initialize-iam.System.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -EndPointPrivileges @((Initialize-iam.EndPointPrivilege.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -Type "Type_example" -System (Initialize-iam.System.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -EndPointPrivileges @() -EndPointRoles @((Initialize-iam.EndPointRole.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Name "Name_example" -RoleType "RoleType_example" -Type "Type_example" -Account  -EndPointPrivileges @() -System )) -Idp (Initialize-iam.Idp.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -DomainName "DomainName_example" -EnableSingleLogout $false -IdpEntityId "IdpEntityId_example" -Metadata "Metadata_example" -Name "Name_example" -Type "Type_example" -Account  -LdapPolicy (Initialize-iam.LdapPolicy.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -BaseProperties (Initialize-iam.LdapBaseProperties-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Attribute "Attribute_example" -BaseDn "BaseDn_example" -BindDn "BindDn_example" -BindMethod "BindMethod_example" -Domain "Domain_example" -EnableEncryption $false -EnableGroupAuthorization $false -VarFilter "VarFilter_example" -GroupAttribute "GroupAttribute_example" -IsPasswordSet $false -NestedGroupSearchDepth 123 -Password "Password_example" -Timeout 123) -DnsParameters (Initialize-iam.LdapDnsParameters-ClassId "ClassId_example" -ObjectType "ObjectType_example" -SearchDomain "SearchDomain_example" -SearchForest "SearchForest_example" -Source "Source_example") -EnableDns $false -Enabled $false -UserSearchPrecedence "UserSearchPrecedence_example" -Var0Idp (Initialize-iam.Idp.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -DomainName "DomainName_example" -EnableSingleLogout $false -IdpEntityId "IdpEntityId_example" -Metadata "Metadata_example" -Name "Name_example" -Type "Type_example" -Account  -LdapPolicy (Initialize-iam.LdapPolicy.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -BaseProperties (Initialize-iam.LdapBaseProperties-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Attribute "Attribute_example" -BaseDn "BaseDn_example" -BindDn "BindDn_example" -BindMethod "BindMethod_example" -Domain "Domain_example" -EnableEncryption $false -EnableGroupAuthorization $false -VarFilter "VarFilter_example" -GroupAttribute "GroupAttribute_example" -IsPasswordSet $false -NestedGroupSearchDepth 123 -Password "Password_example" -Timeout 123) -DnsParameters (Initialize-iam.LdapDnsParameters-ClassId "ClassId_example" -ObjectType "ObjectType_example" -SearchDomain "SearchDomain_example" -SearchForest "SearchForest_example" -Source "Source_example") -EnableDns $false -Enabled $false -UserSearchPrecedence "UserSearchPrecedence_example" -Var0Idp  -ApplianceAccount  -Groups @((Initialize-iam.LdapGroup.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Domain "Domain_example" -Name "Name_example" -EndPointRole @() -LdapPolicy )) -Organization (Initialize-organization.Organization.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -Account  -ResourceGroups @((Initialize-resource.Group.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Name "Name_example" -PerTypeCombinedSelector @((Initialize-resource.PerTypeCombinedSelector-ClassId "ClassId_example" -ObjectType "ObjectType_example" -CombinedSelector "CombinedSelector_example" -EmptyFilter $false -SelectorObjectType "SelectorObjectType_example")) -Qualifier "Qualifier_example" -Selectors @((Initialize-resource.Selector-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Selector "Selector_example")) -Account  -Organizations @()))) -Profiles @((Initialize-policy.AbstractConfigProfile.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -Type "Type_example" -SrcTemplate  -Action "Action_example" -ConfigContext (Initialize-policy.ConfigContext-ClassId "ClassId_example" -ObjectType "ObjectType_example" -ConfigState "ConfigState_example" -ControlAction "ControlAction_example" -ErrorState "ErrorState_example" -OperState "OperState_example"))) -Providers @((Initialize-iam.LdapProvider.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Port 123 -Server "Server_example" -LdapPolicy ))) -System  -UserPreferences @((Initialize-iam.UserPreference.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Preference "TODO" -UserUniqueIdentifier "UserUniqueIdentifier_example" -Idp  -IdpReference (Initialize-iam.IdpReference.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -DomainName "DomainName_example" -IdpEntityId "IdpEntityId_example" -MultiFactorAuthentication $false -Name "Name_example" -Account  -Idp  -UserPreferences @((Initialize-iam.UserPreference.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Preference "TODO" -UserUniqueIdentifier "UserUniqueIdentifier_example" -Idp  -IdpReference (Initialize-iam.IdpReference.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -DomainName "DomainName_example" -IdpEntityId "IdpEntityId_example" -MultiFactorAuthentication $false -Name "Name_example" -Account  -Idp  -UserPreferences @() -Usergroups @((Initialize-iam.UserGroup.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Name "Name_example" -Idp  -Idpreference  -Permissions @((Initialize-iam.Permission.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -Account  -EndPointRoles @() -PrivilegeSets @((Initialize-iam.PrivilegeSet.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -PrivilegeNames @("PrivilegeNames_example") -Account  -AssociatedPrivilegeSets @((Initialize-iam.PrivilegeSet.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -PrivilegeNames @("PrivilegeNames_example") -Account  -AssociatedPrivilegeSets @() -Privileges @((Initialize-iam.Privilege.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -HostnamePrefix "HostnamePrefix_example" -Method "Method_example" -Name "Name_example" -RestPath "RestPath_example" -UrlPrefix "UrlPrefix_example" -Account  -System )) -System )) -Privileges @((Initialize-iam.Privilege.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -HostnamePrefix "HostnamePrefix_example" -Method "Method_example" -Name "Name_example" -RestPath "RestPath_example" -UrlPrefix "UrlPrefix_example" -Account  -System )) -System )) -ResourceRoles @((Initialize-iam.ResourceRoles.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -EndPointRoles @() -Permission  -PrivilegeSets @() -Resource  -Roles @((Initialize-iam.Role.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -PrivilegeNames @("PrivilegeNames_example") -Account  -PrivilegeSets @() -System )))) -Roles @((Initialize-iam.Role.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -PrivilegeNames @("PrivilegeNames_example") -Account  -PrivilegeSets @() -System )) -SessionLimits (Initialize-iam.SessionLimits.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -IdleTimeOut 123 -MaximumLimit 123 -PerUserLimit 123 -SessionTimeOut 123 -Account  -Permission ) -UserGroups @((Initialize-iam.UserGroup.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Name "Name_example" -Idp  -Idpreference  -Permissions @() -Qualifier (Initialize-iam.Qualifier.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Name "Name_example" -Value @("Value_example") -Usergroup ) -Users @((Initialize-iam.User.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -ClientIpAddress "ClientIpAddress_example" -Email "Email_example" -FirstName "FirstName_example" -LastLoginTime Get-Date -LastName "LastName_example" -Name "Name_example" -UserIdOrEmail "UserIdOrEmail_example" -UserType "UserType_example" -UserUniqueIdentifier "UserUniqueIdentifier_example" -ApiKeys @((Initialize-iam.ApiKey.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -HashAlgorithm "HashAlgorithm_example" -KeySpec (Initialize-pkix.KeyGenerationSpec-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Name "Name_example") -PrivateKey "PrivateKey_example" -Purpose "Purpose_example" -SigningAlgorithm "SigningAlgorithm_example" -Permission  -User (Initialize-iam.User.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -ClientIpAddress "ClientIpAddress_example" -Email "Email_example" -FirstName "FirstName_example" -LastLoginTime Get-Date -LastName "LastName_example" -Name "Name_example" -UserIdOrEmail "UserIdOrEmail_example" -UserType "UserType_example" -UserUniqueIdentifier "UserUniqueIdentifier_example" -ApiKeys @((Initialize-iam.ApiKey.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -HashAlgorithm "HashAlgorithm_example" -KeySpec (Initialize-pkix.KeyGenerationSpec-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Name "Name_example") -PrivateKey "PrivateKey_example" -Purpose "Purpose_example" -SigningAlgorithm "SigningAlgorithm_example" -Permission  -User )) -AppRegistrations @() -Idp  -Idpreference  -LocalUserPassword (Initialize-iam.LocalUserPassword.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -CurrentPassword "CurrentPassword_example" -IsCurrentPasswordSet $false -IsNewPasswordSet $false -NewPassword "NewPassword_example" -Password "TODO" -User ) -OauthTokens @((Initialize-iam.OAuthToken.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -AccessExpirationTime Get-Date -ClientId "ClientId_example" -ClientIpAddress "ClientIpAddress_example" -ClientName "ClientName_example" -ExpirationTime Get-Date -LastLoginClient "LastLoginClient_example" -LastLoginTime Get-Date -TokenId "TokenId_example" -UserMeta (Initialize-iam.ClientMeta-ClassId "ClassId_example" -ObjectType "ObjectType_example" -DeviceModel "DeviceModel_example" -UserAgent "UserAgent_example") -AppRegistration  -Permission  -User )) -Permissions @() -Sessions @((Initialize-iam.Session.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -AccountPermissions @((Initialize-iam.AccountPermissions-ClassId "ClassId_example" -ObjectType "ObjectType_example" -AccountIdentifier "AccountIdentifier_example" -AccountName "AccountName_example" -AccountStatus "AccountStatus_example" -Permissions @((Initialize-iam.PermissionReference-ClassId "ClassId_example" -ObjectType "ObjectType_example" -PermissionIdentifier "PermissionIdentifier_example" -PermissionName "PermissionName_example")))) -ClientIpAddress "ClientIpAddress_example" -Expiration Get-Date -IdleTimeExpiration Get-Date -LastLoginClient "LastLoginClient_example" -LastLoginTime Get-Date -Permission  -User ))))) -AppRegistrations @() -Idp  -Idpreference  -LocalUserPassword (Initialize-iam.LocalUserPassword.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -CurrentPassword "CurrentPassword_example" -IsCurrentPasswordSet $false -IsNewPasswordSet $false -NewPassword "NewPassword_example" -Password "TODO" -User ) -OauthTokens @() -Permissions @() -Sessions @((Initialize-iam.Session.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -AccountPermissions @((Initialize-iam.AccountPermissions-ClassId "ClassId_example" -ObjectType "ObjectType_example" -AccountIdentifier "AccountIdentifier_example" -AccountName "AccountName_example" -AccountStatus "AccountStatus_example" -Permissions @((Initialize-iam.PermissionReference-ClassId "ClassId_example" -ObjectType "ObjectType_example" -PermissionIdentifier "PermissionIdentifier_example" -PermissionName "PermissionName_example")))) -ClientIpAddress "ClientIpAddress_example" -Expiration Get-Date -IdleTimeExpiration Get-Date -LastLoginClient "LastLoginClient_example" -LastLoginTime Get-Date -Permission  -User )))))) -Users @())) -Qualifier (Initialize-iam.Qualifier.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Name "Name_example" -Value @("Value_example") -Usergroup ) -Users @())) -Users @()))) -Usergroups @() -Users @()))) -Usergroups @() -Users @()) -ApplianceAccount  -Groups @((Initialize-iam.LdapGroup.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Domain "Domain_example" -Name "Name_example" -EndPointRole @() -LdapPolicy )) -Organization  -Profiles @((Initialize-policy.AbstractConfigProfile.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -Type "Type_example" -SrcTemplate  -Action "Action_example" -ConfigContext )) -Providers @((Initialize-iam.LdapProvider.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Port 123 -Server "Server_example" -LdapPolicy ))) -System  -UserPreferences @() -Usergroups @() -Users @()) -PrivilegeSets @() -Privileges @() -Roles @() -ServiceProvider (Initialize-iam.ServiceProvider.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -EntityId "EntityId_example" -Metadata "Metadata_example" -Name "Name_example" -System )))) -EndPointRoles @() -Idp  -PrivilegeSets @() -Privileges @() -Roles @() -ServiceProvider (Initialize-iam.ServiceProvider.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -EntityId "EntityId_example" -Metadata "Metadata_example" -Name "Name_example" -System )))) -System )) -PrivilegeSets @() -ResourceRoles @((Initialize-iam.ResourceRoles.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -EndPointRoles @() -Permission  -PrivilegeSets @() -Resource  -Roles @())) -Roles @() -SessionLimits (Initialize-iam.SessionLimits.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -IdleTimeOut 123 -MaximumLimit 123 -PerUserLimit 123 -SessionTimeOut 123 -Account  -Permission ) -UserGroups @() -Users @()) -User )) -Permission  -Roles @() -User )) -DomainGroups @((Initialize-iam.DomainGroup.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Name "Name_example" -Partition1 123 -Partition2 123 -Partition3 123 -PartitionKey "PartitionKey_example" -Usage 123 -Account )) -EndPointRoles @() -Idpreferences @() -Idps @() -Permissions @() -PrivilegeSets @() -Privileges @() -ResourceLimits (Initialize-iam.ResourceLimits.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -PerAccountUserLimit 123 -Account ) -Roles @() -SecurityHolder (Initialize-iam.SecurityHolder.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Account  -IpRulesConfiguration (Initialize-iam.IpAccessManagement.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Enable $false -LastRecoveryTime Get-Date -Holder (Initialize-iam.SecurityHolder.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Account  -IpRulesConfiguration (Initialize-iam.IpAccessManagement.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Enable $false -LastRecoveryTime Get-Date -Holder  -IpAddresses @((Initialize-iam.IpAddress.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Address "Address_example" -Description "Description_example" -IpAccessManagement ))) -ResourcePermissions @((Initialize-iam.ResourcePermission.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -PermissionRoles @((Initialize-iam.PermissionToRoles-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Permission (Initialize-cmrf.CmRf-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example") -Roles @((Initialize-cmrf.CmRf-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example")))) -TargetApp "TargetApp_example" -Holder  -Resource ))) -IpAddresses @((Initialize-iam.IpAddress.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Address "Address_example" -Description "Description_example" -IpAccessManagement ))) -ResourcePermissions @((Initialize-iam.ResourcePermission.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -PermissionRoles @((Initialize-iam.PermissionToRoles-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Permission  -Roles @())) -TargetApp "TargetApp_example" -Holder  -Resource ))) -SessionLimits ) -OauthTokens @() -Permission  -Roles @() -User )) -DomainGroups @((Initialize-iam.DomainGroup.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Name "Name_example" -Partition1 123 -Partition2 123 -Partition3 123 -PartitionKey "PartitionKey_example" -Usage 123 -Account )) -EndPointRoles @() -Idpreferences @() -Idps @() -Permissions @() -PrivilegeSets @() -Privileges @() -ResourceLimits (Initialize-iam.ResourceLimits.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -PerAccountUserLimit 123 -Account ) -Roles @() -SecurityHolder  -SessionLimits ) -ResourceGroups @((Initialize-resource.Group.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Name "Name_example" -PerTypeCombinedSelector @((Initialize-resource.PerTypeCombinedSelector-ClassId "ClassId_example" -ObjectType "ObjectType_example" -CombinedSelector "CombinedSelector_example" -EmptyFilter $false -SelectorObjectType "SelectorObjectType_example")) -Qualifier "Qualifier_example" -Selectors @((Initialize-resource.Selector-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Selector "Selector_example")) -Account  -Organizations @()))) -RouterNodes @((Initialize-sdwan.RouterNode.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -DeviceTemplate "DeviceTemplate_example" -Name "Name_example" -NetworkConfiguration @((Initialize-sdwan.NetworkConfigurationType-ClassId "ClassId_example" -ObjectType "ObjectType_example" -NetworkType "NetworkType_example" -PortGroup "PortGroup_example" -Vlan 123)) -TemplateInputs @((Initialize-sdwan.TemplateInputsType-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Editable $false -Key "Key_example" -Required $false -Template "Template_example" -Title "Title_example" -Type "Type_example" -Value "Value_example")) -Uuid "Uuid_example" -Organization  -VarProfile (Initialize-sdwan.Profile.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -Type "Type_example" -SrcTemplate  -Action "Action_example" -ConfigContext  -Organization  -RouterNodes @((Initialize-sdwan.RouterNode.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -DeviceTemplate "DeviceTemplate_example" -Name "Name_example" -NetworkConfiguration @((Initialize-sdwan.NetworkConfigurationType-ClassId "ClassId_example" -ObjectType "ObjectType_example" -NetworkType "NetworkType_example" -PortGroup "PortGroup_example" -Vlan 123)) -TemplateInputs @((Initialize-sdwan.TemplateInputsType-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Editable $false -Key "Key_example" -Required $false -Template "Template_example" -Title "Title_example" -Type "Type_example" -Value "Value_example")) -Uuid "Uuid_example" -Organization  -VarProfile (Initialize-sdwan.Profile.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -Type "Type_example" -SrcTemplate  -Action "Action_example" -ConfigContext  -Organization  -RouterNodes @() -RouterPolicy (Initialize-sdwan.RouterPolicy.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -DeploymentSize "DeploymentSize_example" -WanCount 123 -WanTerminationType "WanTerminationType_example" -Organization  -Profiles @() -SolutionImage (Initialize-software.SolutionDistributable.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -DownloadCount 123 -ImportAction "ImportAction_example" -ImportState "ImportState_example" -ImportedTime Get-Date -LastAccessTime Get-Date -Md5eTag "Md5eTag_example" -Md5sum "Md5sum_example" -Name "Name_example" -ReleaseDate Get-Date -Sha512sum "Sha512sum_example" -Size 123 -SoftwareAdvisoryUrl "SoftwareAdvisoryUrl_example" -Source (Initialize-softwarerepository.FileServer-ClassId "ClassId_example" -ObjectType "ObjectType_example") -Version "Version_example" -BundleType "BundleType_example" -ComponentMeta @((Initialize-firmware.ComponentMeta-ClassId "ClassId_example" -ObjectType "ObjectType_example" -ComponentLabel "ComponentLabel_example" -ComponentType "ComponentType_example" -Description "Description_example" -Disruption "Disruption_example" -ImagePath "ImagePath_example" -IsOobSupported $false -Model "Model_example" -OobManageability @("OobManageability_example") -PackedVersion "PackedVersion_example" -RedfishUrl "RedfishUrl_example" -Vendor "Vendor_example")) -Guid "Guid_example" -Mdfid "Mdfid_example" -Model "Model_example" -PlatformType "PlatformType_example" -RecommendedBuild "RecommendedBuild_example" -ReleaseNotesUrl "ReleaseNotesUrl_example" -SoftwareTypeId "SoftwareTypeId_example" -SupportedModels @("SupportedModels_example") -Vendor "Vendor_example" -DistributableMetas @((Initialize-firmware.DistributableMeta.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -BucketName "BucketName_example" -FileType "FileType_example" -FromVersion "FromVersion_example" -Mdfid "Mdfid_example" -SoftwareTypeId "SoftwareTypeId_example" -Source "Source_example" -SupportedModels @("SupportedModels_example") -ToVersion "ToVersion_example")) -Release (Initialize-softwarerepository.Release.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -ReleaseDate Get-Date -ReleaseNotesUrl "ReleaseNotesUrl_example" -SupportedModels @("SupportedModels_example") -Type "Type_example" -Version "Version_example" -Catalog (Initialize-softwarerepository.Catalog.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -IsImagePullFailure $false -Name "Name_example" -Organization  -System )) -FilePath "FilePath_example" -SolutionName "SolutionName_example" -SubType "SubType_example" -Var0Version (Initialize-kubernetes.Version.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -KubernetesVersion "KubernetesVersion_example" -Name "Name_example" -BootIso (Initialize-software.SolutionDistributable.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -DownloadCount 123 -ImportAction "ImportAction_example" -ImportState "ImportState_example" -ImportedTime Get-Date -LastAccessTime Get-Date -Md5eTag "Md5eTag_example" -Md5sum "Md5sum_example" -Name "Name_example" -ReleaseDate Get-Date -Sha512sum "Sha512sum_example" -Size 123 -SoftwareAdvisoryUrl "SoftwareAdvisoryUrl_example" -Source (Initialize-softwarerepository.FileServer-ClassId "ClassId_example" -ObjectType "ObjectType_example") -Version "Version_example" -BundleType "BundleType_example" -ComponentMeta @((Initialize-firmware.ComponentMeta-ClassId "ClassId_example" -ObjectType "ObjectType_example" -ComponentLabel "ComponentLabel_example" -ComponentType "ComponentType_example" -Description "Description_example" -Disruption "Disruption_example" -ImagePath "ImagePath_example" -IsOobSupported $false -Model "Model_example" -OobManageability @("OobManageability_example") -PackedVersion "PackedVersion_example" -RedfishUrl "RedfishUrl_example" -Vendor "Vendor_example")) -Guid "Guid_example" -Mdfid "Mdfid_example" -Model "Model_example" -PlatformType "PlatformType_example" -RecommendedBuild "RecommendedBuild_example" -ReleaseNotesUrl "ReleaseNotesUrl_example" -SoftwareTypeId "SoftwareTypeId_example" -SupportedModels @("SupportedModels_example") -Vendor "Vendor_example" -DistributableMetas @((Initialize-firmware.DistributableMeta.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -BucketName "BucketName_example" -FileType "FileType_example" -FromVersion "FromVersion_example" -Mdfid "Mdfid_example" -SoftwareTypeId "SoftwareTypeId_example" -Source "Source_example" -SupportedModels @("SupportedModels_example") -ToVersion "ToVersion_example")) -Release (Initialize-softwarerepository.Release.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -ReleaseDate Get-Date -ReleaseNotesUrl "ReleaseNotesUrl_example" -SupportedModels @("SupportedModels_example") -Type "Type_example" -Version "Version_example" -Catalog (Initialize-softwarerepository.Catalog.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -IsImagePullFailure $false -Name "Name_example" -Organization  -System )) -FilePath "FilePath_example" -SolutionName "SolutionName_example" -SubType "SubType_example" -Var0Version (Initialize-kubernetes.Version.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -KubernetesVersion "KubernetesVersion_example" -Name "Name_example" -BootIso  -Catalog (Initialize-kubernetes.Catalog.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Name "Name_example" -Organization  -System ) -OvaImageTemplate  -Qcow2NodeTemplate  -Qcow2VirtualMachineTemplate ) -Var1Version  -Var2Version  -Var3Version  -Catalog ) -Catalog (Initialize-kubernetes.Catalog.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Name "Name_example" -Organization  -System ) -OvaImageTemplate  -Qcow2NodeTemplate  -Qcow2VirtualMachineTemplate ) -Var1Version  -Var2Version  -Var3Version  -Catalog )) -VmanageAccount (Initialize-sdwan.VmanageAccountPolicy.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -EndpointAddress "EndpointAddress_example" -IsPasswordSet $false -Password "Password_example" -Port 123 -Username "Username_example" -Organization  -Profiles @())) -ServerNode (Initialize-asset.DeviceRegistration.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -ApiVersion 123 -AppPartitionNumber 123 -ConnectionId "ConnectionId_example" -ConnectionReason "ConnectionReason_example" -ConnectionStatus "ConnectionStatus_example" -ConnectionStatusLastChangeTime Get-Date -ConnectorVersion "ConnectorVersion_example" -DeviceExternalIpAddress "DeviceExternalIpAddress_example" -ProxyApp "ProxyApp_example" -AccessKeyId "AccessKeyId_example" -ClaimedByUserName "ClaimedByUserName_example" -ClaimedTime Get-Date -DeviceHostname @("DeviceHostname_example") -DeviceIpAddress @("DeviceIpAddress_example") -ExecutionMode "ExecutionMode_example" -ParentSignature (Initialize-asset.ParentConnectionSignature-ClassId "ClassId_example" -ObjectType "ObjectType_example" -DeviceId "DeviceId_example" -NodeId "NodeId_example" -Signature "TODO" -TimeStamp Get-Date) -VarPid @("VarPid_example") -PlatformType "PlatformType_example" -PublicAccessKey "PublicAccessKey_example" -ReadOnly $false -Serial @("Serial_example") -Vendor "Vendor_example" -Account  -ClaimedByUser  -ClusterMembers @((Initialize-asset.ClusterMember.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -ApiVersion 123 -AppPartitionNumber 123 -ConnectionId "ConnectionId_example" -ConnectionReason "ConnectionReason_example" -ConnectionStatus "ConnectionStatus_example" -ConnectionStatusLastChangeTime Get-Date -ConnectorVersion "ConnectorVersion_example" -DeviceExternalIpAddress "DeviceExternalIpAddress_example" -ProxyApp "ProxyApp_example" -Leadership "Leadership_example" -LockedLeader $false -MemberIdentity "MemberIdentity_example" -ParentClusterMemberIdentity "ParentClusterMemberIdentity_example" -Sudi (Initialize-asset.SudiInfo-ClassId "ClassId_example" -ObjectType "ObjectType_example" -VarPid "VarPid_example" -SerialNumber "SerialNumber_example" -Signature "Signature_example" -Status "Status_example" -SudiCertificate (Initialize-x509.Certificate-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Issuer (Initialize-pkix.DistinguishedName-ClassId "ClassId_example" -ObjectType "ObjectType_example" -CommonName "CommonName_example" -Country @("Country_example") -Locality @("Locality_example") -Organization @("Organization_example") -OrganizationalUnit @("OrganizationalUnit_example") -State @("State_example")) -NotAfter Get-Date -NotBefore Get-Date -PemCertificate "PemCertificate_example" -Sha256Fingerprint "Sha256Fingerprint_example" -SignatureAlgorithm "SignatureAlgorithm_example" -Subject (Initialize-pkix.DistinguishedName-ClassId "ClassId_example" -ObjectType "ObjectType_example" -CommonName "CommonName_example" -Country @("Country_example") -Locality @("Locality_example") -Organization @("Organization_example") -OrganizationalUnit @("OrganizationalUnit_example") -State @("State_example")))) -Device (Initialize-asset.DeviceRegistration.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -ApiVersion 123 -AppPartitionNumber 123 -ConnectionId "ConnectionId_example" -ConnectionReason "ConnectionReason_example" -ConnectionStatus "ConnectionStatus_example" -ConnectionStatusLastChangeTime Get-Date -ConnectorVersion "ConnectorVersion_example" -DeviceExternalIpAddress "DeviceExternalIpAddress_example" -ProxyApp "ProxyApp_example" -AccessKeyId "AccessKeyId_example" -ClaimedByUserName "ClaimedByUserName_example" -ClaimedTime Get-Date -DeviceHostname @("DeviceHostname_example") -DeviceIpAddress @("DeviceIpAddress_example") -ExecutionMode "ExecutionMode_example" -ParentSignature (Initialize-asset.ParentConnectionSignature-ClassId "ClassId_example" -ObjectType "ObjectType_example" -DeviceId "DeviceId_example" -NodeId "NodeId_example" -Signature "TODO" -TimeStamp Get-Date) -VarPid @("VarPid_example") -PlatformType "PlatformType_example" -PublicAccessKey "PublicAccessKey_example" -ReadOnly $false -Serial @("Serial_example") -Vendor "Vendor_example" -Account  -ClaimedByUser  -ClusterMembers @((Initialize-asset.ClusterMember.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -ApiVersion 123 -AppPartitionNumber 123 -ConnectionId "ConnectionId_example" -ConnectionReason "ConnectionReason_example" -ConnectionStatus "ConnectionStatus_example" -ConnectionStatusLastChangeTime Get-Date -ConnectorVersion "ConnectorVersion_example" -DeviceExternalIpAddress "DeviceExternalIpAddress_example" -ProxyApp "ProxyApp_example" -Leadership "Leadership_example" -LockedLeader $false -MemberIdentity "MemberIdentity_example" -ParentClusterMemberIdentity "ParentClusterMemberIdentity_example" -Sudi (Initialize-asset.SudiInfo-ClassId "ClassId_example" -ObjectType "ObjectType_example" -VarPid "VarPid_example" -SerialNumber "SerialNumber_example" -Signature "Signature_example" -Status "Status_example" -SudiCertificate (Initialize-x509.Certificate-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Issuer  -NotAfter Get-Date -NotBefore Get-Date -PemCertificate "PemCertificate_example" -Sha256Fingerprint "Sha256Fingerprint_example" -SignatureAlgorithm "SignatureAlgorithm_example" -Subject )) -Device )) -DeviceClaim (Initialize-asset.DeviceClaim.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -DeviceUpdates @((Initialize-asset.ConnectionControlMessage-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Account "Account_example" -ConnectorVersion "ConnectorVersion_example" -DeviceId "DeviceId_example" -DomainGroup "DomainGroup_example" -Evict $false -Leadership "Leadership_example" -NewIdentity "NewIdentity_example" -Partition 123)) -SecurityToken "SecurityToken_example" -SerialNumber "SerialNumber_example" -Account  -Device ) -DeviceConfiguration (Initialize-asset.DeviceConfiguration.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -LocalConfigurationLocked $false -LogLevel "LogLevel_example" -Device ) -DomainGroup  -ParentConnection ))) -DeviceClaim (Initialize-asset.DeviceClaim.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -DeviceUpdates @((Initialize-asset.ConnectionControlMessage-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Account "Account_example" -ConnectorVersion "ConnectorVersion_example" -DeviceId "DeviceId_example" -DomainGroup "DomainGroup_example" -Evict $false -Leadership "Leadership_example" -NewIdentity "NewIdentity_example" -Partition 123)) -SecurityToken "SecurityToken_example" -SerialNumber "SerialNumber_example" -Account  -Device ) -DeviceConfiguration (Initialize-asset.DeviceConfiguration.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -LocalConfigurationLocked $false -LogLevel "LogLevel_example" -Device ) -DomainGroup  -ParentConnection ))) -RouterPolicy (Initialize-sdwan.RouterPolicy.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -DeploymentSize "DeploymentSize_example" -WanCount 123 -WanTerminationType "WanTerminationType_example" -Organization  -Profiles @() -SolutionImage ) -VmanageAccount (Initialize-sdwan.VmanageAccountPolicy.Relationship-ClassId "ClassId_example" -ObjectType "ObjectType_example" -Moid "Moid_example" -Selector "Selector_example" -Link "Link_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -EndpointAddress "EndpointAddress_example" -IsPasswordSet $false -Password "Password_example" -Port 123 -Username "Username_example" -Organization  -Profiles @())) -ServerNode )) -RouterPolicy  -VmanageAccount ) # SdwanProfile | The 'sdwan.Profile' resource to create.
$IfMatch = "IfMatch_example" # String | For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. (optional)
$IfNoneMatch = "IfNoneMatch_example" # String | For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn't happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource's ETag doesn't match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don't have to be identical byte for byte. (optional)

# Create a 'sdwan.Profile' resource.
try {
     $Result = New-IntersightSdwanProfile -SdwanProfile $SdwanProfile -IfMatch $IfMatch -IfNoneMatch $IfNoneMatch
} catch {
    Write-Host ("Exception occured when calling New-IntersightSdwanProfile: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **SdwanProfile** | [**SdwanProfile**](SdwanProfile.md)| The &#39;sdwan.Profile&#39; resource to create. | 
 **IfMatch** | **String**| For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. | [optional] 
 **IfNoneMatch** | **String**| For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn&#39;t happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource&#39;s ETag doesn&#39;t match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don&#39;t have to be identical byte for byte. | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanProfile**](SdwanProfile.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="New-IntersightSdwanRouterNode"></a>
# **New-IntersightSdwanRouterNode**
> SdwanRouterNode New-IntersightSdwanRouterNode<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SdwanRouterNode] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IfMatch] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IfNoneMatch] <String><br>

Create a 'sdwan.RouterNode' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$SdwanRouterNode = (Initialize-sdwan.RouterNode-ClassId "ClassId_example" -ObjectType "ObjectType_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Moid "Moid_example" -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -DeviceTemplate "DeviceTemplate_example" -Name "Name_example" -NetworkConfiguration @() -TemplateInputs @() -Uuid "Uuid_example" -Organization  -VarProfile  -ServerNode ) # SdwanRouterNode | The 'sdwan.RouterNode' resource to create.
$IfMatch = "IfMatch_example" # String | For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. (optional)
$IfNoneMatch = "IfNoneMatch_example" # String | For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn't happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource's ETag doesn't match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don't have to be identical byte for byte. (optional)

# Create a 'sdwan.RouterNode' resource.
try {
     $Result = New-IntersightSdwanRouterNode -SdwanRouterNode $SdwanRouterNode -IfMatch $IfMatch -IfNoneMatch $IfNoneMatch
} catch {
    Write-Host ("Exception occured when calling New-IntersightSdwanRouterNode: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **SdwanRouterNode** | [**SdwanRouterNode**](SdwanRouterNode.md)| The &#39;sdwan.RouterNode&#39; resource to create. | 
 **IfMatch** | **String**| For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. | [optional] 
 **IfNoneMatch** | **String**| For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn&#39;t happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource&#39;s ETag doesn&#39;t match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don&#39;t have to be identical byte for byte. | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanRouterNode**](SdwanRouterNode.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="New-IntersightSdwanRouterPolicy"></a>
# **New-IntersightSdwanRouterPolicy**
> SdwanRouterPolicy New-IntersightSdwanRouterPolicy<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SdwanRouterPolicy] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IfMatch] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IfNoneMatch] <String><br>

Create a 'sdwan.RouterPolicy' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$SdwanRouterPolicy = (Initialize-sdwan.RouterPolicy-ClassId "ClassId_example" -ObjectType "ObjectType_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Moid "Moid_example" -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -DeploymentSize "DeploymentSize_example" -WanCount 123 -WanTerminationType "WanTerminationType_example" -Organization  -Profiles @() -SolutionImage ) # SdwanRouterPolicy | The 'sdwan.RouterPolicy' resource to create.
$IfMatch = "IfMatch_example" # String | For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. (optional)
$IfNoneMatch = "IfNoneMatch_example" # String | For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn't happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource's ETag doesn't match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don't have to be identical byte for byte. (optional)

# Create a 'sdwan.RouterPolicy' resource.
try {
     $Result = New-IntersightSdwanRouterPolicy -SdwanRouterPolicy $SdwanRouterPolicy -IfMatch $IfMatch -IfNoneMatch $IfNoneMatch
} catch {
    Write-Host ("Exception occured when calling New-IntersightSdwanRouterPolicy: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **SdwanRouterPolicy** | [**SdwanRouterPolicy**](SdwanRouterPolicy.md)| The &#39;sdwan.RouterPolicy&#39; resource to create. | 
 **IfMatch** | **String**| For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. | [optional] 
 **IfNoneMatch** | **String**| For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn&#39;t happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource&#39;s ETag doesn&#39;t match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don&#39;t have to be identical byte for byte. | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanRouterPolicy**](SdwanRouterPolicy.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="New-IntersightSdwanVmanageAccountPolicy"></a>
# **New-IntersightSdwanVmanageAccountPolicy**
> SdwanVmanageAccountPolicy New-IntersightSdwanVmanageAccountPolicy<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SdwanVmanageAccountPolicy] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IfMatch] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IfNoneMatch] <String><br>

Create a 'sdwan.VmanageAccountPolicy' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$SdwanVmanageAccountPolicy = (Initialize-sdwan.VmanageAccountPolicy-ClassId "ClassId_example" -ObjectType "ObjectType_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Moid "Moid_example" -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -EndpointAddress "EndpointAddress_example" -IsPasswordSet $false -Password "Password_example" -Port 123 -Username "Username_example" -Organization  -Profiles @()) # SdwanVmanageAccountPolicy | The 'sdwan.VmanageAccountPolicy' resource to create.
$IfMatch = "IfMatch_example" # String | For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. (optional)
$IfNoneMatch = "IfNoneMatch_example" # String | For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn't happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource's ETag doesn't match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don't have to be identical byte for byte. (optional)

# Create a 'sdwan.VmanageAccountPolicy' resource.
try {
     $Result = New-IntersightSdwanVmanageAccountPolicy -SdwanVmanageAccountPolicy $SdwanVmanageAccountPolicy -IfMatch $IfMatch -IfNoneMatch $IfNoneMatch
} catch {
    Write-Host ("Exception occured when calling New-IntersightSdwanVmanageAccountPolicy: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **SdwanVmanageAccountPolicy** | [**SdwanVmanageAccountPolicy**](SdwanVmanageAccountPolicy.md)| The &#39;sdwan.VmanageAccountPolicy&#39; resource to create. | 
 **IfMatch** | **String**| For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. | [optional] 
 **IfNoneMatch** | **String**| For methods that apply server-side changes, If-None-Match used with the * value can be used to create a resource not known to exist, guaranteeing that another resource creation didn&#39;t happen before, losing the data of the previous put. The request will be processed only if the eventually existing resource&#39;s ETag doesn&#39;t match any of the values listed. Otherwise, the status code 412 (Precondition Failed) is used. The asterisk is a special value representing any resource. It is only useful when creating a resource, usually with PUT, to check if another resource with the identity has already been created before. The comparison with the stored ETag uses the weak comparison algorithm, meaning two resources are considered identical if the content is equivalent - they don&#39;t have to be identical byte for byte. | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanVmanageAccountPolicy**](SdwanVmanageAccountPolicy.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Remove-IntersightSdwanProfile"></a>
# **Remove-IntersightSdwanProfile**
> void Remove-IntersightSdwanProfile<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>

Delete a 'sdwan.Profile' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.

# Delete a 'sdwan.Profile' resource.
try {
     $Result = Remove-IntersightSdwanProfile -Moid $Moid
} catch {
    Write-Host ("Exception occured when calling Remove-IntersightSdwanProfile: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Remove-IntersightSdwanRouterNode"></a>
# **Remove-IntersightSdwanRouterNode**
> void Remove-IntersightSdwanRouterNode<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>

Delete a 'sdwan.RouterNode' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.

# Delete a 'sdwan.RouterNode' resource.
try {
     $Result = Remove-IntersightSdwanRouterNode -Moid $Moid
} catch {
    Write-Host ("Exception occured when calling Remove-IntersightSdwanRouterNode: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Remove-IntersightSdwanRouterPolicy"></a>
# **Remove-IntersightSdwanRouterPolicy**
> void Remove-IntersightSdwanRouterPolicy<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>

Delete a 'sdwan.RouterPolicy' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.

# Delete a 'sdwan.RouterPolicy' resource.
try {
     $Result = Remove-IntersightSdwanRouterPolicy -Moid $Moid
} catch {
    Write-Host ("Exception occured when calling Remove-IntersightSdwanRouterPolicy: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Remove-IntersightSdwanVmanageAccountPolicy"></a>
# **Remove-IntersightSdwanVmanageAccountPolicy**
> void Remove-IntersightSdwanVmanageAccountPolicy<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>

Delete a 'sdwan.VmanageAccountPolicy' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.

# Delete a 'sdwan.VmanageAccountPolicy' resource.
try {
     $Result = Remove-IntersightSdwanVmanageAccountPolicy -Moid $Moid
} catch {
    Write-Host ("Exception occured when calling Remove-IntersightSdwanVmanageAccountPolicy: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
void (empty response body)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightSdwanProfileByMoid"></a>
# **Get-IntersightSdwanProfileByMoid**
> SdwanProfile Get-IntersightSdwanProfileByMoid<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>

Read a 'sdwan.Profile' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.

# Read a 'sdwan.Profile' resource.
try {
     $Result = Get-IntersightSdwanProfileByMoid -Moid $Moid
} catch {
    Write-Host ("Exception occured when calling Get-IntersightSdwanProfileByMoid: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanProfile**](SdwanProfile.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightSdwanProfileList"></a>
# **Get-IntersightSdwanProfileList**
> SdwanProfileResponse Get-IntersightSdwanProfileList<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-VarFilter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Select] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Expand] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Apply] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Count] <System.Nullable[Boolean]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Inlinecount] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-At] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Tags] <String><br>

Read a 'sdwan.Profile' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$VarFilter = "VarFilter_example" # String | Filter criteria for the resources to return. A URI with a $filter query option identifies a subset of the entries from the Collection of Entries. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the $filter option. The expression language that is used in $filter queries supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false). (optional) (default to "")
$Orderby = "Orderby_example" # String | Determines what properties are used to sort the collection of resources. (optional)
$Top = 987 # Int32 | Specifies the maximum number of resources to return in the response. (optional) (default to 100)
$Skip = 987 # Int32 | Specifies the number of resources to skip in the response. (optional) (default to 0)
$Select = "Select_example" # String | Specifies a subset of properties to return. (optional) (default to "")
$Expand = "Expand_example" # String | Specify additional attributes or related resources to return in addition to the primary resources. (optional)
$Apply = "Apply_example" # String | Specify one or more transformation operations to perform aggregation on the resources. The transformations are processed in order with the output from a transformation being used as input for the subsequent transformation. The ""$apply"" query takes a sequence of set transformations, separated by forward slashes to express that they are consecutively applied, i.e. the result of each transformation is the input to the next transformation. Supported aggregation methods are ""aggregate"" and ""groupby"". The **aggregate** transformation takes a comma-separated list of one or more aggregate expressions as parameters and returns a result set with a single instance, representing the aggregated value for all instances in the input set. The **groupby** transformation takes one or two parameters and 1. Splits the initial set into subsets where all instances in a subset have the same values for the grouping properties specified in the first parameter, 2. Applies set transformations to each subset according to the second parameter, resulting in a new set of potentially different structure and cardinality, 3. Ensures that the instances in the result set contain all grouping properties with the correct values for the group, 4. Concatenates the intermediate result sets into one result set. A groupby transformation affects the structure of the result set. (optional)
$Count = false # Boolean | The $count query specifies the service should return the count of the matching resources, instead of returning the resources. (optional)
$Inlinecount = "Inlinecount_example" # String | The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response. (optional) (default to "allpages")
$At = "At_example" # String | Similar to ""$filter"", but ""at"" is specifically used to filter versioning information properties for resources to return. A URI with an ""at"" Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in at operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. (optional)
$Tags = "Tags_example" # String | The 'tags' parameter is used to request a summary of the Tag utilization for this resource. When the 'tags' parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key. (optional)

# Read a 'sdwan.Profile' resource.
try {
     $Result = Get-IntersightSdwanProfileList -VarFilter $VarFilter -Orderby $Orderby -Top $Top -Skip $Skip -Select $Select -Expand $Expand -Apply $Apply -Count $Count -Inlinecount $Inlinecount -At $At -Tags $Tags
} catch {
    Write-Host ("Exception occured when calling Get-IntersightSdwanProfileList: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **VarFilter** | **String**| Filter criteria for the resources to return. A URI with a $filter query option identifies a subset of the entries from the Collection of Entries. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the $filter option. The expression language that is used in $filter queries supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false). | [optional] [default to &quot;&quot;]
 **Orderby** | **String**| Determines what properties are used to sort the collection of resources. | [optional] 
 **Top** | **Int32**| Specifies the maximum number of resources to return in the response. | [optional] [default to 100]
 **Skip** | **Int32**| Specifies the number of resources to skip in the response. | [optional] [default to 0]
 **Select** | **String**| Specifies a subset of properties to return. | [optional] [default to &quot;&quot;]
 **Expand** | **String**| Specify additional attributes or related resources to return in addition to the primary resources. | [optional] 
 **Apply** | **String**| Specify one or more transformation operations to perform aggregation on the resources. The transformations are processed in order with the output from a transformation being used as input for the subsequent transformation. The &quot;&quot;$apply&quot;&quot; query takes a sequence of set transformations, separated by forward slashes to express that they are consecutively applied, i.e. the result of each transformation is the input to the next transformation. Supported aggregation methods are &quot;&quot;aggregate&quot;&quot; and &quot;&quot;groupby&quot;&quot;. The **aggregate** transformation takes a comma-separated list of one or more aggregate expressions as parameters and returns a result set with a single instance, representing the aggregated value for all instances in the input set. The **groupby** transformation takes one or two parameters and 1. Splits the initial set into subsets where all instances in a subset have the same values for the grouping properties specified in the first parameter, 2. Applies set transformations to each subset according to the second parameter, resulting in a new set of potentially different structure and cardinality, 3. Ensures that the instances in the result set contain all grouping properties with the correct values for the group, 4. Concatenates the intermediate result sets into one result set. A groupby transformation affects the structure of the result set. | [optional] 
 **Count** | **Boolean**| The $count query specifies the service should return the count of the matching resources, instead of returning the resources. | [optional] 
 **Inlinecount** | **String**| The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response. | [optional] [default to &quot;allpages&quot;]
 **At** | **String**| Similar to &quot;&quot;$filter&quot;&quot;, but &quot;&quot;at&quot;&quot; is specifically used to filter versioning information properties for resources to return. A URI with an &quot;&quot;at&quot;&quot; Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in at operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. | [optional] 
 **Tags** | **String**| The &#39;tags&#39; parameter is used to request a summary of the Tag utilization for this resource. When the &#39;tags&#39; parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key. | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanProfileResponse**](SdwanProfileResponse.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightSdwanRouterNodeByMoid"></a>
# **Get-IntersightSdwanRouterNodeByMoid**
> SdwanRouterNode Get-IntersightSdwanRouterNodeByMoid<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>

Read a 'sdwan.RouterNode' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.

# Read a 'sdwan.RouterNode' resource.
try {
     $Result = Get-IntersightSdwanRouterNodeByMoid -Moid $Moid
} catch {
    Write-Host ("Exception occured when calling Get-IntersightSdwanRouterNodeByMoid: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanRouterNode**](SdwanRouterNode.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightSdwanRouterNodeList"></a>
# **Get-IntersightSdwanRouterNodeList**
> SdwanRouterNodeResponse Get-IntersightSdwanRouterNodeList<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-VarFilter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Select] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Expand] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Apply] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Count] <System.Nullable[Boolean]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Inlinecount] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-At] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Tags] <String><br>

Read a 'sdwan.RouterNode' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$VarFilter = "VarFilter_example" # String | Filter criteria for the resources to return. A URI with a $filter query option identifies a subset of the entries from the Collection of Entries. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the $filter option. The expression language that is used in $filter queries supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false). (optional) (default to "")
$Orderby = "Orderby_example" # String | Determines what properties are used to sort the collection of resources. (optional)
$Top = 987 # Int32 | Specifies the maximum number of resources to return in the response. (optional) (default to 100)
$Skip = 987 # Int32 | Specifies the number of resources to skip in the response. (optional) (default to 0)
$Select = "Select_example" # String | Specifies a subset of properties to return. (optional) (default to "")
$Expand = "Expand_example" # String | Specify additional attributes or related resources to return in addition to the primary resources. (optional)
$Apply = "Apply_example" # String | Specify one or more transformation operations to perform aggregation on the resources. The transformations are processed in order with the output from a transformation being used as input for the subsequent transformation. The ""$apply"" query takes a sequence of set transformations, separated by forward slashes to express that they are consecutively applied, i.e. the result of each transformation is the input to the next transformation. Supported aggregation methods are ""aggregate"" and ""groupby"". The **aggregate** transformation takes a comma-separated list of one or more aggregate expressions as parameters and returns a result set with a single instance, representing the aggregated value for all instances in the input set. The **groupby** transformation takes one or two parameters and 1. Splits the initial set into subsets where all instances in a subset have the same values for the grouping properties specified in the first parameter, 2. Applies set transformations to each subset according to the second parameter, resulting in a new set of potentially different structure and cardinality, 3. Ensures that the instances in the result set contain all grouping properties with the correct values for the group, 4. Concatenates the intermediate result sets into one result set. A groupby transformation affects the structure of the result set. (optional)
$Count = false # Boolean | The $count query specifies the service should return the count of the matching resources, instead of returning the resources. (optional)
$Inlinecount = "Inlinecount_example" # String | The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response. (optional) (default to "allpages")
$At = "At_example" # String | Similar to ""$filter"", but ""at"" is specifically used to filter versioning information properties for resources to return. A URI with an ""at"" Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in at operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. (optional)
$Tags = "Tags_example" # String | The 'tags' parameter is used to request a summary of the Tag utilization for this resource. When the 'tags' parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key. (optional)

# Read a 'sdwan.RouterNode' resource.
try {
     $Result = Get-IntersightSdwanRouterNodeList -VarFilter $VarFilter -Orderby $Orderby -Top $Top -Skip $Skip -Select $Select -Expand $Expand -Apply $Apply -Count $Count -Inlinecount $Inlinecount -At $At -Tags $Tags
} catch {
    Write-Host ("Exception occured when calling Get-IntersightSdwanRouterNodeList: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **VarFilter** | **String**| Filter criteria for the resources to return. A URI with a $filter query option identifies a subset of the entries from the Collection of Entries. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the $filter option. The expression language that is used in $filter queries supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false). | [optional] [default to &quot;&quot;]
 **Orderby** | **String**| Determines what properties are used to sort the collection of resources. | [optional] 
 **Top** | **Int32**| Specifies the maximum number of resources to return in the response. | [optional] [default to 100]
 **Skip** | **Int32**| Specifies the number of resources to skip in the response. | [optional] [default to 0]
 **Select** | **String**| Specifies a subset of properties to return. | [optional] [default to &quot;&quot;]
 **Expand** | **String**| Specify additional attributes or related resources to return in addition to the primary resources. | [optional] 
 **Apply** | **String**| Specify one or more transformation operations to perform aggregation on the resources. The transformations are processed in order with the output from a transformation being used as input for the subsequent transformation. The &quot;&quot;$apply&quot;&quot; query takes a sequence of set transformations, separated by forward slashes to express that they are consecutively applied, i.e. the result of each transformation is the input to the next transformation. Supported aggregation methods are &quot;&quot;aggregate&quot;&quot; and &quot;&quot;groupby&quot;&quot;. The **aggregate** transformation takes a comma-separated list of one or more aggregate expressions as parameters and returns a result set with a single instance, representing the aggregated value for all instances in the input set. The **groupby** transformation takes one or two parameters and 1. Splits the initial set into subsets where all instances in a subset have the same values for the grouping properties specified in the first parameter, 2. Applies set transformations to each subset according to the second parameter, resulting in a new set of potentially different structure and cardinality, 3. Ensures that the instances in the result set contain all grouping properties with the correct values for the group, 4. Concatenates the intermediate result sets into one result set. A groupby transformation affects the structure of the result set. | [optional] 
 **Count** | **Boolean**| The $count query specifies the service should return the count of the matching resources, instead of returning the resources. | [optional] 
 **Inlinecount** | **String**| The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response. | [optional] [default to &quot;allpages&quot;]
 **At** | **String**| Similar to &quot;&quot;$filter&quot;&quot;, but &quot;&quot;at&quot;&quot; is specifically used to filter versioning information properties for resources to return. A URI with an &quot;&quot;at&quot;&quot; Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in at operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. | [optional] 
 **Tags** | **String**| The &#39;tags&#39; parameter is used to request a summary of the Tag utilization for this resource. When the &#39;tags&#39; parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key. | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanRouterNodeResponse**](SdwanRouterNodeResponse.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightSdwanRouterPolicyByMoid"></a>
# **Get-IntersightSdwanRouterPolicyByMoid**
> SdwanRouterPolicy Get-IntersightSdwanRouterPolicyByMoid<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>

Read a 'sdwan.RouterPolicy' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.

# Read a 'sdwan.RouterPolicy' resource.
try {
     $Result = Get-IntersightSdwanRouterPolicyByMoid -Moid $Moid
} catch {
    Write-Host ("Exception occured when calling Get-IntersightSdwanRouterPolicyByMoid: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanRouterPolicy**](SdwanRouterPolicy.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightSdwanRouterPolicyList"></a>
# **Get-IntersightSdwanRouterPolicyList**
> SdwanRouterPolicyResponse Get-IntersightSdwanRouterPolicyList<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-VarFilter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Select] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Expand] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Apply] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Count] <System.Nullable[Boolean]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Inlinecount] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-At] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Tags] <String><br>

Read a 'sdwan.RouterPolicy' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$VarFilter = "VarFilter_example" # String | Filter criteria for the resources to return. A URI with a $filter query option identifies a subset of the entries from the Collection of Entries. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the $filter option. The expression language that is used in $filter queries supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false). (optional) (default to "")
$Orderby = "Orderby_example" # String | Determines what properties are used to sort the collection of resources. (optional)
$Top = 987 # Int32 | Specifies the maximum number of resources to return in the response. (optional) (default to 100)
$Skip = 987 # Int32 | Specifies the number of resources to skip in the response. (optional) (default to 0)
$Select = "Select_example" # String | Specifies a subset of properties to return. (optional) (default to "")
$Expand = "Expand_example" # String | Specify additional attributes or related resources to return in addition to the primary resources. (optional)
$Apply = "Apply_example" # String | Specify one or more transformation operations to perform aggregation on the resources. The transformations are processed in order with the output from a transformation being used as input for the subsequent transformation. The ""$apply"" query takes a sequence of set transformations, separated by forward slashes to express that they are consecutively applied, i.e. the result of each transformation is the input to the next transformation. Supported aggregation methods are ""aggregate"" and ""groupby"". The **aggregate** transformation takes a comma-separated list of one or more aggregate expressions as parameters and returns a result set with a single instance, representing the aggregated value for all instances in the input set. The **groupby** transformation takes one or two parameters and 1. Splits the initial set into subsets where all instances in a subset have the same values for the grouping properties specified in the first parameter, 2. Applies set transformations to each subset according to the second parameter, resulting in a new set of potentially different structure and cardinality, 3. Ensures that the instances in the result set contain all grouping properties with the correct values for the group, 4. Concatenates the intermediate result sets into one result set. A groupby transformation affects the structure of the result set. (optional)
$Count = false # Boolean | The $count query specifies the service should return the count of the matching resources, instead of returning the resources. (optional)
$Inlinecount = "Inlinecount_example" # String | The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response. (optional) (default to "allpages")
$At = "At_example" # String | Similar to ""$filter"", but ""at"" is specifically used to filter versioning information properties for resources to return. A URI with an ""at"" Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in at operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. (optional)
$Tags = "Tags_example" # String | The 'tags' parameter is used to request a summary of the Tag utilization for this resource. When the 'tags' parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key. (optional)

# Read a 'sdwan.RouterPolicy' resource.
try {
     $Result = Get-IntersightSdwanRouterPolicyList -VarFilter $VarFilter -Orderby $Orderby -Top $Top -Skip $Skip -Select $Select -Expand $Expand -Apply $Apply -Count $Count -Inlinecount $Inlinecount -At $At -Tags $Tags
} catch {
    Write-Host ("Exception occured when calling Get-IntersightSdwanRouterPolicyList: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **VarFilter** | **String**| Filter criteria for the resources to return. A URI with a $filter query option identifies a subset of the entries from the Collection of Entries. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the $filter option. The expression language that is used in $filter queries supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false). | [optional] [default to &quot;&quot;]
 **Orderby** | **String**| Determines what properties are used to sort the collection of resources. | [optional] 
 **Top** | **Int32**| Specifies the maximum number of resources to return in the response. | [optional] [default to 100]
 **Skip** | **Int32**| Specifies the number of resources to skip in the response. | [optional] [default to 0]
 **Select** | **String**| Specifies a subset of properties to return. | [optional] [default to &quot;&quot;]
 **Expand** | **String**| Specify additional attributes or related resources to return in addition to the primary resources. | [optional] 
 **Apply** | **String**| Specify one or more transformation operations to perform aggregation on the resources. The transformations are processed in order with the output from a transformation being used as input for the subsequent transformation. The &quot;&quot;$apply&quot;&quot; query takes a sequence of set transformations, separated by forward slashes to express that they are consecutively applied, i.e. the result of each transformation is the input to the next transformation. Supported aggregation methods are &quot;&quot;aggregate&quot;&quot; and &quot;&quot;groupby&quot;&quot;. The **aggregate** transformation takes a comma-separated list of one or more aggregate expressions as parameters and returns a result set with a single instance, representing the aggregated value for all instances in the input set. The **groupby** transformation takes one or two parameters and 1. Splits the initial set into subsets where all instances in a subset have the same values for the grouping properties specified in the first parameter, 2. Applies set transformations to each subset according to the second parameter, resulting in a new set of potentially different structure and cardinality, 3. Ensures that the instances in the result set contain all grouping properties with the correct values for the group, 4. Concatenates the intermediate result sets into one result set. A groupby transformation affects the structure of the result set. | [optional] 
 **Count** | **Boolean**| The $count query specifies the service should return the count of the matching resources, instead of returning the resources. | [optional] 
 **Inlinecount** | **String**| The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response. | [optional] [default to &quot;allpages&quot;]
 **At** | **String**| Similar to &quot;&quot;$filter&quot;&quot;, but &quot;&quot;at&quot;&quot; is specifically used to filter versioning information properties for resources to return. A URI with an &quot;&quot;at&quot;&quot; Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in at operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. | [optional] 
 **Tags** | **String**| The &#39;tags&#39; parameter is used to request a summary of the Tag utilization for this resource. When the &#39;tags&#39; parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key. | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanRouterPolicyResponse**](SdwanRouterPolicyResponse.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightSdwanVmanageAccountPolicyByMoid"></a>
# **Get-IntersightSdwanVmanageAccountPolicyByMoid**
> SdwanVmanageAccountPolicy Get-IntersightSdwanVmanageAccountPolicyByMoid<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>

Read a 'sdwan.VmanageAccountPolicy' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.

# Read a 'sdwan.VmanageAccountPolicy' resource.
try {
     $Result = Get-IntersightSdwanVmanageAccountPolicyByMoid -Moid $Moid
} catch {
    Write-Host ("Exception occured when calling Get-IntersightSdwanVmanageAccountPolicyByMoid: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanVmanageAccountPolicy**](SdwanVmanageAccountPolicy.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Get-IntersightSdwanVmanageAccountPolicyList"></a>
# **Get-IntersightSdwanVmanageAccountPolicyList**
> SdwanVmanageAccountPolicyResponse Get-IntersightSdwanVmanageAccountPolicyList<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-VarFilter] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Orderby] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Top] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Skip] <System.Nullable[Int32]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Select] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Expand] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Apply] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Count] <System.Nullable[Boolean]><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Inlinecount] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-At] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Tags] <String><br>

Read a 'sdwan.VmanageAccountPolicy' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$VarFilter = "VarFilter_example" # String | Filter criteria for the resources to return. A URI with a $filter query option identifies a subset of the entries from the Collection of Entries. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the $filter option. The expression language that is used in $filter queries supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false). (optional) (default to "")
$Orderby = "Orderby_example" # String | Determines what properties are used to sort the collection of resources. (optional)
$Top = 987 # Int32 | Specifies the maximum number of resources to return in the response. (optional) (default to 100)
$Skip = 987 # Int32 | Specifies the number of resources to skip in the response. (optional) (default to 0)
$Select = "Select_example" # String | Specifies a subset of properties to return. (optional) (default to "")
$Expand = "Expand_example" # String | Specify additional attributes or related resources to return in addition to the primary resources. (optional)
$Apply = "Apply_example" # String | Specify one or more transformation operations to perform aggregation on the resources. The transformations are processed in order with the output from a transformation being used as input for the subsequent transformation. The ""$apply"" query takes a sequence of set transformations, separated by forward slashes to express that they are consecutively applied, i.e. the result of each transformation is the input to the next transformation. Supported aggregation methods are ""aggregate"" and ""groupby"". The **aggregate** transformation takes a comma-separated list of one or more aggregate expressions as parameters and returns a result set with a single instance, representing the aggregated value for all instances in the input set. The **groupby** transformation takes one or two parameters and 1. Splits the initial set into subsets where all instances in a subset have the same values for the grouping properties specified in the first parameter, 2. Applies set transformations to each subset according to the second parameter, resulting in a new set of potentially different structure and cardinality, 3. Ensures that the instances in the result set contain all grouping properties with the correct values for the group, 4. Concatenates the intermediate result sets into one result set. A groupby transformation affects the structure of the result set. (optional)
$Count = false # Boolean | The $count query specifies the service should return the count of the matching resources, instead of returning the resources. (optional)
$Inlinecount = "Inlinecount_example" # String | The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response. (optional) (default to "allpages")
$At = "At_example" # String | Similar to ""$filter"", but ""at"" is specifically used to filter versioning information properties for resources to return. A URI with an ""at"" Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in at operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. (optional)
$Tags = "Tags_example" # String | The 'tags' parameter is used to request a summary of the Tag utilization for this resource. When the 'tags' parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key. (optional)

# Read a 'sdwan.VmanageAccountPolicy' resource.
try {
     $Result = Get-IntersightSdwanVmanageAccountPolicyList -VarFilter $VarFilter -Orderby $Orderby -Top $Top -Skip $Skip -Select $Select -Expand $Expand -Apply $Apply -Count $Count -Inlinecount $Inlinecount -At $At -Tags $Tags
} catch {
    Write-Host ("Exception occured when calling Get-IntersightSdwanVmanageAccountPolicyList: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **VarFilter** | **String**| Filter criteria for the resources to return. A URI with a $filter query option identifies a subset of the entries from the Collection of Entries. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the $filter option. The expression language that is used in $filter queries supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false). | [optional] [default to &quot;&quot;]
 **Orderby** | **String**| Determines what properties are used to sort the collection of resources. | [optional] 
 **Top** | **Int32**| Specifies the maximum number of resources to return in the response. | [optional] [default to 100]
 **Skip** | **Int32**| Specifies the number of resources to skip in the response. | [optional] [default to 0]
 **Select** | **String**| Specifies a subset of properties to return. | [optional] [default to &quot;&quot;]
 **Expand** | **String**| Specify additional attributes or related resources to return in addition to the primary resources. | [optional] 
 **Apply** | **String**| Specify one or more transformation operations to perform aggregation on the resources. The transformations are processed in order with the output from a transformation being used as input for the subsequent transformation. The &quot;&quot;$apply&quot;&quot; query takes a sequence of set transformations, separated by forward slashes to express that they are consecutively applied, i.e. the result of each transformation is the input to the next transformation. Supported aggregation methods are &quot;&quot;aggregate&quot;&quot; and &quot;&quot;groupby&quot;&quot;. The **aggregate** transformation takes a comma-separated list of one or more aggregate expressions as parameters and returns a result set with a single instance, representing the aggregated value for all instances in the input set. The **groupby** transformation takes one or two parameters and 1. Splits the initial set into subsets where all instances in a subset have the same values for the grouping properties specified in the first parameter, 2. Applies set transformations to each subset according to the second parameter, resulting in a new set of potentially different structure and cardinality, 3. Ensures that the instances in the result set contain all grouping properties with the correct values for the group, 4. Concatenates the intermediate result sets into one result set. A groupby transformation affects the structure of the result set. | [optional] 
 **Count** | **Boolean**| The $count query specifies the service should return the count of the matching resources, instead of returning the resources. | [optional] 
 **Inlinecount** | **String**| The $inlinecount query option allows clients to request an inline count of the matching resources included with the resources in the response. | [optional] [default to &quot;allpages&quot;]
 **At** | **String**| Similar to &quot;&quot;$filter&quot;&quot;, but &quot;&quot;at&quot;&quot; is specifically used to filter versioning information properties for resources to return. A URI with an &quot;&quot;at&quot;&quot; Query Option identifies a subset of the Entries from the Collection of Entries identified by the Resource Path section of the URI. The subset is determined by selecting only the Entries that satisfy the predicate expression specified by the query option. The expression language that is used in at operators supports references to properties and literals. The literal values can be strings enclosed in single quotes, numbers and boolean values (true or false) or any of the additional literal representations shown in the Abstract Type System section. | [optional] 
 **Tags** | **String**| The &#39;tags&#39; parameter is used to request a summary of the Tag utilization for this resource. When the &#39;tags&#39; parameter is specified, the response provides a list of tag keys, the number of times the key has been used across all documents, and the tag values that have been assigned to the tag key. | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanVmanageAccountPolicyResponse**](SdwanVmanageAccountPolicyResponse.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/csv, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Set-IntersightSdwanProfile"></a>
# **Set-IntersightSdwanProfile**
> SdwanProfile Set-IntersightSdwanProfile<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SdwanProfile] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IfMatch] <String><br>

Update a 'sdwan.Profile' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.
$SdwanProfile = (Initialize-sdwan.Profile-ClassId "ClassId_example" -ObjectType "ObjectType_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Moid "Moid_example" -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -Type "Type_example" -SrcTemplate  -Action "Action_example" -ConfigContext  -Organization  -RouterNodes @() -RouterPolicy  -VmanageAccount ) # SdwanProfile | The 'sdwan.Profile' resource to update.
$IfMatch = "IfMatch_example" # String | For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. (optional)

# Update a 'sdwan.Profile' resource.
try {
     $Result = Set-IntersightSdwanProfile -Moid $Moid -SdwanProfile $SdwanProfile -IfMatch $IfMatch
} catch {
    Write-Host ("Exception occured when calling Set-IntersightSdwanProfile: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 
 **SdwanProfile** | [**SdwanProfile**](SdwanProfile.md)| The &#39;sdwan.Profile&#39; resource to update. | 
 **IfMatch** | **String**| For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanProfile**](SdwanProfile.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/json-patch+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Set-IntersightSdwanRouterNode"></a>
# **Set-IntersightSdwanRouterNode**
> SdwanRouterNode Set-IntersightSdwanRouterNode<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SdwanRouterNode] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IfMatch] <String><br>

Update a 'sdwan.RouterNode' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.
$SdwanRouterNode = (Initialize-sdwan.RouterNode-ClassId "ClassId_example" -ObjectType "ObjectType_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Moid "Moid_example" -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -DeviceTemplate "DeviceTemplate_example" -Name "Name_example" -NetworkConfiguration @() -TemplateInputs @() -Uuid "Uuid_example" -Organization  -VarProfile  -ServerNode ) # SdwanRouterNode | The 'sdwan.RouterNode' resource to update.
$IfMatch = "IfMatch_example" # String | For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. (optional)

# Update a 'sdwan.RouterNode' resource.
try {
     $Result = Set-IntersightSdwanRouterNode -Moid $Moid -SdwanRouterNode $SdwanRouterNode -IfMatch $IfMatch
} catch {
    Write-Host ("Exception occured when calling Set-IntersightSdwanRouterNode: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 
 **SdwanRouterNode** | [**SdwanRouterNode**](SdwanRouterNode.md)| The &#39;sdwan.RouterNode&#39; resource to update. | 
 **IfMatch** | **String**| For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanRouterNode**](SdwanRouterNode.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/json-patch+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Set-IntersightSdwanRouterPolicy"></a>
# **Set-IntersightSdwanRouterPolicy**
> SdwanRouterPolicy Set-IntersightSdwanRouterPolicy<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SdwanRouterPolicy] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IfMatch] <String><br>

Update a 'sdwan.RouterPolicy' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.
$SdwanRouterPolicy = (Initialize-sdwan.RouterPolicy-ClassId "ClassId_example" -ObjectType "ObjectType_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Moid "Moid_example" -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -DeploymentSize "DeploymentSize_example" -WanCount 123 -WanTerminationType "WanTerminationType_example" -Organization  -Profiles @() -SolutionImage ) # SdwanRouterPolicy | The 'sdwan.RouterPolicy' resource to update.
$IfMatch = "IfMatch_example" # String | For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. (optional)

# Update a 'sdwan.RouterPolicy' resource.
try {
     $Result = Set-IntersightSdwanRouterPolicy -Moid $Moid -SdwanRouterPolicy $SdwanRouterPolicy -IfMatch $IfMatch
} catch {
    Write-Host ("Exception occured when calling Set-IntersightSdwanRouterPolicy: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 
 **SdwanRouterPolicy** | [**SdwanRouterPolicy**](SdwanRouterPolicy.md)| The &#39;sdwan.RouterPolicy&#39; resource to update. | 
 **IfMatch** | **String**| For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanRouterPolicy**](SdwanRouterPolicy.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/json-patch+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Set-IntersightSdwanVmanageAccountPolicy"></a>
# **Set-IntersightSdwanVmanageAccountPolicy**
> SdwanVmanageAccountPolicy Set-IntersightSdwanVmanageAccountPolicy<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SdwanVmanageAccountPolicy] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IfMatch] <String><br>

Update a 'sdwan.VmanageAccountPolicy' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.
$SdwanVmanageAccountPolicy = (Initialize-sdwan.VmanageAccountPolicy-ClassId "ClassId_example" -ObjectType "ObjectType_example" -AccountMoid "AccountMoid_example" -CreateTime Get-Date -DomainGroupMoid "DomainGroupMoid_example" -ModTime Get-Date -Moid "Moid_example" -Owners @("Owners_example") -SharedScope "SharedScope_example" -Tags @() -VersionContext  -Ancestors @() -Parent  -PermissionResources @() -DisplayNames "TODO" -Description "Description_example" -Name "Name_example" -EndpointAddress "EndpointAddress_example" -IsPasswordSet $false -Password "Password_example" -Port 123 -Username "Username_example" -Organization  -Profiles @()) # SdwanVmanageAccountPolicy | The 'sdwan.VmanageAccountPolicy' resource to update.
$IfMatch = "IfMatch_example" # String | For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. (optional)

# Update a 'sdwan.VmanageAccountPolicy' resource.
try {
     $Result = Set-IntersightSdwanVmanageAccountPolicy -Moid $Moid -SdwanVmanageAccountPolicy $SdwanVmanageAccountPolicy -IfMatch $IfMatch
} catch {
    Write-Host ("Exception occured when calling Set-IntersightSdwanVmanageAccountPolicy: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 
 **SdwanVmanageAccountPolicy** | [**SdwanVmanageAccountPolicy**](SdwanVmanageAccountPolicy.md)| The &#39;sdwan.VmanageAccountPolicy&#39; resource to update. | 
 **IfMatch** | **String**| For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanVmanageAccountPolicy**](SdwanVmanageAccountPolicy.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/json-patch+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Update-IntersightSdwanProfile"></a>
# **Update-IntersightSdwanProfile**
> SdwanProfile Update-IntersightSdwanProfile<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SdwanProfile] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IfMatch] <String><br>

Update a 'sdwan.Profile' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.
$SdwanProfile =  # SdwanProfile | The 'sdwan.Profile' resource to update.
$IfMatch = "IfMatch_example" # String | For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. (optional)

# Update a 'sdwan.Profile' resource.
try {
     $Result = Update-IntersightSdwanProfile -Moid $Moid -SdwanProfile $SdwanProfile -IfMatch $IfMatch
} catch {
    Write-Host ("Exception occured when calling Update-IntersightSdwanProfile: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 
 **SdwanProfile** | [**SdwanProfile**](SdwanProfile.md)| The &#39;sdwan.Profile&#39; resource to update. | 
 **IfMatch** | **String**| For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanProfile**](SdwanProfile.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/json-patch+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Update-IntersightSdwanRouterNode"></a>
# **Update-IntersightSdwanRouterNode**
> SdwanRouterNode Update-IntersightSdwanRouterNode<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SdwanRouterNode] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IfMatch] <String><br>

Update a 'sdwan.RouterNode' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.
$SdwanRouterNode =  # SdwanRouterNode | The 'sdwan.RouterNode' resource to update.
$IfMatch = "IfMatch_example" # String | For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. (optional)

# Update a 'sdwan.RouterNode' resource.
try {
     $Result = Update-IntersightSdwanRouterNode -Moid $Moid -SdwanRouterNode $SdwanRouterNode -IfMatch $IfMatch
} catch {
    Write-Host ("Exception occured when calling Update-IntersightSdwanRouterNode: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 
 **SdwanRouterNode** | [**SdwanRouterNode**](SdwanRouterNode.md)| The &#39;sdwan.RouterNode&#39; resource to update. | 
 **IfMatch** | **String**| For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanRouterNode**](SdwanRouterNode.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/json-patch+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Update-IntersightSdwanRouterPolicy"></a>
# **Update-IntersightSdwanRouterPolicy**
> SdwanRouterPolicy Update-IntersightSdwanRouterPolicy<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SdwanRouterPolicy] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IfMatch] <String><br>

Update a 'sdwan.RouterPolicy' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.
$SdwanRouterPolicy =  # SdwanRouterPolicy | The 'sdwan.RouterPolicy' resource to update.
$IfMatch = "IfMatch_example" # String | For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. (optional)

# Update a 'sdwan.RouterPolicy' resource.
try {
     $Result = Update-IntersightSdwanRouterPolicy -Moid $Moid -SdwanRouterPolicy $SdwanRouterPolicy -IfMatch $IfMatch
} catch {
    Write-Host ("Exception occured when calling Update-IntersightSdwanRouterPolicy: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 
 **SdwanRouterPolicy** | [**SdwanRouterPolicy**](SdwanRouterPolicy.md)| The &#39;sdwan.RouterPolicy&#39; resource to update. | 
 **IfMatch** | **String**| For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanRouterPolicy**](SdwanRouterPolicy.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/json-patch+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="Update-IntersightSdwanVmanageAccountPolicy"></a>
# **Update-IntersightSdwanVmanageAccountPolicy**
> SdwanVmanageAccountPolicy Update-IntersightSdwanVmanageAccountPolicy<br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-Moid] <String><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-SdwanVmanageAccountPolicy] <PSCustomObject><br>
> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;[-IfMatch] <String><br>

Update a 'sdwan.VmanageAccountPolicy' resource.

### Example
```powershell
Import-Module -Name Intersight

$Configuration = Get-IntersightConfiguration
# Configure API key authorization: cookieAuth
$Configuration["ApiKey"]["X-Starship-Token"] = "YOUR_API_KEY"
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$Configuration["ApiKeyPrefix"]["X-Starship-Token"] = "Bearer"

# Configure HTTP basic authorization: http_signature
$Configuration["Username"] = "YOUR_USERNAME";
$Configuration["Password"] = "YOUR_PASSWORD";

# Configure HttpSignature for authorization :http_signature
$httpSigningParams = @{
    KeyId = "xxxxxx1776876789ac747/xxxxxxx564612d31a62c01/xxxxxxxa1d7564612d31a66ee8"
    KeyFilePath = "C:\SecretKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}
Set-IntersightConfigurationHttpSigning @httpSigningParams

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";

# Configure OAuth2 access token for authorization: oAuth2
$Configuration["AccessToken"] = "YOUR_ACCESS_TOKEN";


$Moid = "Moid_example" # String | The unique Moid identifier of a resource instance.
$SdwanVmanageAccountPolicy =  # SdwanVmanageAccountPolicy | The 'sdwan.VmanageAccountPolicy' resource to update.
$IfMatch = "IfMatch_example" # String | For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. (optional)

# Update a 'sdwan.VmanageAccountPolicy' resource.
try {
     $Result = Update-IntersightSdwanVmanageAccountPolicy -Moid $Moid -SdwanVmanageAccountPolicy $SdwanVmanageAccountPolicy -IfMatch $IfMatch
} catch {
    Write-Host ("Exception occured when calling Update-IntersightSdwanVmanageAccountPolicy: {0}" -f ($_.ErrorDetails | ConvertFrom-Json))
    Write-Host ("Response headers: {0}" -f ($_.Exception.Response.Headers | ConvertTo-Json))
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **Moid** | **String**| The unique Moid identifier of a resource instance. | 
 **SdwanVmanageAccountPolicy** | [**SdwanVmanageAccountPolicy**](SdwanVmanageAccountPolicy.md)| The &#39;sdwan.VmanageAccountPolicy&#39; resource to update. | 
 **IfMatch** | **String**| For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request. | [optional] 

### Return type
# cmdlet returns PSCustomObject, the return object contains the properties of below type
[**SdwanVmanageAccountPolicy**](SdwanVmanageAccountPolicy.md)

### Authorization

[cookieAuth](../README.md#cookieAuth), [http_signature](../README.md#http_signature), [oAuth2](../README.md#oAuth2), [oAuth2](../README.md#oAuth2)

### HTTP request headers

 - **Content-Type**: application/json, application/json-patch+json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

