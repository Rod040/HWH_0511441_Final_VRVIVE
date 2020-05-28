using UnityEngine;

public class ThreePoint : MonoBehaviour
{
    public bool inThreePoint;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name== "HeadCollider")
        {
            inThreePoint = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "HeadCollider")
        {
            inThreePoint = false;
        }
    }
}
