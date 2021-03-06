#
# Cisco Intersight
# Cisco Intersight is a management platform delivered as a service with embedded analytics for your Cisco and 3rd party IT infrastructure. This platform offers an intelligent level of management that enables IT organizations to analyze, simplify, and automate their environments in more advanced ways than the prior generations of tools. Cisco Intersight provides an integrated and intuitive management experience for resources in the traditional data center as well as at the edge. With flexible deployment options to address complex security needs, getting started with Intersight is quick and easy. Cisco Intersight has deep integration with Cisco UCS and HyperFlex systems allowing for remote deployment, configuration, and ongoing maintenance. The model-based deployment works for a single system in a remote location or hundreds of systems in a data center and enables rapid, standardized configuration and deployment. It also streamlines maintaining those systems whether you are working with small or very large configurations. The Intersight OpenAPI document defines the complete set of properties that are returned in the HTTP response. From that perspective, a client can expect that no additional properties are returned, unless these properties are explicitly defined in the OpenAPI document. However, when a client uses an older version of the Intersight OpenAPI document, the server may send additional properties because the software is more recent than the client. In that case, the client may receive properties that it does not know about. Some generated SDKs perform a strict validation of the HTTP response body against the OpenAPI document. This document was created on 2021-02-05T15:05:56Z.
# Version: 1.0.9-3562
# Contact: intersight@cisco.com
# Generated by OpenAPI Generator: https://openapi-generator.tech
#

<#
.SYNOPSIS

No summary available.

.DESCRIPTION

Definition of the list of properties defined in 'storage.StoragePolicy', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER GlobalHotSpares
No description available.
.PARAMETER RetainPolicyVirtualDrives
Retains the virtual drives defined in policy if they exist already. If this flag is false, the existing virtual drives are removed and created again based on virtual drives in the policy.
.PARAMETER UnusedDisksState
Unused Disks State is used to specify the state, unconfigured good or jbod, in which the disks that are not used in this policy should be moved. * `UnconfiguredGood` - Unconfigured good state -ready to be added in a RAID group. * `Jbod` - JBOD state where the disks start showing up to host os.
.PARAMETER VirtualDrives
No description available.
.PARAMETER DiskGroupPolicies
An array of relationships to storageDiskGroupPolicy resources.
.PARAMETER Organization
No description available.
.PARAMETER Profiles
An array of relationships to policyAbstractConfigProfile resources.
.OUTPUTS

StorageStoragePolicyAllOf<PSCustomObject>
#>

function Initialize-IntersightStorageStoragePolicyAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("storage.StoragePolicy")]
        [String]
        ${ClassId} = "storage.StoragePolicy",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("storage.StoragePolicy")]
        [String]
        ${ObjectType} = "storage.StoragePolicy",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${GlobalHotSpares},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${RetainPolicyVirtualDrives} = $true,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("UnconfiguredGood", "Jbod")]
        [String]
        ${UnusedDisksState} = "UnconfiguredGood",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${VirtualDrives},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${DiskGroupPolicies},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Organization},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${Profiles}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightStorageStoragePolicyAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$ClassId) {
            throw "invalid value for 'ClassId', 'ClassId' cannot be null."
        }

        if (!$ObjectType) {
            throw "invalid value for 'ObjectType', 'ObjectType' cannot be null."
        }

        
        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "GlobalHotSpares" = ${GlobalHotSpares}
            "RetainPolicyVirtualDrives" = ${RetainPolicyVirtualDrives}
            "UnusedDisksState" = ${UnusedDisksState}
            "VirtualDrives" = ${VirtualDrives}
            "DiskGroupPolicies" = ${DiskGroupPolicies}
            "Organization" = ${Organization}
            "Profiles" = ${Profiles}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to StorageStoragePolicyAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to StorageStoragePolicyAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

StorageStoragePolicyAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToStorageStoragePolicyAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightStorageStoragePolicyAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightStorageStoragePolicyAllOf
        $AllProperties = ("ClassId", "ObjectType", "GlobalHotSpares", "RetainPolicyVirtualDrives", "UnusedDisksState", "VirtualDrives", "DiskGroupPolicies", "Organization", "Profiles")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        If ([string]::IsNullOrEmpty($Json) -or $Json -eq "{}") { # empty json
            throw "Error! Empty JSON cannot be serialized due to the required property 'ClassId' missing."
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ClassId"))) {
            throw "Error! JSON cannot be serialized due to the required property 'ClassId' missing."
        } else {
            $ClassId = $JsonParameters.PSobject.Properties["ClassId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectType"))) {
            throw "Error! JSON cannot be serialized due to the required property 'ObjectType' missing."
        } else {
            $ObjectType = $JsonParameters.PSobject.Properties["ObjectType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "GlobalHotSpares"))) { #optional property not found
            $GlobalHotSpares = $null
        } else {
            $GlobalHotSpares = $JsonParameters.PSobject.Properties["GlobalHotSpares"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RetainPolicyVirtualDrives"))) { #optional property not found
            $RetainPolicyVirtualDrives = $null
        } else {
            $RetainPolicyVirtualDrives = $JsonParameters.PSobject.Properties["RetainPolicyVirtualDrives"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "UnusedDisksState"))) { #optional property not found
            $UnusedDisksState = $null
        } else {
            $UnusedDisksState = $JsonParameters.PSobject.Properties["UnusedDisksState"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "VirtualDrives"))) { #optional property not found
            $VirtualDrives = $null
        } else {
            $VirtualDrives = $JsonParameters.PSobject.Properties["VirtualDrives"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DiskGroupPolicies"))) { #optional property not found
            $DiskGroupPolicies = $null
        } else {
            $DiskGroupPolicies = $JsonParameters.PSobject.Properties["DiskGroupPolicies"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Organization"))) { #optional property not found
            $Organization = $null
        } else {
            $Organization = $JsonParameters.PSobject.Properties["Organization"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Profiles"))) { #optional property not found
            $Profiles = $null
        } else {
            $Profiles = $JsonParameters.PSobject.Properties["Profiles"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "GlobalHotSpares" = ${GlobalHotSpares}
            "RetainPolicyVirtualDrives" = ${RetainPolicyVirtualDrives}
            "UnusedDisksState" = ${UnusedDisksState}
            "VirtualDrives" = ${VirtualDrives}
            "DiskGroupPolicies" = ${DiskGroupPolicies}
            "Organization" = ${Organization}
            "Profiles" = ${Profiles}
        }

        return $PSO
    }

}

