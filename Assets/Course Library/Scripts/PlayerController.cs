using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed;
    private float horizontalInput;
    [SerializeField]
    private GameObject projectilePrefab ;
    [SerializeField]
    private float maxX = 24 ; // Variable to set the Maximum value of X cordinate  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate( Vector3.right * Time.deltaTime * playerSpeed * horizontalInput );
        if(transform.position.x > 24) 
        {
          transform.position = (new Vector3( maxX , transform.position.y , transform.position.z ))  ;
        }
        
        else if(transform.position.x < -24)
        {
            transform.position = (new Vector3( -maxX , transform.position.y, transform.position.z ));
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
             Instantiate(projectilePrefab /*game object*/,transform.position /* player coordinates */,projectilePrefab.transform.rotation/* game object rotation */);
            
        }
        


        
    }
}
