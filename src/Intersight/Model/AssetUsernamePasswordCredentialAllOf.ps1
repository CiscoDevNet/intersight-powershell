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

Definition of the list of properties defined in 'asset.UsernamePasswordCredential', excluding properties defined in parent classes.

.PARAMETER Password
The password used to authenticate with a managed target.
.PARAMETER Username
The username used to authenticate with a managed target.
.OUTPUTS

AssetUsernamePasswordCredentialAllOf<PSCustomObject>
#>

function Initialize-IntersightAssetUsernamePasswordCredentialAllOf {
    [CmdletBinding()]
    Param (
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Password},
        [Parameter(ValueFromPipelineByPropertyName = $true)]
        [String]
        ${Username}
    )

    Process {
        'Creating PSCustomObject: Intersight => IntersightAssetUsernamePasswordCredentialAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        
        $PSO = [PSCustomObject]@{
            "Password" = ${Password}
            "Username" = ${Username}
        }

        return $PSO
    }
}

<#
.SYNOPSIS

Convert from JSON to AssetUsernamePasswordCredentialAllOf<PSCustomObject>

.DESCRIPTION

Convert from JSON to AssetUsernamePasswordCredentialAllOf<PSCustomObject>

.PARAMETER Json

Json object

.OUTPUTS

AssetUsernamePasswordCredentialAllOf<PSCustomObject>
#>
function ConvertFrom-IntersightJsonToAssetUsernamePasswordCredentialAllOf {
    Param(
        [AllowEmptyString()]
        [string]$Json
    )

    Process {
        'Converting JSON to PSCustomObject: Intersight => IntersightAssetUsernamePasswordCredentialAllOf' | Write-Debug
        $PSBoundParameters | Out-DebugParameter | Write-Debug

        $JsonParameters = ConvertFrom-Json -InputObject $Json

        # check if Json contains properties not defined in IntersightAssetUsernamePasswordCredentialAllOf
        $AllProperties = ("IsPasswordSet", "Password", "Username")
        foreach ($name in $JsonParameters.PsObject.Properties.Name) {
            if (!($AllProperties.Contains($name))) {
                throw "Error! JSON key '$name' not found in the properties: $($AllProperties)"
            }
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "IsPasswordSet"))) { #optional property not found
            $IsPasswordSet = $null
        } else {
            $IsPasswordSet = $JsonParameters.PSobject.Properties["IsPasswordSet"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Password"))) { #optional property not found
            $Password = $null
        } else {
            $Password = $JsonParameters.PSobject.Properties["Password"].value
        }

        if (!([bool]($JsonParameters.PSobject.Properties.name -match "Username"))) { #optional property not found
            $Username = $null
        } else {
            $Username = $JsonParameters.PSobject.Properties["Username"].value
        }

        $PSO = [PSCustomObject]@{
            "IsPasswordSet" = ${IsPasswordSet}
            "Password" = ${Password}
            "Username" = ${Username}
        }

        return $PSO
    }

}
