using UnityEngine;

public class SphereScale : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        Vector3 scale = transform.localScale;

        float s = Mathf.Sin(Time.time * 2.0f) * 2.0f;

        scale.Set(-s, s * 2.0f, s * 1.5f );

        transform.localScale = scale;
        
    }
}
