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

Definition of the list of properties defined in 'fault.Instance', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER InventoryDeviceInfo
No description available.
.PARAMETER RegisteredDevice
No description available.
.OUTPUTS

FaultInstanceAllOf<PSCustomObject>
#>

function Initialize-IntersightFaultInstanceAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("fault.Instance")]
        [String]
        ${ClassId} = "fault.Instance",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("fault.Instance")]
        [String]
        ${ObjectType} = "fault.Instance",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${InventoryDeviceInfo},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${RegisteredDevice}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightFaultInstanceAllOf' | Write-Debug
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
            "InventoryDeviceInfo" = ${InventoryDeviceInfo}
            "RegisteredDevice" = ${RegisteredDevice}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to FaultInstanceAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to FaultInstanceAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

FaultInstanceAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToFaultInstanceAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightFaultInstanceAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightFaultInstanceAllOf
        $AllProperties = ("ClassId", "ObjectType", "Acknowledged", "AffectedDn", "AffectedMoId", "AffectedMoType", "AncestorMoId", "AncestorMoType", "Code", "CreationTime", "Description", "LastTransitionTime", "NumOccurrences", "OriginalSeverity", "PreviousSeverity", "Rule", "Severity", "InventoryDeviceInfo", "RegisteredDevice")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Acknowledged"))) { #optional property not found
            $Acknowledged = $null
        } else {
            $Acknowledged = $JsonParameters.PSobject.Properties["Acknowledged"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AffectedDn"))) { #optional property not found
            $AffectedDn = $null
        } else {
            $AffectedDn = $JsonParameters.PSobject.Properties["AffectedDn"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AffectedMoId"))) { #optional property not found
            $AffectedMoId = $null
        } else {
            $AffectedMoId = $JsonParameters.PSobject.Properties["AffectedMoId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AffectedMoType"))) { #optional property not found
            $AffectedMoType = $null
        } else {
            $AffectedMoType = $JsonParameters.PSobject.Properties["AffectedMoType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AncestorMoId"))) { #optional property not found
            $AncestorMoId = $null
        } else {
            $AncestorMoId = $JsonParameters.PSobject.Properties["AncestorMoId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AncestorMoType"))) { #optional property not found
            $AncestorMoType = $null
        } else {
            $AncestorMoType = $JsonParameters.PSobject.Properties["AncestorMoType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Code"))) { #optional property not found
            $Code = $null
        } else {
            $Code = $JsonParameters.PSobject.Properties["Code"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CreationTime"))) { #optional property not found
            $CreationTime = $null
        } else {
            $CreationTime = $JsonParameters.PSobject.Properties["CreationTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Description"))) { #optional property not found
            $Description = $null
        } else {
            $Description = $JsonParameters.PSobject.Properties["Description"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastTransitionTime"))) { #optional property not found
            $LastTransitionTime = $null
        } else {
            $LastTransitionTime = $JsonParameters.PSobject.Properties["LastTransitionTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "NumOccurrences"))) { #optional property not found
            $NumOccurrences = $null
        } else {
            $NumOccurrences = $JsonParameters.PSobject.Properties["NumOccurrences"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "OriginalSeverity"))) { #optional property not found
            $OriginalSeverity = $null
        } else {
            $OriginalSeverity = $JsonParameters.PSobject.Properties["OriginalSeverity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "PreviousSeverity"))) { #optional property not found
            $PreviousSeverity = $null
        } else {
            $PreviousSeverity = $JsonParameters.PSobject.Properties["PreviousSeverity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Rule"))) { #optional property not found
            $Rule = $null
        } else {
            $Rule = $JsonParameters.PSobject.Properties["Rule"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Severity"))) { #optional property not found
            $Severity = $null
        } else {
            $Severity = $JsonParameters.PSobject.Properties["Severity"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "InventoryDeviceInfo"))) { #optional property not found
            $InventoryDeviceInfo = $null
        } else {
            $InventoryDeviceInfo = $JsonParameters.PSobject.Properties["InventoryDeviceInfo"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "RegisteredDevice"))) { #optional property not found
            $RegisteredDevice = $null
        } else {
            $RegisteredDevice = $JsonParameters.PSobject.Properties["RegisteredDevice"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "Acknowledged" = ${Acknowledged}
            "AffectedDn" = ${AffectedDn}
            "AffectedMoId" = ${AffectedMoId}
            "AffectedMoType" = ${AffectedMoType}
            "AncestorMoId" = ${AncestorMoId}
            "AncestorMoType" = ${AncestorMoType}
            "Code" = ${Code}
            "CreationTime" = ${CreationTime}
            "Description" = ${Description}
            "LastTransitionTime" = ${LastTransitionTime}
            "NumOccurrences" = ${NumOccurrences}
            "OriginalSeverity" = ${OriginalSeverity}
            "PreviousSeverity" = ${PreviousSeverity}
            "Rule" = ${Rule}
            "Severity" = ${Severity}
            "InventoryDeviceInfo" = ${InventoryDeviceInfo}
            "RegisteredDevice" = ${RegisteredDevice}
        }

        return $PSO
    }

}

