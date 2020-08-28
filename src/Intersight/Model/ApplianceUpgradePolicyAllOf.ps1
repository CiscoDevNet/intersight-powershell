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

Definition of the list of properties defined in 'appliance.UpgradePolicy', excluding properties defined in parent classes.

.PARAMETER AutoUpgrade
Indicates if the upgrade service is set to automatically start the software upgrade or not. If autoUpgrade is true, then the value of the schedule field is ignored.
.PARAMETER BlackoutDatesEnabled
If enabled, allows the user to define a blackout period during which the appliance will not be upgraded.
.PARAMETER BlackoutEndDate
End date of the black out period.
.PARAMETER BlackoutStartDate
Start date of the black out period. The appliance will not be upgraded during this period.
.PARAMETER Schedule
No description available.
.PARAMETER Account
No description available.
.OUTPUTS

ApplianceUpgradePolicyAllOf<PSCustomObject>
#>

function Initialize-IntersightApplianceUpgradePolicyAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${AutoUpgrade},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[Boolean]]
        ${BlackoutDatesEnabled},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${BlackoutEndDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [System.Nullable[System.DateTime]]
        ${BlackoutStartDate},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Schedule},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [PSCustomObject]
        ${Account}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightApplianceUpgradePolicyAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "AutoUpgrade" = ${AutoUpgrade}
            "BlackoutDatesEnabled" = ${BlackoutDatesEnabled}
            "BlackoutEndDate" = ${BlackoutEndDate}
            "BlackoutStartDate" = ${BlackoutStartDate}
            "Schedule" = ${Schedule}
            "Account" = ${Account}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to ApplianceUpgradePolicyAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to ApplianceUpgradePolicyAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

ApplianceUpgradePolicyAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToApplianceUpgradePolicyAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightApplianceUpgradePolicyAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightApplianceUpgradePolicyAllOf
        $AllProperties = ("AutoUpgrade", "BlackoutDatesEnabled", "BlackoutEndDate", "BlackoutStartDate", "Schedule", "Account")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "AutoUpgrade"))) { #optional property not found
            $AutoUpgrade = $null
        } else {
            $AutoUpgrade = $JsonParameters.PSobject.Properties["AutoUpgrade"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BlackoutDatesEnabled"))) { #optional property not found
            $BlackoutDatesEnabled = $null
        } else {
            $BlackoutDatesEnabled = $JsonParameters.PSobject.Properties["BlackoutDatesEnabled"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BlackoutEndDate"))) { #optional property not found
            $BlackoutEndDate = $null
        } else {
            $BlackoutEndDate = $JsonParameters.PSobject.Properties["BlackoutEndDate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "BlackoutStartDate"))) { #optional property not found
            $BlackoutStartDate = $null
        } else {
            $BlackoutStartDate = $JsonParameters.PSobject.Properties["BlackoutStartDate"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Schedule"))) { #optional property not found
            $Schedule = $null
        } else {
            $Schedule = $JsonParameters.PSobject.Properties["Schedule"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Account"))) { #optional property not found
            $Account = $null
        } else {
            $Account = $JsonParameters.PSobject.Properties["Account"].value
        }

        $PSO = [PSCustomObject]@{
            "AutoUpgrade" = ${AutoUpgrade}
            "BlackoutDatesEnabled" = ${BlackoutDatesEnabled}
            "BlackoutEndDate" = ${BlackoutEndDate}
            "BlackoutStartDate" = ${BlackoutStartDate}
            "Schedule" = ${Schedule}
            "Account" = ${Account}
        }

        return $PSO
    }

}
