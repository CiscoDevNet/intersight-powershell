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

Definition of the list of properties defined in 'appliance.DeviceCertificate', excluding properties defined in parent classes.

.PARAMETER ClassId
The fully-qualified name of the instantiated, concrete type. This property is used as a discriminator to identify the type of the payload when marshaling and unmarshaling data.
.PARAMETER ObjectType
The fully-qualified name of the instantiated, concrete type. The value should be the same as the 'ClassId' property.
.PARAMETER CompletedPhases
No description available.
.PARAMETER ConfigurationMoId
The operation configuration MOId.
.PARAMETER CurrentPhase
No description available.
.PARAMETER Messages
No description available.
.PARAMETER StartTime
Start date of the certificate renewal.
.PARAMETER Status
The status of ca certificate renewal.
.OUTPUTS

ApplianceDeviceCertificateAllOf<PSCustomObject>
#>

function Initialize-IntersightApplianceDeviceCertificateAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("appliance.DeviceCertificate")]
        [String]
        ${ClassId} = "appliance.DeviceCertificate",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("appliance.DeviceCertificate")]
        [String]
        ${ObjectType} = "appliance.DeviceCertificate",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject[]]
        ${CompletedPhases},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${ConfigurationMoId},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${CurrentPhase},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String[]]
        ${Messages},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${StartTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Status}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightApplianceDeviceCertificateAllOf' | Write-Debug
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
            "CompletedPhases" = ${CompletedPhases}
            "ConfigurationMoId" = ${ConfigurationMoId}
            "CurrentPhase" = ${CurrentPhase}
            "Messages" = ${Messages}
            "StartTime" = ${StartTime}
            "Status" = ${Status}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to ApplianceDeviceCertificateAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to ApplianceDeviceCertificateAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

ApplianceDeviceCertificateAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToApplianceDeviceCertificateAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightApplianceDeviceCertificateAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightApplianceDeviceCertificateAllOf
        $AllProperties = ("ClassId", "ObjectType", "CaCertificate", "CaCertificateExpiryTime", "CertificateRenewalExpiryTime", "CompletedPhases", "ConfigurationMoId", "CurrentPhase", "EndTime", "LastSuccessPollTime", "Messages", "StartTime", "Status")
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

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CaCertificate"))) { #optional property not found
            $CaCertificate = $null
        } else {
            $CaCertificate = $JsonParameters.PSobject.Properties["CaCertificate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CaCertificateExpiryTime"))) { #optional property not found
            $CaCertificateExpiryTime = $null
        } else {
            $CaCertificateExpiryTime = $JsonParameters.PSobject.Properties["CaCertificateExpiryTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CertificateRenewalExpiryTime"))) { #optional property not found
            $CertificateRenewalExpiryTime = $null
        } else {
            $CertificateRenewalExpiryTime = $JsonParameters.PSobject.Properties["CertificateRenewalExpiryTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CompletedPhases"))) { #optional property not found
            $CompletedPhases = $null
        } else {
            $CompletedPhases = $JsonParameters.PSobject.Properties["CompletedPhases"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ConfigurationMoId"))) { #optional property not found
            $ConfigurationMoId = $null
        } else {
            $ConfigurationMoId = $JsonParameters.PSobject.Properties["ConfigurationMoId"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "CurrentPhase"))) { #optional property not found
            $CurrentPhase = $null
        } else {
            $CurrentPhase = $JsonParameters.PSobject.Properties["CurrentPhase"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "EndTime"))) { #optional property not found
            $EndTime = $null
        } else {
            $EndTime = $JsonParameters.PSobject.Properties["EndTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "LastSuccessPollTime"))) { #optional property not found
            $LastSuccessPollTime = $null
        } else {
            $LastSuccessPollTime = $JsonParameters.PSobject.Properties["LastSuccessPollTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Messages"))) { #optional property not found
            $Messages = $null
        } else {
            $Messages = $JsonParameters.PSobject.Properties["Messages"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "StartTime"))) { #optional property not found
            $StartTime = $null
        } else {
            $StartTime = $JsonParameters.PSobject.Properties["StartTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Status"))) { #optional property not found
            $Status = $null
        } else {
            $Status = $JsonParameters.PSobject.Properties["Status"].value
        }

        $PSO = [PSCustomObject]@{
            "ClassId" = ${ClassId}
            "ObjectType" = ${ObjectType}
            "CaCertificate" = ${CaCertificate}
            "CaCertificateExpiryTime" = ${CaCertificateExpiryTime}
            "CertificateRenewalExpiryTime" = ${CertificateRenewalExpiryTime}
            "CompletedPhases" = ${CompletedPhases}
            "ConfigurationMoId" = ${ConfigurationMoId}
            "CurrentPhase" = ${CurrentPhase}
            "EndTime" = ${EndTime}
            "LastSuccessPollTime" = ${LastSuccessPollTime}
            "Messages" = ${Messages}
            "StartTime" = ${StartTime}
            "Status" = ${Status}
        }

        return $PSO
    }

}

