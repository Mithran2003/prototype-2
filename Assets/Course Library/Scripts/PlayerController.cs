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
        Debug.Log($"You have appels to feed to the animals, you can collect more appels as they appear on your screan.");
        Debug.Log("Use the appeles to stop the animals from entering your feild and destroying your crops.");
        Debug.Log("Use A and D key to move and use spacebare to throw appels to feed the animals. You will lose when more than 4 animals are able to enter your feild succesfuly ");
        Debug.Log("when you feed the appele to the animals they will disapear and will not enter your feild");
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate( Vector3.right * Time.deltaTime * playerSpeed * horizontalInput );
        if(transform.position.x > 26) 
        {
          transform.position = (new Vector3( maxX , transform.position.y , transform.position.z ))  ;
        }
        
        else if(transform.position.x < -26)
        {
            transform.position = (new Vector3( -maxX , transform.position.y, transform.position.z ));
        }
        if ((Input.GetKeyDown(KeyCode.Space)) )
        {
             Instantiate(projectilePrefab /*game object*/,transform.position /* player coordinates */,projectilePrefab.transform.rotation/* game object rotation */);
             
            
        } 
    }
}
