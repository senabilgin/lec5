using UnityEngine;

public class Ball : MonoBehaviour
{
    private int countScore = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        

        Vector3 position = transform.position;
        position.x = 2;
        transform.position = position;
        Debug.Log("This is the first script.");

        Vector3 scale = transform.localScale;
        scale.x = 1f;
        scale.y = 1f;
        transform.localScale = scale;

        rb2d.AddForce(new Vector2(Random.Range(0, Mathf.Cos(1)), Random.Range(3, 5 )), ForceMode2D.Impulse);

        //rb2d.AddForce(new Vector2(Random.Range()), ForceMode2D.Impulse);

        
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

     void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Bang");

        
        countScore++;

        if (countScore > 20)
        {
            Debug.Log("Score is greater than 20!");
        }
    }
    

}
