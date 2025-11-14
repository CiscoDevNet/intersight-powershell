---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Set-IntersightLicenseAccountLicenseData

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Set-IntersightLicenseAccountLicenseData [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-CustomerOp< LicenseCustomerOpRelationship>][-DefaultLicenseType< LicenseAccountLicenseData.DefaultLicenseTypeEnum>][-DefaultLicenseTypeNewerModels< LicenseAccountLicenseData.DefaultLicenseTypeNewerModelsEnum>][-ErpCustomerOp< LicenseErpCustomerOpRelationship>][-ErpLicenseCount< LicenseErpLicenseCountRelationship>][-IksCustomerOp< LicenseIksCustomerOpRelationship>][-IksLicenseCount< LicenseIksLicenseCountRelationship>][-IncCustomerOp< LicenseIncCustomerOpRelationship>][-IncLicenseCount< LicenseIncLicenseCountRelationship>][-IwoCustomerOp< LicenseIwoCustomerOpRelationship>][-IwoLicenseCount< LicenseIwoLicenseCountRelationship>][-LicenseInfoView< LicenseLicenseInfoViewRelationship>][-LicenseRegistrationStatus< LicenseLicenseRegistrationStatusRelationship>][-Licenseinfos< System.Collections.Generic.List`1[LicenseLicenseInfoRelationship]>][[-Moid]< string>][-SmartlicenseToken< LicenseSmartlicenseTokenRelationship>][-Tags< System.Collections.Generic.List`1[MoTag]>][-IfMatch< String>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Update a &apos;LicenseAccountLicenseData&apos; resource.

## PARAMETERS

### -AdditionalProperties


```yaml
Type: System.Collections.Generic.Dictionary`2[string,object]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -CustomerOp
A reference to a licenseCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: LicenseCustomerOpRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DefaultLicenseType
Default license tier set by the user.\n* `Base` - Base as a License type. It is default license type.\n* `Essential` - Essential as a License type.\n* `Standard` - Standard as a License type.\n* `Advantage` - Advantage as a License type.\n* `Premier` - Premier as a License type.\n* `IWO-Essential` - IWO-Essential as a License type.\n* `IWO-Advantage` - IWO-Advantage as a License type.\n* `IWO-Premier` - IWO-Premier as a License type.\n* `IKS-Advantage` - IKS-Advantage as a License type.\n* `INC-Premier-1GFixed` - Premier 1G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-10GFixed` - Premier 10G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-100GFixed` - Premier 100G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod4Slot` - Premier Modular 4 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod8Slot` - Premier Modular 8 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsFixed` - Premier D2Ops fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsMod` - Premier D2Ops modular license tier for Intersight Nexus Cloud.\n* `INC-Premier-CentralizedMod8Slot` - Premier modular license tier of switch type CentralizedMod8Slot for Intersight Nexus Cloud.\n* `INC-Premier-DistributedMod8Slot` - Premier modular license tier of switch type DistributedMod8Slot for Intersight Nexus Cloud.\n* `ERP-Advantage` - Advantage license tier for ERP workflows.\n* `IntersightTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Intersight tiers.\n* `IWOTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IKS tiers.\n* `IKSTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IWO tiers.\n* `INCTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Nexus tiers.

```yaml
Type: LicenseAccountLicenseData.DefaultLicenseTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DefaultLicenseTypeNewerModels
Default license tier for newer model M7+ servers set by the user.\n* `Base` - Base as a License type. It is default license type.\n* `Essential` - Essential as a License type.\n* `Standard` - Standard as a License type.\n* `Advantage` - Advantage as a License type.\n* `Premier` - Premier as a License type.\n* `IWO-Essential` - IWO-Essential as a License type.\n* `IWO-Advantage` - IWO-Advantage as a License type.\n* `IWO-Premier` - IWO-Premier as a License type.\n* `IKS-Advantage` - IKS-Advantage as a License type.\n* `INC-Premier-1GFixed` - Premier 1G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-10GFixed` - Premier 10G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-100GFixed` - Premier 100G Fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod4Slot` - Premier Modular 4 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-Mod8Slot` - Premier Modular 8 slot license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsFixed` - Premier D2Ops fixed license tier for Intersight Nexus Cloud.\n* `INC-Premier-D2OpsMod` - Premier D2Ops modular license tier for Intersight Nexus Cloud.\n* `INC-Premier-CentralizedMod8Slot` - Premier modular license tier of switch type CentralizedMod8Slot for Intersight Nexus Cloud.\n* `INC-Premier-DistributedMod8Slot` - Premier modular license tier of switch type DistributedMod8Slot for Intersight Nexus Cloud.\n* `ERP-Advantage` - Advantage license tier for ERP workflows.\n* `IntersightTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Intersight tiers.\n* `IWOTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IKS tiers.\n* `IKSTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode IWO tiers.\n* `INCTrial` - Virtual dummy license type to indicate trial. Used for UI display of trial mode Nexus tiers.

```yaml
Type: LicenseAccountLicenseData.DefaultLicenseTypeNewerModelsEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ErpCustomerOp
A reference to a licenseErpCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: LicenseErpCustomerOpRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ErpLicenseCount
A reference to a licenseErpLicenseCount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: LicenseErpLicenseCountRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IksCustomerOp
A reference to a licenseIksCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: LicenseIksCustomerOpRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IksLicenseCount
A reference to a licenseIksLicenseCount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: LicenseIksLicenseCountRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IncCustomerOp
A reference to a licenseIncCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: LicenseIncCustomerOpRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IncLicenseCount
A reference to a licenseIncLicenseCount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: LicenseIncLicenseCountRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IwoCustomerOp
A reference to a licenseIwoCustomerOp resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: LicenseIwoCustomerOpRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IwoLicenseCount
A reference to a licenseIwoLicenseCount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: LicenseIwoLicenseCountRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LicenseInfoView
A reference to a licenseLicenseInfoView resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: LicenseLicenseInfoViewRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -LicenseRegistrationStatus
A reference to a licenseLicenseRegistrationStatus resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: LicenseLicenseRegistrationStatusRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Licenseinfos
An array of relationships to licenseLicenseInfo resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[LicenseLicenseInfoRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Moid
The unique identifier of this Managed Object instance.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: true
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SmartlicenseToken
A reference to a licenseSmartlicenseToken resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: LicenseSmartlicenseTokenRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Tags


Note :- Use Initialize-IntersightMoTag to create the object of complex type MoTag

```yaml
Type: System.Collections.Generic.List`1[MoTag]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IfMatch
For methods that apply server-side changes, and in particular for PUT, If-Match can be used to prevent the lost update problem. It can check if the modification of a resource that the user wants to upload will not override another change that has been done since the original resource was fetched. If the request cannot be fulfilled, the 412 (Precondition Failed) response is returned. When modifying a resource using POST or PUT, the If-Match header must be set to the value of the resource ModTime property after which no lost update problem should occur. For example, a client send a GET request to obtain a resource, which includes the ModTime property. The ModTime indicates the last time the resource was created or modified. The client then sends a POST or PUT request with the If-Match header set to the ModTime property of the resource as obtained in the GET request.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -Json
Returns the json payload received in response.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```

### -WithHttpInfo
Returns the HTTP response with headers and content.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True False
Accept wildcard characters: False
```


### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## EXAMPLES

### Example 1
```powershell
PS C:\> Set-IntersightLicenseAccountLicenseData
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Get-IntersightLicenseAccountLicenseData](./Get-IntersightLicenseAccountLicenseData.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
