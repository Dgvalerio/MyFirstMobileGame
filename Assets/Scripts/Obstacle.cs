using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Rigidbody2D rig;
    public float speed;
    
    private void Start()
    {
        transform.Rotate(new Vector3(0, 0, Random.Range(-145, -45)));
    }

    private void FixedUpdate()
    {
        var t = transform;
        rig.MovePosition(t.position + speed * Time.deltaTime * t.right);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameController.Instance.ShowGameOver();
        }
    }
}
