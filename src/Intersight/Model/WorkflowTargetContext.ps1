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

Target details like moid, type and name of the Intersight managed object.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER TargetMoid
Moid of the target Intersight managed object.
.PARAMETER TargetName
Name of the target instance.
.PARAMETER TargetType
Object type of the target Intersight managed object.
.OUTPUTS

WorkflowTargetContext<PSCustomObject>
#>

function Initialize-IntersightWorkflowTargetContext {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("workflow.TargetContext")]
        [String]
        ${ClassId} = "workflow.TargetContext",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("workflow.TargetContext")]
        [String]
        ${ObjectType} = "workflow.TargetContext",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TargetMoid},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TargetName},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TargetType}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightWorkflowTargetContext' | Write-Debug
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
            "TargetMoid" = ${TargetMoid}
            "TargetName" = ${TargetName}
            "TargetType" = ${TargetType}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to WorkflowTargetContext<PSCustomObject>

.DESCRIPTION

Convert from JSON to WorkflowTargetContext<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

WorkflowTargetContext<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToWorkflowTargetContext {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightWorkflowTargetContext' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightWorkflowTargetContext
        $AllProperties = ("ClassId", "ObjectType", "TargetMoid", "TargetName", "TargetType")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TargetMoid"))) { #optional property not found
            $TargetMoid = $null
        } else {
            $TargetMoid = $JsonParameters.PSobject.Properties["TargetMoid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TargetName"))) { #optional property not found
            $TargetName = $null
        } else {
            $TargetName = $JsonParameters.PSobject.Properties["TargetName"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TargetType"))) { #optional property not found
            $TargetType = $null
        } else {
            $TargetType = $JsonParameters.PSobject.Properties["TargetType"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "TargetMoid" = ${TargetMoid}
            "TargetName" = ${TargetName}
            "TargetType" = ${TargetType}
        }

        return $PSO
    }

}

