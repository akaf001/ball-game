using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControler : MonoBehaviour
{
    public float _speed = 2f;
    private Rigidbody _rb;

    private float xInput;
    private float yInput;

    private int _score = 0;
    private int _winScore = 5;

    public GameObject _winText;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if(transform.position.y < -5f)
        {
            SceneManager.LoadScene("Game");
        }
    }

    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        _rb.AddForce(xInput*_speed,0,yInput*_speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin"){
            other.gameObject.SetActive(false);
            _score++;
            if (_score == _winScore)
            {
                _winText.SetActive(true);
            }
        }
    }

}
