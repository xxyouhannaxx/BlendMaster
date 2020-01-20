using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BlendMaster
{
    public class SpriteProgressBar : MonoBehaviour
    {
        public GameObject mask;
        public float maxSize;
        // Start is called before the first frame update
        void Awake()
        {
            maxSize = mask.transform.localScale.y;
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void setProgress(float fillAmount)
        {
            Vector3 scale = mask.transform.localScale;
            scale.y = fillAmount * maxSize;
            Debug.Log("Y" + scale.y);
            mask.transform.localScale = scale;
        }
    }
}
