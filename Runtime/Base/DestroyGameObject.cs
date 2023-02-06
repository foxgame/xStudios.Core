using UnityEngine;
using System.Collections;

namespace X
{


    public class DestroyGameObject : MonoBehaviour
    {
        public float delay;

        IEnumerator Start()
        {
            yield return new WaitForSeconds( delay );
            Destroy( gameObject );
        }
    }

}
