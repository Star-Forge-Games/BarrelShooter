using UnityEngine;

public class Forward : MonoBehaviour
{

    [SerializeField] private float speed;

    void Update()
    {
        transform.position += new Vector3(0, 0, speed * Time.deltaTime);
    }
}
