using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScriptVector : MonoBehaviour
{
    public Transform aTf;
    public Transform bTf;

    [Range(0f, 4f)]
    public float offset = 1f;

    public float abDist;

    private void OnDrawGizmos() {

        Vector2 a = aTf.position;
        Vector2 b = bTf.position;

        // Draw the direction a to b
        Vector2 direction = (b - a);
        Vector2 direction_noamlized = direction / direction.magnitude;

        Gizmos.DrawLine(a, a + direction_noamlized);

        Vector2 offsetVector = direction_noamlized * offset;
        Gizmos.DrawSphere(offsetVector + a, 0.05f);


        abDist = Vector2.Distance(a, b);
        

        
        //-------------------------------------------------
        //             Vector Normalization
        //-------------------------------------------------
        
        // Math Way to normalize a vector
        //Vector2 ptr = transform.position;
        //float length = Mathf.Sqrt(Mathf.Pow(ptr.x, 2) + Mathf.Pow(ptr.y, 2));

        //Gizmos.DrawLine(Vector2.zero , ptr/length);

        // Unity Way to normalize a vector
        Vector2 ptr = transform.position;
        Vector2 dirToPoint = ptr / ptr.magnitude;
        Gizmos.DrawLine (Vector2.zero, dirToPoint);

    }
}
