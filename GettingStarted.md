## Build the Intersight PowerShell module
---
**Note**
#### This step is not required when module is installed from PowerShell gallery using Install-Module cmldet
---
Clone the repository using git clone command, and run the `./build.ps1` to build the Intersight.PowerShell module.

```powershell
PS c:\> git clone https://github.com/CiscoDevNet/intersight-powershell.git
PS c:\> cd intersight-powershell
PS c:\> .\build.ps1
```

---
**Note**
#### This step is required only once, it generates the Powershell module and user can import it to use the cmdlet.
---

## Install the module using PSGallery
The Intersight.PowerShell  module is published on PSGallery, it can be installed using below cmdlet.

```powershell
PS c:\> Install-Module -Name Intersight.PowerShell
```

## Import the Intersight.PowerShell module
Once the build is completed. It generates the Intersight.PowerShell module. The Intersight.PowerShell directory contains the following items
* Intersight.PowerShell.dll
* Intersight.PowerShell.dll-help.xml
* Intersight.PowerShell.psd1
* Intersight.dll
* dependent dlls to work with intersight.dll

```powershell
# Assume the generated module is available in c:\ drive.
PS C:\> Import-module -Name .\Intersight.PowerShell

#Check the loaded module
PS C:\> Get-Module

ModuleType Version    PreRelease Name                                ExportedCommands
---------- -------    ---------- ----                                ----------------
Binary     1.0.9.3978            Intersight.PowerShell               {Get-IntersightAaaAuditRecord, Get-IntersightAccessPolicy, Get…
Manifest   7.0.0.0               Microsoft.PowerShell.Management     {Add-Content, Clear-Content, Clear-Item, Clear-ItemProperty…}
Manifest   7.0.0.0               Microsoft.PowerShell.Utility        {Add-Member, Add-Type, Clear-Variable, Compare-Object…}
Script     2.1.0                 PSReadLine                          {Get-PSReadLineKeyHandler, Get-PSReadLineOption, Remove-PSRead…

```
User can place the module in the directory listed in ```$env:PSModulePath``` or the path of Intersight.PowerShell can be added in ```$env:PSModulePath``` to import the module by name.

## Configure the Intersight Environment
The environment related configuration is required once for each PowerShell session. The environment configuration required following required configuration. 
* BasePath :- Url of the Intersight, default value is https://intersight.com
* ApiKeyId :- ApiKey Id , user can generate it by loging to intersight.com or onprem portal.
* ApiKeyFilePath :- ApiKeyFilePath is secrect key file path which is in pem format. (RSA key or ECDSA key)
* HashAlgorithm :- Accepted values is SHA256 and SHA512
* HttpSignerHeader :- requires the name of the headers to use in the http signing, for intersight minimum required headers are "(request-target)", "Host", "Date", "Digest"

To expore the other supported cmdlet parameter like ```KeyPassPhrase```, ```Proxy```, ```SignatureValidityPeriod``` and ```SkipCertificateCheck``` refer to cmdlet help.

<a name = "Authenticate"></a>

### Authenticate the user
Intersight.PowerShell supports only HttpSigning Auth.
```powershell
$onprem = @{
    BasePath = "https://intersight.com"
    ApiKeyId = "xxxxx27564612d30dxxxxx/5f21c9d97564612d30dd575a/5f9a8b877564612xxxxxxxx"
    ApiKeyFilePath = "C:\\secrectKey.txt" 
    HttpSingingHeader =  @("(request-target)", "Host", "Date", "Digest")
}

PS C:\> Set-IntersightConfiguration @onprem

PS C:\> Get-IntersightConfiguration

BasePath                : https://intersight.com
ApiKeyId                : xxxxx27564612d30dxxxxx/5f21c9d97564612d30dd575a/5f9a8b877564612xxxxxxxx
ApiKeyFilePath          : C:\\secrectKey.txt
ApiKeyPassPhrase        :
Proxy                   :
HashAlgorithm           : SHA256
HttpSingingHeader       : {(request-target), Host, Date, Digest}
SignatureValidityPeriod : 0

```

## Create the Organization
The cmdlet ```New-IntersightOrganizationOrganization``` is used to create the Organization MO.

```powershell
PS C:\> $newOrg = New-IntersightOrganizationOrganization -Name PSOrg
PS C:\> $newOrg

ClassId                           : OrganizationOrganization
ObjectType                        : OrganizationOrganization
Description                       :
Name                              : PSOrg
Account                           : class IamAccountRelationship {
                                      ActualInstance: class MoMoRef {
                                      ClassId: MoMoRef
                                      ObjectType: IamAccount
                                      Moid: 5f21c2527564612d30dd3c06
                                      Selector:
                                      Link: https://xxxxxxx.xxx.com/api/v1/iam/Accounts/5f21c2527564612d30dd3c06
                                      AdditionalProperties: System.Collections.Generic.Dictionary`2[System.String,System.Object]
                                    }

                                    }

ResourceGroups                    :
AdditionalProperties              : {}
AccountMoid                       : 5f21c2527564612d30dd3c06
CreateTime                        : 23-03-2021 07:03:01
DomainGroupMoid                   : 5f21c2527564612d30dd3c07
ModTime                           : 23-03-2021 07:03:01
Moid                              : 605992a56972652d30f7a714
Owners                            : {5f21c2527564612d30dd3c06}
SharedScope                       :
Tags                              : {}
VersionContext                    :
_0ClusterReplicationNetworkPolicy :
Ancestors                         :
Parent                            :
PermissionResources               : {class MoBaseMoRelationship {
                                      ActualInstance: class MoMoRef {
                                      ClassId: MoMoRef
                                      ObjectType: OrganizationOrganization
                                      Moid: 605992a56972652d30f7a714
                                      Selector:
                                      Link:
                                    https://xxxxxxx.xxx.com/api/v1/organization/Organizations/605992a56972652d30f7a714
                                      AdditionalProperties: System.Collections.Generic.Dictionary`2[System.String,System.Object]
                                    }

                                    }
                                    }
DisplayNames                      :
```

## Create the Policy Under PSOrg organization
### Create Ntp Policy
The cmdlet ```New-IntersightNtpPolicy``` is used to create the Ntp Policy. To refer Organization we are using  ```$newOrg``` variable where we have
created the organization in previous example.
``` powershell
PS C:\> $ntpPolicy = New-IntersightNtpPolicy -Name "PSNtp" -Description "ntp policy for PSOrg" -NtpServers @("22.22.22.22","77.77.77.77") -Enabled $true -Timezone IndianMauritius -Organization $newOrg
PS C:\> $ntpPolicy

ClassId                           : NtpPolicy
ObjectType                        : NtpPolicy
Timezone                          : IndianMauritius
Enabled                           : True
NtpServers                        : {22.22.22.22, 77.77.77.77}
ApplianceAccount                  :
Organization                      : class OrganizationOrganizationRelationship {
                                      ActualInstance: class MoMoRef {
                                      ClassId: MoMoRef
                                      ObjectType: OrganizationOrganization
                                      Moid: 605992a56972652d30f7a714
                                      Selector:
                                      Link:
                                    https://xxxxxxx.xxx.com/api/v1/organization/Organizations/605992a56972652d30f7a714
                                      AdditionalProperties: System.Collections.Generic.Dictionary`2[System.String,System.Object]
                                    }

                                    }

Profiles                          :
AdditionalProperties              : {}
Description                       : ntp policy for PSOrg
Name                              : PSNtp
AccountMoid                       : 5f21c2527564612d30dd3c06
CreateTime                        : 23-03-2021 07:10:58
DomainGroupMoid                   : 5f21c2527564612d30dd3c07
ModTime                           : 23-03-2021 07:10:58
Moid                              : 605994826275722d3037017f
Owners                            : {5f21c2527564612d30dd3c06}
SharedScope                       :
Tags                              : {}
VersionContext                    :
_0ClusterReplicationNetworkPolicy :
Ancestors                         :
Parent                            :
PermissionResources               : {class MoBaseMoRelationship {
                                      ActualInstance: class MoMoRef {
                                      ClassId: MoMoRef
                                      ObjectType: OrganizationOrganization
                                      Moid: 605992a56972652d30f7a714
                                      Selector:
                                      Link:
                                    https://xxxxxxx.xxx.com/api/v1/organization/Organizations/605992a56972652d30f7a714
                                      AdditionalProperties: System.Collections.Generic.Dictionary`2[System.String,System.Object]
                                    }

                                    }
                                    }
DisplayNames                      :


```

### create KVM policy under PSOrg organization
The cmdlet ```New-IntersightKvmPolicy``` is used to create the Kvm Policy. To refer Organization we are using  ```$newOrg``` variable where we have
created the organization in previous example.

```powershell
PS C:\> $kvmPolicy = New-IntersightKvmPolicy -Name PSKvm -Description "Kvm policy for PSOrg" -EnableVideoEncryption $true -EnableLocalServerVideo $true -Enabled $true -MaximumSessions 2 -Organization $newOrg
PS C:\> $kvmPolicy

ClassId                           : KvmPolicy
ObjectType                        : KvmPolicy
EnableLocalServerVideo            : True
EnableVideoEncryption             : True
Enabled                           : True
MaximumSessions                   : 2
RemotePort                        : 2068
Organization                      : class OrganizationOrganizationRelationship {
                                      ActualInstance: class MoMoRef {
                                      ClassId: MoMoRef
                                      ObjectType: OrganizationOrganization
                                      Moid: 605992a56972652d30f7a714
                                      Selector:
                                      Link:
                                    https://xxxxxxx.xxx.com/api/v1/organization/Organizations/605992a56972652d30f7a714
                                      AdditionalProperties: System.Collections.Generic.Dictionary`2[System.String,System.Object]
                                    }

                                    }

Profiles                          :
AdditionalProperties              : {}
Description                       : Kvm policy for PSOrg
Name                              : PSKvm
AccountMoid                       : 5f21c2527564612d30dd3c06
CreateTime                        : 23-03-2021 07:17:21
DomainGroupMoid                   : 5f21c2527564612d30dd3c07
ModTime                           : 23-03-2021 07:17:21
Moid                              : 605996016275722d30370189
Owners                            : {5f21c2527564612d30dd3c06}
SharedScope                       :
Tags                              : {}
VersionContext                    :
_0ClusterReplicationNetworkPolicy :
Ancestors                         :
Parent                            :
PermissionResources               : {class MoBaseMoRelationship {
                                      ActualInstance: class MoMoRef {
                                      ClassId: MoMoRef
                                      ObjectType: OrganizationOrganization
                                      Moid: 605992a56972652d30f7a714
                                      Selector:
                                      Link:
                                    https://xxxxxxx.xxx.com/api/v1/organization/Organizations/605992a56972652d30f7a714
                                      AdditionalProperties: System.Collections.Generic.Dictionary`2[System.String,System.Object]
                                    }

                                    }
                                    }
DisplayNames                      :

```

## Get the policy based on different parameter

### Get-IntersightNtpPolicy
---
It returns the list of availabe ntp policy in the intersight cloud.
```powershell
PS C:\> $ntpPolicyList = Get-IntersightNtpPolicy
PS C:\> $ntpPolicyList.Count
15
```
 ```$ntpPolicyList ``` contains the list of ntp policy, showing only the count of ntp policy to avoid the huge list. 

 ### Get-intersightNtpPolicy -Name <Name of the policy>
 ---
 It returns the ntp policy named "PSNtp"

 ```powershell
PS C:\> $getNtp = Get-IntersightNtpPolicy -Name PSNtp
PS C:\> $getNtp

ClassId                           : NtpPolicy
ObjectType                        : NtpPolicy
Timezone                          : IndianMauritius
Enabled                           : True
NtpServers                        : {22.22.22.22, 77.77.77.77}
ApplianceAccount                  :
Organization                      : class OrganizationOrganizationRelationship {
                                      ActualInstance: class MoMoRef {
                                      ClassId: MoMoRef
                                      ObjectType: OrganizationOrganization
                                      Moid: 605992a56972652d30f7a714
                                      Selector:
                                      Link:
                                    https://xxxxxxx.xxx.com/api/v1/organization/Organizations/605992a56972652d30f7a714
                                      AdditionalProperties: System.Collections.Generic.Dictionary`2[System.String,System.Object]
                                    }

                                    }

Profiles                          : {}
AdditionalProperties              : {}
Description                       : ntp policy for PSOrg
Name                              : PSNtp
AccountMoid                       : 5f21c2527564612d30dd3c06
CreateTime                        : 23-03-2021 07:10:58
DomainGroupMoid                   : 5f21c2527564612d30dd3c07
ModTime                           : 23-03-2021 07:10:58
Moid                              : 605994826275722d3037017f
Owners                            : {5f21c2527564612d30dd3c06}
SharedScope                       :
Tags                              : {}
VersionContext                    :
_0ClusterReplicationNetworkPolicy :
Ancestors                         : {}
Parent                            :
PermissionResources               : {class MoBaseMoRelationship {
                                      ActualInstance: class MoMoRef {
                                      ClassId: MoMoRef
                                      ObjectType: OrganizationOrganization
                                      Moid: 605992a56972652d30f7a714
                                      Selector:
                                      Link:
                                    https://xxxxxxx.xxx.com/api/v1/organization/Organizations/605992a56972652d30f7a714
                                      AdditionalProperties: System.Collections.Generic.Dictionary`2[System.String,System.Object]
                                    }

                                    }
                                    }
DisplayNames                      :


 ```

 ### Get ntp Policies under the Organization named PSOrg
---
 ```powershell
PS C:\> $ntpPolicyList  = Get-IntersightOrganizationOrganization -Name PSOrg | Get-IntersightNtpPolicy

 ```

 ### Get ntp policy based on query parameter inlineCount
 Get cmdlets support all the query parameter specified in Intersight OpenAPI document.

 ```powershell
 
PS C:\> $ntpPolicy = Get-IntersightNtpPolicy -InlineCount allpages
PS C:\> $ntpPolicy

Count Results
----- -------
   15 {class NtpPolicy {…
 
 ```
---
 ## update the existing MO
 ### Update the ntp policy -NtpServers with "33.33.33.33" and "10.10.10.10"
 Here we refer the PSNtp policy what we have already created in previous example.
 ```powershell
 
PS C:\> $updateNtp = Get-IntersightNtpPolicy -Name PSNtp | Set-IntersightNtpPolicy -NtpServers @("33.33.33.33","10.10.10.10")
PS C:\> $updateNtp

ClassId                           : NtpPolicy
ObjectType                        : NtpPolicy
Timezone                          : IndianMauritius
Enabled                           : True
NtpServers                        : {33.33.33.33, 10.10.10.10}
ApplianceAccount                  :
Organization                      : class OrganizationOrganizationRelationship {
                                      ActualInstance: class MoMoRef {
                                      ClassId: MoMoRef
                                      ObjectType: OrganizationOrganization
                                      Moid: 605992a56972652d30f7a714
                                      Selector:
                                      Link:
                                    https://xxxxxxx.xxx.com/api/v1/organization/Organizations/605992a56972652d30f7a714
                                      AdditionalProperties: System.Collections.Generic.Dictionary`2[System.String,System.Object]
                                    }

                                    }

Profiles                          : {}
AdditionalProperties              : {}
Description                       : ntp policy for PSOrg
Name                              : PSNtp
AccountMoid                       : 5f21c2527564612d30dd3c06
CreateTime                        : 23-03-2021 07:10:58
DomainGroupMoid                   : 5f21c2527564612d30dd3c07
ModTime                           : 23-03-2021 07:48:58
Moid                              : 605994826275722d3037017f
Owners                            : {5f21c2527564612d30dd3c06}
SharedScope                       :
Tags                              : {}
VersionContext                    :
_0ClusterReplicationNetworkPolicy :
Ancestors                         : {}
Parent                            :
PermissionResources               : {class MoBaseMoRelationship {
                                      ActualInstance: class MoMoRef {
                                      ClassId: MoMoRef
                                      ObjectType: OrganizationOrganization
                                      Moid: 605992a56972652d30f7a714
                                      Selector:
                                      Link:
                                    https://xxxxxxx.xxx.com/api/v1/organization/Organizations/605992a56972652d30f7a714
                                      AdditionalProperties: System.Collections.Generic.Dictionary`2[System.String,System.Object]
                                    }

                                    }
                                    }
DisplayNames                      :


 ```
---

## Delete the Mo
We have already created one Ntp policy and Kvm policy, now we delete it. 

```powershell

PS C:\> $removeNtp = Get-IntersightNtpPolicy -Name PSNtp | Remove-IntersightNtpPolicy
PS C:\> $removeNtp -eq $null
PS C:\> True
```
Remove cmdlet returns null on successful execution, otherwise it throws exception.

---

## Create a server profile and associate a policy to it.
Here referring the Organization ```$newOrg``` and KVM policy name ```PSKvm``` to attach the policy to the server profile.
```powershell
#create a server profile
PS c:\> $serverProfile = Get-IntersightServerProfile -Name PSServerProfile -Organization $newOrg
# get the MoRef of the server profile 
PS c:\> $profileRef = $serverProfile | Get-IntersightMoMORef

# use the set cmdlet to add the policy to the server profile
PS c:\> Get-IntersightKvmPolicy -Name PSKvm | Set-IntersightKvmPolicy -Profiles $profileRef
```