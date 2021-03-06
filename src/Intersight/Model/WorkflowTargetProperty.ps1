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

Capture all the properties for an input target endpoint or device.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER ConnectorAttribute
A singleton value which will contain the path to connector object from the selected object.
.PARAMETER ConstraintAttributes
No description available.
.PARAMETER DisplayAttributes
No description available.
.PARAMETER Selector
Field to hold an Intersight API along with an optional filter to narrow down the search options for target device.
.PARAMETER SupportedObjects
No description available.
.OUTPUTS

WorkflowTargetProperty<PSCustomObject>
#>

function Initialize-IntersightWorkflowTargetProperty {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("workflow.TargetProperty")]
        [String]
        ${ClassId} = "workflow.TargetProperty",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("workflow.TargetProperty")]
        [String]
        ${ObjectType} = "workflow.TargetProperty",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ConnectorAttribute},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${ConstraintAttributes},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${DisplayAttributes},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidatePattern("^$|/api/v1/.*")]
        [String]
        ${Selector},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${SupportedObjects}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightWorkflowTargetProperty' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        if (!$ClassId) {
            throw "invalid value for 'ClassId', 'ClassId' cannot be null."
        }

        if (!$ObjectType) {
            throw "invalid value for 'ObjectType', 'ObjectType' cannot be null."
        }

        if (!$DisplayAttributes -and $DisplayAttributes.length -lt 1) {
            throw "invalid value for 'DisplayAttributes', number of items must be greater than or equal to 1."
        }

        
        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "ConnectorAttribute" = ${ConnectorAttribute}
            "ConstraintAttributes" = ${ConstraintAttributes}
            "DisplayAttributes" = ${DisplayAttributes}
            "Selector" = ${Selector}
            "SupportedObjects" = ${SupportedObjects}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to WorkflowTargetProperty<PSCustomObject>

.DESCRIPTION

Convert from JSON to WorkflowTargetProperty<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

WorkflowTargetProperty<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToWorkflowTargetProperty {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightWorkflowTargetProperty' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightWorkflowTargetProperty
        $AllProperties = ("ClassId", "ObjectType", "ConnectorAttribute", "ConstraintAttributes", "DisplayAttributes", "Selector", "SupportedObjects")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConnectorAttribute"))) { #optional property not found
            $ConnectorAttribute = $null
        } else {
            $ConnectorAttribute = $JsonParameters.PSobject.Properties["ConnectorAttribute"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConstraintAttributes"))) { #optional property not found
            $ConstraintAttributes = $null
        } else {
            $ConstraintAttributes = $JsonParameters.PSobject.Properties["ConstraintAttributes"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "DisplayAttributes"))) { #optional property not found
            $DisplayAttributes = $null
        } else {
            $DisplayAttributes = $JsonParameters.PSobject.Properties["DisplayAttributes"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Selector"))) { #optional property not found
            $Selector = $null
        } else {
            $Selector = $JsonParameters.PSobject.Properties["Selector"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "SupportedObjects"))) { #optional property not found
            $SupportedObjects = $null
        } else {
            $SupportedObjects = $JsonParameters.PSobject.Properties["SupportedObjects"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "ConnectorAttribute" = ${ConnectorAttribute}
            "ConstraintAttributes" = ${ConstraintAttributes}
            "DisplayAttributes" = ${DisplayAttributes}
            "Selector" = ${Selector}
            "SupportedObjects" = ${SupportedObjects}
        }

        return $PSO
    }

}

