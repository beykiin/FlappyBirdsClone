using UnityEngine;

public class MoveLevel : MonoBehaviour
{
    [SerializeField] private GameObject birds;
    [SerializeField] private float speed;

    void Update()
    {
        birds.transform.position += Vector3.right * -speed * Time.deltaTime;
    }
}
