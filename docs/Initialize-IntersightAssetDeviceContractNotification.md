---
external help file: Intersight.PowerShell.dll-Help.xml
Module Name: Intersight.PowerShell
online version:
schema: 2.0.0
---

# Initialize-IntersightAssetDeviceContractNotification

## SYNOPSIS
Fill in the Synopsis

## SYNTAX

```

Initialize-IntersightAssetDeviceContractNotification [-AdditionalProperties< System.Collections.Generic.Dictionary`2[string,object]>][-ClassId< AssetDeviceContractNotification.ClassIdEnum>][-Contract< Model.AssetContractInformation>][-ContractStatus< AssetDeviceContractNotification.ContractStatusEnum>][-ContractStatusReason< AssetDeviceContractNotification.ContractStatusReasonEnum>][-ContractUpdatedTime< DateTime>][-CoveredProductLineEndDate< string>][-DeviceId< string>][-EndCustomer< Model.AssetCustomerInformation>][-EndUserGlobalUltimate< Model.AssetGlobalUltimate>][-IsValid< bool>][-ItemType< string>][-LastDateOfSupport< DateTime>][-MaintenancePurchaseOrderNumber< string>][-MaintenanceSalesOrderNumber< string>][-Moid< string>][-ObjectType< AssetDeviceContractNotification.ObjectTypeEnum>][-Product< Model.AssetProductInformation>][-PurchaseOrderNumber< string>][-ResellerGlobalUltimate< Model.AssetGlobalUltimate>][-SalesOrderNumber< string>][-ServiceDescription< string>][-ServiceEndDate< DateTime>][-ServiceLevel< string>][-ServiceSku< string>][-ServiceStartDate< DateTime>][-StateContract< AssetDeviceContractNotification.StateContractEnum>][-StateSn2Info< AssetDeviceContractNotification.StateSn2InfoEnum>][-Tags< System.Collections.Generic.List`1[Model.MoTag]>][-WarrantyEndDate< string>][-WarrantyType< string>][-Json< SwitchParameter>][-WithHttpInfo< SwitchParameter>]

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
Type: AssetDeviceContractNotification.ClassIdEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Contract
Contract information for the Cisco support contract purchased for the Cisco device.

Note :- Use Initialize-IntersightAssetContractInformation to create the object of complex type AssetContractInformation

```yaml
Type: Model.AssetContractInformation
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ContractStatus
Calculated contract status that is derived based on the service line status and contract end date. It is different from serviceLineStatus property. serviceLineStatus gives us ACTIVE, OVERDUE, EXPIRED. These are transformed into Active, Expiring Soon and Not Covered.\n* `Unknown` - The device&apos;s contract status cannot be determined.\n* `Not Covered` - The Cisco device does not have a valid support contract.\n* `Active` - The Cisco device is covered under a active support contract.\n* `Expiring Soon` - The contract for this Cisco device is going to expire in the next 30 days.

```yaml
Type: AssetDeviceContractNotification.ContractStatusEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ContractStatusReason
Reason for contract status. In case of Not Covered, reason is either Terminated or Expired.\n* `` - There is no reason for the specified contract status.\n* `Line Item Expired` - The Cisco device does not have a valid support contract, it has expired.\n* `Line Item Terminated` - The Cisco device does not have a valid support contract, it has been terminated.

```yaml
Type: AssetDeviceContractNotification.ContractStatusReasonEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ContractUpdatedTime
Date and time indicating when the contract data is last refreshed.

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

### -CoveredProductLineEndDate
End date of the covered product line. The coverage end date is fetched from Cisco SN2INFO API.

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

### -DeviceId
Unique identifier of the Cisco device.

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

### -EndCustomer
End customer information for the Cisco support contract purchased for the Cisco device.

Note :- Use Initialize-IntersightAssetCustomerInformation to create the object of complex type AssetCustomerInformation

```yaml
Type: Model.AssetCustomerInformation
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -EndUserGlobalUltimate
EndUserGlobalUltimate information listed in the contract.

Note :- Use Initialize-IntersightAssetGlobalUltimate to create the object of complex type AssetGlobalUltimate

```yaml
Type: Model.AssetGlobalUltimate
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -IsValid
Validates if the device is a genuine Cisco device. Validated is done using the Cisco SN2INFO APIs.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -ItemType
Item type of this specific Cisco device. example \&quot;Chassis\&quot;.

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

### -LastDateOfSupport
The last date of hardware support for this device.

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

### -MaintenancePurchaseOrderNumber
Maintenance purchase order number for the Cisco device.

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

### -MaintenanceSalesOrderNumber
Maintenance sales order number for the Cisco device.

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

### -ObjectType
The fully-qualified name of the instantiated, concrete type.\nThe value should be the same as the &apos;ClassId&apos; property.

```yaml
Type: AssetDeviceContractNotification.ObjectTypeEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -Product
Product information of the offering under a contract.

Note :- Use Initialize-IntersightAssetProductInformation to create the object of complex type AssetProductInformation

```yaml
Type: Model.AssetProductInformation
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -PurchaseOrderNumber
Purchase order number for the Cisco device. It is a unique number assigned for every purchase.

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

### -ResellerGlobalUltimate
ResellerGlobalUltimate information listed in the contract.

Note :- Use Initialize-IntersightAssetGlobalUltimate to create the object of complex type AssetGlobalUltimate

```yaml
Type: Model.AssetGlobalUltimate
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -SalesOrderNumber
Sales order number for the Cisco device. It is a unique number assigned for every sale.

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

### -ServiceDescription
The type of service contract that covers the Cisco device.

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

### -ServiceEndDate
End date for the Cisco service contract that covers this Cisco device.

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

### -ServiceLevel
The type of service contract that covers the Cisco device.

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

### -ServiceSku
The SKU of the service contract that covers the Cisco device.

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

### -ServiceStartDate
Start date for the Cisco service contract that covers this Cisco device.

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

### -StateContract
Internal property used for triggering and tracking actions for contract information.\n* `Update` - Sn2Info/Contract information needs to be updated.\n* `OK` - Sn2Info/Contract information was fetched succcessfuly and updated.\n* `Failed` - Sn2Info/Contract information was not available  or failed while fetching.\n* `Retry` - Sn2Info/Contract information update failed and will be retried later.

```yaml
Type: AssetDeviceContractNotification.StateContractEnum
Parameter Sets: (All)
Aliases:

Required: false
Position: Named
Default value: None
Accept pipeline input: True True (ByPropertyName)
Accept wildcard characters: False
```

### -StateSn2Info
Internal property used for triggering and tracking actions for sn2info information.\n* `Update` - Sn2Info/Contract information needs to be updated.\n* `OK` - Sn2Info/Contract information was fetched succcessfuly and updated.\n* `Failed` - Sn2Info/Contract information was not available  or failed while fetching.\n* `Retry` - Sn2Info/Contract information update failed and will be retried later.

```yaml
Type: AssetDeviceContractNotification.StateSn2InfoEnum
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

### -WarrantyEndDate
End date for the warranty that covers the Cisco device.

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

### -WarrantyType
Type of warranty that covers the Cisco device.

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
PS C:\> Initialize-IntersightAssetDeviceContractNotification
```

{ Add example description here }

## INPUTS

### System.Int32

### System.String

## OUTPUTS

### TestModule.FavoriteStuff

## NOTES

## RELATED LINKS

[Initialize-IntersightAssetContractInformation](./Initialize-IntersightAssetContractInformation.md)

[Initialize-IntersightAssetCustomerInformation](./Initialize-IntersightAssetCustomerInformation.md)

[Initialize-IntersightAssetGlobalUltimate](./Initialize-IntersightAssetGlobalUltimate.md)

[Initialize-IntersightAssetProductInformation](./Initialize-IntersightAssetProductInformation.md)

[Initialize-IntersightDateTime](./Initialize-IntersightDateTime.md)

[Initialize-IntersightMoTag](./Initialize-IntersightMoTag.md)
