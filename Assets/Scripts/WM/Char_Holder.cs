using UnityEngine;
using System.Collections;
namespace wm
{
    public class Char_Holder : MonoBehaviour
    {

        void OnTriggerEnter(Collider col)
        {
            col.transform.parent = gameObject.transform;

        }
        void OnTriggerExit(Collider col)
        {
            col.transform.parent = null;

        }

    }
}