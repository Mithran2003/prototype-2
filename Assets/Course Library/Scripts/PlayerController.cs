using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float playerSpeed;
    private float horizontalInput;
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
          transform.position = (new Vector3( 24f , 0f , - 2f ))  ;
        }
        
        else if(transform.position.x < -24)
        {
            transform.position = (new Vector3( -24f , 0f , - 2f ));
        }


        
    }
}
