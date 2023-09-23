using UnityEngine;

public class ForwardMotion : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(transform.forward * _speed);
    }
}
