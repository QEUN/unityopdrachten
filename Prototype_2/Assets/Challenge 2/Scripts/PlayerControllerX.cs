using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spamLockinterval = 1.0f;
    private bool locked;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&&!locked)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            locked = true;
            Invoke("Unlock", spamLockinterval);
        }
    }
    void Unlock()
    {
        locked = false;
    }
}
