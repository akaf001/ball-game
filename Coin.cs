using UnityEngine;

public class Coin : MonoBehaviour
{
    public float _rotate=5f;

    private void Update()
    {
       
    }
    private void FixedUpdate()
    {
        transform.Rotate(0, 0, _rotate);
    }
}
