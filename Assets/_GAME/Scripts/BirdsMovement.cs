using UnityEngine;

public class BirdsMovement : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private GameObject birds;
    [SerializeField] private float speed;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
        birds.transform.position += Vector3.right * speed * Time.deltaTime;

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);




        //}
        //transform.position = (Vector2.up * jumpForce).normalized;
    }
}
