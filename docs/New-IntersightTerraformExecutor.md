---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# New-IntersightTerraformExecutor

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

New-IntersightTerraformExecutor [-Account< IamAccountRelationship>][-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-CloudResource< System.Collections.Generic.List`1[TerraformCloudResource]>][-Command< string>][-Moid< string>][-Operation< TerraformExecutor.OperationEnum>][-Output< object>][-PlatformType< string>][-RegisteredDevice< AssetDeviceRegistrationRelationship>][-RunState< System.Collections.Generic.List`1[TerraformRunstate]>][-SourceFolderName< string>][-SourceFolderPath< string>][-SourceLocation< string>][-Status< string>][-Stderr< object>][-Stdout< object>][-Tags< System.Collections.Generic.List`1[MoTag]>][-TaskId< string>][-Variables< object>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

```

## DESCRIPTION
Create a &apos;TerraformExecutor&apos; resource.

## PARAMETERS

### -Account
A reference to a iamAccount resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: IamAccountRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

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

### -CloudResource


Note :- Use Initialize-IntersightTerraformCloudResource to create the object of complex type TerraformCloudResource

```yaml
Type: System.Collections.Generic.List`1[TerraformCloudResource]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Command
Command to be executed during update operation.

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

### -Operation
Enum indicates what operation is being done.\n* `Create` - Creating a Terraform resource.\n* `Update` - Updating a Terraform resource.\n* `Delete` - Deleting a Terraform resource.

```yaml
Type: TerraformExecutor.OperationEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Output
Terraform output of the entire execution.

Note :- Use Initialize-Intersightobject to create the object of complex type object

```yaml
Type: object
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PlatformType
The Platform type used in conjunction with &amp;apos;sourceFolderPath&amp;apos; and &amp;apos;sourceFolderName&amp;apos; determines unique path for a Terraform workflow.

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

### -RegisteredDevice
A reference to a assetDeviceRegistration resource.\nWhen the $expand query parameter is specified, the referenced resource is returned inline.

 Note:- To get the relationship object pass the MO to the cmdlet Get-IntersightMoMoRef 
or use the cmdlet Initialize-IntersightMoMoRef.

```yaml
Type: AssetDeviceRegistrationRelationship
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -RunState


Note :- Use Initialize-IntersightTerraformRunstate to create the object of complex type TerraformRunstate

```yaml
Type: System.Collections.Generic.List`1[TerraformRunstate]
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SourceFolderName
Folder Name where Terraform workflows are stored.

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

### -SourceFolderPath
Relative folder Path where &apos;sourceFolderName&apos; is located.

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

### -SourceLocation
Flag indicates whether workflow is internal/external.

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

### -Status
Status of the terraform execution.

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

### -Stderr
Stderr of the terraform execution will be captured here.

Note :- Use Initialize-Intersightobject to create the object of complex type object

```yaml
Type: object
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Stdout
Stdout of the terraform execution will be captured here.

Note :- Use Initialize-Intersightobject to create the object of complex type object

```yaml
Type: object
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

### -TaskId
TaskId of a pontem workflow is same as the MO.

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

### -Variables
Variables needed by the terraform configuration as a JSON object.

Note :- Use Initialize-Intersightobject to create the object of complex type object

```yaml
Type: object
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
PS C:\> New-IntersightTerraformExecutor
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Set-IntersightTerraformExecutor](./Set-IntersightTerraformExecutor.md)

[Remove-IntersightTerraformExecutor](./Remove-IntersightTerraformExecutor.md)

[Get-IntersightTerraformExecutor](./Get-IntersightTerraformExecutor.md)

[Initialize-IntersightTerraformCloudResource](./Initialize-IntersightTerraformCloudResource.md)

[Initialize-Intersightobject](./Initialize-Intersightobject.md)

[Initialize-IntersightTerraformRunstate](./Initialize-IntersightTerraformRunstate.md)

[Initialize-IntersightMoVersionContext](./Initialize-IntersightMoVersionContext.md)
