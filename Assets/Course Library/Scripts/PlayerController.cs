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
    private int startingFoodCount ;
    private int currentFoodCount ;
    [SerializeField]
    private float maxX = 24 ; // Variable to set the Maximum value of X cordinate  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentFoodCount = startingFoodCount;
        Debug.Log($"Number of apples on player is :{currentFoodCount}");
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
        if ((Input.GetKeyDown(KeyCode.Space)) && (currentFoodCount>0))
        {
             Instantiate(projectilePrefab /*game object*/,transform.position /* player coordinates */,projectilePrefab.transform.rotation/* game object rotation */);
             currentFoodCount -= 1;
             Debug.Log($"Number of apples left on the player {currentFoodCount} started with {startingFoodCount} number of apples ");
            
        }
        if ((Input.GetKeyDown(KeyCode.Space)) && (currentFoodCount<=0))
        {
            Debug.Log("NO more apples to feed try to find more apples  ");
        }
        


        
    }
}
