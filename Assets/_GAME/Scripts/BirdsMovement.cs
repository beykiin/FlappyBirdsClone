using UnityEngine;

public class BirdsMovement : MonoBehaviour
{
    [SerializeField] private float jumpForce;
    [SerializeField] private float maxTime = 0.5f;
    

    private Rigidbody2D _rb;
    private float _currentTime;
    private bool _isJumping;
    

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _isJumping = true;
    }

    private void Update()
    {
        

        // Bastýkça sürekli artarak zýplama
        Timer();
        if (Input.GetKeyDown(KeyCode.Space) && _isJumping)
        {
            Jump();
            _currentTime = 0;
            _isJumping = false;
        }
    }

    void Jump()
    {
        _rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    void Timer()
    {
        if (!_isJumping)
        {
            _currentTime += Time.deltaTime;
            if (_currentTime > maxTime)
            {
                _isJumping = true;
            }
        }
        Debug.Log(_currentTime);
    }
}
