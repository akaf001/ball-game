using UnityEngine;

public class Cameracontroler : MonoBehaviour
{
    public Transform _target;


  

    private void FixedUpdate()
    {
        transform.LookAt( _target );
    }
}
