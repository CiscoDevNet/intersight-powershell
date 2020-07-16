# ConnectorFileMessageAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MsgType** | **String** | Message type carrying the file operation to perform. | [optional] [default to "OpenFile"]
**Path** | **String** | The absolute path of the file to open on the platforms file system. Must be a sub-directory of a directory defined within the platform configurations WriteableDirectories. The file system device to write to must also have sufficient free space to write to (&lt;75% full). Must be set for each message that is sent. | [optional] 
**Stream** | [**SystemByte**](SystemByte.md) | The stream of bytes to write to file. Only applicable for FileContent message. Ignored for OpenFile and CloseFile messages. | [optional] 

## Examples

- Prepare the resource
```powershell
Initialize-IntersightConnectorFileMessageAllOf  -MsgType null `
 -Path null `
 -Stream null
```

- Convert the resource to JSON
```powershell
$ | Convert-ToJSON
```

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

