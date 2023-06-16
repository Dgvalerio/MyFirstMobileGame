using UnityEngine;

public class Collectable : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speed;

    private void FixedUpdate()
    {
        rig.MovePosition(transform.position + Vector3.down * (speed * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player")) return;
        
        GameController.Instance.AddScore();
        if (gameObject != null) Destroy(gameObject);
    }
}
