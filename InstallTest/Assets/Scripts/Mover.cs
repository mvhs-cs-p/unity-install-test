using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform m_Target;
    public float speed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        Vector2 toTarget = m_Target.position - transform.position;
        Vector2 dirToTarget = toTarget.normalized;
        transform.Translate(dirToTarget * speed * Time.deltaTime);
    }
}
