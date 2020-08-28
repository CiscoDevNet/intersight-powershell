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

A relationship to the 'network.Element' resource, or the expanded 'network.Element' resource, or the 'null' value.

.PARAMETER Json

JSON object

.OUTPUTS

NetworkElementRelationship<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToNetworkElementRelationship {
    [CmdletBinding()]
    Param (
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        $match = 0
        $matchType = $null
        $matchInstance = $null

        # nullalble check
        if ([string]::IsNullOrEmpty($Json) -or $Json -eq "{}") {
            return [PSCustomObject]@{
                "ActualType" = $null
                "ActualInstance" = $null
                "OneOfSchemas" = @("MoMoRef", "NetworkElement")
            }
        }

        $JsonData = ConvertFrom-Json -InputObject $Json
        # check if the discriminator value is 'mo.MoRef'
        if ($JsonData.PSobject.Properties["ClassId"].value -eq "mo.MoRef") {
            # try to match MoMoRef defined in the oneOf schemas
            try {
                $matchInstance = ConvertFrom-IntersightJsonToMoMoRef $Json

                foreach($property in $matchInstance.PsObject.Properties) {
                    if ($null -ne $property.Value) {
                        $matchType = "MoMoRef"
                        return [PSCustomObject]@{
                            "ActualType" = ${matchType}
                            "ActualInstance" = ${matchInstance}
                            "oneOfSchemas" = @("MoMoRef", "NetworkElement")
                        }
                    }
                }
            } catch {
                # fail to match the schema defined in oneOf with the discriminator lookup, proceed to the next one
                Write-Debug "Failed to match 'MoMoRef' defined in oneOf (IntersightNetworkElementRelationship) using the discriminator lookup (mo.MoRef). Proceeding with the typical oneOf type matching."
            }
        }

        # check if the discriminator value is 'network.Element'
        if ($JsonData.PSobject.Properties["ClassId"].value -eq "network.Element") {
            # try to match NetworkElement defined in the oneOf schemas
            try {
                $matchInstance = ConvertFrom-IntersightJsonToNetworkElement $Json

                foreach($property in $matchInstance.PsObject.Properties) {
                    if ($null -ne $property.Value) {
                        $matchType = "NetworkElement"
                        return [PSCustomObject]@{
                            "ActualType" = ${matchType}
                            "ActualInstance" = ${matchInstance}
                            "oneOfSchemas" = @("MoMoRef", "NetworkElement")
                        }
                    }
                }
            } catch {
                # fail to match the schema defined in oneOf with the discriminator lookup, proceed to the next one
                Write-Debug "Failed to match 'NetworkElement' defined in oneOf (IntersightNetworkElementRelationship) using the discriminator lookup (network.Element). Proceeding with the typical oneOf type matching."
            }
        }

        # try to match MoMoRef defined in the oneOf schemas
        try {
            $matchInstance = ConvertFrom-IntersightJsonToMoMoRef $Json

            foreach($property in $matchInstance.PsObject.Properties) {
                if ($null -ne $property.Value) {
                    $matchType = "MoMoRef"
                    $match++
                    break
                }
            }
        } catch {
            # fail to match the schema defined in oneOf, proceed to the next one
            Write-Debug "Failed to match 'MoMoRef' defined in oneOf (IntersightNetworkElementRelationship). Proceeding to the next one if any."
        }

        # try to match NetworkElement defined in the oneOf schemas
        try {
            $matchInstance = ConvertFrom-IntersightJsonToNetworkElement $Json

            foreach($property in $matchInstance.PsObject.Properties) {
                if ($null -ne $property.Value) {
                    $matchType = "NetworkElement"
                    $match++
                    break
                }
            }
        } catch {
            # fail to match the schema defined in oneOf, proceed to the next one
            Write-Debug "Failed to match 'NetworkElement' defined in oneOf (IntersightNetworkElementRelationship). Proceeding to the next one if any."
        }

        if ($match -gt 1) {
            throw "Error! The JSON payload matches more than one type defined in oneOf schemas ([MoMoRef, NetworkElement]). JSON Payload: $($Json)"
        } elseif ($match -eq 1) {
            return [PSCustomObject]@{
                "ActualType" = ${matchType}
                "ActualInstance" = ${matchInstance}
                "OneOfSchemas" = @("MoMoRef", "NetworkElement")
            }
        } else {
            throw "Error! The JSON payload doesn't matches any type defined in oneOf schemas ([MoMoRef, NetworkElement]). JSON Payload: $($Json)"
        }
    }
}

