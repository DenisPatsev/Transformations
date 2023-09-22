using UnityEngine;

public class SphereMotion : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(transform.forward * _speed);
    }
}
