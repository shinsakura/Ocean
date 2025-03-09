using UnityEngine;

public class SailController : MonoBehaviour
{
    public float sailRotationSpeed = 100f;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * sailRotationSpeed * Time.deltaTime); // ¶‰EƒL[‚Å”¿‚ğ‰ñ“]
    }
}

