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

Definition of the list of properties defined in 'aaa.AbstractAuditRecord', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data. The enum values provides the list of concrete types that can be instantiated from this abstract type.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property. The enum values provides the list of concrete types that can be instantiated from this abstract type.
.PARAMETER VarEvent
The operation that was performed on this Managed Object. The event is a compound string that includes the CRUD operation such as Create, Modify, Delete, and a string representing the Managed Object type.
.PARAMETER MoDisplayNames
The user-friendly names of the changed MO.
.PARAMETER MoType
The object type of the REST resource that was created, modified or deleted.
.PARAMETER ObjectMoid
The Moid of the REST resource that was created, modified or deleted.
.PARAMETER Request
The body of the REST request that was received from a client to create or modify a REST resource, represented as a JSON document.
.PARAMETER TraceId
The trace id of the request that was used to create, modify or delete a REST resource. A trace id is a unique identifier for one particular REST request. It may be used for troubleshooting purpose by the Intersight technical support team.
.OUTPUTS

AaaAbstractAuditRecordAllOf<PSCustomObject>
#>

function Initialize-IntersightAaaAbstractAuditRecordAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("aaa.AuditRecord")]
        [String]
        ${ClassId} = "aaa.AuditRecord",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("aaa.AuditRecord")]
        [String]
        ${ObjectType} = "aaa.AuditRecord",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${VarEvent},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${MoDisplayNames},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${MoType},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ObjectMoid},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Request},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${TraceId}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightAaaAbstractAuditRecordAllOf' | Write-Debug
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
            "Event" = ${VarEvent}
            "MoDisplayNames" = ${MoDisplayNames}
            "MoType" = ${MoType}
            "ObjectMoid" = ${ObjectMoid}
            "Request" = ${Request}
            "TraceId" = ${TraceId}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to AaaAbstractAuditRecordAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to AaaAbstractAuditRecordAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

AaaAbstractAuditRecordAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToAaaAbstractAuditRecordAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightAaaAbstractAuditRecordAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightAaaAbstractAuditRecordAllOf
        $AllProperties = ("ClassId", "ObjectType", "Event", "MoDisplayNames", "MoType", "ObjectMoid", "Request", "TraceId")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Event"))) { #optional property not found
            $VarEvent = $null
        } else {
            $VarEvent = $JsonParameters.PSobject.Properties["Event"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MoDisplayNames"))) { #optional property not found
            $MoDisplayNames = $null
        } else {
            $MoDisplayNames = $JsonParameters.PSobject.Properties["MoDisplayNames"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "MoType"))) { #optional property not found
            $MoType = $null
        } else {
            $MoType = $JsonParameters.PSobject.Properties["MoType"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ObjectMoid"))) { #optional property not found
            $ObjectMoid = $null
        } else {
            $ObjectMoid = $JsonParameters.PSobject.Properties["ObjectMoid"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Request"))) { #optional property not found
            $Request = $null
        } else {
            $Request = $JsonParameters.PSobject.Properties["Request"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "TraceId"))) { #optional property not found
            $TraceId = $null
        } else {
            $TraceId = $JsonParameters.PSobject.Properties["TraceId"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "Event" = ${VarEvent}
            "MoDisplayNames" = ${MoDisplayNames}
            "MoType" = ${MoType}
            "ObjectMoid" = ${ObjectMoid}
            "Request" = ${Request}
            "TraceId" = ${TraceId}
        }

        return $PSO
    }

}

