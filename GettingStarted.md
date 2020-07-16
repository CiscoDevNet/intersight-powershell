## Writing code using PowerShell SDK
1. To install from the source, run the following command to build and install the PowerShell module locally:
```powershell
Build.ps1
Import-Module -Name '.\src\Intersight' -Verbose
```

2. To configure the Intersight URL, use the Set-IntersightConfiguration cmdlet:

```powershell
Set-IntersightConfiguration -BaseUrl "https://intersight.com"
```
   - **BaseUrl** : Intersight URL
   - **SkipCertificateCheck** : This parameter is used to bypass the certificate check.

3. Configure the HTTP signing parameters.
```powershell
$httpSigningParams = @{
    KeyId = "XXXXXXX96736327a31bbebff/XXXXXX586736327a31bbeb74/XXXXX054647339736e57b82c"
    KeyFilePath = "C:\SecrectKey.txt"
    HttpSigningHeader = @("(request-target)","Host","Date","Digest")
    HashAlgorithm = "sha256"
}

Set-IntersightConfigurationHttpSigning @httpSigningParams
```
- Verify the above configurations using the following cmdlets
```powershell
Get-IntersightConfiguration
Get-IntersightConfigurationHttpSigning
```
4. Once the above configuration is done, you can execute Intersight cmdlets
- To get the list of Server Profiles
```powershell
$SeverProfileList = Get-IntersightServerProfileList
```
- To get the Server Profile by MOID
```powershell
$serverProfile = Get-IntersightServerProfileByMoid -Moid xxxxxxxxxxxxxxxxxxxxxxxxxxxx
```
- To create a new Server Profile
```powershell
# fetch the organization by Moid
$org = Get-IntersightOrganizationOrganizationByMoid -Moid xxxxxxxxxxxxxxxxxxxxxxxxxxxx

$orgRef = [PSCustomObject]@{
    ObjectType = $org.ObjectType
    Moid = $org.Moid
}

#create the server Profile Object using Initialize cmdlet
$demoServerprofile = Initialize-IntersightServerProfile -Name "demoServerprofile" -Description "demoServerprofile" -Organization $orgRef -TargetPlatform Standalone
$serverProfileResult = New-IntersightServerProfile -ServerProfile $demoServerprofile
```
- To associate a Server Profile to a sever and deploy it:
```powershell
# Get the RackServer Unit where server Profile should be deployed
$computeRackUnit = Get-IntersightComputeRackUnitByMoid -Moid xxxxxxxxxxxxxxxxxxxxxxxxxxxx
$computeRackRef = [PSCustomObject]@{
    ObjectType = $computeRackUnit.ObjectType
    Moid = $computeRackUnit.Moid
}

#assign the server to the server Profile
$updateServerProfile = $serverProfileResult | Initialize-IntersightServerProfile -AssignedServer $computeRackRef -Action "Deploy"
$result = Set-IntersightServerProfile -Moid $updateServerProfile.Moid -ServerProfile $updateServerProfile

#Deploy the server Profile
$deployServerProfile = $result | Initialize-IntersightServerProfile -Action "Deploy"
$deployResult = Set-IntersightServerProfile -Moid $deployServerProfile.Moid -ServerProfile $deployServerProfile
```
- Delete the Server Profile
```powershell
#Note : Make sure the Server Profile is not in use.
Remove-IntersightServerProfile -Moid xxxxxxxxxxxxxxxxxxxxxxxxxxxx
```
