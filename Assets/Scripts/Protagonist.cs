using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool isRight;
    public float speed;
    
    public Transform leftPoint;
    public Transform rightPoint;
    
    private void Update()
    {
        if (isRight)
        {
            transform.Translate(speed * Time.deltaTime * Vector2.right);
        }
        else
        {
            transform.Translate(speed * Time.deltaTime * -Vector2.right);
        }

        if (Input.GetMouseButtonDown(0))
        {
            isRight = !isRight;
        }

        if (Vector2.Distance(transform.position, leftPoint.position) < 0.1f || Vector2.Distance(transform.position, rightPoint.position) < 0.1f)
        {
            isRight = !isRight;
        }
    }
}
