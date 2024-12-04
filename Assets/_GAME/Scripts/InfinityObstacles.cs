using UnityEngine;

public class InfinityObstacles : MonoBehaviour, IInteractable
{
    [SerializeField] GameObject obstacle;
    [SerializeField] float distance = 6f;
    [SerializeField] float minHeight = -0.7f;
    [SerializeField] float maxHeight = 1.1f;
    

    void PoolingObstacles()
    {
        obstacle.SetActive(false);
        obstacle.transform.position += new Vector3(distance, 0, 0);
        obstacle.transform.position = new Vector3(obstacle.transform.position.x, Random.Range(minHeight, maxHeight), 0);
        obstacle.SetActive(true);
    }


    public void Interact()
    {
        PoolingObstacles();
    }
}
