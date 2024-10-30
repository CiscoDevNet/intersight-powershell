---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightIamFeatureDefinition

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightIamFeatureDefinition [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< IamFeatureDefinition.ClassIdEnum>][-Feature< IamFeatureDefinition.FeatureEnum>][-ObjectType< IamFeatureDefinition.ObjectTypeEnum>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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

### -ClassId
The fully-qualified name of the instantiated, concrete type.\nThis property is used as a discriminator to identify the type of the payload\nwhen marshaling and unmarshaling data.

```yaml
Type: IamFeatureDefinition.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Feature
The beta feature that will be enabled for specific account.\n* `IWO` - Intersight Workflow Optimizer.\n* `Hitachi` - Support to claim Hitachi Storage arrays using the Intersight Orchestrator framework.\n* `KubernetesExtension` - Extension to the IKS and Adopted Clusters.\n* `NetAppIO` - Support to claim NetApp Storage arrays as IO targets.\n* `IvsPublicCloud` - Enables virtualization service for public clouds.\n* `TerraformCloud` - Enables an ability to create Terraform Cloud.\n* `WashingtonEFT` - Support for EFT customers to use Washington firmware images for upgrades.\n* `Solutions` - Support for managing solutions.\n* `IksBm` - Enables Intersight Kubernetes Service on Baremetal server.\n* `NexusCloud` - Enables Nexus Cloud services functionality.\n* `NexusCloudTrial` - Enables Nexus Cloud trial period.\n* `NexusCloudUpgradeAssist` - Enables Nexus Cloud upgrade assist.\n* `NexusCloudSustainability` - Enables Nexus Cloud sustainability.\n* `PlatformUIRefresh` - Enables platform refreshed UI with new service launcher.\n* `IksGpu` - Enables GPU support for Intersight Kubernetes Service.\n* `IwoAppServiceVerticalScaling` - Enables vertical Scaling of App Service Plans.\n* `IwoDataExporter` - Enables IWO Data Exporter component.\n* `IwoMigrate` - Enables IWO data Migration.\n* `NexusCloudTechPreviewGold` - Enable Nexus Cloud Preview of stable features, available for public consumption.\n* `NexusCloudTechPreviewSilver` - Enable Nexus Cloud Preview of beta features. This feature set is intended for consumption by internal audiences.\n* `NexusCloudTechPreviewBronze` - Enable Nexus Cloud Preview of features still in development. This feature set is intended for consumption by internal audiences.\n* `DisconnectedTargetAlarm` - Raise an alarm when a Target is disconnected from Intersight. Intersight is unable to manage disconnected Targets.\n* `AsAService` - Enable AsAService Preview of beta features. This feature set is intended for consumption by selective audiences.\n* `EMEA` - Enable all avaialble features on Intersight EMEA region.\n* `CrossPlatformNavigation` - Enable Cross-Platform Navigation on UI.\n* `WorkflowsPreview` - Enable Workflows preview for this account.\n* `ManualKEKSupport` - Enable support for Manual key to enhance storage controller security for this account.\n* `FirmwareConsolidationEFT` - Enable usage of firmware images transitioned from CCO to Intersight. This feature set is intended for consumption by internal audiences.

```yaml
Type: IamFeatureDefinition.FeatureEnum
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
Type: IamFeatureDefinition.ObjectTypeEnum
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
PS C:\> Initialize-IntersightIamFeatureDefinition
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS
