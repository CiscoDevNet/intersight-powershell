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

The granularity field determines how data gets bucketed across the time dimension, or how it gets aggregated by hour, day, minute, etc. It can be specified either as a string for simple granularities or as an object for arbitrary granularities. See [Granularities](https://druid.apache.org/docs/latest/querying/granularities.html).

.PARAMETER Json

JSON object

.OUTPUTS

TelemetryDruidGranularity<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToTelemetryDruidGranularity {
    [CmdletBinding()]
    Param (
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        $match = 0
        $matchType = $null
        $matchInstance = $null

        $JsonData = ConvertFrom-Json -InputObject $Json
        # check if the discriminator value is 'duration'
        if ($JsonData.PSobject.Properties["type"].value -eq "duration") {
            # try to match TelemetryDruidDurationGranularity defined in the oneOf schemas
            try {
                $matchInstance = ConvertFrom-IntersightJsonToTelemetryDruidDurationGranularity $Json

                foreach($property in $matchInstance.PsObject.Properties) {
                    if ($null -ne $property.Value) {
                        $matchType = "TelemetryDruidDurationGranularity"
                        return [PSCustomObject]@{
                            "ActualType" = ${matchType}
                            "ActualInstance" = ${matchInstance}
                            "oneOfSchemas" = @("TelemetryDruidDurationGranularity", "TelemetryDruidPeriodGranularity")
                        }
                    }
                }
            } catch {
                # fail to match the schema defined in oneOf with the discriminator lookup, proceed to the next one
                Write-Debug "Failed to match 'TelemetryDruidDurationGranularity' defined in oneOf (IntersightTelemetryDruidGranularity) using the discriminator lookup (duration). Proceeding with the typical oneOf type matching."
            }
        }

        # check if the discriminator value is 'period'
        if ($JsonData.PSobject.Properties["type"].value -eq "period") {
            # try to match TelemetryDruidPeriodGranularity defined in the oneOf schemas
            try {
                $matchInstance = ConvertFrom-IntersightJsonToTelemetryDruidPeriodGranularity $Json

                foreach($property in $matchInstance.PsObject.Properties) {
                    if ($null -ne $property.Value) {
                        $matchType = "TelemetryDruidPeriodGranularity"
                        return [PSCustomObject]@{
                            "ActualType" = ${matchType}
                            "ActualInstance" = ${matchInstance}
                            "oneOfSchemas" = @("TelemetryDruidDurationGranularity", "TelemetryDruidPeriodGranularity")
                        }
                    }
                }
            } catch {
                # fail to match the schema defined in oneOf with the discriminator lookup, proceed to the next one
                Write-Debug "Failed to match 'TelemetryDruidPeriodGranularity' defined in oneOf (IntersightTelemetryDruidGranularity) using the discriminator lookup (period). Proceeding with the typical oneOf type matching."
            }
        }

        # check if the discriminator value is 'telemetry.DruidDurationGranularity'
        if ($JsonData.PSobject.Properties["type"].value -eq "telemetry.DruidDurationGranularity") {
            # try to match TelemetryDruidDurationGranularity defined in the oneOf schemas
            try {
                $matchInstance = ConvertFrom-IntersightJsonToTelemetryDruidDurationGranularity $Json

                foreach($property in $matchInstance.PsObject.Properties) {
                    if ($null -ne $property.Value) {
                        $matchType = "TelemetryDruidDurationGranularity"
                        return [PSCustomObject]@{
                            "ActualType" = ${matchType}
                            "ActualInstance" = ${matchInstance}
                            "oneOfSchemas" = @("TelemetryDruidDurationGranularity", "TelemetryDruidPeriodGranularity")
                        }
                    }
                }
            } catch {
                # fail to match the schema defined in oneOf with the discriminator lookup, proceed to the next one
                Write-Debug "Failed to match 'TelemetryDruidDurationGranularity' defined in oneOf (IntersightTelemetryDruidGranularity) using the discriminator lookup (telemetry.DruidDurationGranularity). Proceeding with the typical oneOf type matching."
            }
        }

        # check if the discriminator value is 'telemetry.DruidPeriodGranularity'
        if ($JsonData.PSobject.Properties["type"].value -eq "telemetry.DruidPeriodGranularity") {
            # try to match TelemetryDruidPeriodGranularity defined in the oneOf schemas
            try {
                $matchInstance = ConvertFrom-IntersightJsonToTelemetryDruidPeriodGranularity $Json

                foreach($property in $matchInstance.PsObject.Properties) {
                    if ($null -ne $property.Value) {
                        $matchType = "TelemetryDruidPeriodGranularity"
                        return [PSCustomObject]@{
                            "ActualType" = ${matchType}
                            "ActualInstance" = ${matchInstance}
                            "oneOfSchemas" = @("TelemetryDruidDurationGranularity", "TelemetryDruidPeriodGranularity")
                        }
                    }
                }
            } catch {
                # fail to match the schema defined in oneOf with the discriminator lookup, proceed to the next one
                Write-Debug "Failed to match 'TelemetryDruidPeriodGranularity' defined in oneOf (IntersightTelemetryDruidGranularity) using the discriminator lookup (telemetry.DruidPeriodGranularity). Proceeding with the typical oneOf type matching."
            }
        }

        # try to match TelemetryDruidDurationGranularity defined in the oneOf schemas
        try {
            $matchInstance = ConvertFrom-IntersightJsonToTelemetryDruidDurationGranularity $Json

            foreach($property in $matchInstance.PsObject.Properties) {
                if ($null -ne $property.Value) {
                    $matchType = "TelemetryDruidDurationGranularity"
                    $match++
                    break
                }
            }
        } catch {
            # fail to match the schema defined in oneOf, proceed to the next one
            Write-Debug "Failed to match 'TelemetryDruidDurationGranularity' defined in oneOf (IntersightTelemetryDruidGranularity). Proceeding to the next one if any."
        }

        # try to match TelemetryDruidPeriodGranularity defined in the oneOf schemas
        try {
            $matchInstance = ConvertFrom-IntersightJsonToTelemetryDruidPeriodGranularity $Json

            foreach($property in $matchInstance.PsObject.Properties) {
                if ($null -ne $property.Value) {
                    $matchType = "TelemetryDruidPeriodGranularity"
                    $match++
                    break
                }
            }
        } catch {
            # fail to match the schema defined in oneOf, proceed to the next one
            Write-Debug "Failed to match 'TelemetryDruidPeriodGranularity' defined in oneOf (IntersightTelemetryDruidGranularity). Proceeding to the next one if any."
        }

        if ($match -gt 1) {
            throw "Error! The JSON payload matches more than one type defined in oneOf schemas ([TelemetryDruidDurationGranularity, TelemetryDruidPeriodGranularity]). JSON Payload: $($Json)"
        } elseif ($match -eq 1) {
            return [PSCustomObject]@{
                "ActualType" = ${matchType}
                "ActualInstance" = ${matchInstance}
                "OneOfSchemas" = @("TelemetryDruidDurationGranularity", "TelemetryDruidPeriodGranularity")
            }
        } else {
            throw "Error! The JSON payload doesn't matches any type defined in oneOf schemas ([TelemetryDruidDurationGranularity, TelemetryDruidPeriodGranularity]). JSON Payload: $($Json)"
        }
    }
}


