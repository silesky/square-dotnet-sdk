
# Create Dispute Evidence File Request

Defines the parameters for a `CreateDisputeEvidenceFile` request.

## Structure

`CreateDisputeEvidenceFileRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `IdempotencyKey` | `string` |  | The Unique ID. For more information, see [Idempotency](https://developer.squareup.com/docs/working-with-apis/idempotency). |
| `EvidenceType` | [`string`](/doc/models/dispute-evidence-type.md) | Optional | The type of the dispute evidence. |
| `ContentType` | `string` | Optional | The MIME type of the uploaded file.<br>The type can be image/heic, image/heif, image/jpeg, application/pdf, image/png, or image/tiff. |

## Example (as JSON)

```json
{
  "idempotency_key": "idempotency_key6",
  "evidence_type": "RECEIPT",
  "content_type": "content_type6"
}
```

