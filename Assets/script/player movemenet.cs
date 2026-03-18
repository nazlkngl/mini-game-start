using UnityEngine;

public class playermovemenet : MonoBehaviour
{

    public float speed = 10f; 
    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // Debug.Log("Start function in playermovement script.");
        rb = GetComponent<Rigidbody>();
   
    
    
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 movement=new Vector3 (moveX ,2.4f,moveZ );
        rb.AddForce(movement* speed);
    }
  
    void Update()
    {

    }
}

