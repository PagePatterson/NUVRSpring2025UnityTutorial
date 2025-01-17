using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheese : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Mouse"))
        {
            GameManager.Instance.CollectedCheese();
            Destroy(this.gameObject);
        }
    }
}