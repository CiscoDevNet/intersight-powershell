#
# Cisco Intersight
# Cisco Intersight is a management platform delivered as a service with embedded analytics for your Cisco and 3rd party IT infrastructure. This platform offers an intelligent level of management that enables IT organizations to analyze, simplify, and automate their environments in more advanced ways than the prior generations of tools. Cisco Intersight provides an integrated and intuitive management experience for resources in the traditional data center as well as at the edge. With flexible deployment options to address complex security needs, getting started with Intersight is quick and easy. Cisco Intersight has deep integration with Cisco UCS and HyperFlex systems allowing for remote deployment, configuration, and ongoing maintenance. The model-based deployment works for a single system in a remote location or hundreds of systems in a data center and enables rapid, standardized configuration and deployment. It also streamlines maintaining those systems whether you are working with small or very large configurations. The Intersight OpenAPI document defines the complete set of properties that are returned in the HTTP response. From that perspective, a client can expect that no additional properties are returned, unless these properties are explicitly defined in the OpenAPI document. However, when a client uses an older version of the Intersight OpenAPI document, the server may send additional properties because the software is more recent than the client. In that case, the client may receive properties that it does not know about. Some generated SDKs perform a strict validation of the HTTP response body against the OpenAPI document. This document was created on 2020-07-16T08:45:19Z.
# Version: 1.0.9-2020
# Contact: intersight@cisco.com
# Generated by OpenAPI Generator: https://openapi-generator.tech
#

<#
.SYNOPSIS

No summary available.

.DESCRIPTION

Definition of the list of properties defined in 'recovery.BackupSchedule', excluding properties defined in parent classes.

.PARAMETER ExecutionTime
The time at which the backup is to be run on a given day. This is used when the frequency unit is daily.
.PARAMETER FrequencyUnit
The frequency at which the backup schedule must run.
.PARAMETER Hours
The frequency, in hours, at which the backup schedule runs.
.OUTPUTS

RecoveryBackupScheduleAllOf<PSCustomObject>
#>

function Initialize-IntersightRecoveryBackupScheduleAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${ExecutionTime},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("Daily", "Periodic")]
        [String]
        ${FrequencyUnit} = "Daily",
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [ValidateSet("8", "4", "12", "16", "20")]
        [System.Nullable[Int32]]
        ${Hours} = 8
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightRecoveryBackupScheduleAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "ExecutionTime" = ${ExecutionTime}
            "FrequencyUnit" = ${FrequencyUnit}
            "Hours" = ${Hours}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to RecoveryBackupScheduleAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to RecoveryBackupScheduleAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

RecoveryBackupScheduleAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToRecoveryBackupScheduleAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightRecoveryBackupScheduleAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightRecoveryBackupScheduleAllOf
        $AllProperties = ("ExecutionTime", "FrequencyUnit", "Hours")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "ExecutionTime"))) { #optional property not found
            $ExecutionTime = $null
        } else {
            $ExecutionTime = $JsonParameters.PSobject.Properties["ExecutionTime"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "FrequencyUnit"))) { #optional property not found
            $FrequencyUnit = $null
        } else {
            $FrequencyUnit = $JsonParameters.PSobject.Properties["FrequencyUnit"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Hours"))) { #optional property not found
            $Hours = $null
        } else {
            $Hours = $JsonParameters.PSobject.Properties["Hours"].value
        }

        $PSO = [PSCustomObject]@{
            "ExecutionTime" = ${ExecutionTime}
            "FrequencyUnit" = ${FrequencyUnit}
            "Hours" = ${Hours}
        }

        return $PSO
    }

}
