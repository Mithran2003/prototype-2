using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    [SerializeField]
    private float maxZ = 35f ;
    [SerializeField]
    private float minZ = -15f ;
    public static int AnimalsEscaped = 0 ;
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
             AnimalsEscaped += 1 ;
            Debug.Log($"{AnimalsEscaped} Ran away ");
        }
    }
}
