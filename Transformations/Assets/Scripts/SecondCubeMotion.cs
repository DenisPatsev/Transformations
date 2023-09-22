using UnityEngine;

public class SecondCubeMotion : MonoBehaviour
{
    [SerializeField] private float _motionSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        transform.Translate(transform.forward * _motionSpeed);
        transform.Rotate(1 * _rotationSpeed, 0, 0);
        transform.localScale += new Vector3(1, 1, 1) * _scaleSpeed;
    }
}
