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

Definition of the list of properties defined in 'inventory.InventoryMo', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER MoDn
The UCS DN of the MO for which the latest inventory to be fetched. If this property is empty and moId property has the Moid of the MO to be updated, the Moid will be used. If this property is empty and moId is also empty, all the MOs of the given moType will be updated.
.PARAMETER MoId
The MO id of an MO for which the latest inventory to be fetched. If this property is empty and moDn property has the UCS DN of the MO to be updated, the DN will be used. If this property is empty and moDn is also empty, all the MOs of the given moType will be updated.
.PARAMETER MoType
The type of the MO for which the latest inventory to be fetched.
.OUTPUTS

InventoryInventoryMoAllOf<PSCustomObject>
#>

function Initialize-IntersightInventoryInventoryMoAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("inventory.InventoryMo")]
        [String]
        ${ClassId} = "inventory.InventoryMo",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("inventory.InventoryMo")]
        [String]
        ${ObjectType} = "inventory.InventoryMo",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MoDn},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MoId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MoType}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightInventoryInventoryMoAllOf' | Write-Debug
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
            "MoDn" = ${MoDn}
            "MoId" = ${MoId}
            "MoType" = ${MoType}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to InventoryInventoryMoAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to InventoryInventoryMoAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

InventoryInventoryMoAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToInventoryInventoryMoAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightInventoryInventoryMoAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightInventoryInventoryMoAllOf
        $AllProperties = ("ClassId", "ObjectType", "MoDn", "MoId", "MoType")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MoDn"))) { #optional property not found
            $MoDn = $null
        } else {
            $MoDn = $JsonParameters.PSobject.Properties["MoDn"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MoId"))) { #optional property not found
            $MoId = $null
        } else {
            $MoId = $JsonParameters.PSobject.Properties["MoId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MoType"))) { #optional property not found
            $MoType = $null
        } else {
            $MoType = $JsonParameters.PSobject.Properties["MoType"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "MoDn" = ${MoDn}
            "MoId" = ${MoId}
            "MoType" = ${MoType}
        }

        return $PSO
    }

}

