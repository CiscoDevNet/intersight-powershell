# if you have not build the module then run the build.ps1 file in the moudle folder.
# in this script user has created the module.

import-module -Name .\Intersight.PowerShell

#check the imported module uisng 
Get-Module 

$onprem = @{
    BasePath = "https://intersight.cisco.com"
    ApiKeyId = "xxxxx27564612d30dxxxxx/5f21c9d97564612d30dd575a/5f9a8b877564612xxxxxxxx"
    ApiKeyFilePath = "C:\\secrectKey.txt" 
    HttpSingingHeader =  @("(request-target)", "Host", "Date", "Digest")
}

Set-IntersightConfiguration @onprem

#check the configuration is set or not by using below cmdlet
Get-IntersightConfiguration
