using UnityEngine;
using System.Collections;

public class BusterGun : MonoBehaviour
{
    bool mShooting;

    float kShootDuration = 0.25f;
    float mTime;

    public GameObject mBulletPrefab;
    tank mtankRef;

    AudioSource mBusterSound;

    void Start ()
    {
        mtankRef = GameObject.Find("tank").GetComponent<tank>();
        mBusterSound = GameObject.Find("BusterGun").GetComponent<AudioSource>();
    }

    void Update ()
    {
        if(Input.GetButtonDown ("Fire"))
        {
            
            GameObject bulletObject = Instantiate(mBulletPrefab, transform.position + new Vector3(0, 1), Quaternion.identity);
         
            
            

            
            mBusterSound.Play();
         
            mShooting = true;
            mTime = 0.0f;
        }

        if(mShooting)
        {
            mTime += Time.deltaTime;
            if(mTime > kShootDuration)
            {
                mShooting = false;
            }
        }

    }
}
