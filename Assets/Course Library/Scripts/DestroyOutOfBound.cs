using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    [SerializeField]
    private float maxZ = 35 ;
    [SerializeField]
    private float minZ = -15 ;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > maxZ)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < minZ )
        {
            Destroy(gameObject);
        }
    }
}
