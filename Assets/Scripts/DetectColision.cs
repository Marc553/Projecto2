using UnityEngine;

public class DetectColision : MonoBehaviour
{
    private void OnTriggerEnter(Collider otherCollider)
    {
        //el projectil se destruye
        Destroy(gameObject);

        //destruir el animal contra el que colisionamos
        Destroy(otherCollider.gameObject);

    }
}
