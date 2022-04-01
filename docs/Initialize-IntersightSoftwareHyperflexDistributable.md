---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightSoftwareHyperflexDistributable

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightSoftwareHyperflexDistributable [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-Catalog< Model.SoftwarerepositoryCatalogRelationship>][-ClassId< SoftwareHyperflexDistributable.ClassIdEnum>][-ComponentMeta< System.Collections.Generic.List`1[Model.FirmwareComponentMeta]>][-Description< string>][-DistributableMetas< System.Collections.Generic.List`1[Model.FirmwareDistributableMetaRelationship]>][-ImageType< string>][-ImportAction< SoftwareHyperflexDistributable.ImportActionEnum>][-Md5eTag< string>][-Md5sum< string>][-Mdfid< string>][-Model< string>][-Moid< string>][-Name< string>][-ObjectType< SoftwareHyperflexDistributable.ObjectTypeEnum>][-RecommendedBuild< string>][-Release< Model.SoftwarerepositoryReleaseRelationship>][-ReleaseDate< DateTime>][-ReleaseNotesUrl< string>][-Sha512sum< string>][-Size< long>][-SoftwareAdvisoryUrl< string>][-Source< Model.SoftwarerepositoryFileServer>][-SupportedModels< System.Collections.Generic.List`1[string]>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-Vendor< string>][-Version< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION

Initialize cmdlet is used to instantiate the object of complex type in the Powershell session, it does not create the object on the server.

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

### -Catalog
A reference to a softwarerepositoryCatalog resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.SoftwarerepositoryCatalogRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: SoftwareHyperflexDistributable.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ComponentMeta


Note :- Use Initialize-IntersightFirmwareComponentMeta to create the object of complex type FirmwareComponentMeta

```yaml
Type: System.Collections.Generic.List`1[Model.FirmwareComponentMeta]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Description
User provided description about the file. Cisco provided description for image inventoried from a Cisco repository.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -DistributableMetas
An array of relationships to firmwareDistributableMeta resources.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: System.Collections.Generic.List`1[Model.FirmwareDistributableMetaRelationship]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ImageType
The type of image which the distributable falls into according to the component it can upgrade. For e.g.; Standalone server, Intersight managed server, UCS Managed Fabric Interconnect. The field is used in private appliance mode, where image does not have description populated from CCO.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ImportAction
The action to be performed on the imported file. If &apos;PreCache&apos; is set, the image will be cached in Appliance. Applicable in Intersight appliance deployment. If &apos;Evict&apos; is set, the cached file will be removed. Applicable in Intersight appliance deployment. If &apos;GeneratePreSignedUploadUrl&apos; is set, generates pre signed URL (s) for the file to be imported into the repository. Applicable for local machine source. The URL (s) will be populated under LocalMachine file server. If &apos;CompleteImportProcess&apos; is set, the ImportState is marked as &apos;Imported&apos;. Applicable for local machine source. If &apos;Cancel&apos; is set, the ImportState is marked as &apos;Failed&apos;. Applicable for local machine source.\n* `None` - No action should be taken on the imported file.\n* `GeneratePreSignedUploadUrl` - Generate pre signed URL of file for importing into the repository.\n* `GeneratePreSignedDownloadUrl` - Generate pre signed URL of file in the repository to download.\n* `CompleteImportProcess` - Mark that the import process of the file into the repository is complete.\n* `MarkImportFailed` - Mark to indicate that the import process of the file into the repository failed.\n* `PreCache` - Cache the file into the Intersight Appliance.\n* `Cancel` - The cancel import process for the file into the repository.\n* `Extract` - The action to extract the file in the external repository.\n* `Evict` - Evict the cached file from the Intersight Appliance.

```yaml
Type: SoftwareHyperflexDistributable.ImportActionEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Md5eTag
The MD5 ETag for a file that is stored in Intersight repository or in the appliance cache. Warning - MD5 is currently broken and this will be migrated to SHA shortly.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Md5sum
The md5sum checksum of the file. This information is available for all Cisco distributed images and files imported to the local repository.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Mdfid
The mdfid of the image provided by cisco.com.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Model
The endpoint model for which this firmware image is applicable.

```yaml
Type: string
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

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Name
The name of the file. It is populated as part of the image import operation.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: SoftwareHyperflexDistributable.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RecommendedBuild
The build which is recommended by Cisco.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Release
A reference to a softwarerepositoryRelease resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: Model.SoftwarerepositoryReleaseRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ReleaseDate
The date on which the file was released or distributed by its vendor.

```yaml
Type: DateTime
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ReleaseNotesUrl
The url for the release notes of this image.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Sha512sum
The sha512sum of the file. This information is available for all Cisco distributed images and files imported to the local repository.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Size
The size (in bytes) of the file. This information is available for all Cisco distributed images and files imported to the local repository.

```yaml
Type: long
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SoftwareAdvisoryUrl
The software advisory, if any, provided by the vendor for this file.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Source
Location of the file in an external repository.

Note :- Use Initialize-IntersightSoftwarerepositoryFileServer to create the object of complex type SoftwarerepositoryFileServer

```yaml
Type: Model.SoftwarerepositoryFileServer
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SupportedModels


```yaml
Type: System.Collections.Generic.List`1[string]
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
Type: System.Collections.Generic.List`1[Model.MoTag]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Vendor
The vendor or publisher of this file.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Version
Vendor provided version for the file.

```yaml
Type: string
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
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
PS C:\> Initialize-IntersightSoftwareHyperflexDistributable
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightDateTime](./Initialize-IntersightDateTime.md)

[Initialize-IntersightFirmwareComponentMeta](./Initialize-IntersightFirmwareComponentMeta.md)

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)

[Initialize-IntersightSoftwarerepositoryFileServer](./Initialize-IntersightSoftwarerepositoryFileServer.md)
