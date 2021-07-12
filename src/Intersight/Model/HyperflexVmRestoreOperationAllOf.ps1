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

Definition of the list of properties defined in 'hyperflex.VmRestoreOperation', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER NewName
New name for the Virtual Machine after recovery.
.PARAMETER PowerOn
Power on the Virtual Machine after recovery.
.PARAMETER Organization
No description available.
.PARAMETER RestoreEdgeClusterMoid
No description available.
.PARAMETER VmBackupInfoMoid
No description available.
.PARAMETER VmSnapshotInfoMoid
No description available.
.OUTPUTS

HyperflexVmRestoreOperationAllOf<PSCustomObject>
#>

function Initialize-IntersightHyperflexVmRestoreOperationAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("hyperflex.VmRestoreOperation")]
        [String]
        ${ClassId} = "hyperflex.VmRestoreOperation",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("hyperflex.VmRestoreOperation")]
        [String]
        ${ObjectType} = "hyperflex.VmRestoreOperation",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${NewName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${PowerOn} = $true,
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Organization},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RestoreEdgeClusterMoid},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${VmBackupInfoMoid},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${VmSnapshotInfoMoid}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightHyperflexVmRestoreOperationAllOf' | Write-Debug
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
            "NewName" = ${NewName}
            "PowerOn" = ${PowerOn}
            "Organization" = ${Organization}
            "RestoreEdgeClusterMoid" = ${RestoreEdgeClusterMoid}
            "VmBackupInfoMoid" = ${VmBackupInfoMoid}
            "VmSnapshotInfoMoid" = ${VmSnapshotInfoMoid}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to HyperflexVmRestoreOperationAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to HyperflexVmRestoreOperationAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

HyperflexVmRestoreOperationAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToHyperflexVmRestoreOperationAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightHyperflexVmRestoreOperationAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightHyperflexVmRestoreOperationAllOf
        $AllProperties = ("ClassId", "ObjectType", "NewName", "PowerOn", "Organization", "RestoreEdgeClusterMoid", "VmBackupInfoMoid", "VmSnapshotInfoMoid")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NewName"))) { #optional property not found
            $NewName = $null
        } else {
            $NewName = $JsonParameters.PSobject.Properties["NewName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PowerOn"))) { #optional property not found
            $PowerOn = $null
        } else {
            $PowerOn = $JsonParameters.PSobject.Properties["PowerOn"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Organization"))) { #optional property not found
            $Organization = $null
        } else {
            $Organization = $JsonParameters.PSobject.Properties["Organization"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RestoreEdgeClusterMoid"))) { #optional property not found
            $RestoreEdgeClusterMoid = $null
        } else {
            $RestoreEdgeClusterMoid = $JsonParameters.PSobject.Properties["RestoreEdgeClusterMoid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "VmBackupInfoMoid"))) { #optional property not found
            $VmBackupInfoMoid = $null
        } else {
            $VmBackupInfoMoid = $JsonParameters.PSobject.Properties["VmBackupInfoMoid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "VmSnapshotInfoMoid"))) { #optional property not found
            $VmSnapshotInfoMoid = $null
        } else {
            $VmSnapshotInfoMoid = $JsonParameters.PSobject.Properties["VmSnapshotInfoMoid"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "NewName" = ${NewName}
            "PowerOn" = ${PowerOn}
            "Organization" = ${Organization}
            "RestoreEdgeClusterMoid" = ${RestoreEdgeClusterMoid}
            "VmBackupInfoMoid" = ${VmBackupInfoMoid}
            "VmSnapshotInfoMoid" = ${VmSnapshotInfoMoid}
        }

        return $PSO
    }

}
