using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace BlendMaster {
    public class BlenderButton : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        private void OnMouseDown()
        {
            GameManager.Instance.fillBlender();
        }
        private void OnMouseUp()
        {
            GameManager.Instance.stopFilling();
        }
    }
}
