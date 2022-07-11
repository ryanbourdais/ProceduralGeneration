using UnityEngine;

public class RayCast : MonoBehaviour
{
    public float height;
    RaycastHit hit;

    void Start()
    {
        Ray ray = new Ray(transform.position, -Vector3.up);
        Debug.DrawRay(transform.position, -Vector3.up * height, Color.red);

        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider.tag == "ground")
            {
                this.transform.position = new Vector3(transform.position.x, transform.position.y - hit.distance, transform.position.z);
                Destroy(GetComponent<RayCast>());
            }
            if(this.transform.position.y == 100)
                { Destroy(gameObject);}
        }
    }
}
