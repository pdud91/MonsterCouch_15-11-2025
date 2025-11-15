using UnityEditor;
using UnityEngine;

public class Actor : MonoBehaviour
{
    [SerializeField] float movementSpeed = 1f;
    [SerializeField] CircleCollider2D circleCollider;
    protected CircleCollider2D myCollider => circleCollider;

    public void MoveTowards(Vector2 direction)
    {
        Move(direction, movementSpeed);
    }

    void Move(Vector2 direction, float moveSpeed)
    {
        // move the game object
        Vector3 pos = transform.position;
        Vector3 delta = direction * moveSpeed * Time.deltaTime;
        Vector3 newPos = pos + delta;


        // make sure Actor cannot go outside the bounds
        Vector3 boundsLowerLeft = Camera.main.ViewportToWorldPoint(Vector2.zero);
        Vector3 boundsUpperRight = Camera.main.ViewportToWorldPoint(Vector2.one);

        if (newPos.x < boundsLowerLeft.x)
            newPos.x = boundsLowerLeft.x;

        if (newPos.x > boundsUpperRight.x)
            newPos.x = boundsUpperRight.x;

        if (newPos.y < boundsLowerLeft.y)
            newPos.y = boundsLowerLeft.y;

        if (newPos.y > boundsUpperRight.y)
            newPos.y = boundsUpperRight.y;


        transform.SetPositionAndRotation(newPos, transform.rotation);
    }

}
